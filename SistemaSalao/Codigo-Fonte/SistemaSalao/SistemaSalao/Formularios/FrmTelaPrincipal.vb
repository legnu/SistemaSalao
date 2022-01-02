Imports MySql.Data.MySqlClient

Public Class FrmTelaPrincipal


    Private Sub FrmTelaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menuPrincipal.BackColor = Color.FromArgb(209, 251, 241)

        lblUsuario.Text = nomeFuncionario
        lblEsp.Text = especialidade


        'RECUPERANDO DADOS DA GRID DE MOVIMENTOS
        ListarDadosMovimentos()
        ListarDadosServicos()

        'verificar niveis de permissão de usuários
        If especialidade = "Gerente" Then
            menuFunc.Enabled = True
            menuProdutos.Enabled = True
            menuPagamentos.Enabled = True
        End If


    End Sub


    Sub ListarDadosMovimentos()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM movimentacoes where data = curDate()"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            grid.DataSource = dt


            CalcularTotalEntradas()
            CalcularTotalSaidas()
            CalcularTotal()


            If grid.Rows.Count > 0 Then

            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub



    Sub ListarDadosServicos()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim data As String
            data = Now().ToString("yyyy-MM-dd")


            sql = "select * from agendamentos where data = '" & data & "' "
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            gridServicos.DataSource = dt

            CalcularTotalAgendamentoCancelado()
            CalcularTotalAgendamentoConcluido()
            CalcularTotalAgendamentoMarcado()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub






    'CALCULANDO OS TOTAIS

    Sub CalcularTotalEntradas()
        Dim valor As Decimal
        Dim linha As DataGridViewRow

        For Each linha In grid.Rows
            If linha.Cells(1).Value = "Entrada" Then
                valor = valor + linha.Cells(3).Value
            End If

        Next

        lblTotEntradas.Text = valor

    End Sub


    Sub CalcularTotalSaidas()
        Dim valor As Decimal
        Dim linha As DataGridViewRow

        For Each linha In grid.Rows
            If linha.Cells(1).Value = "Saída" Then
                valor = valor + linha.Cells(3).Value
            End If

        Next

        lblTotalSaidas.Text = valor

    End Sub





    Sub CalcularTotal()
        Dim total As Decimal
        total = lblTotEntradas.Text - lblTotalSaidas.Text
        'lblTotalDia.Text = Format(total, "R$ 00,00")
        lblTotalDia.Text = Format(total, "R$ 00.00")

        If lblTotalDia.Text < 0 Then
            lblTotalDia.ForeColor = Color.Red
        Else
            lblTotalDia.ForeColor = Color.DarkGreen
        End If

    End Sub






    'CALCULANDO OS TOTAIS DE AGENDAMENTOS

    Sub CalcularTotalAgendamentoMarcado()
        Dim valor As Integer
        Dim linha As DataGridViewRow

        For Each linha In gridServicos.Rows
            If linha.Cells(7).Value = "Marcado" Then
                valor = valor + 1
            End If

        Next

        lblAgMarcado.Text = valor

    End Sub


    Sub CalcularTotalAgendamentoConcluido()
        Dim valor As Integer
        Dim linha As DataGridViewRow

        For Each linha In gridServicos.Rows
            If linha.Cells(7).Value = "Concluído" Then
                valor = valor + 1
            End If

        Next

        lblAgConcluido.Text = valor

    End Sub


    Sub CalcularTotalAgendamentoCancelado()
        Dim valor As Integer
        Dim linha As DataGridViewRow

        For Each linha In gridServicos.Rows
            If linha.Cells(7).Value = "Cancelado" Then
                valor = valor + 1
            End If

        Next

        lblAgCancelado.Text = valor

    End Sub







    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub CadastroDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuProdutos.Click
        Dim form = New FrmCadProdutos
        form.ShowDialog()
    End Sub

    Private Sub EspecialidadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecialidadeToolStripMenuItem.Click
        Dim form = New FrmCadEspecialidades
        form.ShowDialog()
    End Sub

    Private Sub BtnAddCliente_Click(sender As Object, e As EventArgs) Handles btnAddCliente.Click
        Dim form = New FrmCadClientes
        form.ShowDialog()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menuFunc.Click
        Dim form = New FrmCadFuncionarios
        form.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim form = New FrmLogin
        Me.Hide()
        form.ShowDialog()
    End Sub

    Private Sub FrmTelaPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub FrmTelaPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ListarDadosMovimentos()
        ListarDadosServicos()


    End Sub

    Private Sub TimerData_Tick(sender As Object, e As EventArgs) Handles TimerData.Tick
        lblData.Text = Now().ToShortDateString
        lblHora.Text = Now().ToLongTimeString

    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Dim form = New FrmCadFornecedores
        form.ShowDialog()
    End Sub

    Private Sub ServiçosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiçosToolStripMenuItem1.Click
        Dim form = New FrmCadServicos
        form.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem1.Click
        Dim form = New RelProdutosFrm
        form.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim form = New RelClientesFrm
        form.ShowDialog()
    End Sub

    Private Sub NovaVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaVendaToolStripMenuItem.Click
        Dim form = New FrmVendas
        form.ShowDialog()
    End Sub

    Private Sub EntradasESaidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasESaidasToolStripMenuItem.Click
        Dim form = New FrmEntradasSaidas
        form.ShowDialog()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        Dim form = New FrmGastos
        form.ShowDialog()
    End Sub



    Private Sub PagamentosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles menuPagamentos.Click
        Dim form = New FrmPagamentos
        form.ShowDialog()
    End Sub

    Private Sub GastosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem1.Click
        Dim form = New RelGastosFrm
        form.ShowDialog()
    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.Click
        Dim form = New RelVendaFrm
        form.ShowDialog()
    End Sub

    Private Sub AgendamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendamentoToolStripMenuItem.Click
        Dim form = New FrmAgendamento
        form.ShowDialog()
    End Sub

    Private Sub CadastroDeHoráriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeHoráriosToolStripMenuItem.Click
        Dim form = New FrmCadHorarios
        form.ShowDialog()
    End Sub

    Private Sub ConsultaDosAgendamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDosAgendamentosToolStripMenuItem.Click
        Dim form = New FrmConsultarAgendamento
        form.ShowDialog()
    End Sub

    Private Sub QuadroDeHoráriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuadroDeHoráriosToolStripMenuItem.Click
        Dim form = New FrmQuadroHorarios
        form.ShowDialog()
    End Sub

    Private Sub ConsultaPorClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaPorClientesToolStripMenuItem.Click
        Dim form = New FrmConsultarAgClientes
        form.ShowDialog()
    End Sub

    Private Sub AgendamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AgendamentoToolStripMenuItem1.Click
        Dim form = New RelAgendamentoFrm
        form.ShowDialog()
    End Sub

    Private Sub AgendamentoPorStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgendamentoPorStatusToolStripMenuItem.Click
        Dim form = New RelAgendamentoStatusFrm
        form.ShowDialog()
    End Sub

    Private Sub btnHorarios_Click(sender As Object, e As EventArgs) Handles btnHorarios.Click
        Dim form = New FrmQuadroHorarios
        form.ShowDialog()
    End Sub

    Private Sub btnVenda_Click(sender As Object, e As EventArgs) Handles btnVenda.Click
        Dim form = New FrmVendas
        form.ShowDialog()
    End Sub

    Private Sub btnAgendamento_Click(sender As Object, e As EventArgs) Handles btnAgendamento.Click
        Dim form = New FrmConsultarAgClientes
        form.ShowDialog()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        Dim form = New FrmSobre
        form.ShowDialog()
    End Sub


End Class