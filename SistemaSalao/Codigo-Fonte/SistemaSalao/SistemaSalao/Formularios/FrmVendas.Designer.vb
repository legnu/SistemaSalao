<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendas
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendas))
		Me.img = New System.Windows.Forms.PictureBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtValor = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnExcluir = New System.Windows.Forms.Button()
		Me.BtnEditar = New System.Windows.Forms.Button()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.btnNovo = New System.Windows.Forms.Button()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.txtQuantidade = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cbProduto = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnBuscarCliente = New System.Windows.Forms.Button()
		Me.txtCliente = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.dataBuscar = New System.Windows.Forms.DateTimePicker()
		Me.txtEstoque = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtTotal = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.lblTotalDia = New System.Windows.Forms.Label()
		CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'img
		'
		Me.img.BackColor = System.Drawing.Color.Honeydew
		Me.img.Location = New System.Drawing.Point(493, 65)
		Me.img.Name = "img"
		Me.img.Size = New System.Drawing.Size(120, 120)
		Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.img.TabIndex = 62
		Me.img.TabStop = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Location = New System.Drawing.Point(32, 117)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(42, 13)
		Me.Label7.TabIndex = 61
		Me.Label7.Text = "Cliente:"
		'
		'txtValor
		'
		Me.txtValor.Enabled = False
		Me.txtValor.Location = New System.Drawing.Point(96, 148)
		Me.txtValor.Name = "txtValor"
		Me.txtValor.Size = New System.Drawing.Size(131, 20)
		Me.txtValor.TabIndex = 51
		Me.txtValor.Text = "0"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Location = New System.Drawing.Point(34, 151)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(34, 13)
		Me.Label3.TabIndex = 60
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
		Me.btnExcluir.Location = New System.Drawing.Point(621, 376)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(65, 65)
		Me.btnExcluir.TabIndex = 59
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
		Me.BtnEditar.Location = New System.Drawing.Point(538, 376)
		Me.BtnEditar.Name = "BtnEditar"
		Me.BtnEditar.Size = New System.Drawing.Size(65, 65)
		Me.BtnEditar.TabIndex = 58
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
		Me.btnSalvar.Location = New System.Drawing.Point(458, 376)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
		Me.btnSalvar.TabIndex = 57
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
		Me.btnNovo.Location = New System.Drawing.Point(376, 376)
		Me.btnNovo.Name = "btnNovo"
		Me.btnNovo.Size = New System.Drawing.Size(65, 65)
		Me.btnNovo.TabIndex = 56
		Me.btnNovo.UseVisualStyleBackColor = False
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.MintCream
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Location = New System.Drawing.Point(28, 205)
		Me.grid.Name = "grid"
		Me.grid.ReadOnly = True
		Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grid.Size = New System.Drawing.Size(604, 141)
		Me.grid.TabIndex = 55
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(69, 25)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
		Me.txtCodigo.TabIndex = 54
		Me.txtCodigo.Visible = False
		'
		'txtQuantidade
		'
		Me.txtQuantidade.Enabled = False
		Me.txtQuantidade.Location = New System.Drawing.Point(338, 84)
		Me.txtQuantidade.Name = "txtQuantidade"
		Me.txtQuantidade.Size = New System.Drawing.Size(112, 20)
		Me.txtQuantidade.TabIndex = 50
		Me.txtQuantidade.Text = "0"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Location = New System.Drawing.Point(267, 88)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(65, 13)
		Me.Label2.TabIndex = 53
		Me.Label2.Text = "Quantidade:"
		'
		'cbProduto
		'
		Me.cbProduto.Enabled = False
		Me.cbProduto.FormattingEnabled = True
		Me.cbProduto.Location = New System.Drawing.Point(96, 82)
		Me.cbProduto.Name = "cbProduto"
		Me.cbProduto.Size = New System.Drawing.Size(131, 21)
		Me.cbProduto.TabIndex = 63
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(32, 85)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(47, 13)
		Me.Label1.TabIndex = 64
		Me.Label1.Text = "Produto:"
		'
		'btnBuscarCliente
		'
		Me.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent
		Me.btnBuscarCliente.Enabled = False
		Me.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
		Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscarCliente.Location = New System.Drawing.Point(198, 114)
		Me.btnBuscarCliente.Name = "btnBuscarCliente"
		Me.btnBuscarCliente.Size = New System.Drawing.Size(29, 21)
		Me.btnBuscarCliente.TabIndex = 65
		Me.btnBuscarCliente.Text = "Ir"
		Me.btnBuscarCliente.UseVisualStyleBackColor = False
		'
		'txtCliente
		'
		Me.txtCliente.Enabled = False
		Me.txtCliente.Location = New System.Drawing.Point(96, 115)
		Me.txtCliente.Name = "txtCliente"
		Me.txtCliente.Size = New System.Drawing.Size(96, 20)
		Me.txtCliente.TabIndex = 66
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(464, 9)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 67
		Me.Label4.Text = "Buscar:"
		'
		'dataBuscar
		'
		Me.dataBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dataBuscar.Location = New System.Drawing.Point(514, 9)
		Me.dataBuscar.Name = "dataBuscar"
		Me.dataBuscar.Size = New System.Drawing.Size(99, 20)
		Me.dataBuscar.TabIndex = 68
		'
		'txtEstoque
		'
		Me.txtEstoque.Enabled = False
		Me.txtEstoque.Location = New System.Drawing.Point(338, 117)
		Me.txtEstoque.Name = "txtEstoque"
		Me.txtEstoque.Size = New System.Drawing.Size(112, 20)
		Me.txtEstoque.TabIndex = 69
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Location = New System.Drawing.Point(280, 118)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(49, 13)
		Me.Label5.TabIndex = 70
		Me.Label5.Text = "Estoque:"
		'
		'txtTotal
		'
		Me.txtTotal.Enabled = False
		Me.txtTotal.Location = New System.Drawing.Point(338, 151)
		Me.txtTotal.Name = "txtTotal"
		Me.txtTotal.Size = New System.Drawing.Size(112, 20)
		Me.txtTotal.TabIndex = 71
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Location = New System.Drawing.Point(295, 154)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(34, 13)
		Me.Label6.TabIndex = 72
		Me.Label6.Text = "Total:"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Location = New System.Drawing.Point(525, 357)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(53, 13)
		Me.Label8.TabIndex = 73
		Me.Label8.Text = "Total Dia:"
		'
		'lblTotalDia
		'
		Me.lblTotalDia.AutoSize = True
		Me.lblTotalDia.BackColor = System.Drawing.Color.Transparent
		Me.lblTotalDia.Location = New System.Drawing.Point(582, 357)
		Me.lblTotalDia.Name = "lblTotalDia"
		Me.lblTotalDia.Size = New System.Drawing.Size(10, 13)
		Me.lblTotalDia.TabIndex = 74
		Me.lblTotalDia.Text = "-"
		'
		'FrmVendas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(698, 453)
		Me.Controls.Add(Me.lblTotalDia)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.txtTotal)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtEstoque)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.dataBuscar)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtCliente)
		Me.Controls.Add(Me.btnBuscarCliente)
		Me.Controls.Add(Me.cbProduto)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.img)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtValor)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.BtnEditar)
		Me.Controls.Add(Me.btnSalvar)
		Me.Controls.Add(Me.btnNovo)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.txtCodigo)
		Me.Controls.Add(Me.txtQuantidade)
		Me.Controls.Add(Me.Label2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FrmVendas"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Vendas"
		CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents img As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbProduto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dataBuscar As DateTimePicker
    Friend WithEvents txtEstoque As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalDia As Label
End Class
