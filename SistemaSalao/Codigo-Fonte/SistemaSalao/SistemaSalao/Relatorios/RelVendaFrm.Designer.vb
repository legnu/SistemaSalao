<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelVendaFrm
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
        Me.VendasPorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.salaoDataSet1 = New SistemaSalao.salaoDataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataFinal = New System.Windows.Forms.DateTimePicker()
        Me.dataInicial = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VendasPorDataTableAdapter = New SistemaSalao.salaoDataSet1TableAdapters.VendasPorDataTableAdapter()
        CType(Me.VendasPorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salaoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendasPorDataBindingSource
        '
        Me.VendasPorDataBindingSource.DataMember = "VendasPorData"
        Me.VendasPorDataBindingSource.DataSource = Me.salaoDataSet1
        '
        'salaoDataSet1
        '
        Me.salaoDataSet1.DataSetName = "salaoDataSet1"
        Me.salaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(489, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Data Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Data Inicial"
        '
        'dataFinal
        '
        Me.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataFinal.Location = New System.Drawing.Point(555, 12)
        Me.dataFinal.Name = "dataFinal"
        Me.dataFinal.Size = New System.Drawing.Size(107, 20)
        Me.dataFinal.TabIndex = 10
        '
        'dataInicial
        '
        Me.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataInicial.Location = New System.Drawing.Point(335, 12)
        Me.dataInicial.Name = "dataInicial"
        Me.dataInicial.Size = New System.Drawing.Size(107, 20)
        Me.dataInicial.TabIndex = 9
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DSVendas"
        ReportDataSource1.Value = Me.VendasPorDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaSalao.RelVendas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 67)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(682, 488)
        Me.ReportViewer1.TabIndex = 13
        '
        'VendasPorDataTableAdapter
        '
        Me.VendasPorDataTableAdapter.ClearBeforeFill = True
        '
        'RelVendaFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(721, 567)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataFinal)
        Me.Controls.Add(Me.dataInicial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RelVendaFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas"
        CType(Me.VendasPorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salaoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dataFinal As DateTimePicker
    Friend WithEvents dataInicial As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VendasPorDataBindingSource As BindingSource
    Friend WithEvents salaoDataSet1 As salaoDataSet1
    Friend WithEvents VendasPorDataTableAdapter As salaoDataSet1TableAdapters.VendasPorDataTableAdapter
End Class
