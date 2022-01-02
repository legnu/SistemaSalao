Imports MySql.Data.MySqlClient

Public Class FrmConsultarAgendamento

    Private Sub FrmConsultarAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarComboboxFuncionarios()
        dataBuscar.Value = Now().ToShortDateString
        cbStatus.Text = "Marcado"
        Listar()
    End Sub

    Private Sub CbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If cbStatus.Text = "Marcado" Then
            btnSalvar.Enabled = True
        Else
            btnSalvar.Enabled = False
        End If

        BuscarPorData()
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

            Dim data As String
            data = Now().ToString("yyyy-MM-dd")


            sql = "select * from agendamentos where data = '" & data & "' and status = '" & cbStatus.Text & "' and funcionario = '" & cbFuncionario.Text & "' order by hora asc"
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


    Private Sub BuscarPorData()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim data As String
            data = dataBuscar.Value.ToString("yyyy-MM-dd")

            sql = "select * from agendamentos where data = '" & data & "' and status = '" & cbStatus.Text & "' and funcionario = '" & cbFuncionario.Text & "' order by hora asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt


            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub DataBuscar_ValueChanged(sender As Object, e As EventArgs) Handles dataBuscar.ValueChanged
        BuscarPorData()
    End Sub

    Private Sub Grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        txtCodigo.Text = grid.CurrentRow.Cells(0).Value
        txtValor.Text = grid.CurrentRow.Cells(4).Value


    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtCodigo.Text <> "" Then
            If MsgBox("Deseja mudar o status para concluído?", vbYesNo, "Escolha a Opção") = vbYes Then

                Try
                    Abrir()
                    'PROGRAMANDO ALTERAÇÃO DO STATUS DA MARCAÇÃO PARA CONCLUIDO
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "UPDATE agendamentos SET status = 'Concluído' where id = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    Dim data As String
                    data = Now().ToString("yyyy-MM-dd")

                    'INSERINDO NA TABELA DE MOVIMENTAÇÃO O VALOR DO SERVIÇO
                    Dim cmdMov As MySqlCommand
                    Dim sqlMov As String
                    sqlMov = "INSERT INTO movimentacoes (tipo, movimento, valor, funcionario, data, id_movimento) VALUES ('Entrada', 'Serviço', '" & txtValor.Text & "', '" & nomeFuncionario & "',  '" & data & "', '" & txtCodigo.Text & "')"
                    cmdMov = New MySqlCommand(sqlMov, con)
                    cmdMov.ExecuteNonQuery()


                    MsgBox("Alterado com Sucesso!!", MsgBoxStyle.Information, "Dados Cancelados")
                    Listar()

                Catch ex As Exception
                    MsgBox("Erro ao alterar!!" + ex.Message)
                End Try

            End If
        Else
            MsgBox("Selecione um registro na grid para definir seu status como Concluido")
        End If
    End Sub

    Private Sub CbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuncionario.SelectedIndexChanged
        BuscarPorData()
    End Sub
End Class