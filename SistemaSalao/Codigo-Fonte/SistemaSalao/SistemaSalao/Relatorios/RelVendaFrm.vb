Imports Microsoft.Reporting.WinForms

Public Class RelVendaFrm
    Private Sub RelVendaFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'salaoDataSet1.VendasPorData'. Você pode movê-la ou removê-la conforme necessário.
        dataInicial.Value = Now.ToShortDateString
        dataFinal.Value = Now.ToShortDateString

        AbrirRelatorio()
    End Sub

    Private Sub dataInicial_ValueChanged(sender As Object, e As EventArgs) Handles dataInicial.ValueChanged
        AbrirRelatorio()
    End Sub

    Private Sub dataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dataFinal.ValueChanged
        AbrirRelatorio()
    End Sub


    Sub AbrirRelatorio()
        Me.VendasPorDataTableAdapter.Fill(Me.salaoDataSet1.VendasPorData, dataInicial.Text, dataFinal.Text)

        'ABAIXO RECUPERACAO DOS PARAMETROS NO CORPO DO RELATÓRIO
        Dim paramDataIni As ReportParameter
        Dim paramDataFin As ReportParameter

        paramDataIni = New ReportParameter("dataInicial", dataInicial.Text)
        paramDataFin = New ReportParameter("dataFinal", dataFinal.Text)

        Me.ReportViewer1.LocalReport.SetParameters(paramDataIni)
        Me.ReportViewer1.LocalReport.SetParameters(paramDataFin)



        Me.ReportViewer1.RefreshReport()
    End Sub

End Class