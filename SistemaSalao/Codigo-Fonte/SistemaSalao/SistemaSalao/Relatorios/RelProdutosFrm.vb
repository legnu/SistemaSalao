Public Class RelProdutosFrm
    Private Sub RelProdutosFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'salaoDataSet.ProdutosFornecedores'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProdutosFornecedoresTableAdapter.Fill(Me.salaoDataSet.ProdutosFornecedores)
        'TODO: esta linha de código carrega dados na tabela 'salaoDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.produtosTableAdapter.Fill(Me.salaoDataSet.produtos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class