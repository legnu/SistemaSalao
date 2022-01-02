<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuadroHorarios
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuadroHorarios))
		Me.dataBuscar = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cbFuncionario = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.grid = New System.Windows.Forms.DataGridView()
		Me.txtCodigo = New System.Windows.Forms.TextBox()
		Me.Panel14 = New System.Windows.Forms.Panel()
		Me.lbl6 = New System.Windows.Forms.Label()
		Me.Panel8 = New System.Windows.Forms.Panel()
		Me.lbl1 = New System.Windows.Forms.Label()
		Me.Panel18 = New System.Windows.Forms.Panel()
		Me.lbl10 = New System.Windows.Forms.Label()
		Me.Panel17 = New System.Windows.Forms.Panel()
		Me.lbl9 = New System.Windows.Forms.Label()
		Me.Panel13 = New System.Windows.Forms.Panel()
		Me.lbl5 = New System.Windows.Forms.Label()
		Me.Panel16 = New System.Windows.Forms.Panel()
		Me.lbl8 = New System.Windows.Forms.Label()
		Me.Panel11 = New System.Windows.Forms.Panel()
		Me.lbl4 = New System.Windows.Forms.Label()
		Me.Panel15 = New System.Windows.Forms.Panel()
		Me.lbl7 = New System.Windows.Forms.Label()
		Me.Panel10 = New System.Windows.Forms.Panel()
		Me.lbl3 = New System.Windows.Forms.Label()
		Me.Panel9 = New System.Windows.Forms.Panel()
		Me.lbl2 = New System.Windows.Forms.Label()
		Me.gridHorarios = New System.Windows.Forms.DataGridView()
		Me.cbHora = New System.Windows.Forms.ComboBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.lbl11 = New System.Windows.Forms.Label()
		Me.Panel2 = New System.Windows.Forms.Panel()
		Me.lbl16 = New System.Windows.Forms.Label()
		Me.Panel3 = New System.Windows.Forms.Panel()
		Me.lbl13 = New System.Windows.Forms.Label()
		Me.Panel4 = New System.Windows.Forms.Panel()
		Me.lbl14 = New System.Windows.Forms.Label()
		Me.Panel5 = New System.Windows.Forms.Panel()
		Me.lbl20 = New System.Windows.Forms.Label()
		Me.Panel6 = New System.Windows.Forms.Panel()
		Me.lbl19 = New System.Windows.Forms.Label()
		Me.Panel7 = New System.Windows.Forms.Panel()
		Me.lbl18 = New System.Windows.Forms.Label()
		Me.Panel12 = New System.Windows.Forms.Panel()
		Me.lbl15 = New System.Windows.Forms.Label()
		Me.Panel19 = New System.Windows.Forms.Panel()
		Me.lbl12 = New System.Windows.Forms.Label()
		Me.Panel20 = New System.Windows.Forms.Panel()
		Me.lbl17 = New System.Windows.Forms.Label()
		CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel14.SuspendLayout()
		Me.Panel8.SuspendLayout()
		Me.Panel18.SuspendLayout()
		Me.Panel17.SuspendLayout()
		Me.Panel13.SuspendLayout()
		Me.Panel16.SuspendLayout()
		Me.Panel11.SuspendLayout()
		Me.Panel15.SuspendLayout()
		Me.Panel10.SuspendLayout()
		Me.Panel9.SuspendLayout()
		CType(Me.gridHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		Me.Panel2.SuspendLayout()
		Me.Panel3.SuspendLayout()
		Me.Panel4.SuspendLayout()
		Me.Panel5.SuspendLayout()
		Me.Panel6.SuspendLayout()
		Me.Panel7.SuspendLayout()
		Me.Panel12.SuspendLayout()
		Me.Panel19.SuspendLayout()
		Me.Panel20.SuspendLayout()
		Me.SuspendLayout()
		'
		'dataBuscar
		'
		Me.dataBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dataBuscar.Location = New System.Drawing.Point(519, 15)
		Me.dataBuscar.Name = "dataBuscar"
		Me.dataBuscar.Size = New System.Drawing.Size(99, 20)
		Me.dataBuscar.TabIndex = 94
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(469, 15)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(43, 13)
		Me.Label4.TabIndex = 93
		Me.Label4.Text = "Buscar:"
		'
		'cbFuncionario
		'
		Me.cbFuncionario.FormattingEnabled = True
		Me.cbFuncionario.Location = New System.Drawing.Point(83, 14)
		Me.cbFuncionario.Name = "cbFuncionario"
		Me.cbFuncionario.Size = New System.Drawing.Size(111, 21)
		Me.cbFuncionario.TabIndex = 91
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(12, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(65, 13)
		Me.Label1.TabIndex = 92
		Me.Label1.Text = "Funcionário:"
		'
		'grid
		'
		Me.grid.AllowUserToAddRows = False
		Me.grid.AllowUserToDeleteRows = False
		Me.grid.BackgroundColor = System.Drawing.Color.MintCream
		Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grid.Location = New System.Drawing.Point(14, 155)
		Me.grid.Name = "grid"
		Me.grid.ReadOnly = True
		Me.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.grid.Size = New System.Drawing.Size(606, 236)
		Me.grid.TabIndex = 90
		'
		'txtCodigo
		'
		Me.txtCodigo.Location = New System.Drawing.Point(397, 41)
		Me.txtCodigo.Name = "txtCodigo"
		Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
		Me.txtCodigo.TabIndex = 89
		Me.txtCodigo.Visible = False
		'
		'Panel14
		'
		Me.Panel14.BackColor = System.Drawing.Color.LightGreen
		Me.Panel14.Controls.Add(Me.lbl6)
		Me.Panel14.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel14.Location = New System.Drawing.Point(317, 72)
		Me.Panel14.Name = "Panel14"
		Me.Panel14.Size = New System.Drawing.Size(55, 30)
		Me.Panel14.TabIndex = 98
		'
		'lbl6
		'
		Me.lbl6.AutoSize = True
		Me.lbl6.Enabled = False
		Me.lbl6.Location = New System.Drawing.Point(3, 8)
		Me.lbl6.Name = "lbl6"
		Me.lbl6.Size = New System.Drawing.Size(0, 13)
		Me.lbl6.TabIndex = 69
		'
		'Panel8
		'
		Me.Panel8.BackColor = System.Drawing.Color.LightGreen
		Me.Panel8.Controls.Add(Me.lbl1)
		Me.Panel8.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel8.Location = New System.Drawing.Point(12, 72)
		Me.Panel8.Name = "Panel8"
		Me.Panel8.Size = New System.Drawing.Size(55, 30)
		Me.Panel8.TabIndex = 96
		'
		'lbl1
		'
		Me.lbl1.AutoSize = True
		Me.lbl1.Enabled = False
		Me.lbl1.Location = New System.Drawing.Point(3, 8)
		Me.lbl1.Name = "lbl1"
		Me.lbl1.Size = New System.Drawing.Size(0, 13)
		Me.lbl1.TabIndex = 69
		'
		'Panel18
		'
		Me.Panel18.BackColor = System.Drawing.Color.LightGreen
		Me.Panel18.Controls.Add(Me.lbl10)
		Me.Panel18.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel18.Location = New System.Drawing.Point(563, 72)
		Me.Panel18.Name = "Panel18"
		Me.Panel18.Size = New System.Drawing.Size(55, 30)
		Me.Panel18.TabIndex = 104
		'
		'lbl10
		'
		Me.lbl10.AutoSize = True
		Me.lbl10.Enabled = False
		Me.lbl10.Location = New System.Drawing.Point(3, 9)
		Me.lbl10.Name = "lbl10"
		Me.lbl10.Size = New System.Drawing.Size(0, 13)
		Me.lbl10.TabIndex = 70
		'
		'Panel17
		'
		Me.Panel17.BackColor = System.Drawing.Color.LightGreen
		Me.Panel17.Controls.Add(Me.lbl9)
		Me.Panel17.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel17.Location = New System.Drawing.Point(502, 72)
		Me.Panel17.Name = "Panel17"
		Me.Panel17.Size = New System.Drawing.Size(55, 30)
		Me.Panel17.TabIndex = 103
		'
		'lbl9
		'
		Me.lbl9.AutoSize = True
		Me.lbl9.Enabled = False
		Me.lbl9.Location = New System.Drawing.Point(3, 9)
		Me.lbl9.Name = "lbl9"
		Me.lbl9.Size = New System.Drawing.Size(0, 13)
		Me.lbl9.TabIndex = 70
		'
		'Panel13
		'
		Me.Panel13.BackColor = System.Drawing.Color.LightGreen
		Me.Panel13.Controls.Add(Me.lbl5)
		Me.Panel13.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel13.Location = New System.Drawing.Point(256, 72)
		Me.Panel13.Name = "Panel13"
		Me.Panel13.Size = New System.Drawing.Size(55, 30)
		Me.Panel13.TabIndex = 100
		'
		'lbl5
		'
		Me.lbl5.AutoSize = True
		Me.lbl5.Enabled = False
		Me.lbl5.Location = New System.Drawing.Point(3, 9)
		Me.lbl5.Name = "lbl5"
		Me.lbl5.Size = New System.Drawing.Size(0, 13)
		Me.lbl5.TabIndex = 70
		'
		'Panel16
		'
		Me.Panel16.BackColor = System.Drawing.Color.LightGreen
		Me.Panel16.Controls.Add(Me.lbl8)
		Me.Panel16.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel16.Location = New System.Drawing.Point(439, 72)
		Me.Panel16.Name = "Panel16"
		Me.Panel16.Size = New System.Drawing.Size(55, 30)
		Me.Panel16.TabIndex = 102
		'
		'lbl8
		'
		Me.lbl8.AutoSize = True
		Me.lbl8.Enabled = False
		Me.lbl8.Location = New System.Drawing.Point(3, 8)
		Me.lbl8.Name = "lbl8"
		Me.lbl8.Size = New System.Drawing.Size(0, 13)
		Me.lbl8.TabIndex = 69
		'
		'Panel11
		'
		Me.Panel11.BackColor = System.Drawing.Color.LightGreen
		Me.Panel11.Controls.Add(Me.lbl4)
		Me.Panel11.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel11.Location = New System.Drawing.Point(195, 72)
		Me.Panel11.Name = "Panel11"
		Me.Panel11.Size = New System.Drawing.Size(55, 30)
		Me.Panel11.TabIndex = 99
		'
		'lbl4
		'
		Me.lbl4.AutoSize = True
		Me.lbl4.Enabled = False
		Me.lbl4.Location = New System.Drawing.Point(3, 9)
		Me.lbl4.Name = "lbl4"
		Me.lbl4.Size = New System.Drawing.Size(0, 13)
		Me.lbl4.TabIndex = 70
		'
		'Panel15
		'
		Me.Panel15.BackColor = System.Drawing.Color.LightGreen
		Me.Panel15.Controls.Add(Me.lbl7)
		Me.Panel15.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel15.Location = New System.Drawing.Point(378, 72)
		Me.Panel15.Name = "Panel15"
		Me.Panel15.Size = New System.Drawing.Size(55, 30)
		Me.Panel15.TabIndex = 101
		'
		'lbl7
		'
		Me.lbl7.AutoSize = True
		Me.lbl7.Enabled = False
		Me.lbl7.Location = New System.Drawing.Point(3, 8)
		Me.lbl7.Name = "lbl7"
		Me.lbl7.Size = New System.Drawing.Size(0, 13)
		Me.lbl7.TabIndex = 69
		'
		'Panel10
		'
		Me.Panel10.BackColor = System.Drawing.Color.LightGreen
		Me.Panel10.Controls.Add(Me.lbl3)
		Me.Panel10.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel10.Location = New System.Drawing.Point(134, 72)
		Me.Panel10.Name = "Panel10"
		Me.Panel10.Size = New System.Drawing.Size(55, 30)
		Me.Panel10.TabIndex = 97
		'
		'lbl3
		'
		Me.lbl3.AutoSize = True
		Me.lbl3.Enabled = False
		Me.lbl3.Location = New System.Drawing.Point(3, 8)
		Me.lbl3.Name = "lbl3"
		Me.lbl3.Size = New System.Drawing.Size(0, 13)
		Me.lbl3.TabIndex = 69
		'
		'Panel9
		'
		Me.Panel9.BackColor = System.Drawing.Color.LightGreen
		Me.Panel9.Controls.Add(Me.lbl2)
		Me.Panel9.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Panel9.Location = New System.Drawing.Point(73, 72)
		Me.Panel9.Name = "Panel9"
		Me.Panel9.Size = New System.Drawing.Size(55, 30)
		Me.Panel9.TabIndex = 95
		'
		'lbl2
		'
		Me.lbl2.AutoSize = True
		Me.lbl2.Enabled = False
		Me.lbl2.Location = New System.Drawing.Point(3, 8)
		Me.lbl2.Name = "lbl2"
		Me.lbl2.Size = New System.Drawing.Size(0, 13)
		Me.lbl2.TabIndex = 69
		'
		'gridHorarios
		'
		Me.gridHorarios.AllowUserToAddRows = False
		Me.gridHorarios.AllowUserToDeleteRows = False
		Me.gridHorarios.BackgroundColor = System.Drawing.Color.MintCream
		Me.gridHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.gridHorarios.Location = New System.Drawing.Point(116, 41)
		Me.gridHorarios.Name = "gridHorarios"
		Me.gridHorarios.ReadOnly = True
		Me.gridHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.gridHorarios.Size = New System.Drawing.Size(78, 25)
		Me.gridHorarios.TabIndex = 105
		Me.gridHorarios.Visible = False
		'
		'cbHora
		'
		Me.cbHora.FormattingEnabled = True
		Me.cbHora.Location = New System.Drawing.Point(256, 15)
		Me.cbHora.Name = "cbHora"
		Me.cbHora.Size = New System.Drawing.Size(111, 21)
		Me.cbHora.TabIndex = 106
		Me.cbHora.Visible = False
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.Color.LightGreen
		Me.Panel1.Controls.Add(Me.lbl11)
		Me.Panel1.Location = New System.Drawing.Point(12, 108)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(55, 30)
		Me.Panel1.TabIndex = 107
		'
		'lbl11
		'
		Me.lbl11.AutoSize = True
		Me.lbl11.Location = New System.Drawing.Point(3, 9)
		Me.lbl11.Name = "lbl11"
		Me.lbl11.Size = New System.Drawing.Size(0, 13)
		Me.lbl11.TabIndex = 108
		'
		'Panel2
		'
		Me.Panel2.BackColor = System.Drawing.Color.LightGreen
		Me.Panel2.Controls.Add(Me.lbl16)
		Me.Panel2.Location = New System.Drawing.Point(317, 108)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(55, 30)
		Me.Panel2.TabIndex = 108
		'
		'lbl16
		'
		Me.lbl16.AutoSize = True
		Me.lbl16.Location = New System.Drawing.Point(3, 8)
		Me.lbl16.Name = "lbl16"
		Me.lbl16.Size = New System.Drawing.Size(0, 13)
		Me.lbl16.TabIndex = 108
		'
		'Panel3
		'
		Me.Panel3.BackColor = System.Drawing.Color.LightGreen
		Me.Panel3.Controls.Add(Me.lbl13)
		Me.Panel3.Location = New System.Drawing.Point(134, 108)
		Me.Panel3.Name = "Panel3"
		Me.Panel3.Size = New System.Drawing.Size(55, 30)
		Me.Panel3.TabIndex = 109
		'
		'lbl13
		'
		Me.lbl13.AutoSize = True
		Me.lbl13.Location = New System.Drawing.Point(3, 9)
		Me.lbl13.Name = "lbl13"
		Me.lbl13.Size = New System.Drawing.Size(0, 13)
		Me.lbl13.TabIndex = 108
		'
		'Panel4
		'
		Me.Panel4.BackColor = System.Drawing.Color.LightGreen
		Me.Panel4.Controls.Add(Me.lbl14)
		Me.Panel4.Location = New System.Drawing.Point(195, 108)
		Me.Panel4.Name = "Panel4"
		Me.Panel4.Size = New System.Drawing.Size(55, 30)
		Me.Panel4.TabIndex = 109
		'
		'lbl14
		'
		Me.lbl14.AutoSize = True
		Me.lbl14.Location = New System.Drawing.Point(3, 9)
		Me.lbl14.Name = "lbl14"
		Me.lbl14.Size = New System.Drawing.Size(0, 13)
		Me.lbl14.TabIndex = 108
		'
		'Panel5
		'
		Me.Panel5.BackColor = System.Drawing.Color.LightGreen
		Me.Panel5.Controls.Add(Me.lbl20)
		Me.Panel5.Location = New System.Drawing.Point(563, 108)
		Me.Panel5.Name = "Panel5"
		Me.Panel5.Size = New System.Drawing.Size(55, 30)
		Me.Panel5.TabIndex = 109
		'
		'lbl20
		'
		Me.lbl20.AutoSize = True
		Me.lbl20.Location = New System.Drawing.Point(3, 9)
		Me.lbl20.Name = "lbl20"
		Me.lbl20.Size = New System.Drawing.Size(0, 13)
		Me.lbl20.TabIndex = 108
		'
		'Panel6
		'
		Me.Panel6.BackColor = System.Drawing.Color.LightGreen
		Me.Panel6.Controls.Add(Me.lbl19)
		Me.Panel6.Location = New System.Drawing.Point(502, 108)
		Me.Panel6.Name = "Panel6"
		Me.Panel6.Size = New System.Drawing.Size(55, 30)
		Me.Panel6.TabIndex = 109
		'
		'lbl19
		'
		Me.lbl19.AutoSize = True
		Me.lbl19.Location = New System.Drawing.Point(3, 9)
		Me.lbl19.Name = "lbl19"
		Me.lbl19.Size = New System.Drawing.Size(0, 13)
		Me.lbl19.TabIndex = 108
		'
		'Panel7
		'
		Me.Panel7.BackColor = System.Drawing.Color.LightGreen
		Me.Panel7.Controls.Add(Me.lbl18)
		Me.Panel7.Location = New System.Drawing.Point(439, 108)
		Me.Panel7.Name = "Panel7"
		Me.Panel7.Size = New System.Drawing.Size(55, 30)
		Me.Panel7.TabIndex = 109
		'
		'lbl18
		'
		Me.lbl18.AutoSize = True
		Me.lbl18.Location = New System.Drawing.Point(3, 9)
		Me.lbl18.Name = "lbl18"
		Me.lbl18.Size = New System.Drawing.Size(0, 13)
		Me.lbl18.TabIndex = 108
		'
		'Panel12
		'
		Me.Panel12.BackColor = System.Drawing.Color.LightGreen
		Me.Panel12.Controls.Add(Me.lbl15)
		Me.Panel12.Location = New System.Drawing.Point(256, 108)
		Me.Panel12.Name = "Panel12"
		Me.Panel12.Size = New System.Drawing.Size(55, 30)
		Me.Panel12.TabIndex = 109
		'
		'lbl15
		'
		Me.lbl15.AutoSize = True
		Me.lbl15.Location = New System.Drawing.Point(3, 9)
		Me.lbl15.Name = "lbl15"
		Me.lbl15.Size = New System.Drawing.Size(0, 13)
		Me.lbl15.TabIndex = 108
		'
		'Panel19
		'
		Me.Panel19.BackColor = System.Drawing.Color.LightGreen
		Me.Panel19.Controls.Add(Me.lbl12)
		Me.Panel19.Location = New System.Drawing.Point(73, 108)
		Me.Panel19.Name = "Panel19"
		Me.Panel19.Size = New System.Drawing.Size(55, 30)
		Me.Panel19.TabIndex = 109
		'
		'lbl12
		'
		Me.lbl12.AutoSize = True
		Me.lbl12.Location = New System.Drawing.Point(3, 9)
		Me.lbl12.Name = "lbl12"
		Me.lbl12.Size = New System.Drawing.Size(0, 13)
		Me.lbl12.TabIndex = 108
		'
		'Panel20
		'
		Me.Panel20.BackColor = System.Drawing.Color.LightGreen
		Me.Panel20.Controls.Add(Me.lbl17)
		Me.Panel20.Location = New System.Drawing.Point(378, 108)
		Me.Panel20.Name = "Panel20"
		Me.Panel20.Size = New System.Drawing.Size(55, 30)
		Me.Panel20.TabIndex = 109
		'
		'lbl17
		'
		Me.lbl17.AutoSize = True
		Me.lbl17.Location = New System.Drawing.Point(3, 9)
		Me.lbl17.Name = "lbl17"
		Me.lbl17.Size = New System.Drawing.Size(0, 13)
		Me.lbl17.TabIndex = 108
		'
		'FrmQuadroHorarios
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(632, 403)
		Me.Controls.Add(Me.Panel19)
		Me.Controls.Add(Me.Panel5)
		Me.Controls.Add(Me.Panel20)
		Me.Controls.Add(Me.Panel3)
		Me.Controls.Add(Me.Panel6)
		Me.Controls.Add(Me.Panel7)
		Me.Controls.Add(Me.Panel4)
		Me.Controls.Add(Me.Panel12)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.cbHora)
		Me.Controls.Add(Me.gridHorarios)
		Me.Controls.Add(Me.Panel14)
		Me.Controls.Add(Me.Panel8)
		Me.Controls.Add(Me.Panel18)
		Me.Controls.Add(Me.Panel17)
		Me.Controls.Add(Me.Panel13)
		Me.Controls.Add(Me.Panel16)
		Me.Controls.Add(Me.Panel11)
		Me.Controls.Add(Me.Panel15)
		Me.Controls.Add(Me.Panel10)
		Me.Controls.Add(Me.Panel9)
		Me.Controls.Add(Me.dataBuscar)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.cbFuncionario)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.grid)
		Me.Controls.Add(Me.txtCodigo)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "FrmQuadroHorarios"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Quadro de Horários"
		CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel14.ResumeLayout(False)
		Me.Panel14.PerformLayout()
		Me.Panel8.ResumeLayout(False)
		Me.Panel8.PerformLayout()
		Me.Panel18.ResumeLayout(False)
		Me.Panel18.PerformLayout()
		Me.Panel17.ResumeLayout(False)
		Me.Panel17.PerformLayout()
		Me.Panel13.ResumeLayout(False)
		Me.Panel13.PerformLayout()
		Me.Panel16.ResumeLayout(False)
		Me.Panel16.PerformLayout()
		Me.Panel11.ResumeLayout(False)
		Me.Panel11.PerformLayout()
		Me.Panel15.ResumeLayout(False)
		Me.Panel15.PerformLayout()
		Me.Panel10.ResumeLayout(False)
		Me.Panel10.PerformLayout()
		Me.Panel9.ResumeLayout(False)
		Me.Panel9.PerformLayout()
		CType(Me.gridHorarios, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		Me.Panel3.ResumeLayout(False)
		Me.Panel3.PerformLayout()
		Me.Panel4.ResumeLayout(False)
		Me.Panel4.PerformLayout()
		Me.Panel5.ResumeLayout(False)
		Me.Panel5.PerformLayout()
		Me.Panel6.ResumeLayout(False)
		Me.Panel6.PerformLayout()
		Me.Panel7.ResumeLayout(False)
		Me.Panel7.PerformLayout()
		Me.Panel12.ResumeLayout(False)
		Me.Panel12.PerformLayout()
		Me.Panel19.ResumeLayout(False)
		Me.Panel19.PerformLayout()
		Me.Panel20.ResumeLayout(False)
		Me.Panel20.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dataBuscar As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbFuncionario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grid As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Panel14 As Panel
	Friend WithEvents Panel8 As Panel
	Friend WithEvents Panel18 As Panel
	Friend WithEvents Panel17 As Panel
	Friend WithEvents Panel13 As Panel
	Friend WithEvents Panel16 As Panel
	Friend WithEvents Panel11 As Panel
	Friend WithEvents Panel15 As Panel
	Friend WithEvents Panel10 As Panel
	Friend WithEvents Panel9 As Panel
	Friend WithEvents lbl6 As Label
	Friend WithEvents lbl1 As Label
	Friend WithEvents lbl10 As Label
	Friend WithEvents lbl9 As Label
	Friend WithEvents lbl5 As Label
	Friend WithEvents lbl8 As Label
	Friend WithEvents lbl4 As Label
	Friend WithEvents lbl7 As Label
	Friend WithEvents lbl3 As Label
	Friend WithEvents lbl2 As Label
	Friend WithEvents gridHorarios As DataGridView
	Friend WithEvents cbHora As ComboBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents lbl11 As Label
	Friend WithEvents Panel2 As Panel
	Friend WithEvents lbl16 As Label
	Friend WithEvents Panel3 As Panel
	Friend WithEvents lbl13 As Label
	Friend WithEvents Panel4 As Panel
	Friend WithEvents lbl14 As Label
	Friend WithEvents Panel5 As Panel
	Friend WithEvents lbl20 As Label
	Friend WithEvents Panel6 As Panel
	Friend WithEvents lbl19 As Label
	Friend WithEvents Panel7 As Panel
	Friend WithEvents lbl18 As Label
	Friend WithEvents Panel12 As Panel
	Friend WithEvents lbl15 As Label
	Friend WithEvents Panel19 As Panel
	Friend WithEvents lbl12 As Label
	Friend WithEvents Panel20 As Panel
	Friend WithEvents lbl17 As Label
End Class
