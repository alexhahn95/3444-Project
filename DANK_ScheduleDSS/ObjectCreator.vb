Public Class ObjectCreator

    Public Property SpecificCourseList As List(Of SpecificCourse)
    Public Property CourseList As New List(Of Course)
    Public Property WeightList As New List(Of Weight)
    Public Sections() As String
    Public CourseOfferings(,) As Integer
    Public Property PeriodCount As Integer = 845

    Public Database As New Database
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Fall2017Classes.accdb"
    Public ProjSQL As String
    Public DataSet As New DataSet

    Public tableName As String = "Classes"

    Public Sub CreateObjects()

        PopulateCourseList()
        PopulateSpecificCourseList()

        'Creates Sections
        Sections = New String() {"Evening", "Morning", "TuesThurs", "MonWedFri", "MonWed"}

        'Initializes Course Offerings Paramater 2D array
        CourseOfferings = New Integer(SpecificCourseList.Count - 1, PeriodCount - 1) {}

        'Updates values for totals in the CourseList
        For CourseIndex = 0 To SpecificCourseList.Count - 1
            SpecificCourseList.ElementAt(CourseIndex).UpdateCourseOfferings(CourseOfferings, CourseIndex)
        Next

    End Sub

    Public Sub PopulateCourseList()
        For rowNum As Integer = 0 To DataSet.Tables("Distinct").Rows.Count - 1
            Dim Course As New Course With {
                    .Department = DataSet.Tables("Distinct").Rows(rowNum)("Department"),
                    .CourseNumber = DataSet.Tables("Distinct").Rows(rowNum)("CourseNumber")
                }
            SpecificCourseList = New List(Of SpecificCourse)

            For numOfSpecificCourse = 0 To CalculateNumOfSpecificCourse(Course)

            Next
            Course.SpecificCourseList = SpecificCourseList
                CourseList.Add(Course)
            Next
    End Sub

    Function CalculateNumOfSpecificCourse(Course As Course)
        Dim SpecificCourseCount As Integer = 0
        For Each Row As DataGridViewRow In DataSet.Tables(tableName).Rows
            'If Course.Department = Row.Cells() Then
            Dim h As Integer = 5
        Next
        Return 5
    End Function

    Public Sub PopulateSpecificCourseList()
        For rowNum As Integer = 0 To DataSet.Tables(tableName).Rows.Count - 1
            Dim SpecificCourse As New SpecificCourse With {
                .CRN = DataSet.Tables(tableName).Rows(rowNum)("CRN"),
                .Department = DataSet.Tables(tableName).Rows(rowNum)("Department"),
                .Title = DataSet.Tables(tableName).Rows(rowNum)("Title"),
                .Instructor = DataSet.Tables(tableName).Rows(rowNum)("Instructor"),
                .Days = DataSet.Tables(tableName).Rows(rowNum)("Days"),
                .BeginTime = DataSet.Tables(tableName).Rows(rowNum)("Begin"),
                .EndTime = DataSet.Tables(tableName).Rows(rowNum)("End"),
                .Location = DataSet.Tables(tableName).Rows(rowNum)("Location"),
                .CourseNumber = DataSet.Tables(tableName).Rows(rowNum)("CourseNumber")
            }

            SpecificCourse.UpdateStartAndEndIndicies()
        Next
    End Sub

    Public Sub PopulateDataSet(Department As String, CourseNumber As Integer)
        ProjSQL = "SELECT * FROM " & tableName & " WHERE Department = "
        Dim FormattedDepartmentAndCourse As String = "'" & Department & "'" & " AND CourseNumber = " & CourseNumber
        ProjSQL = ProjSQL + FormattedDepartmentAndCourse
        Database.RunSql(ConnectionString, ProjSQL, DataSet, tableName)
    End Sub


    Public Sub PopulateDataSet(Department As String)
        ProjSQL = "SELECT * FROM " & tableName & " WHERE Department = "
        Dim FormattedDepartment As String = "'" & Department & "'"
        ProjSQL = ProjSQL + FormattedDepartment
        Database.RunSql(ConnectionString, ProjSQL, DataSet, tableName)
    End Sub

    Public Sub PopulateDistinctTableDataSet()
        ProjSQL = "SELECT * FROM Distinct"
        Database.RunSql(ConnectionString, ProjSQL, DataSet, "Distinct")
    End Sub

End Class


