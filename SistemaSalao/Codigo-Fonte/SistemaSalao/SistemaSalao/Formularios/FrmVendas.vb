Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmVendas
    Private Sub FrmVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        CarregarCombobox()
        dataBuscar.Value = Now().ToShortDateString
        nomeCliente = ""

    End Sub

    Private Sub CarregarCombobox()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM produtos order by nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbProduto.ValueMember = "id"
                cbProduto.DisplayMember = "nome"
                cbProduto.DataSource = dt
            Else
                cbProduto.Text = "Cadastre um Produto"
                btnNovo.Enabled = False
            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT v.id, p.nome, v.cliente, v.quantidade, v.valor_total, v.funcionario, v.data_venda, v.produto FROM vendas as v INNER JOIN produtos as p on v.produto = p.id order by v.data_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt

            If grid.Rows.Count > 0 Then
                FormatarGrid()
                CalcularTotalVendasDia()
            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Private Sub FormatarGrid()
        grid.Columns(0).Visible = False
        grid.Columns(7).Visible = False

        grid.Columns(0).HeaderText = "Id"

        grid.Columns(1).HeaderText = "Produto"
        grid.Columns(2).HeaderText = "Cliente"
        grid.Columns(3).HeaderText = "Quantidade"
        grid.Columns(4).HeaderText = "Valor Venda"
        grid.Columns(5).HeaderText = "Funcionário"
        grid.Columns(6).HeaderText = "Data Venda"
        grid.Columns(7).HeaderText = "Id Produto"

        'grid.Columns(3).Width = 130

    End Sub




    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
        btnBuscarCliente.Enabled = True
    End Sub


    Sub HabilitarCampos()
        txtQuantidade.Enabled = True

        cbProduto.Enabled = True
        btnBuscarCliente.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtQuantidade.Enabled = False

        cbProduto.Enabled = False
        btnBuscarCliente.Enabled = False
    End Sub


    Sub Limpar()
        txtQuantidade.Text = "1"
        txtCliente.Text = ""
        nomeCliente = ""
        BuscarDadosProdutos()
        cbProduto.SelectedIndex() = 0


    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub FrmVendas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtCliente.Text = nomeCliente
    End Sub

    Private Sub CbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        BuscarDadosProdutos()
    End Sub

    Private Sub BuscarDadosProdutos()
        Dim IdProduto As Integer
        IdProduto = cbProduto.SelectedValue

        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String

            sql = "SELECT * FROM produtos where id = '" & IdProduto & "'  "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader




            If reader.Read = True Then

                'RECUPERANDO O VALOR, IMAGEM E ESTOQUE DO PRODUTO
                Dim valor As Decimal
                Dim imagem As Byte()
                Dim quantEstoque As Integer
                valor = reader(4)
                imagem = reader(7)
                quantEstoque = reader(5)


                txtValor.Text = valor
                txtEstoque.Text = quantEstoque

                CalcularTotal()


                'CONVERTENDO BYTE EM OBJETO PICTURE BOX

                Dim ms As MemoryStream = New MemoryStream(imagem)
                img.Image = System.Drawing.Image.FromStream(ms)

                reader.Close()



            Else
                MsgBox("Não foi possível trazer os dados!", MsgBoxStyle.Information, "Vendas")

            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Não foi possível trazer os dados! " + ex.Message)
        End Try


    End Sub


    Sub CalcularTotal()
        Dim total As Decimal
        total = txtQuantidade.Text * txtValor.Text
        txtTotal.Text = total
    End Sub

    Private Sub TxtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged
        If txtQuantidade.Text <> "" Then
            CalcularTotal()
        End If

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim id_mov As Integer

        If txtQuantidade.Text > "0" Then



            If txtQuantidade.Text <= txtEstoque.Text Then
                Try
                    'ABRINDO A CONEXÃO
                    Abrir()


                    'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    Dim cmdEstoque As MySqlCommand
                    Dim sqlEstoque As String

                    Dim data As String
                    data = Now().ToString("yyyy-MM-dd")

                    sql = "INSERT INTO vendas (produto, cliente, quantidade, valor_total, funcionario, data_venda) VALUES ('" & cbProduto.SelectedValue & "', '" & txtCliente.Text & "', '" & txtQuantidade.Text & "', '" & txtTotal.Text & "', '" & nomeFuncionario & "', '" & data & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()


                    'RECUPERAR O ID DA ULTIMA VENDA QUE EU ACABEI DE INSERIR
                    Dim cmdR As MySqlCommand
                    Dim reader As MySqlDataReader
                    Dim sqlR As String

                    sqlR = "SELECT MAX(ID) FROM vendas"
                    cmdR = New MySqlCommand(sqlR, con)
                    reader = cmdR.ExecuteReader




                    If reader.Read = True Then

                        'RECUPERANDO O ID
                        Dim id As Integer
                        id = reader(0)
                        id_mov = id

                        reader.Close()


                    Else
                        MsgBox("Não foi encontrado o id!", MsgBoxStyle.Information, "Id")

                    End If
                    reader.Close()


                    'INSERINDO MOVIMENTAÇÃO DA VENDA NA TABELA DE MOVIMENTAÇÕES
                    Dim cmdMov As MySqlCommand
                    Dim sqlMov As String
                    sqlMov = "INSERT INTO movimentacoes (tipo, movimento, valor, funcionario, data, id_movimento) VALUES ('Entrada', 'Venda', '" & txtTotal.Text & "', '" & nomeFuncionario & "',  '" & data & "', '" & id_mov & "')"
                    cmdMov = New MySqlCommand(sqlMov, con)
                    cmdMov.ExecuteNonQuery()


                    'ABATENDO A QUANTIDADE NO ESTOQUE

                    Dim total As Integer
                    total = txtEstoque.Text - txtQuantidade.Text

                    sqlEstoque = "UPDATE produtos SET quantidade = '" & total & "' where id = '" & cbProduto.SelectedValue & "'"
                    cmdEstoque = New MySqlCommand(sqlEstoque, con)
                    cmdEstoque.ExecuteNonQuery()

                    MsgBox("Salvo com Sucesso!!", MsgBoxStyle.Information, "Dados Salvo")
                    Listar()
                    Limpar()
                    DesabilitarCampos()
                    btnSalvar.Enabled = False
                Catch ex As Exception
                    MsgBox("Erro ao Salvar!!" + ex.Message)
                End Try
            Else
                MsgBox("A quantidade não existe no estoque!!", MsgBoxStyle.Information, "Quantidade Inexistente")
            End If



        Else
            MsgBox("A quantidade deve ser maior que 0!!", MsgBoxStyle.Information, "Prencha os Dados")

        End If

    End Sub


    Sub CalcularTotalVendasDia()
        Dim totalVendasDia As Decimal
        Dim linha As DataGridViewRow

        For Each linha In grid.Rows
            totalVendasDia = totalVendasDia + linha.Cells(4).Value
        Next

        lblTotalDia.Text = totalVendasDia

    End Sub




    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        btnBuscarCliente.Enabled = True
        BtnEditar.Enabled = True
        btnExcluir.Enabled = True

        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        cbProduto.SelectedValue = grid.CurrentRow.Cells(7).Value
        txtCliente.Text = grid.CurrentRow.Cells(2).Value
        txtQuantidade.Text = grid.CurrentRow.Cells(3).Value
        txtTotal.Text = grid.CurrentRow.Cells(4).Value
    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If txtQuantidade.Text > "0" Then
            Try

                'ABRINDO A CONEXÃO
                Abrir()


                'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE vendas SET cliente = '" & txtCliente.Text & "' where id = '" & txtCodigo.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Editado com Sucesso!!", MsgBoxStyle.Information, "Dados Editado")
                Listar()
                DesabilitarCampos()
                BtnEditar.Enabled = False
                btnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao editar!!" + ex.Message)
            End Try

        Else
            MsgBox("Preencha os Campos!!", MsgBoxStyle.Information, "Prencha os Dados")

        End If
    End Sub


    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If MsgBox("Deseja excluir o registro?", vbYesNo, "Escolha a Opção") = vbYes Then

            Try
                Abrir()
                'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM vendas where id = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()



                'PROGRAMANDO EXCLUSÃO DE REGISTRO NAS MOVIMENTAÇÕES
                Dim cmdM As MySqlCommand
                Dim sqlM As String

                sqlM = "DELETE FROM movimentacoes where id_movimento = '" & txtCodigo.Text & "' and movimento = 'Venda'"
                cmdM = New MySqlCommand(sqlM, con)
                cmdM.ExecuteNonQuery()


                'DEVOLVER A QUANTIDADE NO ESTOQUE
                Dim cmdEstoque As MySqlCommand
                Dim sqlEstoque As String
                Dim total As Integer
                total = CInt(txtEstoque.Text) + CInt(txtQuantidade.Text)

                sqlEstoque = "UPDATE produtos SET quantidade = '" & total & "' where id = '" & cbProduto.SelectedValue & "'"
                cmdEstoque = New MySqlCommand(sqlEstoque, con)
                cmdEstoque.ExecuteNonQuery()


                MsgBox("Excluido com Sucesso!!", MsgBoxStyle.Information, "Dados Apagados")
                Listar()
                Limpar()
                DesabilitarCampos()
                BtnEditar.Enabled = False
                btnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try

        End If
    End Sub

    Private Sub DataBuscar_ValueChanged(sender As Object, e As EventArgs) Handles dataBuscar.ValueChanged
        BuscarVendas()
    End Sub

    Private Sub BuscarVendas()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim data As String
            data = dataBuscar.Value.ToString("yyyy-MM-dd")

            sql = "SELECT v.id, p.nome, v.cliente, v.quantidade, v.valor_total, v.funcionario, v.data_venda, v.produto FROM vendas as v INNER JOIN produtos as p on v.produto = p.id where v.data_venda = '" & data & "' order by v.data_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt
            CalcularTotalVendasDia()

            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub
End Class