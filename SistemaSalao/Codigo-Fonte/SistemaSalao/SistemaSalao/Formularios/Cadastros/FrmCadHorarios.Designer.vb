<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadHorarios
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadHorarios))
		Me.btnExcluir = New System.Windows.Forms.Button()
		Me.BtnEditar = New System.Windows.Forms.Button()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.btnNovo = New System.Windows.Forms.Button()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.dtHora = New System.Windows.Forms.DateTimePicker()
		Me.btnReset = New System.Windows.Forms.Button()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnExcluir
		'
		Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
		Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnExcluir.FlatAppearance.BorderSize = 0
		Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
		Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
		Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
		Me.btnExcluir.Location = New System.Drawing.Point(241, 240)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(65, 65)
		Me.btnExcluir.TabIndex = 38
		Me.btnExcluir.UseVisualStyleBackColor = False
		'
		'BtnEditar
		'
		Me.BtnEditar.BackColor = System.Drawing.Color.Transparent
		Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.BtnEditar.Enabled = False
		Me.BtnEditar.FlatAppearance.BorderSize = 0
		Me.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
		Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
		Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
		Me.BtnEditar.Location = New System.Drawing.Point(170, 240)
		Me.BtnEditar.Name = "BtnEditar"
		Me.BtnEditar.Size = New System.Drawing.Size(65, 65)
		Me.BtnEditar.TabIndex = 37
		Me.BtnEditar.UseVisualStyleBackColor = False
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
		Me.btnSalvar.Location = New System.Drawing.Point(81, 240)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
		Me.btnSalvar.TabIndex = 36
		Me.btnSalvar.UseVisualStyleBackColor = False
		'
		'btnNovo
		'
		Me.btnNovo.BackColor = System.Drawing.Color.Transparent
		Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnNovo.FlatAppearance.BorderSize = 0
		Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
		Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
		Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
		Me.btnNovo.Location = New System.Drawing.Point(10, 235)
		Me.btnNovo.Name = "btnNovo"
		Me.btnNovo.Size = New System.Drawing.Size(65, 66)
		Me.btnNovo.TabIndex = 35
		Me.btnNovo.UseVisualStyleBackColor = False
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.MintCream
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Location = New System.Drawing.Point(12, 59)
		Me.grid.Name = "grid"
		Me.grid.ReadOnly = True
		Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grid.Size = New System.Drawing.Size(377, 175)
		Me.grid.TabIndex = 34
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(333, 12)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
		Me.txtCodigo.TabIndex = 33
		Me.txtCodigo.Visible = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Location = New System.Drawing.Point(7, 16)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(33, 13)
		Me.Label2.TabIndex = 32
		Me.Label2.Text = "Hora:"
		'
		'dtHora
		'
		Me.dtHora.CustomFormat = "13:00"
		Me.dtHora.Enabled = False
		Me.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtHora.Location = New System.Drawing.Point(46, 12)
		Me.dtHora.Name = "dtHora"
		Me.dtHora.ShowUpDown = True
		Me.dtHora.Size = New System.Drawing.Size(111, 20)
		Me.dtHora.TabIndex = 90
		'
		'btnReset
		'
		Me.btnReset.BackColor = System.Drawing.Color.Transparent
		Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnReset.FlatAppearance.BorderSize = 0
		Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
		Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
		Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
		Me.btnReset.Location = New System.Drawing.Point(324, 240)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(65, 65)
		Me.btnReset.TabIndex = 91
		Me.btnReset.UseVisualStyleBackColor = False
		'
		'FrmCadHorarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(401, 313)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.dtHora)
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.BtnEditar)
		Me.Controls.Add(Me.btnSalvar)
		Me.Controls.Add(Me.btnNovo)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.txtCodigo)
		Me.Controls.Add(Me.Label2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FrmCadHorarios"
		Me.RightToLeftLayout = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cadastro de Horários"
		CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnExcluir As Button
	Friend WithEvents BtnEditar As Button
	Friend WithEvents btnSalvar As Button
	Friend WithEvents btnNovo As Button
	Friend WithEvents grid As DataGridView
	Friend WithEvents txtCodigo As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents dtHora As DateTimePicker
	Friend WithEvents btnReset As Button
End Class
