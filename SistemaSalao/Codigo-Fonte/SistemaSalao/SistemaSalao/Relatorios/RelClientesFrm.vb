Imports Microsoft.Reporting.WinForms

Public Class RelClientesFrm
    Private Sub RelClientesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dataInicial.Value = Now.ToShortDateString
        dataFinal.Value = Now.ToShortDateString
        CarregarRel()
    End Sub

    Sub CarregarRel()
        'TODO: esta linha de código carrega dados na tabela 'DSClientes.clientesPorData'. Você pode movê-la ou removê-la conforme necessário.

        'ESSA LINHA RECUPERA PARAMETROS VINDOS DE UMA CONSULTA NO RELATÓRIO
        Me.clientesPorDataTableAdapter.Fill(Me.DSClientes.clientesPorData, dataInicial.Text, dataFinal.Text)


        'ABAIXO RECUPERACAO DOS PARAMETROS NO CORPO DO RELATÓRIO
        Dim paramDataIni As ReportParameter
        Dim paramDataFin As ReportParameter

        paramDataIni = New ReportParameter("dataInicial", dataInicial.Text)
        paramDataFin = New ReportParameter("dataFinal", dataFinal.Text)

        Me.ReportViewer1.LocalReport.SetParameters(paramDataIni)
        Me.ReportViewer1.LocalReport.SetParameters(paramDataFin)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dataInicial_ValueChanged(sender As Object, e As EventArgs) Handles dataInicial.ValueChanged
        CarregarRel()
    End Sub

    Private Sub dataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dataFinal.ValueChanged
        CarregarRel()
    End Sub
End Class