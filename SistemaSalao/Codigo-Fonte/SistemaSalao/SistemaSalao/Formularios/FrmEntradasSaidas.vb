Imports MySql.Data.MySqlClient

Public Class FrmEntradasSaidas
    Private Sub FrmEntradasSaidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
        dataBuscarIni.Value = Now().ToShortDateString
        dataBuscarFin.Value = Now().ToShortDateString
    End Sub


    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM movimentacoes order by data desc"
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
        grid.Columns(6).Visible = False
        grid.Columns(0).HeaderText = "Id"
        grid.Columns(1).HeaderText = "Tipo"
        grid.Columns(2).HeaderText = "Movimento"
        grid.Columns(3).HeaderText = "Valor"
        grid.Columns(4).HeaderText = "Funcionário"
        grid.Columns(5).HeaderText = "Data"
        grid.Columns(6).HeaderText = "Id do Movimento"

        'grid.Columns(3).Width = 130

        CalcularTotalEntradas()
        CalcularTotalSaidas()
        CalcularTotal()

    End Sub



    Private Sub RbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        cbBusca.Visible = False
        dataBuscarIni.Visible = True
        dataBuscarFin.Visible = True
        lblInicial.Visible = True
        lblFinal.Visible = True
        If grid.Rows.Count > 0 Then
            BuscarPorData()
        End If


    End Sub

    Private Sub RbCPF_CheckedChanged(sender As Object, e As EventArgs) Handles rbEntSaida.CheckedChanged
        cbBusca.Visible = True
        dataBuscarIni.Visible = False
        dataBuscarFin.Visible = False
        lblInicial.Visible = False
        lblFinal.Visible = False
        BuscarPorEntradaSaida()
    End Sub


    Private Sub RbAmbos_CheckedChanged(sender As Object, e As EventArgs) Handles rbAmbos.CheckedChanged
        cbBusca.Visible = True
        dataBuscarIni.Visible = True
        dataBuscarFin.Visible = True
        lblInicial.Visible = True
        lblFinal.Visible = True
    End Sub

    Private Sub DataBuscarIni_ValueChanged(sender As Object, e As EventArgs) Handles dataBuscarIni.ValueChanged
        If rbAmbos.Checked = True Then
            BuscarPorDataEEntradaSaida()

        Else
            BuscarPorData()
        End If
    End Sub

    Private Sub DataBuscarFin_ValueChanged(sender As Object, e As EventArgs) Handles dataBuscarFin.ValueChanged
        If rbAmbos.Checked = True Then
            BuscarPorDataEEntradaSaida()

        Else
            BuscarPorData()
        End If
    End Sub


    Private Sub BuscarPorData()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim dataIni As String
            dataIni = dataBuscarIni.Value.ToString("yyyy-MM-dd")

            Dim dataFin As String
            dataFin = dataBuscarFin.Value.ToString("yyyy-MM-dd")

            sql = "SELECT * from movimentacoes where data >= '" & dataIni & "' and data <= '" & dataFin & "' order by data desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt

            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub CbBusca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBusca.SelectedIndexChanged
        If rbAmbos.Checked = True Then
            BuscarPorDataEEntradaSaida()
        Else
            BuscarPorEntradaSaida()
        End If

    End Sub

    Private Sub BuscarPorEntradaSaida()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter


            sql = "SELECT * from movimentacoes where tipo = '" & cbBusca.Text & "'  order by data desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt

            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub



    Private Sub BuscarPorDataEEntradaSaida()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim dataIni As String
            dataIni = dataBuscarIni.Value.ToString("yyyy-MM-dd")

            Dim dataFin As String
            dataFin = dataBuscarFin.Value.ToString("yyyy-MM-dd")

            sql = "SELECT * from movimentacoes where data >= '" & dataIni & "' and data <= '" & dataFin & "' and tipo = '" & cbBusca.Text & "' order by data desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt

            FormatarGrid()
        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub



    Sub CalcularTotalEntradas()
        Dim valor As Decimal
        Dim linha As DataGridViewRow

        For Each linha In grid.Rows
            If linha.Cells(1).Value = "Entrada" Then
                valor = valor + linha.Cells(3).Value
            End If

        Next

        lblTotEntradas.Text = valor

    End Sub


    Sub CalcularTotalSaidas()
        Dim valor As Decimal
        Dim linha As DataGridViewRow

        For Each linha In grid.Rows
            If linha.Cells(1).Value = "Saída" Then
                valor = valor + linha.Cells(3).Value
            End If

        Next

        lblTotalSaidas.Text = valor

    End Sub


    Sub CalcularTotal()
        Dim total As Decimal
        total = lblTotEntradas.Text - lblTotalSaidas.Text
        'lblTotalDia.Text = Format(total, "R$ 00,00")
        lblTotalDia.Text = Format(total, "R$ 00.00")

        If lblTotalDia.Text < 0 Then
            lblTotalDia.ForeColor = Color.Red
        Else
            lblTotalDia.ForeColor = Color.DarkGreen
        End If

    End Sub

End Class