Imports MySql.Data.MySqlClient

Public Class FrmCadServicos
    Private Sub FrmCadServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub


    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM servicos order by servico asc"
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

        grid.Columns(1).HeaderText = "Serviço"
        grid.Columns(2).HeaderText = "Valor"

        grid.Columns(2).DefaultCellStyle.Format = "c"

        grid.Columns(1).Width = 120

    End Sub


    Sub HabilitarCampos()
        txtServico.Enabled = True
        txtValor.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        txtServico.Enabled = False
        txtValor.Enabled = False
    End Sub


    Sub Limpar()
        txtServico.Text = ""
        txtValor.Text = ""
    End Sub


    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        BtnEditar.Enabled = True
        btnExcluir.Enabled = True

        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        txtServico.Text = grid.CurrentRow.Cells(1).Value
        txtValor.Text = grid.CurrentRow.Cells(2).Value

    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
    End Sub


    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        If txtServico.Text <> "" Then
            Try
                'ABRINDO A CONEXÃO
                Abrir()


                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO servicos (servico, valor) VALUES ('" & txtServico.Text & "', '" & txtValor.Text & "')"
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
            MsgBox("Preencha o Campo!!", MsgBoxStyle.Information, "Prencha os Dados")
            txtServico.Focus()
        End If

    End Sub




    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If txtServico.Text <> "" Then
            Try

                'ABRINDO A CONEXÃO
                Abrir()


                'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE servicos SET servico = '" & txtServico.Text & "', valor = '" & txtValor.Text & "' where id = '" & txtCodigo.Text & "'"
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
            txtServico.Focus()
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If MsgBox("Deseja excluir o registro?", vbYesNo, "Escolha a Opção") = vbYes Then

            Try
                Abrir()
                'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM servicos where id = '" & txtCodigo.Text & "' "
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



End Class