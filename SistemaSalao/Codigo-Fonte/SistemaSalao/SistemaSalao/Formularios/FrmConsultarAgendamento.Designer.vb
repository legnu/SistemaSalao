<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultarAgendamento
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultarAgendamento))
		Me.dataBuscar = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cbStatus = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.txtValor = New System.Windows.Forms.TextBox()
		Me.cbFuncionario = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dataBuscar
		'
		Me.dataBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dataBuscar.Location = New System.Drawing.Point(648, 12)
		Me.dataBuscar.Name = "dataBuscar"
		Me.dataBuscar.Size = New System.Drawing.Size(99, 20)
		Me.dataBuscar.TabIndex = 88
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(598, 12)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 87
		Me.Label4.Text = "Buscar:"
		'
		'cbStatus
		'
		Me.cbStatus.FormattingEnabled = True
		Me.cbStatus.Items.AddRange(New Object() {"Marcado", "Cancelado", "Concluído"})
		Me.cbStatus.Location = New System.Drawing.Point(456, 11)
		Me.cbStatus.Name = "cbStatus"
		Me.cbStatus.Size = New System.Drawing.Size(111, 21)
		Me.cbStatus.TabIndex = 85
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(410, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(40, 13)
		Me.Label1.TabIndex = 86
		Me.Label1.Text = "Status:"
		'
		'btnSalvar
		'
		Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
		Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnSalvar.Enabled = False
		Me.btnSalvar.FlatAppearance.BorderSize = 0
		Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
		Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
		Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
		Me.btnSalvar.Location = New System.Drawing.Point(682, 324)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
		Me.btnSalvar.TabIndex = 84
		Me.btnSalvar.UseVisualStyleBackColor = False
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.MintCream
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Location = New System.Drawing.Point(26, 71)
		Me.grid.Name = "grid"
		Me.grid.ReadOnly = True
		Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grid.Size = New System.Drawing.Size(721, 247)
		Me.grid.TabIndex = 83
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(22, 18)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
		Me.txtCodigo.TabIndex = 82
		Me.txtCodigo.Visible = False
		'
		'txtValor
		'
		Me.txtValor.Location = New System.Drawing.Point(110, 15)
		Me.txtValor.Name = "txtValor"
		Me.txtValor.Size = New System.Drawing.Size(56, 20)
		Me.txtValor.TabIndex = 89
		Me.txtValor.Visible = False
		'
		'cbFuncionario
		'
		Me.cbFuncionario.FormattingEnabled = True
		Me.cbFuncionario.Location = New System.Drawing.Point(264, 12)
		Me.cbFuncionario.Name = "cbFuncionario"
		Me.cbFuncionario.Size = New System.Drawing.Size(111, 21)
		Me.cbFuncionario.TabIndex = 93
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Location = New System.Drawing.Point(193, 16)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(65, 13)
		Me.Label2.TabIndex = 94
		Me.Label2.Text = "Funcionário:"
		'
		'FrmConsultarAgendamento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(776, 396)
		Me.Controls.Add(Me.cbFuncionario)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtValor)
		Me.Controls.Add(Me.dataBuscar)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.cbStatus)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnSalvar)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.txtCodigo)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FrmConsultarAgendamento"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Consultar Agendamentos"
		CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dataBuscar As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents Label2 As Label
End Class
