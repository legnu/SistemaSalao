﻿Imports MySql.Data.MySqlClient

Module Conexao

    Public con As New MySqlConnection("server=mysql796.umbler.com:41890; userid=legnu; password=peruca13; database=legnus; port=;")

    Sub Abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    Sub Fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub



    'DECLAÇÃO DE VARIAVEIS GLOBAIS
    Public nomeFuncionario As String
    Public especialidade As String
    Public nomeCliente As String

    Public nomeFuncAgendamento As String
    Public horarioAgendamento As String

    Public nomeClienteAgendamento As String



End Module
