<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgendamento
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendamento))
		Me.dataBuscar = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtCliente = New System.Windows.Forms.TextBox()
		Me.btnBuscarCliente = New System.Windows.Forms.Button()
		Me.cbFuncionario = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.btnExcluir = New System.Windows.Forms.Button()
		Me.BtnEditar = New System.Windows.Forms.Button()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.btnNovo = New System.Windows.Forms.Button()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.cbServico = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtValor = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.dtData = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.dtHora = New System.Windows.Forms.DateTimePicker()
		Me.Label6 = New System.Windows.Forms.Label()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dataBuscar
		'
		Me.dataBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dataBuscar.Location = New System.Drawing.Point(581, 12)
		Me.dataBuscar.Name = "dataBuscar"
		Me.dataBuscar.Size = New System.Drawing.Size(99, 20)
		Me.dataBuscar.TabIndex = 81
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(531, 12)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 80
		Me.Label4.Text = "Buscar:"
		'
		'txtCliente
		'
		Me.txtCliente.Enabled = False
		Me.txtCliente.Location = New System.Drawing.Point(344, 54)
		Me.txtCliente.Name = "txtCliente"
		Me.txtCliente.Size = New System.Drawing.Size(96, 20)
		Me.txtCliente.TabIndex = 79
		'
		'btnBuscarCliente
		'
		Me.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent
		Me.btnBuscarCliente.Enabled = False
		Me.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
		Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscarCliente.Location = New System.Drawing.Point(446, 53)
		Me.btnBuscarCliente.Name = "btnBuscarCliente"
		Me.btnBuscarCliente.Size = New System.Drawing.Size(29, 21)
		Me.btnBuscarCliente.TabIndex = 78
		Me.btnBuscarCliente.Text = "Ir"
		Me.btnBuscarCliente.UseVisualStyleBackColor = False
		'
		'cbFuncionario
		'
		Me.cbFuncionario.Enabled = False
		Me.cbFuncionario.FormattingEnabled = True
		Me.cbFuncionario.Location = New System.Drawing.Point(151, 54)
		Me.cbFuncionario.Name = "cbFuncionario"
		Me.cbFuncionario.Size = New System.Drawing.Size(111, 21)
		Me.cbFuncionario.TabIndex = 76
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(80, 57)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(65, 13)
		Me.Label1.TabIndex = 77
		Me.Label1.Text = "Funcionário:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Location = New System.Drawing.Point(296, 57)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(42, 13)
		Me.Label7.TabIndex = 75
		Me.Label7.Text = "Cliente:"
		'
		'btnExcluir
		'
		Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
		Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnExcluir.Enabled = False
		Me.btnExcluir.FlatAppearance.BorderSize = 0
		Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
		Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew
		Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
		Me.btnExcluir.Location = New System.Drawing.Point(654, 324)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(65, 65)
		Me.btnExcluir.TabIndex = 74
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
		Me.BtnEditar.Location = New System.Drawing.Point(571, 324)
		Me.BtnEditar.Name = "BtnEditar"
		Me.BtnEditar.Size = New System.Drawing.Size(65, 65)
		Me.BtnEditar.TabIndex = 73
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
		Me.btnSalvar.Location = New System.Drawing.Point(491, 324)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
		Me.btnSalvar.TabIndex = 72
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
		Me.btnNovo.Location = New System.Drawing.Point(409, 324)
		Me.btnNovo.Name = "btnNovo"
		Me.btnNovo.Size = New System.Drawing.Size(65, 65)
		Me.btnNovo.TabIndex = 71
		Me.btnNovo.UseVisualStyleBackColor = False
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.MintCream
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Location = New System.Drawing.Point(27, 136)
		Me.grid.Name = "grid"
		Me.grid.ReadOnly = True
		Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grid.Size = New System.Drawing.Size(692, 182)
		Me.grid.TabIndex = 70
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(101, 12)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
		Me.txtCodigo.TabIndex = 69
		Me.txtCodigo.Visible = False
		'
		'cbServico
		'
		Me.cbServico.Enabled = False
		Me.cbServico.FormattingEnabled = True
		Me.cbServico.Location = New System.Drawing.Point(569, 56)
		Me.cbServico.Name = "cbServico"
		Me.cbServico.Size = New System.Drawing.Size(111, 21)
		Me.cbServico.TabIndex = 82
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Location = New System.Drawing.Point(517, 60)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(46, 13)
		Me.Label2.TabIndex = 83
		Me.Label2.Text = "Serviço:"
		'
		'txtValor
		'
		Me.txtValor.Enabled = False
		Me.txtValor.Location = New System.Drawing.Point(151, 91)
		Me.txtValor.Name = "txtValor"
		Me.txtValor.Size = New System.Drawing.Size(111, 20)
		Me.txtValor.TabIndex = 84
		Me.txtValor.Text = "0"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Location = New System.Drawing.Point(89, 94)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(34, 13)
		Me.Label3.TabIndex = 85
		Me.Label3.Text = "Valor:"
		'
		'dtData
		'
		Me.dtData.Enabled = False
		Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtData.Location = New System.Drawing.Point(344, 94)
		Me.dtData.Name = "dtData"
		Me.dtData.Size = New System.Drawing.Size(99, 20)
		Me.dtData.TabIndex = 87
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Location = New System.Drawing.Point(294, 94)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(33, 13)
		Me.Label5.TabIndex = 86
		Me.Label5.Text = "Data:"
		'
		'dtHora
		'
		Me.dtHora.CustomFormat = "13:00"
		Me.dtHora.Enabled = False
		Me.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtHora.Location = New System.Drawing.Point(569, 94)
		Me.dtHora.Name = "dtHora"
		Me.dtHora.ShowUpDown = True
		Me.dtHora.Size = New System.Drawing.Size(111, 20)
		Me.dtHora.TabIndex = 89
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Location = New System.Drawing.Point(519, 94)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(33, 13)
		Me.Label6.TabIndex = 88
		Me.Label6.Text = "Hora:"
		'
		'FrmAgendamento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(750, 399)
		Me.Controls.Add(Me.dtHora)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.dtData)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtValor)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.cbServico)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.dataBuscar)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtCliente)
		Me.Controls.Add(Me.btnBuscarCliente)
		Me.Controls.Add(Me.cbFuncionario)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.BtnEditar)
		Me.Controls.Add(Me.btnSalvar)
		Me.Controls.Add(Me.btnNovo)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.txtCodigo)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FrmAgendamento"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Agendamentos"
		CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dataBuscar As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents cbServico As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtHora As DateTimePicker
    Friend WithEvents Label6 As Label
End Class
