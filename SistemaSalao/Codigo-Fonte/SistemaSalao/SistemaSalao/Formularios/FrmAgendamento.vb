Imports MySql.Data.MySqlClient

Public Class FrmAgendamento
    Private Sub FrmAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        CarregarComboboxFuncionarios()
        CarregarComboboxServicos()
        dataBuscar.Value = Now().ToShortDateString
        dtData.Value = Now().ToShortDateString

        If horarioAgendamento <> "" Then
            dtHora.Text = horarioAgendamento
        Else
            dtHora.Value = Now().ToString("yyyy-MM-dd 13:00")
        End If

        If nomeFuncAgendamento <> "" Then
            cbFuncionario.Text = nomeFuncAgendamento
        End If

    End Sub


    Private Sub CarregarComboboxFuncionarios()
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

    Private Sub CarregarComboboxServicos()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM servicos order by servico asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbServico.ValueMember = "valor"
                cbServico.DisplayMember = "servico"
                cbServico.DataSource = dt
            Else
                cbServico.Text = "Cadastre um Serviço"
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

            sql = "SELECT * from agendamentos where status = 'Marcado' order by data desc"
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

        grid.Columns(1).HeaderText = "Funcionário"
        grid.Columns(2).HeaderText = "Cliente"
        grid.Columns(3).HeaderText = "Serviço"
        grid.Columns(4).HeaderText = "Valor Serviço"
        grid.Columns(5).HeaderText = "Data"
        grid.Columns(6).HeaderText = "Hora"
        grid.Columns(7).HeaderText = "Status"

        'grid.Columns(3).Width = 130

    End Sub

    Private Sub CbServico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbServico.SelectedIndexChanged
        txtValor.Text = cbServico.SelectedValue
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub FrmAgendamento_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtCliente.Text = nomeCliente
    End Sub



    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Limpar()
        HabilitarCampos()
        btnSalvar.Enabled = True
        btnBuscarCliente.Enabled = True
    End Sub


    Sub HabilitarCampos()
        cbServico.Enabled = True
        cbFuncionario.Enabled = True
        dtData.Enabled = True
        dtHora.Enabled = True
        btnBuscarCliente.Enabled = True
    End Sub

    Sub DesabilitarCampos()
        cbServico.Enabled = False
        cbFuncionario.Enabled = False
        dtData.Enabled = False
        dtHora.Enabled = False
        btnBuscarCliente.Enabled = False
    End Sub


    Sub Limpar()

        txtCliente.Text = ""
        nomeCliente = ""
        cbServico.SelectedIndex() = 0



    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If cbServico.Text <> "" And cbFuncionario.Text <> "" And txtCliente.Text <> "" Then
            Try
                'ABRINDO A CONEXÃO
                Abrir()


                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                Dim data As String
                data = dtData.Value.ToString("yyyy-MM-dd")


                'VERIFICAR SE O HORÁRIO EXISTE NA TABELA DE HORARIOS
                Dim cmdH As MySqlCommand
                Dim sqlH As String
                Dim readerH As MySqlDataReader


                sqlH = "select * from horarios where horario = '" & dtHora.Text & "' "
                cmdH = New MySqlCommand(sqlH, con)
                readerH = cmdH.ExecuteReader

                If readerH.Read Then
                    readerH.Close()

                    'SABER SE O HORÁRIO ESTÁ DISPONIVEL
                    Dim cmdDisp As MySqlCommand
                    Dim sqlDisp As String
                    Dim readerDisp As MySqlDataReader


                    sqlDisp = "select * from agendamentos where hora = '" & dtHora.Text & "' and data = '" & data & "' and funcionario = '" & cbFuncionario.Text & "' and status = 'Marcado' "
                    cmdDisp = New MySqlCommand(sqlDisp, con)
                    readerDisp = cmdDisp.ExecuteReader

                    If readerDisp.Read Then
                        readerDisp.Close()
                        MsgBox("Este horário não está disponível!")
                    Else
                        readerDisp.Close()

                        sql = "INSERT INTO agendamentos (funcionario, cliente, servico, valor, data, hora, status) VALUES ('" & cbFuncionario.Text & "', '" & txtCliente.Text & "', '" & cbServico.Text & "', '" & txtValor.Text & "', '" & data & "', '" & dtHora.Text & "', 'Marcado')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        MsgBox("Salvo com Sucesso!!", MsgBoxStyle.Information, "Dados Salvo")
                        Listar()
                        Limpar()
                        DesabilitarCampos()
                        btnSalvar.Enabled = False
                        cbFuncionario.SelectedIndex() = 0
                        nomeFuncAgendamento = ""
                        horarioAgendamento = ""
                    End If
                    readerDisp.Close()

                Else
                    readerH.Close()
                    MsgBox("Horario Inexistente para Agendamento")
                End If
                readerH.Close()



            Catch ex As Exception
                MsgBox("Erro ao Salvar " + ex.Message)
            End Try
        Else
            MsgBox("Preencha os Campos")
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If cbServico.Text <> "" And cbFuncionario.Text <> "" And txtCliente.Text <> "" Then
            Try
                'ABRINDO A CONEXÃO
                Abrir()


                'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                Dim data As String
                data = dtData.Value.ToString("yyyy-MM-dd")


                'VERIFICAR SE O HORÁRIO EXISTE NA TABELA DE HORARIOS
                Dim cmdH As MySqlCommand
                Dim sqlH As String
                Dim readerH As MySqlDataReader


                sqlH = "select * from horarios where horario = '" & dtHora.Text & "' "
                cmdH = New MySqlCommand(sqlH, con)
                readerH = cmdH.ExecuteReader

                If readerH.Read Then
                    readerH.Close()

                    'SABER SE O HORÁRIO ESTÁ DISPONIVEL
                    Dim cmdDisp As MySqlCommand
                    Dim sqlDisp As String
                    Dim readerDisp As MySqlDataReader


                    sqlDisp = "select * from agendamentos where hora = '" & dtHora.Text & "' and data = '" & data & "' and funcionario = '" & cbFuncionario.Text & "' and status = 'Marcado' "
                    cmdDisp = New MySqlCommand(sqlDisp, con)
                    readerDisp = cmdDisp.ExecuteReader

                    If readerDisp.Read Then
                        readerDisp.Close()
                        MsgBox("Este horário não está disponível!")
                    Else
                        readerDisp.Close()


                        sql = "UPDATE agendamentos SET funcionario = '" & cbFuncionario.Text & "', cliente = '" & txtCliente.Text & "', servico = '" & cbServico.Text & "', valor = '" & txtValor.Text & "', data = '" & data & "', hora = '" & dtHora.Text & "' where id = '" & txtCodigo.Text & "'"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        MsgBox("Editado com sucesso!!", MsgBoxStyle.Information, "Dados Editados")
                        Listar()
                        Limpar()
                        DesabilitarCampos()
                        BtnEditar.Enabled = False
                        btnExcluir.Enabled = False

                    End If
                    readerDisp.Close()

                Else
                    readerH.Close()
                    MsgBox("Horario Inexistente para Agendamento")
                End If
                readerH.Close()



            Catch ex As Exception
                MsgBox("Erro ao Salvar " + ex.Message)
            End Try
        Else
            MsgBox("Preencha os Campos")
        End If
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        btnBuscarCliente.Enabled = True
        BtnEditar.Enabled = True
        btnExcluir.Enabled = True
        HabilitarCampos()

        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        cbFuncionario.Text = grid.CurrentRow.Cells(1).Value
        txtCliente.Text = grid.CurrentRow.Cells(2).Value
        cbServico.Text = grid.CurrentRow.Cells(3).Value
        txtValor.Text = grid.CurrentRow.Cells(4).Value
        dtData.Text = grid.CurrentRow.Cells(5).Value
        dtHora.Text = grid.CurrentRow.Cells(6).Value.ToString

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja cancelar o agendamento?", vbYesNo, "Escolha a Opção") = vbYes Then

            Try
                Abrir()
                'PROGRAMANDO ALTERAÇÃO DO STATUS DA MARCAÇÃO PARA CANCELADO
                Dim cmd As MySqlCommand
                Dim sql As String

                sql = "UPDATE agendamentos SET status = 'Cancelado' where id = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                MsgBox("Cancelado com Sucesso!!", MsgBoxStyle.Information, "Dados Cancelados")
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

            sql = "select * from agendamentos where data = '" & data & "' and status = 'Marcado' order by hora asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt


            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

End Class