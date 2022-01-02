Imports MySql.Data.MySqlClient

Public Class FrmCadFornecedores
    Private Sub FrmCadFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub


    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM fornecedores order by nome asc"
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

        grid.Columns(1).HeaderText = "Nome"

        grid.Columns(2).HeaderText = "Endereço"
        grid.Columns(3).HeaderText = "Telefone"
        grid.Columns(4).HeaderText = "Email"
        grid.Columns(5).HeaderText = "Produto"


        grid.Columns(4).Width = 120
        grid.Columns(5).Width = 150

    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
    End Sub




    Sub HabilitarCampos()
        txtNome.Enabled = True

        txtEndereco.Enabled = True
        txtTelefone.Enabled = True
        txtEmail.Enabled = True
        txtProduto.Enabled = True

    End Sub

    Sub DesabilitarCampos()
        txtNome.Enabled = False

        txtEndereco.Enabled = False
        txtTelefone.Enabled = False
        txtEmail.Enabled = False
        txtProduto.Enabled = False

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        If txtNome.Text <> "" Then
            Try
                'ABRINDO A CONEXÃO
                Abrir()

                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO fornecedores (nome, endereco, telefone, email, produto) VALUES ('" & txtNome.Text & "', '" & txtEndereco.Text & "', '" & txtTelefone.Text & "', '" & txtEmail.Text & "', '" & txtProduto.Text & "')"
                cmd = New MySqlCommand(sql, con)
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

        txtEndereco.Text = ""
        txtTelefone.Text = ""
        txtEmail.Text = ""
        txtProduto.Text = ""
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        BtnEditar.Enabled = True
        btnExcluir.Enabled = True

        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        txtNome.Text = grid.CurrentRow.Cells(1).Value

        txtEndereco.Text = grid.CurrentRow.Cells(2).Value
        txtTelefone.Text = grid.CurrentRow.Cells(3).Value
        txtEmail.Text = grid.CurrentRow.Cells(4).Value
        txtProduto.Text = grid.CurrentRow.Cells(5).Value


    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If txtNome.Text <> "" Then
            Try

                'ABRINDO A CONEXÃO
                Abrir()


                'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE fornecedores SET nome = '" & txtNome.Text & "',  endereco = '" & txtEndereco.Text & "', telefone = '" & txtTelefone.Text & "', email = '" & txtEmail.Text & "', produto = '" & txtProduto.Text & "' where id = '" & txtCodigo.Text & "'"
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

                sql = "DELETE FROM fornecedores where id = '" & txtCodigo.Text & "' "
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

    Private Sub TxtBuscarNome_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNome.TextChanged
        BuscarNome()
    End Sub

    Sub BuscarNome()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM fornecedores where nome LIKE '" & txtBuscarNome.Text & "%' order by nome asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt


            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub



End Class