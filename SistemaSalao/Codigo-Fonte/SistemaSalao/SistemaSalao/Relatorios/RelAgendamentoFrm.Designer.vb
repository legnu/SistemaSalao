<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelAgendamentoFrm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataFinal = New System.Windows.Forms.DateTimePicker()
        Me.dataInicial = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSAgendamentos = New SistemaSalao.DSAgendamentos()
        Me.agendamentosPorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.agendamentosPorDataTableAdapter = New SistemaSalao.DSAgendamentosTableAdapters.agendamentosPorDataTableAdapter()
        CType(Me.DSAgendamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.agendamentosPorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(503, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Data Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Data Inicial"
        '
        'dataFinal
        '
        Me.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataFinal.Location = New System.Drawing.Point(569, 12)
        Me.dataFinal.Name = "dataFinal"
        Me.dataFinal.Size = New System.Drawing.Size(107, 20)
        Me.dataFinal.TabIndex = 6
        '
        'dataInicial
        '
        Me.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataInicial.Location = New System.Drawing.Point(349, 12)
        Me.dataInicial.Name = "dataInicial"
        Me.dataInicial.Size = New System.Drawing.Size(107, 20)
        Me.dataInicial.TabIndex = 5
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DSAgendamentos"
        ReportDataSource1.Value = Me.agendamentosPorDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaSalao.RelAgendamento.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 66)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(663, 531)
        Me.ReportViewer1.TabIndex = 9
        '
        'DSAgendamentos
        '
        Me.DSAgendamentos.DataSetName = "DSAgendamentos"
        Me.DSAgendamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'agendamentosPorDataBindingSource
        '
        Me.agendamentosPorDataBindingSource.DataMember = "agendamentosPorData"
        Me.agendamentosPorDataBindingSource.DataSource = Me.DSAgendamentos
        '
        'agendamentosPorDataTableAdapter
        '
        Me.agendamentosPorDataTableAdapter.ClearBeforeFill = True
        '
        'RelAgendamentoFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(699, 609)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataFinal)
        Me.Controls.Add(Me.dataInicial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RelAgendamentoFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Agendamento"
        CType(Me.DSAgendamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.agendamentosPorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dataFinal As DateTimePicker
    Friend WithEvents dataInicial As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents agendamentosPorDataBindingSource As BindingSource
    Friend WithEvents DSAgendamentos As DSAgendamentos
    Friend WithEvents agendamentosPorDataTableAdapter As DSAgendamentosTableAdapters.agendamentosPorDataTableAdapter
End Class
