Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmCadProdutos

    Public imgNome As String
    Public abriu As Boolean

    Private Sub FrmCadProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        CarregarCombobox()
    End Sub


    Private Sub CarregarCombobox()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM fornecedores order by nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbFornecedor.ValueMember = "id"
                cbFornecedor.DisplayMember = "nome"
                cbFornecedor.DataSource = dt
            Else
                cbFornecedor.Text = "Cadastre um Fornecedor"
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

            sql = "SELECT p.id, p.nome, p.descricao, p.valor_compra, p.valor_venda, p.quantidade, p.id_fornecedor, p.imagem, f.nome FROM produtos as p INNER JOIN fornecedores as f on p.id_fornecedor = f.id order by p.nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt

            If grid.Rows.Count > 0 Then
                FormatarGrid()
            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Private Sub FormatarGrid()
        grid.Columns(0).Visible = False
        grid.Columns(7).Visible = False
        grid.Columns(6).Visible = False
        grid.Columns(0).HeaderText = "Id"

        grid.Columns(1).HeaderText = "Nome"
        grid.Columns(2).HeaderText = "Descrição"
        grid.Columns(3).HeaderText = "Valor da Compra"
        grid.Columns(4).HeaderText = "Valor da Venda"
        grid.Columns(5).HeaderText = "Quantidade"
        grid.Columns(6).HeaderText = "Fornecedor"
        grid.Columns(8).HeaderText = "Fornecedor"

        'grid.Columns(3).Width = 130

    End Sub




    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
    End Sub


    Sub HabilitarCampos()
        txtNome.Enabled = True
        txtDescricao.Enabled = True
        txtValorCompra.Enabled = True
        txtValorVenda.Enabled = True
        txtQuant.Enabled = True
        cbFornecedor.Enabled = True
        btnAddImagem.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtNome.Enabled = False
        txtDescricao.Enabled = False
        txtValorCompra.Enabled = False
        txtValorVenda.Enabled = False
        txtQuant.Enabled = False
        cbFornecedor.Enabled = False
        btnAddImagem.Enabled = False
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        If txtNome.Text <> "" Then
            Try


                'TRATAMENTO PARA IMAGEM A PARTIR DE UMA STRING (CAMINHO DA IMAGEM)

                Dim fs As FileStream
                fs = New FileStream(imgNome, FileMode.Open, FileAccess.Read)
                Dim fotoByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(fotoByte, 0, System.Convert.ToInt32(fs.Length))





                Abrir()
                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO produtos (nome, descricao, valor_compra, valor_venda, quantidade, id_fornecedor, imagem) VALUES ('" & txtNome.Text & "', '" & txtDescricao.Text & "', '" & txtValorCompra.Text.Replace(",", ".") & "', '" & txtValorVenda.Text.Replace(",", ".") & "', '" & txtQuant.Text & "', '" & cbFornecedor.SelectedValue & "',  @img )"

                'DECLARACAO DO PARAMETRO DE IMAGEM
                Dim param As New MySqlParameter
                param.MySqlDbType = MySqlDbType.Binary
                param.ParameterName = "img"
                param.Value = fotoByte

                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.Add(param)
                cmd.ExecuteNonQuery()

                MsgBox("Salvo com Sucesso!!", MsgBoxStyle.Information, "Dados Salvo")
                Listar()
                DesabilitarCampos()
                btnSalvar.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao Salvar!!" + ex.Message)
            End Try

        Else
            MsgBox("Preencha os Campos!!", MsgBoxStyle.Information, "Prencha os Dados")
            txtNome.Focus()
        End If





    End Sub


    Sub Limpar()
        txtNome.Text = ""
        txtDescricao.Text = ""
        txtValorCompra.Text = ""
        txtValorVenda.Text = ""
        txtQuant.Text = ""


        img.Image = My.Resources.sem_foto
        imgNome = "sem-foto.jpg"

    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        BtnEditar.Enabled = True
        btnExcluir.Enabled = True


        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        txtNome.Text = grid.CurrentRow.Cells(1).Value
        txtDescricao.Text = grid.CurrentRow.Cells(2).Value
        txtValorCompra.Text = grid.CurrentRow.Cells(3).Value
        txtValorVenda.Text = grid.CurrentRow.Cells(4).Value
        txtQuant.Text = grid.CurrentRow.Cells(5).Value
        cbFornecedor.SelectedValue = grid.CurrentRow.Cells(6).Value


        'CONVERTENDO BYTE EM OBJETO PICTURE BOX
        Dim imgByte As Byte() = grid.CurrentRow.Cells(7).Value
        Dim ms As MemoryStream = New MemoryStream(imgByte)
        img.Image = System.Drawing.Image.FromStream(ms)

    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If txtNome.Text <> "" Then
            Try



                Abrir()
                'PROGRAMANDO EDICAO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                If abriu Then

                    'TRATAMENTO PARA IMAGEM A PARTIR DE UMA STRING (CAMINHO DA IMAGEM)
                    Dim fs As FileStream
                    fs = New FileStream(imgNome, FileMode.Open, FileAccess.Read)
                    Dim fotoByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(fotoByte, 0, System.Convert.ToInt32(fs.Length))


                    sql = "UPDATE produtos SET nome = '" & txtNome.Text & "', descricao = '" & txtDescricao.Text & "', valor_compra = '" & txtValorCompra.Text.Replace(",", ".") & "', valor_venda = '" & txtValorVenda.Text.Replace(",", ".") & "', quantidade = '" & txtQuant.Text & "', id_fornecedor = '" & cbFornecedor.SelectedValue & "', imagem = @img where id = '" & txtCodigo.Text & "'"

                    'DECLARACAO DO PARAMETRO DE IMAGEM
                    Dim param As New MySqlParameter
                    param.MySqlDbType = MySqlDbType.Binary
                    param.ParameterName = "img"
                    param.Value = fotoByte

                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.Add(param)
                    cmd.ExecuteNonQuery()
                Else

                    sql = "UPDATE produtos SET nome = '" & txtNome.Text & "', descricao = '" & txtDescricao.Text & "', valor_compra = '" & txtValorCompra.Text.Replace(",", ".") & "', valor_venda = '" & txtValorVenda.Text.Replace(",", ".") & "', quantidade = '" & txtQuant.Text & "', id_fornecedor = '" & cbFornecedor.SelectedValue & "' where id = '" & txtCodigo.Text & "'"
                    cmd = New MySqlCommand(sql, con)

                    cmd.ExecuteNonQuery()
                End If





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
            txtNome.Focus()
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If MsgBox("Deseja excluir o registro?", vbYesNo, "Escolha a Opção") = vbYes Then

            Try
                Abrir()
                'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM produtos where id = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Excluido com Sucesso!!", MsgBoxStyle.Information, "Dados Apagados")
                Listar()
                DesabilitarCampos()
                BtnEditar.Enabled = False
                btnExcluir.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try

        End If
    End Sub

    Private Sub BtnAddImagem_Click(sender As Object, e As EventArgs) Handles btnAddImagem.Click
        Dim dlgImagem As FileDialog = New OpenFileDialog
        dlgImagem.Filter = "Arquivo de Imagem(*.jpg; *.bmp; *.png)|*.jpg;*.bmp;*.png"

        If (dlgImagem.ShowDialog) = DialogResult.OK Then
            imgNome = dlgImagem.FileName
            abriu = True

            'DECLARANDO UMA VARIAVEL DO TIPO BITMAP PARA ASSOCIAR AO PICKTURE BOX
            Dim novaImg As New Bitmap(imgNome)
            img.Image = DirectCast(novaImg, Image)



        Else
            dlgImagem = Nothing
        End If

    End Sub



    Private Sub TxtBuscarNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged
        BuscarNome()
    End Sub

    Sub BuscarNome()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT p.id, p.nome, p.descricao, p.valor_compra, p.valor_venda, p.quantidade, p.id_fornecedor, p.imagem, f.nome FROM produtos as p INNER JOIN fornecedores as f on p.id_fornecedor = f.id where p.nome LIKE '" & txtBuscarNome.Text & "%' order by p.nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt


            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub


End Class