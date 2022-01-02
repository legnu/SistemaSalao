<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RelClientesFrm
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
        Me.dataInicial = New System.Windows.Forms.DateTimePicker()
        Me.dataFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clientesPorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSClientes = New SistemaSalao.DSClientes()
        Me.clientesPorDataTableAdapter = New SistemaSalao.DSClientesTableAdapters.clientesPorDataTableAdapter()
        CType(Me.clientesPorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DSClientes"
        ReportDataSource1.Value = Me.clientesPorDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaSalao.RelClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 57)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(670, 503)
        Me.ReportViewer1.TabIndex = 0
        '
        'dataInicial
        '
        Me.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataInicial.Location = New System.Drawing.Point(355, 12)
        Me.dataInicial.Name = "dataInicial"
        Me.dataInicial.Size = New System.Drawing.Size(107, 20)
        Me.dataInicial.TabIndex = 1
        '
        'dataFinal
        '
        Me.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dataFinal.Location = New System.Drawing.Point(575, 12)
        Me.dataFinal.Name = "dataFinal"
        Me.dataFinal.Size = New System.Drawing.Size(107, 20)
        Me.dataFinal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(509, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data Final"
        '
        'clientesPorDataBindingSource
        '
        Me.clientesPorDataBindingSource.DataMember = "clientesPorData"
        Me.clientesPorDataBindingSource.DataSource = Me.DSClientes
        '
        'DSClientes
        '
        Me.DSClientes.DataSetName = "DSClientes"
        Me.DSClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clientesPorDataTableAdapter
        '
        Me.clientesPorDataTableAdapter.ClearBeforeFill = True
        '
        'RelClientesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(699, 572)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dataFinal)
        Me.Controls.Add(Me.dataInicial)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RelClientesFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Clientes"
        CType(Me.clientesPorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clientesPorDataBindingSource As BindingSource
    Friend WithEvents DSClientes As DSClientes
    Friend WithEvents clientesPorDataTableAdapter As DSClientesTableAdapters.clientesPorDataTableAdapter
    Friend WithEvents dataInicial As DateTimePicker
    Friend WithEvents dataFinal As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
