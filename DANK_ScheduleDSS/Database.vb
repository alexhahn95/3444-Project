Imports System.Data.OleDb

'This class is used to interface with the database and fill the dataset
Public Class Database

    'Fields used to connect to the database
    Private DataAdapter As New OleDbDataAdapter
    Private DataConnection As New OleDbConnection
    Private ConnectionString As String
    Private DataSet As New DataSet
    Private Command As New OleDbCommand
    Private TableName As String

    'Default constructor
    Public Sub New()
    End Sub

    'Fills the dataset with data from the database
    Public Sub RunSql(ConnectionString, ProjSQL, DataSet, tableName)
        DataConnection.ConnectionString = ConnectionString

        Command = DataConnection.CreateCommand()
        Command.CommandText = ProjSQL

        DataAdapter.SelectCommand = Command
        DataAdapter.Fill(DataSet, tableName)
    End Sub
End Class