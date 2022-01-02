<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGastos
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGastos))
		Me.txtDescricao = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.dataBuscar = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtValor = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnExcluir = New System.Windows.Forms.Button()
		Me.BtnEditar = New System.Windows.Forms.Button()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.btnNovo = New System.Windows.Forms.Button()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtDescricao
		'
		Me.txtDescricao.Enabled = False
		Me.txtDescricao.Location = New System.Drawing.Point(293, 71)
		Me.txtDescricao.Multiline = True
		Me.txtDescricao.Name = "txtDescricao"
		Me.txtDescricao.Size = New System.Drawing.Size(433, 49)
		Me.txtDescricao.TabIndex = 81
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Location = New System.Drawing.Point(229, 74)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(58, 13)
		Me.Label5.TabIndex = 82
		Me.Label5.Text = "Descrição:"
		'
		'dataBuscar
		'
		Me.dataBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dataBuscar.Location = New System.Drawing.Point(627, 13)
		Me.dataBuscar.Name = "dataBuscar"
		Me.dataBuscar.Size = New System.Drawing.Size(99, 20)
		Me.dataBuscar.TabIndex = 80
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(577, 13)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 79
		Me.Label4.Text = "Buscar:"
		'
		'txtValor
		'
		Me.txtValor.Enabled = False
		Me.txtValor.Location = New System.Drawing.Point(74, 71)
		Me.txtValor.Name = "txtValor"
		Me.txtValor.Size = New System.Drawing.Size(109, 20)
		Me.txtValor.TabIndex = 71
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Location = New System.Drawing.Point(34, 71)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(34, 13)
		Me.Label3.TabIndex = 78
		Me.Label3.Text = "Valor:"
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
		Me.btnExcluir.Location = New System.Drawing.Point(661, 336)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(65, 65)
		Me.btnExcluir.TabIndex = 77
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
		Me.BtnEditar.Location = New System.Drawing.Point(578, 336)
		Me.BtnEditar.Name = "BtnEditar"
		Me.BtnEditar.Size = New System.Drawing.Size(65, 65)
		Me.BtnEditar.TabIndex = 76
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
		Me.btnSalvar.Location = New System.Drawing.Point(498, 336)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
		Me.btnSalvar.TabIndex = 75
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
		Me.btnNovo.Location = New System.Drawing.Point(416, 336)
		Me.btnNovo.Name = "btnNovo"
		Me.btnNovo.Size = New System.Drawing.Size(65, 65)
		Me.btnNovo.TabIndex = 74
		Me.btnNovo.UseVisualStyleBackColor = False
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.MintCream
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Location = New System.Drawing.Point(28, 147)
		Me.grid.Name = "grid"
		Me.grid.ReadOnly = True
		Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grid.Size = New System.Drawing.Size(698, 173)
		Me.grid.TabIndex = 73
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(84, 13)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
		Me.txtCodigo.TabIndex = 72
		Me.txtCodigo.Visible = False
		'
		'FrmGastos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(750, 402)
		Me.Controls.Add(Me.txtDescricao)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.dataBuscar)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtValor)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.BtnEditar)
		Me.Controls.Add(Me.btnSalvar)
		Me.Controls.Add(Me.btnNovo)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.txtCodigo)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FrmGastos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Gastos"
		CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dataBuscar As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtCodigo As TextBox
End Class
