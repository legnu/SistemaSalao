Imports MySql.Data.MySqlClient

Public Class FrmCadHorarios
    Private Sub FrmCadHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtHora.Value = Now().ToString("yyyy-MM-dd 13:00")
        Listar()



    End Sub


    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM horarios order by horario asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt
            ValidaçaoDeHorarios()


            If grid.Rows.Count > 0 Then
                FormatarGrid()

            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub





    Private Sub FormatarGrid()
        'grid.Columns(0).Visible = False
        grid.Columns(0).HeaderText = "Id"
        grid.Columns(1).HeaderText = "Hora"


        grid.Columns(1).Width = 130

    End Sub


    Sub HabilitarCampos()
        dtHora.Enabled = True

    End Sub

    Sub DesabilitarCampos()
        dtHora.Enabled = False

    End Sub


    Sub Limpar()


    End Sub


    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        HabilitarCampos()
        BtnEditar.Enabled = True


        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        dtHora.Text = grid.CurrentRow.Cells(1).Value.ToString


    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
        ValidaçaoDeHorarios()

    End Sub


    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click


        If dtHora.Text <> "" Then
            Try
                'ABRINDO A CONEXÃO
                Abrir()





                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO


                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "INSERT INTO horarios (horario) VALUES ('" & dtHora.Text & "') "
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

        End If

    End Sub




    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If dtHora.Text <> "" Then
            Try

                'ABRINDO A CONEXÃO
                Abrir()


                'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE horarios SET horario = '" & dtHora.Text & "' where id = '" & txtCodigo.Text & "'"
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

        excluirHorarioUnitario()


    End Sub

    Sub ValidaçaoDeHorarios()

        Dim linha As DataGridViewRow



        For Each linha In grid.Rows
            If linha.Cells(0).Value < 20 Then

            Else
                btnSalvar.Enabled = False
                MsgBox("Quadro de Horarios Cheio!!", MsgBoxStyle.Information, "Esvazie a Carga de Horarios")
            End If

        Next
    End Sub

    Sub excluirHorarioUnitario()
        If MsgBox("Deseja excluir o registro?", vbYesNo, "Escolha a Opção") = vbYes Then

            Try
                Abrir()

                'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM horarios where id = '" & txtCodigo.Text & "'; ALTER TABLE horarios AUTO_INCREMENT = 1"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()


                MsgBox("Excluido com Sucesso!!", MsgBoxStyle.Information, "Dados Apagados")
                Listar()
                DesabilitarCampos()
                BtnEditar.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try

        End If
    End Sub

    Sub excluirTodoHorario()
        If MsgBox("Deseja excluir todo o registro?", vbYesNo, "Escolha a Opção") = vbYes Then

            Try
                Abrir()
                'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO

                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "DELETE FROM horarios ; ALTER TABLE horarios AUTO_INCREMENT = 1"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Registro excluido com Sucesso!!", MsgBoxStyle.Information, "Dados Apagados")
                Listar()
                DesabilitarCampos()
                BtnEditar.Enabled = False
            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        excluirTodoHorario()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs)

    End Sub


End Class