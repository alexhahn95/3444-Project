Imports System.Data.OleDb

Public Class Database
    Dim SQL As String

    Private DataAdapter As New OleDbDataAdapter
    Private DataConnection As New OleDbConnection
    Private ConnectionString As String
    Private DataSet As New DataSet
    Private Command As New OleDbCommand
    Private TableName As String

    Public Sub New()
    End Sub

    Public Sub RunSql(ConnectionString, ProjSQL, DataSet, tableName)
        DataConnection.ConnectionString = ConnectionString

        Command = DataConnection.CreateCommand()
        Command.CommandText = ProjSQL

        DataAdapter.SelectCommand = Command
        DataAdapter.Fill(DataSet, tableName)
    End Sub
End Class