<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelProdutosFrm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.produtosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.salaoDataSet = New SistemaSalao.salaoDataSet()
        Me.produtosTableAdapter = New SistemaSalao.salaoDataSetTableAdapters.produtosTableAdapter()
        Me.ProdutosFornecedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdutosFornecedoresTableAdapter = New SistemaSalao.salaoDataSetTableAdapters.ProdutosFornecedoresTableAdapter()
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salaoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdutosFornecedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetProdutos"
        ReportDataSource1.Value = Me.ProdutosFornecedoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaSalao.RelProdutos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(606, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'produtosBindingSource
        '
        Me.produtosBindingSource.DataMember = "produtos"
        Me.produtosBindingSource.DataSource = Me.salaoDataSet
        '
        'salaoDataSet
        '
        Me.salaoDataSet.DataSetName = "salaoDataSet"
        Me.salaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'produtosTableAdapter
        '
        Me.produtosTableAdapter.ClearBeforeFill = True
        '
        'ProdutosFornecedoresBindingSource
        '
        Me.ProdutosFornecedoresBindingSource.DataMember = "ProdutosFornecedores"
        Me.ProdutosFornecedoresBindingSource.DataSource = Me.salaoDataSet
        '
        'ProdutosFornecedoresTableAdapter
        '
        Me.ProdutosFornecedoresTableAdapter.ClearBeforeFill = True
        '
        'RelProdutosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(606, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RelProdutosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Produtos"
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salaoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdutosFornecedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents produtosBindingSource As BindingSource
    Friend WithEvents salaoDataSet As salaoDataSet
    Friend WithEvents produtosTableAdapter As salaoDataSetTableAdapters.produtosTableAdapter
    Friend WithEvents ProdutosFornecedoresBindingSource As BindingSource
    Friend WithEvents ProdutosFornecedoresTableAdapter As salaoDataSetTableAdapters.ProdutosFornecedoresTableAdapter
End Class
