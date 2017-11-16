Public Class CreateObjects

    'TODO: Update comments
    Public CourseList As New List(Of Course)
    Public WeightList As New List(Of Weight)
    Public SectionList As New List(Of Section)
    Public PeriodList As New List(Of Period)
    Public DeviationContainerList As New List(Of DeviationContainer)
    Public GoalList As New List(Of Goal)

    Public Database As New Database
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Fall2017Classes.accdb"
    Public ProjSQL As String
    Public DataSet As New DataSet

    Public Sub CreateObjects()
        'First, we get the table in the dataset updated
        Dim tableName As String = "Classes"
        ProjSQL = "SELECT * FROM " & tableName
        Database.RunSql(ConnectionString, ProjSQL, DataSet, tableName)

        'Next we transfer data from the table to objects
        For rowNum As Integer = 0 To DataSet.Tables(tableName).Rows.Count - 1
            Dim Course As New Course With {
                .CRN = DataSet.Tables(tableName).Rows(rowNum)("CRN ?"),
                .Department = DataSet.Tables(tableName).Rows(rowNum)("Department"),
                .Title = DataSet.Tables(tableName).Rows(rowNum)("Title"),
                .Instructor = DataSet.Tables(tableName).Rows(rowNum)("Instructor"),
                .Days = DataSet.Tables(tableName).Rows(rowNum)("Days ?"),
                .Begin = DataSet.Tables(tableName).Rows(rowNum)("Begin"),
                .EndInst = DataSet.Tables(tableName).Rows(rowNum)("End"),
                .Location = DataSet.Tables(tableName).Rows(rowNum)("Location ?")
            }
            CourseList.Add(Course)
            rowNum = rowNum + 1
        Next

        'Creates Sections
        Dim evening As New Section() With {.Section = "evening"}
        Dim morning As New Section() With {.Section = "morning"}
        Dim tuesThurs As New Section() With {.Section = "tuesThurs"}
        Dim monWedFri As New Section() With {.Section = "monWedFri"}
        Dim monWed As New Section() With {.Section = "monWed"}

        SectionList.Add(evening)
        SectionList.Add(morning)
        SectionList.Add(tuesThurs)
        SectionList.Add(monWedFri)
        SectionList.Add(monWed)

        'Creates Periods
        Dim period
        For i As Integer = 1 To 20
            period = New Period With {.Period = i}
            PeriodList.Add(period)
        Next

        'Creates DeviationContainers
        For Each section As Section In SectionList
            Dim deviationContainerInstance As New DeviationContainer() With {
                .Section = section,
                .Performance = 0,
                .Deviation = 0,
                .Goal = 5
            }
            DeviationContainerList.Add(deviationContainerInstance)
        Next



    End Sub

    Public Sub Query()
        'TODO This is for creating queries for certian criteria on the client

    End Sub

End Class

'.CourseName = DataSet.Tables(tableName).Rows(rowNum)("Course"),
