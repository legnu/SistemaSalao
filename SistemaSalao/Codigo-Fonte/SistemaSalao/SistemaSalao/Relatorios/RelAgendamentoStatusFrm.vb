Imports Microsoft.Reporting.WinForms

Public Class RelAgendamentoStatusFrm
    Private Sub RelAgendamentoStatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DSAgendamentos.agendamentosPorDataeStatus'. Você pode movê-la ou removê-la conforme necessário.

        dataInicial.Value = Now.ToShortDateString
        dataFinal.Value = Now.ToShortDateString
        cbStatus.Text = "Concluído"
        CarregarRel()



    End Sub

    Private Sub CarregarRel()
        Me.agendamentosPorDataeStatusTableAdapter.Fill(Me.DSAgendamentos.agendamentosPorDataeStatus, dataInicial.Text, dataFinal.Text, cbStatus.Text)


        'ABAIXO RECUPERACAO DOS PARAMETROS NO CORPO DO RELATÓRIO
        Dim param(2) As ReportParameter


        param(0) = New ReportParameter("dataInicial", dataInicial.Text)
        param(1) = New ReportParameter("dataFinal", dataFinal.Text)
        param(2) = New ReportParameter("status", cbStatus.Text)

        Me.ReportViewer1.LocalReport.SetParameters(param)



        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub dataInicial_ValueChanged(sender As Object, e As EventArgs) Handles dataInicial.ValueChanged
        CarregarRel()
    End Sub

    Private Sub dataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dataFinal.ValueChanged
        CarregarRel()
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        CarregarRel()
    End Sub
End Class