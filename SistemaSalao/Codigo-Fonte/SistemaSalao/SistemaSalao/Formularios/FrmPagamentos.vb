Imports MySql.Data.MySqlClient

Public Class FrmPagamentos
    Private Sub FrmPagamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        dataBuscar.Value = Now().ToShortDateString
        CarregarCombobox()
    End Sub


    Private Sub CarregarCombobox()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM funcionarios order by nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbFuncionario.ValueMember = "id"
                cbFuncionario.DisplayMember = "nome"
                cbFuncionario.DataSource = dt
            Else
                cbFuncionario.Text = "Cadastre um Funcionário"
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

            sql = "SELECT * FROM pagamentos order by data desc"
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
        grid.Columns(0).HeaderText = "Id"
        grid.Columns(1).HeaderText = "Valor"

        grid.Columns(2).HeaderText = "Funcionário"
        grid.Columns(3).HeaderText = "Gerente"
        grid.Columns(4).HeaderText = "Data"

        'grid.Columns(2).Width = 300

    End Sub


    Sub HabilitarCampos()
        txtValor.Enabled = True
        cbFuncionario.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtValor.Enabled = False
        cbFuncionario.Enabled = False

    End Sub


    Sub Limpar()

        txtValor.Text = ""
    End Sub


    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        BtnEditar.Enabled = True
        btnExcluir.Enabled = True

        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        txtValor.Text = grid.CurrentRow.Cells(1).Value
        cbFuncionario.Text = grid.CurrentRow.Cells(2).Value


    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
    End Sub


    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim id_pgt As Integer

        If txtValor.Text <> "" Then
            Try
                'ABRINDO A CONEXÃO
                Abrir()


                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                Dim data As String
                data = Now().ToString("yyyy-MM-dd")

                sql = "INSERT INTO pagamentos (valor, funcionario, gerente, data) VALUES ('" & txtValor.Text & "', '" & cbFuncionario.Text & "', '" & nomeFuncionario & "', '" & data & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()


                'RECUPERAR O ID DO ULTIMO PAGAMENTO QUE EU ACABEI DE INSERIR
                Dim cmdR As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sqlR As String

                sqlR = "SELECT MAX(ID) FROM pagamentos"
                cmdR = New MySqlCommand(sqlR, con)
                reader = cmdR.ExecuteReader




                If reader.Read = True Then

                    'RECUPERANDO O ID
                    Dim id As Integer
                    id = reader(0)
                    id_pgt = id

                    reader.Close()


                Else
                    MsgBox("Não foi encontrado o id!", MsgBoxStyle.Information, "Id")

                End If
                reader.Close()


                'INSERINDO MOVIMENTAÇÃO DO PAGAMENTO NA TABELA DE MOVIMENTAÇÕES
                Dim cmdMov As MySqlCommand
                Dim sqlMov As String
                sqlMov = "INSERT INTO movimentacoes (tipo, movimento, valor, funcionario, data, id_movimento) VALUES ('Saída', 'Pagamento', '" & txtValor.Text & "', '" & nomeFuncionario & "',  '" & data & "', '" & id_pgt & "')"
                cmdMov = New MySqlCommand(sqlMov, con)
                cmdMov.ExecuteNonQuery()



                MsgBox("Salvo com Sucesso!!", MsgBoxStyle.Information, "Dados Salvo")
                Listar()
                DesabilitarCampos()
                btnSalvar.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao Salvar!!" + ex.Message)
            End Try

        Else
            MsgBox("Preencha o Campo!!", MsgBoxStyle.Information, "Prencha os Dados")
            txtValor.Focus()
        End If

    End Sub




    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If txtValor.Text <> "" Then
            Try

                'ABRINDO A CONEXÃO
                Abrir()


                'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE pagamentos SET valor = '" & txtValor.Text & "', funcionario = '" & cbFuncionario.Text & "' where id = '" & txtCodigo.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()



                'EDITANTO MOVIMENTAÇÃO DO PAGAMENTO NA TABELA DE MOVIMENTAÇÕES
                Dim cmdMov As MySqlCommand
                Dim sqlMov As String
                sqlMov = "UPDATE movimentacoes SET valor = '" & txtValor.Text & "'  where id_movimento = '" & txtCodigo.Text & "'  and movimento = 'Pagamento'"
                cmdMov = New MySqlCommand(sqlMov, con)
                cmdMov.ExecuteNonQuery()





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
            txtValor.Focus()
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If MsgBox("Deseja excluir o registro?", vbYesNo, "Escolha a Opção") = vbYes Then

            Try
                Abrir()
                'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM pagamentos where id = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                'PROGRAMANDO EXCLUSÃO DE REGISTRO NAS MOVIMENTAÇÕES
                Dim cmdM As MySqlCommand
                Dim sqlM As String

                sqlM = "DELETE FROM movimentacoes where id_movimento = '" & txtCodigo.Text & "' and movimento = 'Pagamento'"
                cmdM = New MySqlCommand(sqlM, con)
                cmdM.ExecuteNonQuery()

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

    Private Sub DataBuscar_ValueChanged(sender As Object, e As EventArgs) Handles dataBuscar.ValueChanged
        BuscarPorData()
    End Sub

    Private Sub BuscarPorData()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim data As String
            data = dataBuscar.Value.ToString("yyyy-MM-dd")

            sql = "SELECT * from pagamentos where data = '" & data & "' order by data desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt

            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub



End Class