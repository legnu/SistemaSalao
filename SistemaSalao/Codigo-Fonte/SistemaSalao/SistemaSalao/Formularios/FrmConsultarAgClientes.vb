Imports MySql.Data.MySqlClient

Public Class FrmConsultarAgClientes
    Private Sub FrmConsultarAgClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()


    End Sub


    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim data As DateTime
            Dim dataFormatada As String
            data = DateTime.Now().AddDays(-30)
            dataFormatada = data.ToString("yyyy-MM-dd")

            sql = "select * from agendamentos where status = 'Concluído' and data <= '" & dataFormatada & "' order by data asc"
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


    Sub BuscarPorNome()
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter


            Dim data As DateTime
            Dim dataFormatada As String
            data = DateTime.Now().AddDays(-30)
            dataFormatada = data.ToString("yyyy-MM-dd")


            sql = "select * from agendamentos where status = 'Concluído' and cliente LIKE '" & txtBuscar.Text & "%' and data <= '" & dataFormatada & "' order by data asc"
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

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BuscarPorNome()
    End Sub

    Private Sub Grid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellDoubleClick
        nomeClienteAgendamento = grid.CurrentRow.Cells(2).Value
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub
End Class