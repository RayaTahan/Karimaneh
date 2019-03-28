Imports System.Data.SQLite

Public NotInheritable Class SQLiter
    Private Shared password As String = "I.R.Iran.RT57dP"
    ' میتونی از رمز دیگه ای برای محافظت از داده ها استفاده کنی

    Private Shared con As New SQLiteConnection($"{AppMan.ConnectionString}Password={password};", True)
    Private Shared Cmd As New SQLiteCommand("", con)
    Private Shared DA As New SQLiteDataAdapter("", con)


    Public Shared Sub CreateFile(Name As String)
        SQLiteConnection.CreateFile("data/" & Name)
        con.SetPassword(password)
    End Sub

    Public Shared Function RunCommand(ByVal CommandText As String) As Integer
        Dim tmp As Integer
        If con.State <> ConnectionState.Open Then con.Open()
        Cmd.CommandText = CommandText
        tmp = Cmd.ExecuteNonQuery()

        If con.Changes > 0 Then SabteZamaneTaqir()
        con.Close()
        Return tmp
    End Function

    Public Shared Function RunCommand(ByVal CommandText As String, ByVal Parametrs() As SQLiteParameter) As Integer
        Dim tmp As Integer
        If con.State <> ConnectionState.Open Then con.Open()
        Cmd = con.CreateCommand
        Cmd.Parameters.Clear()
        Cmd.CommandText = CommandText
        Cmd.Parameters.AddRange(Parametrs)

        tmp = Cmd.ExecuteNonQuery()

        If Parametrs.Count = 2 And Parametrs(0).Value = "ZamaneAkharinTaqir" Then
        Else
            If con.Changes > 0 Then SabteZamaneTaqir()
        End If
        con.Close()
        Return tmp
    End Function

    Public Shared Function RunCommandScaler(ByVal CommandText As String) As String
        Dim tmp As String
        If con.State <> ConnectionState.Open Then con.Open()
        Cmd.CommandText = CommandText
        tmp = ""

        Try
            tmp = Cmd.ExecuteScalar().ToString
        Catch ex As Exception
            tmp = ""
        End Try


        If con.Changes > 0 Then SabteZamaneTaqir()
        con.Close()
        Return tmp
    End Function

    Public Shared Function RunCommandScaler(ByVal CommandText As String, ByVal Parametrs() As SQLiteParameter) As String
        Dim tmp As String
        Try
            con.Close()
        Catch ex As Exception

        End Try
        If con.State <> ConnectionState.Open Then con.Open()
        Cmd = con.CreateCommand
        Cmd.Parameters.Clear()
        Cmd.CommandText = CommandText
        Cmd.Parameters.AddRange(Parametrs)

        Try
            tmp = Cmd.ExecuteScalar().ToString
        Catch ex As Exception
            tmp = ""
        End Try


        If con.Changes > 0 Then SabteZamaneTaqir()
        con.Close()
        Return tmp
    End Function

    Public Shared Function Fill(CommandText As String) As DataTable
        Dim tmp As New DataTable
        DA.SelectCommand.CommandText = CommandText
        DA.Fill(tmp)

        If HasIUD(CommandText) Then SabteZamaneTaqir()
        Return tmp
    End Function

    Public Shared Function Fill(CommandText As String, ByVal Parametrs() As SQLiteParameter) As DataTable
        Dim tmp As New DataTable
        DA.SelectCommand = con.CreateCommand
        DA.SelectCommand.CommandText = CommandText
        DA.SelectCommand.Parameters.Clear()
        DA.SelectCommand.Parameters.AddRange(Parametrs)
        DA.Fill(tmp)

        If HasIUD(CommandText) Then SabteZamaneTaqir()
        Return tmp
    End Function

    Public Shared Sub Fill(ByRef DataSet As DataSet, ByVal TableName As String, ByVal CommandText As String)
        DA.SelectCommand.CommandText = CommandText
        If DataSet.Tables.Contains(TableName) Then
            DataSet.Tables.Remove(TableName)
        End If
        DA.Fill(DataSet, TableName)

        If HasIUD(CommandText) Then SabteZamaneTaqir()
    End Sub

    Public Shared Sub Fill(ByRef DataSet As DataSet, ByVal TableName As String, ByVal CommandText As String, ByVal Parametrs() As SQLiteParameter)
        DA.SelectCommand = con.CreateCommand
        DA.SelectCommand.CommandText = CommandText
        DA.SelectCommand.Parameters.Clear()
        DA.SelectCommand.Parameters.AddRange(Parametrs)
        If DataSet.Tables.Contains(TableName) Then
            DataSet.Tables.Remove(TableName)
        End If
        DA.Fill(DataSet, TableName)

        If HasIUD(CommandText) Then SabteZamaneTaqir()
    End Sub

    Private Shared Sub SabteZamaneTaqir()
        AppMan.Tanzimat("ZamaneAkharinTaqir") = $"{AppMan.AlanTarikh}-{AppMan.AlanSaat}"
    End Sub

    Private Shared Function HasIUD(Command As String) As Boolean
        Command = Command.ToLower
        Dim iud = {"insert ", "update ", "delete "}
        For Each s In iud
            If Command.Contains(s) Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
