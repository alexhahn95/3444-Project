Public Class ObjectCreator

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

        '*******************************IMPORTANT: READ THIS *******************************
        'This is the section where you can select which classes are going to be added to the
        'dataset and therefore which ones will be pulled for optimization. You may pull an
        'entire department or a paticular course from a departmnet by using either version
        'of the overloaded PopulateDataSet method. Because of Solver limitations, you may run
        'into a licensing exception, in which case you need to reduce the amount of classes
        'that are in the dataset. This feature will be added to the UI for the next deliverable/
        'submission.

        'Also populates CourseList
        PopulateDataSet("ACIS")
        PopulateDataSet("BIT", 2405)
        'PopulateDataSet("CS")
        'PopulateDataSet("ECON")
        'PopulateDataSet("ENGL")
        'PopulateDataSet("FIN")
        'PopulateDataSet("MATH")
        'PopulateDataSet("MGT")
        'PopulateDataSet("MKTG")

        PopulateCourseList()

        'Creates Sections
        Sections = New String() {"Evening", "Morning", "TuesThurs", "MonWedFri", "MonWed"}

        'Initializes Course Offerings Paramater 2D array
        CourseOfferings = New Integer(CourseList.Count - 1, PeriodCount - 1) {}

        'Updates values for totals in the CourseList
        For CourseIndex = 0 To CourseList.Count - 1
            CourseList.ElementAt(CourseIndex).UpdateCourseOfferings(CourseOfferings, CourseIndex)
        Next

    End Sub

    Public Sub PopulateCourseList()
        For rowNum As Integer = 0 To DataSet.Tables(tableName).Rows.Count - 1
            Dim Course As New Course With {
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

            Course.UpdateStartAndEndIndicies()
            CourseList.Add(Course)
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

End Class


