<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTelaPrincipal
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTelaPrincipal))
		Me.menuPrincipal = New System.Windows.Forms.MenuStrip()
		Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuFunc = New System.Windows.Forms.ToolStripMenuItem()
		Me.ServiçosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.EspecialidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuProdutos = New System.Windows.Forms.ToolStripMenuItem()
		Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgendamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.QuadroDeHoráriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CadastroDeHoráriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ConsultaDosAgendamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ConsultaPorClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MovimentaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NovaVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.menuPagamentos = New System.Windows.Forms.ToolStripMenuItem()
		Me.EntradasESaidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProdutosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.GastosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgendamentoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgendamentoPorStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.lblUsuario = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblEsp = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblData = New System.Windows.Forms.Label()
		Me.lblHora = New System.Windows.Forms.Label()
		Me.TimerData = New System.Windows.Forms.Timer(Me.components)
		Me.lblTotalSaidas = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblTotEntradas = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblTotalDia = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.gridServicos = New System.Windows.Forms.DataGridView()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.lblAgConcluido = New System.Windows.Forms.Label()
		Me.lblAgCancelado = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.lblAgMarcado = New System.Windows.Forms.Label()
		Me.btnAddCliente = New System.Windows.Forms.Button()
		Me.btnAgendamento = New System.Windows.Forms.Button()
		Me.btnHorarios = New System.Windows.Forms.Button()
		Me.btnVenda = New System.Windows.Forms.Button()
		Me.menuPrincipal.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.gridServicos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'menuPrincipal
		'
		Me.menuPrincipal.BackColor = System.Drawing.Color.Transparent
		Me.menuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.MovimentaçõesToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.AjudaToolStripMenuItem, Me.SairToolStripMenuItem})
		Me.menuPrincipal.Location = New System.Drawing.Point(0, 0)
		Me.menuPrincipal.Name = "menuPrincipal"
		Me.menuPrincipal.Size = New System.Drawing.Size(1052, 24)
		Me.menuPrincipal.TabIndex = 0
		Me.menuPrincipal.Text = "MenuStrip1"
		'
		'CadastrosToolStripMenuItem
		'
		Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.menuFunc, Me.ServiçosToolStripMenuItem1, Me.EspecialidadeToolStripMenuItem})
		Me.CadastrosToolStripMenuItem.Image = CType(resources.GetObject("CadastrosToolStripMenuItem.Image"), System.Drawing.Image)
		Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
		Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
		Me.CadastrosToolStripMenuItem.Text = "Cadastros"
		'
		'ClientesToolStripMenuItem
		'
		Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
		Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
		Me.ClientesToolStripMenuItem.Text = "Clientes"
		'
		'FornecedoresToolStripMenuItem
		'
		Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
		Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
		Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
		'
		'menuFunc
		'
		Me.menuFunc.Enabled = False
		Me.menuFunc.Name = "menuFunc"
		Me.menuFunc.Size = New System.Drawing.Size(145, 22)
		Me.menuFunc.Text = "Funcionários"
		'
		'ServiçosToolStripMenuItem1
		'
		Me.ServiçosToolStripMenuItem1.Name = "ServiçosToolStripMenuItem1"
		Me.ServiçosToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
		Me.ServiçosToolStripMenuItem1.Text = "Serviços"
		'
		'EspecialidadeToolStripMenuItem
		'
		Me.EspecialidadeToolStripMenuItem.Name = "EspecialidadeToolStripMenuItem"
		Me.EspecialidadeToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
		Me.EspecialidadeToolStripMenuItem.Text = "Especialidade"
		'
		'ProdutosToolStripMenuItem
		'
		Me.ProdutosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuProdutos})
		Me.ProdutosToolStripMenuItem.Image = CType(resources.GetObject("ProdutosToolStripMenuItem.Image"), System.Drawing.Image)
		Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
		Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
		Me.ProdutosToolStripMenuItem.Text = "Produtos"
		'
		'menuProdutos
		'
		Me.menuProdutos.Enabled = False
		Me.menuProdutos.Name = "menuProdutos"
		Me.menuProdutos.Size = New System.Drawing.Size(188, 22)
		Me.menuProdutos.Text = "Cadastro de Produtos"
		'
		'ServiçosToolStripMenuItem
		'
		Me.ServiçosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgendamentoToolStripMenuItem, Me.QuadroDeHoráriosToolStripMenuItem, Me.CadastroDeHoráriosToolStripMenuItem, Me.ConsultaDosAgendamentosToolStripMenuItem, Me.ConsultaPorClientesToolStripMenuItem})
		Me.ServiçosToolStripMenuItem.Image = CType(resources.GetObject("ServiçosToolStripMenuItem.Image"), System.Drawing.Image)
		Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
		Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
		Me.ServiçosToolStripMenuItem.Text = "Serviços"
		'
		'AgendamentoToolStripMenuItem
		'
		Me.AgendamentoToolStripMenuItem.Name = "AgendamentoToolStripMenuItem"
		Me.AgendamentoToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
		Me.AgendamentoToolStripMenuItem.Text = "Agendamento"
		'
		'QuadroDeHoráriosToolStripMenuItem
		'
		Me.QuadroDeHoráriosToolStripMenuItem.Name = "QuadroDeHoráriosToolStripMenuItem"
		Me.QuadroDeHoráriosToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
		Me.QuadroDeHoráriosToolStripMenuItem.Text = "Quadro de Horários"
		'
		'CadastroDeHoráriosToolStripMenuItem
		'
		Me.CadastroDeHoráriosToolStripMenuItem.Name = "CadastroDeHoráriosToolStripMenuItem"
		Me.CadastroDeHoráriosToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
		Me.CadastroDeHoráriosToolStripMenuItem.Text = "Cadastro de Horários"
		'
		'ConsultaDosAgendamentosToolStripMenuItem
		'
		Me.ConsultaDosAgendamentosToolStripMenuItem.Name = "ConsultaDosAgendamentosToolStripMenuItem"
		Me.ConsultaDosAgendamentosToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
		Me.ConsultaDosAgendamentosToolStripMenuItem.Text = "Consulta dos Agendamentos"
		'
		'ConsultaPorClientesToolStripMenuItem
		'
		Me.ConsultaPorClientesToolStripMenuItem.Name = "ConsultaPorClientesToolStripMenuItem"
		Me.ConsultaPorClientesToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
		Me.ConsultaPorClientesToolStripMenuItem.Text = "Consulta por Clientes"
		'
		'MovimentaçõesToolStripMenuItem
		'
		Me.MovimentaçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaVendaToolStripMenuItem, Me.GastosToolStripMenuItem, Me.menuPagamentos, Me.EntradasESaidasToolStripMenuItem})
		Me.MovimentaçõesToolStripMenuItem.Image = CType(resources.GetObject("MovimentaçõesToolStripMenuItem.Image"), System.Drawing.Image)
		Me.MovimentaçõesToolStripMenuItem.Name = "MovimentaçõesToolStripMenuItem"
		Me.MovimentaçõesToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
		Me.MovimentaçõesToolStripMenuItem.Text = "Movimentações"
		'
		'NovaVendaToolStripMenuItem
		'
		Me.NovaVendaToolStripMenuItem.Name = "NovaVendaToolStripMenuItem"
		Me.NovaVendaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
		Me.NovaVendaToolStripMenuItem.Text = "Nova Venda"
		'
		'GastosToolStripMenuItem
		'
		Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
		Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
		Me.GastosToolStripMenuItem.Text = "Gastos"
		'
		'menuPagamentos
		'
		Me.menuPagamentos.Enabled = False
		Me.menuPagamentos.Name = "menuPagamentos"
		Me.menuPagamentos.Size = New System.Drawing.Size(164, 22)
		Me.menuPagamentos.Text = "Pagamentos"
		'
		'EntradasESaidasToolStripMenuItem
		'
		Me.EntradasESaidasToolStripMenuItem.Name = "EntradasESaidasToolStripMenuItem"
		Me.EntradasESaidasToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
		Me.EntradasESaidasToolStripMenuItem.Text = "Entradas e Saidas"
		'
		'RelatóriosToolStripMenuItem
		'
		Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem1, Me.ClientesToolStripMenuItem1, Me.GastosToolStripMenuItem1, Me.VendasToolStripMenuItem, Me.AgendamentoToolStripMenuItem1, Me.AgendamentoPorStatusToolStripMenuItem})
		Me.RelatóriosToolStripMenuItem.Image = CType(resources.GetObject("RelatóriosToolStripMenuItem.Image"), System.Drawing.Image)
		Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
		Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
		Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
		'
		'ProdutosToolStripMenuItem1
		'
		Me.ProdutosToolStripMenuItem1.Name = "ProdutosToolStripMenuItem1"
		Me.ProdutosToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
		Me.ProdutosToolStripMenuItem1.Text = "Produtos"
		'
		'ClientesToolStripMenuItem1
		'
		Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
		Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
		Me.ClientesToolStripMenuItem1.Text = "Clientes"
		'
		'GastosToolStripMenuItem1
		'
		Me.GastosToolStripMenuItem1.Name = "GastosToolStripMenuItem1"
		Me.GastosToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
		Me.GastosToolStripMenuItem1.Text = "Gastos"
		'
		'VendasToolStripMenuItem
		'
		Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
		Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
		Me.VendasToolStripMenuItem.Text = "Vendas"
		'
		'AgendamentoToolStripMenuItem1
		'
		Me.AgendamentoToolStripMenuItem1.Name = "AgendamentoToolStripMenuItem1"
		Me.AgendamentoToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
		Me.AgendamentoToolStripMenuItem1.Text = "Agendamento"
		'
		'AgendamentoPorStatusToolStripMenuItem
		'
		Me.AgendamentoPorStatusToolStripMenuItem.Name = "AgendamentoPorStatusToolStripMenuItem"
		Me.AgendamentoPorStatusToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
		Me.AgendamentoPorStatusToolStripMenuItem.Text = "Agendamento Por Status"
		'
		'AjudaToolStripMenuItem
		'
		Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
		Me.AjudaToolStripMenuItem.Image = CType(resources.GetObject("AjudaToolStripMenuItem.Image"), System.Drawing.Image)
		Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
		Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
		Me.AjudaToolStripMenuItem.Text = "Ajuda"
		'
		'SobreToolStripMenuItem
		'
		Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
		Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
		Me.SobreToolStripMenuItem.Text = "Sobre"
		'
		'SairToolStripMenuItem
		'
		Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
		Me.SairToolStripMenuItem.Image = CType(resources.GetObject("SairToolStripMenuItem.Image"), System.Drawing.Image)
		Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
		Me.SairToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
		Me.SairToolStripMenuItem.Text = "Sair"
		'
		'LogoutToolStripMenuItem
		'
		Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
		Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
		Me.LogoutToolStripMenuItem.Text = "Logout"
		'
		'lblUsuario
		'
		Me.lblUsuario.AutoSize = True
		Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
		Me.lblUsuario.Location = New System.Drawing.Point(50, 27)
		Me.lblUsuario.Name = "lblUsuario"
		Me.lblUsuario.Size = New System.Drawing.Size(39, 13)
		Me.lblUsuario.TabIndex = 6
		Me.lblUsuario.Text = "Label1"
		'
		'GroupBox1
		'
		Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.lblEsp)
		Me.GroupBox1.Controls.Add(Me.lblUsuario)
		Me.GroupBox1.Location = New System.Drawing.Point(839, 26)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(158, 79)
		Me.GroupBox1.TabIndex = 7
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Dados do Funcionário"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Location = New System.Drawing.Point(6, 52)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(46, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Função:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(6, 27)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(46, 13)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "Usuário:"
		'
		'lblEsp
		'
		Me.lblEsp.AutoSize = True
		Me.lblEsp.BackColor = System.Drawing.Color.Transparent
		Me.lblEsp.Location = New System.Drawing.Point(50, 52)
		Me.lblEsp.Name = "lblEsp"
		Me.lblEsp.Size = New System.Drawing.Size(39, 13)
		Me.lblEsp.TabIndex = 7
		Me.lblEsp.Text = "Label1"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Location = New System.Drawing.Point(721, 113)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(33, 13)
		Me.Label3.TabIndex = 10
		Me.Label3.Text = "Data:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(836, 113)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(33, 13)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Hora:"
		'
		'lblData
		'
		Me.lblData.AutoSize = True
		Me.lblData.BackColor = System.Drawing.Color.Transparent
		Me.lblData.Location = New System.Drawing.Point(754, 113)
		Me.lblData.Name = "lblData"
		Me.lblData.Size = New System.Drawing.Size(15, 13)
		Me.lblData.TabIndex = 12
		Me.lblData.Text = "D"
		'
		'lblHora
		'
		Me.lblHora.AutoSize = True
		Me.lblHora.BackColor = System.Drawing.Color.Transparent
		Me.lblHora.Location = New System.Drawing.Point(872, 113)
		Me.lblHora.Name = "lblHora"
		Me.lblHora.Size = New System.Drawing.Size(15, 13)
		Me.lblHora.TabIndex = 13
		Me.lblHora.Text = "H"
		'
		'TimerData
		'
		Me.TimerData.Enabled = True
		'
		'lblTotalSaidas
		'
		Me.lblTotalSaidas.AutoSize = True
		Me.lblTotalSaidas.BackColor = System.Drawing.Color.Transparent
		Me.lblTotalSaidas.ForeColor = System.Drawing.Color.Red
		Me.lblTotalSaidas.Location = New System.Drawing.Point(87, 47)
		Me.lblTotalSaidas.Name = "lblTotalSaidas"
		Me.lblTotalSaidas.Size = New System.Drawing.Size(10, 13)
		Me.lblTotalSaidas.TabIndex = 93
		Me.lblTotalSaidas.Text = "-"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Location = New System.Drawing.Point(16, 47)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(71, 13)
		Me.Label5.TabIndex = 92
		Me.Label5.Text = "Total Saídas:"
		'
		'lblTotEntradas
		'
		Me.lblTotEntradas.AutoSize = True
		Me.lblTotEntradas.BackColor = System.Drawing.Color.Transparent
		Me.lblTotEntradas.ForeColor = System.Drawing.Color.DarkGreen
		Me.lblTotEntradas.Location = New System.Drawing.Point(94, 25)
		Me.lblTotEntradas.Name = "lblTotEntradas"
		Me.lblTotEntradas.Size = New System.Drawing.Size(10, 13)
		Me.lblTotEntradas.TabIndex = 91
		Me.lblTotEntradas.Text = "-"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Location = New System.Drawing.Point(16, 25)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(79, 13)
		Me.Label6.TabIndex = 90
		Me.Label6.Text = "Total Entradas:"
		'
		'lblTotalDia
		'
		Me.lblTotalDia.AutoSize = True
		Me.lblTotalDia.BackColor = System.Drawing.Color.Transparent
		Me.lblTotalDia.Location = New System.Drawing.Point(94, 73)
		Me.lblTotalDia.Name = "lblTotalDia"
		Me.lblTotalDia.Size = New System.Drawing.Size(10, 13)
		Me.lblTotalDia.TabIndex = 89
		Me.lblTotalDia.Text = "-"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Location = New System.Drawing.Point(19, 73)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(71, 13)
		Me.Label8.TabIndex = 88
		Me.Label8.Text = "Saldo do Dia:"
		'
		'GroupBox2
		'
		Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.lblTotalSaidas)
		Me.GroupBox2.Controls.Add(Me.lblTotalDia)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.lblTotEntradas)
		Me.GroupBox2.Location = New System.Drawing.Point(818, 158)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(179, 100)
		Me.GroupBox2.TabIndex = 94
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Saldo do Dia"
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.MintCream
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Location = New System.Drawing.Point(12, 132)
		Me.grid.Name = "grid"
		Me.grid.ReadOnly = True
		Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grid.Size = New System.Drawing.Size(304, 152)
		Me.grid.TabIndex = 95
		Me.grid.Visible = False
		'
		'gridServicos
		'
		Me.gridServicos.AllowUserToAddRows = False
		Me.gridServicos.AllowUserToDeleteRows = False
		Me.gridServicos.BackgroundColor = System.Drawing.Color.MintCream
		Me.gridServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gridServicos.Location = New System.Drawing.Point(322, 132)
		Me.gridServicos.Name = "gridServicos"
		Me.gridServicos.ReadOnly = True
		Me.gridServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.gridServicos.Size = New System.Drawing.Size(304, 152)
		Me.gridServicos.TabIndex = 96
		Me.gridServicos.Visible = False
		'
		'GroupBox3
		'
		Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
		Me.GroupBox3.Controls.Add(Me.Label7)
		Me.GroupBox3.Controls.Add(Me.lblAgConcluido)
		Me.GroupBox3.Controls.Add(Me.lblAgCancelado)
		Me.GroupBox3.Controls.Add(Me.Label11)
		Me.GroupBox3.Controls.Add(Me.Label12)
		Me.GroupBox3.Controls.Add(Me.lblAgMarcado)
		Me.GroupBox3.Location = New System.Drawing.Point(818, 285)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(179, 100)
		Me.GroupBox3.TabIndex = 94
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Agendamentos"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Location = New System.Drawing.Point(19, 73)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(61, 13)
		Me.Label7.TabIndex = 88
		Me.Label7.Text = "Cancelado:"
		'
		'lblAgConcluido
		'
		Me.lblAgConcluido.AutoSize = True
		Me.lblAgConcluido.BackColor = System.Drawing.Color.Transparent
		Me.lblAgConcluido.ForeColor = System.Drawing.Color.DarkBlue
		Me.lblAgConcluido.Location = New System.Drawing.Point(87, 47)
		Me.lblAgConcluido.Name = "lblAgConcluido"
		Me.lblAgConcluido.Size = New System.Drawing.Size(10, 13)
		Me.lblAgConcluido.TabIndex = 93
		Me.lblAgConcluido.Text = "-"
		'
		'lblAgCancelado
		'
		Me.lblAgCancelado.AutoSize = True
		Me.lblAgCancelado.BackColor = System.Drawing.Color.Transparent
		Me.lblAgCancelado.ForeColor = System.Drawing.Color.Red
		Me.lblAgCancelado.Location = New System.Drawing.Point(94, 73)
		Me.lblAgCancelado.Name = "lblAgCancelado"
		Me.lblAgCancelado.Size = New System.Drawing.Size(10, 13)
		Me.lblAgCancelado.TabIndex = 89
		Me.lblAgCancelado.Text = "-"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Location = New System.Drawing.Point(16, 47)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(59, 13)
		Me.Label11.TabIndex = 92
		Me.Label11.Text = "Concluído:"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Location = New System.Drawing.Point(16, 25)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(52, 13)
		Me.Label12.TabIndex = 90
		Me.Label12.Text = "Marcado:"
		'
		'lblAgMarcado
		'
		Me.lblAgMarcado.AutoSize = True
		Me.lblAgMarcado.BackColor = System.Drawing.Color.Transparent
		Me.lblAgMarcado.ForeColor = System.Drawing.Color.DarkGreen
		Me.lblAgMarcado.Location = New System.Drawing.Point(94, 25)
		Me.lblAgMarcado.Name = "lblAgMarcado"
		Me.lblAgMarcado.Size = New System.Drawing.Size(10, 13)
		Me.lblAgMarcado.TabIndex = 91
		Me.lblAgMarcado.Text = "-"
		'
		'btnAddCliente
		'
		Me.btnAddCliente.BackColor = System.Drawing.Color.Transparent
		Me.btnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnAddCliente.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.btnAddCliente.FlatAppearance.BorderSize = 0
		Me.btnAddCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnAddCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAddCliente.Image = CType(resources.GetObject("btnAddCliente.Image"), System.Drawing.Image)
		Me.btnAddCliente.Location = New System.Drawing.Point(0, 35)
		Me.btnAddCliente.Name = "btnAddCliente"
		Me.btnAddCliente.Size = New System.Drawing.Size(64, 58)
		Me.btnAddCliente.TabIndex = 2
		Me.btnAddCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAddCliente.UseVisualStyleBackColor = False
		'
		'btnAgendamento
		'
		Me.btnAgendamento.BackColor = System.Drawing.Color.Transparent
		Me.btnAgendamento.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnAgendamento.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.btnAgendamento.FlatAppearance.BorderSize = 0
		Me.btnAgendamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAgendamento.Image = CType(resources.GetObject("btnAgendamento.Image"), System.Drawing.Image)
		Me.btnAgendamento.Location = New System.Drawing.Point(70, 35)
		Me.btnAgendamento.Name = "btnAgendamento"
		Me.btnAgendamento.Size = New System.Drawing.Size(64, 58)
		Me.btnAgendamento.TabIndex = 3
		Me.btnAgendamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnAgendamento.UseVisualStyleBackColor = False
		'
		'btnHorarios
		'
		Me.btnHorarios.BackColor = System.Drawing.Color.Transparent
		Me.btnHorarios.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnHorarios.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.btnHorarios.FlatAppearance.BorderSize = 0
		Me.btnHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnHorarios.Image = CType(resources.GetObject("btnHorarios.Image"), System.Drawing.Image)
		Me.btnHorarios.Location = New System.Drawing.Point(140, 35)
		Me.btnHorarios.Name = "btnHorarios"
		Me.btnHorarios.Size = New System.Drawing.Size(64, 58)
		Me.btnHorarios.TabIndex = 4
		Me.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnHorarios.UseVisualStyleBackColor = False
		'
		'btnVenda
		'
		Me.btnVenda.BackColor = System.Drawing.Color.Transparent
		Me.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand
		Me.btnVenda.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen
		Me.btnVenda.FlatAppearance.BorderSize = 0
		Me.btnVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnVenda.Image = CType(resources.GetObject("btnVenda.Image"), System.Drawing.Image)
		Me.btnVenda.Location = New System.Drawing.Point(210, 35)
		Me.btnVenda.Name = "btnVenda"
		Me.btnVenda.Size = New System.Drawing.Size(64, 58)
		Me.btnVenda.TabIndex = 5
		Me.btnVenda.Text = "*"
		Me.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnVenda.UseVisualStyleBackColor = False
		'
		'FrmTelaPrincipal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.RoyalBlue
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(1052, 483)
		Me.Controls.Add(Me.gridServicos)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.lblHora)
		Me.Controls.Add(Me.lblData)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnVenda)
		Me.Controls.Add(Me.btnHorarios)
		Me.Controls.Add(Me.btnAgendamento)
		Me.Controls.Add(Me.btnAddCliente)
		Me.Controls.Add(Me.menuPrincipal)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MainMenuStrip = Me.menuPrincipal
		Me.Name = "FrmTelaPrincipal"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Menu Principal"
		Me.menuPrincipal.ResumeLayout(False)
		Me.menuPrincipal.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.gridServicos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents menuPrincipal As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimentaçõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuFunc As ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EspecialidadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuProdutos As ToolStripMenuItem
	Friend WithEvents AgendamentoToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents QuadroDeHoráriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuPagamentos As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents lblUsuario As Label
	Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEsp As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents TimerData As Timer
    Friend WithEvents ProdutosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EntradasESaidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTotalSaidas As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotEntradas As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalDia As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grid As DataGridView
    Friend WithEvents GastosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeHoráriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDosAgendamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gridServicos As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAgConcluido As Label
    Friend WithEvents lblAgCancelado As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblAgMarcado As Label
    Friend WithEvents ConsultaPorClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgendamentoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AgendamentoPorStatusToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btnAddCliente As Button
	Friend WithEvents btnAgendamento As Button
	Friend WithEvents btnHorarios As Button
	Friend WithEvents btnVenda As Button
End Class
