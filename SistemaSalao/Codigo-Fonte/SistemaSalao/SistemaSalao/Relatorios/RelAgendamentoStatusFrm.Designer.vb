<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RelAgendamentoStatusFrm
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
        Me.agendamentosPorDataeStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAgendamentos = New SistemaSalao.DSAgendamentos()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataFinal = New System.Windows.Forms.DateTimePicker()
        Me.dataInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.agendamentosPorDataeStatusTableAdapter = New SistemaSalao.DSAgendamentosTableAdapters.agendamentosPorDataeStatusTableAdapter()
        CType(Me.agendamentosPorDataeStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAgendamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'agendamentosPorDataeStatusBindingSource
        '
        Me.agendamentosPorDataeStatusBindingSource.DataMember = "agendamentosPorDataeStatus"
        Me.agendamentosPorDataeStatusBindingSource.DataSource = Me.DSAgendamentos
        '
        'DSAgendamentos
        '
        Me.DSAgendamentos.DataSetName = "DSAgendamentos"
        Me.DSAgendamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(513, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Data Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Data Inicial"
        '
        'dataFinal
        '
        Me.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataFinal.Location = New System.Drawing.Point(579, 12)
        Me.dataFinal.Name = "dataFinal"
        Me.dataFinal.Size = New System.Drawing.Size(107, 20)
        Me.dataFinal.TabIndex = 10
        '
        'dataInicial
        '
        Me.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataInicial.Location = New System.Drawing.Point(359, 12)
        Me.dataInicial.Name = "dataInicial"
        Me.dataInicial.Size = New System.Drawing.Size(107, 20)
        Me.dataInicial.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Status"
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Concluído", "Marcado", "Cancelado"})
        Me.cbStatus.Location = New System.Drawing.Point(136, 13)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 14
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.agendamentosPorDataeStatusBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaSalao.RelAgendamentoStatus.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 68)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(674, 562)
        Me.ReportViewer1.TabIndex = 15
        '
        'agendamentosPorDataeStatusTableAdapter
        '
        Me.agendamentosPorDataeStatusTableAdapter.ClearBeforeFill = True
        '
        'RelAgendamentoStatusFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(699, 642)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataFinal)
        Me.Controls.Add(Me.dataInicial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RelAgendamentoStatusFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Agendamento por Status"
        CType(Me.agendamentosPorDataeStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAgendamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dataFinal As DateTimePicker
    Friend WithEvents dataInicial As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents agendamentosPorDataeStatusBindingSource As BindingSource
    Friend WithEvents DSAgendamentos As DSAgendamentos
    Friend WithEvents agendamentosPorDataeStatusTableAdapter As DSAgendamentosTableAdapters.agendamentosPorDataeStatusTableAdapter
End Class
