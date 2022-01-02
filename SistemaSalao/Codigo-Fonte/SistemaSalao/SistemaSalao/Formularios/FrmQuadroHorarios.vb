Imports MySql.Data.MySqlClient

Public Class FrmQuadroHorarios
    Private Sub FrmQuadroHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataBuscar.Value = Now().ToShortDateString
        CarregarComboboxFuncionarios()
        CarregarHora()
        cbFuncionario.Text = nomeFuncionario
        Listar()
        ListarHorarios()
        SincronizarHorarios()


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


            sql = "select * from agendamentos where data = '" & data & "' and status = 'Marcado' and funcionario = '" & cbFuncionario.Text & "' order by hora asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt
            VerificarHorarios()


            If grid.Rows.Count > 0 Then
                FormatarGrid()

            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Sub ListarHorarios()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM horarios order by horario asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            gridHorarios.DataSource = dt

            If gridHorarios.Rows.Count > 0 Then
                FormatarGrid()

            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


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

    Private Sub CarregarHora()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM horarios order by horario asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbHora.ValueMember = "id"
                cbHora.DisplayMember = "horario"
                cbHora.DataSource = dt
            Else
                cbHora.Text = "Cadastre um Horario"

            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub



    Private Sub FormatarGrid()
        grid.Columns(0).Visible = False
        grid.Columns(1).Visible = False
        grid.Columns(3).Visible = False
        grid.Columns(4).Visible = False
        grid.Columns(7).Visible = False

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







    Private Sub BuscarPorDataEFuncionario()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim data As String
            data = dataBuscar.Value.ToString("yyyy-MM-dd")

            sql = "select * from agendamentos where data = '" & data & "' and status = 'Marcado' and funcionario = '" & cbFuncionario.Text & "' order by hora asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt
            VerificarHorarios()

            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub CbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuncionario.SelectedIndexChanged
        BuscarPorDataEFuncionario()
    End Sub

    Private Sub DataBuscar_ValueChanged(sender As Object, e As EventArgs) Handles dataBuscar.ValueChanged
        BuscarPorDataEFuncionario()
    End Sub


    Sub VerificarHorarios()

        RestaurarHorarios()



        For Each linha As DataGridViewRow In grid.Rows
            If lbl1.Text = linha.Cells(6).Value.ToString Then
                Panel8.BackColor = Color.Tomato
                Panel8.Enabled = False
            End If


            If lbl2.Text = linha.Cells(6).Value.ToString Then
                Panel9.BackColor = Color.Tomato
                Panel9.Enabled = False
            End If

            If lbl3.Text = linha.Cells(6).Value.ToString Then
                Panel10.BackColor = Color.Tomato
                Panel10.Enabled = False
            End If

            If lbl4.Text = linha.Cells(6).Value.ToString Then
                Panel11.BackColor = Color.Tomato
                Panel11.Enabled = False
            End If

            If lbl5.Text = linha.Cells(6).Value.ToString Then
                Panel13.BackColor = Color.Tomato
                Panel13.Enabled = False
            End If

            If lbl6.Text = linha.Cells(6).Value.ToString Then
                Panel14.BackColor = Color.Tomato
                Panel14.Enabled = False
            End If


            If lbl7.Text = linha.Cells(6).Value.ToString Then
                Panel15.BackColor = Color.Tomato
                Panel15.Enabled = False
            End If

            If lbl8.Text = linha.Cells(6).Value.ToString Then
                Panel16.BackColor = Color.Tomato
                Panel16.Enabled = False
            End If

            If lbl9.Text = linha.Cells(6).Value.ToString Then
                Panel17.BackColor = Color.Tomato
                Panel17.Enabled = False
            End If

            If lbl10.Text = linha.Cells(6).Value.ToString Then
                Panel18.BackColor = Color.Tomato
                Panel18.Enabled = False
            End If

            If lbl11.Text = linha.Cells(6).Value.ToString Then
                Panel1.BackColor = Color.Tomato
                Panel1.Enabled = False
            End If

            If lbl12.Text = linha.Cells(6).Value.ToString Then
                Panel19.BackColor = Color.Tomato
                Panel19.Enabled = False
            End If

            If lbl13.Text = linha.Cells(6).Value.ToString Then
                Panel3.BackColor = Color.Tomato
                Panel3.Enabled = False
            End If

            If lbl14.Text = linha.Cells(6).Value.ToString Then
                Panel4.BackColor = Color.Tomato
                Panel4.Enabled = False
            End If

            If lbl15.Text = linha.Cells(6).Value.ToString Then
                Panel12.BackColor = Color.Tomato
                Panel12.Enabled = False
            End If

            If lbl16.Text = linha.Cells(6).Value.ToString Then
                Panel2.BackColor = Color.Tomato
                Panel2.Enabled = False
            End If

            If lbl17.Text = linha.Cells(6).Value.ToString Then
                Panel20.BackColor = Color.Tomato
                Panel20.Enabled = False
            End If

            If lbl18.Text = linha.Cells(6).Value.ToString Then
                Panel7.BackColor = Color.Tomato
                Panel7.Enabled = False
            End If

            If lbl19.Text = linha.Cells(6).Value.ToString Then
                Panel6.BackColor = Color.Tomato
                Panel6.Enabled = False
            End If

            If lbl20.Text = linha.Cells(6).Value.ToString Then
                Panel5.BackColor = Color.Tomato
                Panel5.Enabled = False
            End If

        Next

    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click

        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl1.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub FrmQuadroHorarios_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl2.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel10_Click(sender As Object, e As EventArgs) Handles Panel10.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl3.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel11_Click(sender As Object, e As EventArgs) Handles Panel11.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl4.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel13_Click(sender As Object, e As EventArgs) Handles Panel13.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl5.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel14_Click(sender As Object, e As EventArgs) Handles Panel14.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl6.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel15_Click(sender As Object, e As EventArgs) Handles Panel15.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl7.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel16_Click(sender As Object, e As EventArgs) Handles Panel16.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl8.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel17_Click(sender As Object, e As EventArgs) Handles Panel17.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl9.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel18_Click(sender As Object, e As EventArgs) Handles Panel18.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl10.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl11.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel19_Click(sender As Object, e As EventArgs) Handles Panel19.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl12.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl13.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl14.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl15.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl16.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel20_Click(sender As Object, e As EventArgs) Handles Panel20.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl17.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl18.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl19.Text
        Dim form = FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        nomeFuncAgendamento = cbFuncionario.Text
        horarioAgendamento = lbl20.Text
        Dim form = FrmAgendamento
        form.ShowDialog()

    End Sub

    Sub RestaurarHorarios()
        Panel8.BackColor = Color.LightGreen
        Panel8.Enabled = True

        Panel9.BackColor = Color.LightGreen
        Panel9.Enabled = True

        Panel10.BackColor = Color.LightGreen
        Panel10.Enabled = True

        Panel11.BackColor = Color.LightGreen
        Panel11.Enabled = True

        Panel13.BackColor = Color.LightGreen
        Panel13.Enabled = True

        Panel14.BackColor = Color.LightGreen
        Panel14.Enabled = True

        Panel15.BackColor = Color.LightGreen
        Panel15.Enabled = True

        Panel16.BackColor = Color.LightGreen
        Panel16.Enabled = True

        Panel17.BackColor = Color.LightGreen
        Panel17.Enabled = True

        Panel18.BackColor = Color.LightGreen
        Panel18.Enabled = True
    End Sub




    Sub SincronizarHorarios()

        Dim linha As DataGridViewRow



        For Each linha In gridHorarios.Rows

            If lbl1.Text = "" Then
                lbl1.Text = linha.Cells(1).Value.ToString


            ElseIf lbl2.Text = "" Then

                lbl2.Text = linha.Cells(1).Value.ToString

            ElseIf lbl3.Text = "" Then
                lbl3.Text = linha.Cells(1).Value.ToString

            ElseIf lbl4.Text = "" Then
                lbl4.Text = linha.Cells(1).Value.ToString

            ElseIf lbl5.Text = "" Then
                lbl5.Text = linha.Cells(1).Value.ToString

            ElseIf lbl6.Text = "" Then
                lbl6.Text = linha.Cells(1).Value.ToString

            ElseIf lbl7.Text = "" Then
                lbl7.Text = linha.Cells(1).Value.ToString

            ElseIf lbl8.Text = "" Then
                lbl8.Text = linha.Cells(1).Value.ToString

            ElseIf lbl9.Text = "" Then
                lbl9.Text = linha.Cells(1).Value.ToString

            ElseIf lbl10.Text = "" Then
                lbl10.Text = linha.Cells(1).Value.ToString

            ElseIf lbl11.Text = "" Then
                lbl11.Text = linha.Cells(1).Value.ToString

            ElseIf lbl12.Text = "" Then

                lbl12.Text = linha.Cells(1).Value.ToString

            ElseIf lbl13.Text = "" Then
                lbl13.Text = linha.Cells(1).Value.ToString

            ElseIf lbl14.Text = "" Then
                lbl14.Text = linha.Cells(1).Value.ToString

            ElseIf lbl15.Text = "" Then
                lbl15.Text = linha.Cells(1).Value.ToString

            ElseIf lbl16.Text = "" Then
                lbl16.Text = linha.Cells(1).Value.ToString

            ElseIf lbl17.Text = "" Then
                lbl17.Text = linha.Cells(1).Value.ToString

            ElseIf lbl18.Text = "" Then
                lbl18.Text = linha.Cells(1).Value.ToString

            ElseIf lbl19.Text = "" Then
                lbl19.Text = linha.Cells(1).Value.ToString

            ElseIf lbl20.Text = "" Then
                lbl20.Text = linha.Cells(1).Value.ToString

            End If




        Next


    End Sub


End Class