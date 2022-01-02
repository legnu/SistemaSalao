<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RelGastosFrm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataFinal = New System.Windows.Forms.DateTimePicker()
        Me.dataInicial = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSGastos = New SistemaSalao.DSGastos()
        Me.GastorPorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GastorPorDataTableAdapter = New SistemaSalao.DSGastosTableAdapters.GastorPorDataTableAdapter()
        CType(Me.DSGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastorPorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(495, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Data Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data Inicial"
        '
        'dataFinal
        '
        Me.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataFinal.Location = New System.Drawing.Point(561, 12)
        Me.dataFinal.Name = "dataFinal"
        Me.dataFinal.Size = New System.Drawing.Size(107, 20)
        Me.dataFinal.TabIndex = 6
        '
        'dataInicial
        '
        Me.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataInicial.Location = New System.Drawing.Point(341, 12)
        Me.dataInicial.Name = "dataInicial"
        Me.dataInicial.Size = New System.Drawing.Size(107, 20)
        Me.dataInicial.TabIndex = 5
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.GastorPorDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaSalao.RelGastos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 57)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(656, 534)
        Me.ReportViewer1.TabIndex = 9
        '
        'DSGastos
        '
        Me.DSGastos.DataSetName = "DSGastos"
        Me.DSGastos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GastorPorDataBindingSource
        '
        Me.GastorPorDataBindingSource.DataMember = "GastorPorData"
        Me.GastorPorDataBindingSource.DataSource = Me.DSGastos
        '
        'GastorPorDataTableAdapter
        '
        Me.GastorPorDataTableAdapter.ClearBeforeFill = True
        '
        'RelGastosFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(688, 603)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataFinal)
        Me.Controls.Add(Me.dataInicial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RelGastosFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Gastos"
        CType(Me.DSGastos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastorPorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dataFinal As DateTimePicker
    Friend WithEvents dataInicial As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GastorPorDataBindingSource As BindingSource
    Friend WithEvents DSGastos As DSGastos
    Friend WithEvents GastorPorDataTableAdapter As DSGastosTableAdapters.GastorPorDataTableAdapter
End Class
