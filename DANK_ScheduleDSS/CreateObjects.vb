Public Class CreateObjects

    'TODO: Update comments
    Public EnrollmentList As List(Of Enrollment)
    Public WeightList As List(Of Weight)

    Public Database As New Database
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Fall2017Classes.accdb"
    Public ProjSQL As String
    Public DataSet As New DataSet

    Public Sub MakeObjects()
        'First, we get the table in the dataset updated
        Dim tableName As String = "Enrollment"
        ProjSQL = "SELECT * FROM " & tableName
        Database.RunSql(ConnectionString, ProjSQL, DataSet, tableName)
        'Next we transfer data from the table to objects
        For rowNum As Integer = 0 To DataSet.Tables(tableName).Rows.Count - 1
            Dim Enrollment As New Enrollment
            Enrollment.Name = DataSet.Tables(tableName).Rows(rowNum)("Name")
            Enrollment.Enrollment = DataSet.Tables(tableName).Rows(rowNum)("Enrollment")
            EnrollmentList.Add(Enrollment)
        Next

        'First, we get the table in the dataset updated
        tableName = "Weight"
        ProjSQL = "SELECT * FROM " & tableName
        Database.RunSql(ConnectionString, ProjSQL, DataSet, tableName)
        'Next we transfer data from the table to objects
        For rowNum As Integer = 0 To DataSet.Tables(tableName).Rows.Count - 1
            Dim Weight As New Weight
            Weight.Section = DataSet.Tables(tableName).Rows(rowNum)("Section")
            Weight.PositiveDeviation = DataSet.Tables(tableName).Rows(rowNum)("Positive Deviation")
            Weight.NegativeDeviation = DataSet.Tables(tableName).Rows(rowNum)("Negative Deviation")
            WeightList.Add(Weight)
        Next

    End Sub
    Public Sub Query()
        'TODO This is for creating queries for certian criteria on the client
    End Sub

End Class
