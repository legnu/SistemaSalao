<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadFornecedores
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadFornecedores))
		Me.btnExcluir = New System.Windows.Forms.Button()
		Me.BtnEditar = New System.Windows.Forms.Button()
		Me.btnSalvar = New System.Windows.Forms.Button()
		Me.btnNovo = New System.Windows.Forms.Button()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtEndereco = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtNome = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtBuscarNome = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtProduto = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
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
		Me.btnExcluir.Location = New System.Drawing.Point(656, 339)
		Me.btnExcluir.Name = "btnExcluir"
		Me.btnExcluir.Size = New System.Drawing.Size(65, 65)
		Me.btnExcluir.TabIndex = 41
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
		Me.BtnEditar.Location = New System.Drawing.Point(585, 339)
		Me.BtnEditar.Name = "BtnEditar"
		Me.BtnEditar.Size = New System.Drawing.Size(65, 65)
		Me.BtnEditar.TabIndex = 40
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
		Me.btnSalvar.Location = New System.Drawing.Point(515, 339)
		Me.btnSalvar.Name = "btnSalvar"
		Me.btnSalvar.Size = New System.Drawing.Size(65, 65)
		Me.btnSalvar.TabIndex = 39
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
		Me.btnNovo.Location = New System.Drawing.Point(444, 339)
		Me.btnNovo.Name = "btnNovo"
		Me.btnNovo.Size = New System.Drawing.Size(65, 65)
		Me.btnNovo.TabIndex = 38
		Me.btnNovo.UseVisualStyleBackColor = False
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.MintCream
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Location = New System.Drawing.Point(26, 161)
		Me.grid.Name = "grid"
		Me.grid.ReadOnly = True
		Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grid.Size = New System.Drawing.Size(695, 161)
		Me.grid.TabIndex = 37
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(67, 20)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
		Me.txtCodigo.TabIndex = 36
		Me.txtCodigo.Visible = False
		'
		'txtTelefone
		'
		Me.txtTelefone.Enabled = False
		Me.txtTelefone.Location = New System.Drawing.Point(515, 71)
		Me.txtTelefone.Mask = "(00)00000-0000"
		Me.txtTelefone.Name = "txtTelefone"
		Me.txtTelefone.Size = New System.Drawing.Size(103, 20)
		Me.txtTelefone.TabIndex = 27
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Location = New System.Drawing.Point(457, 74)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(52, 13)
		Me.Label5.TabIndex = 35
		Me.Label5.Text = "Telefone:"
		'
		'txtEndereco
		'
		Me.txtEndereco.Enabled = False
		Me.txtEndereco.Location = New System.Drawing.Point(280, 71)
		Me.txtEndereco.Name = "txtEndereco"
		Me.txtEndereco.Size = New System.Drawing.Size(135, 20)
		Me.txtEndereco.TabIndex = 26
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(218, 74)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(56, 13)
		Me.Label4.TabIndex = 34
		Me.Label4.Text = "Endereço:"
		'
		'txtNome
		'
		Me.txtNome.Enabled = False
		Me.txtNome.Location = New System.Drawing.Point(67, 71)
		Me.txtNome.Name = "txtNome"
		Me.txtNome.Size = New System.Drawing.Size(112, 20)
		Me.txtNome.TabIndex = 24
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Location = New System.Drawing.Point(23, 74)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(38, 13)
		Me.Label2.TabIndex = 32
		Me.Label2.Text = "Nome:"
		'
		'txtBuscarNome
		'
		Me.txtBuscarNome.Location = New System.Drawing.Point(609, 20)
		Me.txtBuscarNome.Name = "txtBuscarNome"
		Me.txtBuscarNome.Size = New System.Drawing.Size(112, 20)
		Me.txtBuscarNome.TabIndex = 29
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(555, 23)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(38, 13)
		Me.Label1.TabIndex = 42
		Me.Label1.Text = "Nome:"
		'
		'txtEmail
		'
		Me.txtEmail.Enabled = False
		Me.txtEmail.Location = New System.Drawing.Point(67, 110)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(112, 20)
		Me.txtEmail.TabIndex = 43
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Location = New System.Drawing.Point(23, 113)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(35, 13)
		Me.Label3.TabIndex = 44
		Me.Label3.Text = "Email:"
		'
		'txtProduto
		'
		Me.txtProduto.Enabled = False
		Me.txtProduto.Location = New System.Drawing.Point(280, 113)
		Me.txtProduto.Name = "txtProduto"
		Me.txtProduto.Size = New System.Drawing.Size(135, 20)
		Me.txtProduto.TabIndex = 45
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Location = New System.Drawing.Point(218, 116)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(44, 13)
		Me.Label6.TabIndex = 46
		Me.Label6.Text = "Produto"
		'
		'FrmCadFornecedores
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(749, 416)
		Me.Controls.Add(Me.txtProduto)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnExcluir)
		Me.Controls.Add(Me.BtnEditar)
		Me.Controls.Add(Me.btnSalvar)
		Me.Controls.Add(Me.btnNovo)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.txtCodigo)
		Me.Controls.Add(Me.txtTelefone)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtEndereco)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtNome)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtBuscarNome)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FrmCadFornecedores"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Cadastro de Forncedores"
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
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscarNome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents Label6 As Label
End Class
