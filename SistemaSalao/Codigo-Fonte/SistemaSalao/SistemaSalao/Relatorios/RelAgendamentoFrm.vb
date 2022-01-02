Imports Microsoft.Reporting.WinForms

Public Class RelAgendamentoFrm
    Private Sub RelAgendamentoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DSAgendamentos.agendamentosPorData'. Você pode movê-la ou removê-la conforme necessário.

        dataInicial.Value = Now.ToShortDateString
        dataFinal.Value = Now.ToShortDateString
        CarregarRel()
    End Sub


    Sub CarregarRel()
        Me.agendamentosPorDataTableAdapter.Fill(Me.DSAgendamentos.agendamentosPorData, dataInicial.Text, dataFinal.Text)


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