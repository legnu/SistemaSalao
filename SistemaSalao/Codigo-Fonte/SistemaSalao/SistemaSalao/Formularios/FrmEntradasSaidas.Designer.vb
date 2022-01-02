<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntradasSaidas
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntradasSaidas))
		Me.lblTotalDia = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.dataBuscarIni = New System.Windows.Forms.DateTimePicker()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.rbEntSaida = New System.Windows.Forms.RadioButton()
		Me.rbData = New System.Windows.Forms.RadioButton()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.cbBusca = New System.Windows.Forms.ComboBox()
		Me.lblTotEntradas = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblTotalSaidas = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblInicial = New System.Windows.Forms.Label()
		Me.lblFinal = New System.Windows.Forms.Label()
		Me.dataBuscarFin = New System.Windows.Forms.DateTimePicker()
		Me.rbAmbos = New System.Windows.Forms.RadioButton()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblTotalDia
		'
		Me.lblTotalDia.AutoSize = True
		Me.lblTotalDia.BackColor = System.Drawing.Color.Transparent
		Me.lblTotalDia.Location = New System.Drawing.Point(566, 296)
		Me.lblTotalDia.Name = "lblTotalDia"
		Me.lblTotalDia.Size = New System.Drawing.Size(10, 13)
		Me.lblTotalDia.TabIndex = 79
		Me.lblTotalDia.Text = "-"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Location = New System.Drawing.Point(509, 296)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(53, 13)
		Me.Label8.TabIndex = 78
		Me.Label8.Text = "Total Dia:"
		'
		'dataBuscarIni
		'
		Me.dataBuscarIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dataBuscarIni.Location = New System.Drawing.Point(537, 26)
		Me.dataBuscarIni.Name = "dataBuscarIni"
		Me.dataBuscarIni.Size = New System.Drawing.Size(99, 20)
		Me.dataBuscarIni.TabIndex = 77
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.MintCream
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Location = New System.Drawing.Point(32, 113)
		Me.grid.Name = "grid"
		Me.grid.ReadOnly = True
		Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grid.Size = New System.Drawing.Size(604, 171)
		Me.grid.TabIndex = 75
		'
		'rbEntSaida
		'
		Me.rbEntSaida.AutoSize = True
		Me.rbEntSaida.BackColor = System.Drawing.Color.Transparent
		Me.rbEntSaida.Location = New System.Drawing.Point(368, 26)
		Me.rbEntSaida.Name = "rbEntSaida"
		Me.rbEntSaida.Size = New System.Drawing.Size(102, 17)
		Me.rbEntSaida.TabIndex = 82
		Me.rbEntSaida.Text = "Entrada / Saída"
		Me.rbEntSaida.UseVisualStyleBackColor = False
		'
		'rbData
		'
		Me.rbData.AutoSize = True
		Me.rbData.BackColor = System.Drawing.Color.Transparent
		Me.rbData.Checked = True
		Me.rbData.Location = New System.Drawing.Point(301, 26)
		Me.rbData.Name = "rbData"
		Me.rbData.Size = New System.Drawing.Size(51, 17)
		Me.rbData.TabIndex = 81
		Me.rbData.TabStop = True
		Me.rbData.Text = "Data:"
		Me.rbData.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(171, 28)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(40, 13)
		Me.Label1.TabIndex = 80
		Me.Label1.Text = "Buscar"
		'
		'cbBusca
		'
		Me.cbBusca.FormattingEnabled = True
		Me.cbBusca.Items.AddRange(New Object() {"Entrada", "Saída"})
		Me.cbBusca.Location = New System.Drawing.Point(371, 50)
		Me.cbBusca.Name = "cbBusca"
		Me.cbBusca.Size = New System.Drawing.Size(99, 21)
		Me.cbBusca.TabIndex = 83
		'
		'lblTotEntradas
		'
		Me.lblTotEntradas.AutoSize = True
		Me.lblTotEntradas.BackColor = System.Drawing.Color.Transparent
		Me.lblTotEntradas.ForeColor = System.Drawing.Color.DarkGreen
		Me.lblTotEntradas.Location = New System.Drawing.Point(107, 296)
		Me.lblTotEntradas.Name = "lblTotEntradas"
		Me.lblTotEntradas.Size = New System.Drawing.Size(10, 13)
		Me.lblTotEntradas.TabIndex = 85
		Me.lblTotEntradas.Text = "-"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Location = New System.Drawing.Point(29, 296)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(79, 13)
		Me.Label3.TabIndex = 84
		Me.Label3.Text = "Total Entradas:"
		'
		'lblTotalSaidas
		'
		Me.lblTotalSaidas.AutoSize = True
		Me.lblTotalSaidas.BackColor = System.Drawing.Color.Transparent
		Me.lblTotalSaidas.ForeColor = System.Drawing.Color.Red
		Me.lblTotalSaidas.Location = New System.Drawing.Point(242, 296)
		Me.lblTotalSaidas.Name = "lblTotalSaidas"
		Me.lblTotalSaidas.Size = New System.Drawing.Size(10, 13)
		Me.lblTotalSaidas.TabIndex = 87
		Me.lblTotalSaidas.Text = "-"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Location = New System.Drawing.Point(171, 296)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(71, 13)
		Me.Label5.TabIndex = 86
		Me.Label5.Text = "Total Saídas:"
		'
		'lblInicial
		'
		Me.lblInicial.AutoSize = True
		Me.lblInicial.BackColor = System.Drawing.Color.Transparent
		Me.lblInicial.Location = New System.Drawing.Point(491, 28)
		Me.lblInicial.Name = "lblInicial"
		Me.lblInicial.Size = New System.Drawing.Size(37, 13)
		Me.lblInicial.TabIndex = 88
		Me.lblInicial.Text = "Inicial:"
		'
		'lblFinal
		'
		Me.lblFinal.AutoSize = True
		Me.lblFinal.BackColor = System.Drawing.Color.Transparent
		Me.lblFinal.Location = New System.Drawing.Point(491, 52)
		Me.lblFinal.Name = "lblFinal"
		Me.lblFinal.Size = New System.Drawing.Size(32, 13)
		Me.lblFinal.TabIndex = 90
		Me.lblFinal.Text = "Final:"
		'
		'dataBuscarFin
		'
		Me.dataBuscarFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dataBuscarFin.Location = New System.Drawing.Point(537, 50)
		Me.dataBuscarFin.Name = "dataBuscarFin"
		Me.dataBuscarFin.Size = New System.Drawing.Size(99, 20)
		Me.dataBuscarFin.TabIndex = 89
		'
		'rbAmbos
		'
		Me.rbAmbos.AutoSize = True
		Me.rbAmbos.BackColor = System.Drawing.Color.Transparent
		Me.rbAmbos.Location = New System.Drawing.Point(227, 26)
		Me.rbAmbos.Name = "rbAmbos"
		Me.rbAmbos.Size = New System.Drawing.Size(60, 17)
		Me.rbAmbos.TabIndex = 91
		Me.rbAmbos.Text = "Ambos:"
		Me.rbAmbos.UseVisualStyleBackColor = False
		'
		'FrmEntradasSaidas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(687, 319)
		Me.Controls.Add(Me.rbAmbos)
		Me.Controls.Add(Me.lblFinal)
		Me.Controls.Add(Me.dataBuscarFin)
		Me.Controls.Add(Me.lblInicial)
		Me.Controls.Add(Me.lblTotalSaidas)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.lblTotEntradas)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.cbBusca)
		Me.Controls.Add(Me.rbEntSaida)
		Me.Controls.Add(Me.rbData)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lblTotalDia)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.dataBuscarIni)
		Me.Controls.Add(Me.grid)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FrmEntradasSaidas"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Entradas e Saídas"
		CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblTotalDia As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dataBuscarIni As DateTimePicker
    Friend WithEvents grid As DataGridView
    Friend WithEvents rbEntSaida As RadioButton
    Friend WithEvents rbData As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cbBusca As ComboBox
    Friend WithEvents lblTotEntradas As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalSaidas As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblInicial As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents dataBuscarFin As DateTimePicker
    Friend WithEvents rbAmbos As RadioButton
End Class
