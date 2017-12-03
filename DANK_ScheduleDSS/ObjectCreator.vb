Public Class ObjectCreator

    Public Property AbstractCourseList As New List(Of AbstractCourse)
    Public Property WeightList As New List(Of Weight)
    Public Property ReferenceList As New List(Of DiscreteCourse)
    Public Sections() As String
    Public DiscreteCourseOfferings(,) As Integer
    Public Property PeriodCount As Integer = 845

    Public Database As New Database
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Fall2017Classes.accdb"
    Public ProjSQL As String
    Public DataSet As New DataSet

    Public discreteTable As String = "Classes"
    Public abstractionTable As String = "CourseAbstraction"

    Public Sub CreateObjects()

        PopulateAbstractCourseList()
        PopulateReferenceList(AbstractCourseList)

        'Creates Sections
        Sections = New String() {"Evening", "Morning", "TuesThurs", "MonWedFri", "MonWed"}

        'Initializes AbstractCourse Offerings Paramater 2D array
        DiscreteCourseOfferings = New Integer(ReferenceList.Count - 1, PeriodCount - 1) {}

        'Updates values for totals in the AbstractCourseList
        For courseindex = 0 To ReferenceList.Count - 1
            ReferenceList.ElementAt(courseindex).UpdateCourseOfferings(DiscreteCourseOfferings, courseindex)
        Next

    End Sub

    Public Sub PopulateAbstractCourseList()
        For rowNum As Integer = 0 To DataSet.Tables(abstractionTable).Rows.Count - 1
            Dim AbstractCourse As New AbstractCourse With {
                    .Department = DataSet.Tables(abstractionTable).Rows(rowNum)("Department"),
                    .CourseNumber = DataSet.Tables(abstractionTable).Rows(rowNum)("CourseNumber")
                }

            AbstractCourse.DiscreteCourseList = CreateDiscreteCourseList(AbstractCourse)
            AbstractCourseList.Add(AbstractCourse)
        Next
    End Sub

    Public Function CreateDiscreteCourseList(AbstractCourse As AbstractCourse)
        Dim DiscreteCourseList As New List(Of DiscreteCourse)
        Dim DiscreteCourse As DiscreteCourse
        For rowNum As Integer = 0 To CalculateNumOfDiscreteCourses(AbstractCourse) - 1
            DiscreteCourse = New DiscreteCourse With {
                .CRN = DataSet.Tables(discreteTable).Rows(rowNum)("CRN"),
                .Department = DataSet.Tables(discreteTable).Rows(rowNum)("Department"),
                .Title = DataSet.Tables(discreteTable).Rows(rowNum)("Title"),
                .Instructor = DataSet.Tables(discreteTable).Rows(rowNum)("Instructor"),
                .Days = DataSet.Tables(discreteTable).Rows(rowNum)("Days"),
                .BeginTime = DataSet.Tables(discreteTable).Rows(rowNum)("Begin"),
                .EndTime = DataSet.Tables(discreteTable).Rows(rowNum)("End"),
                .Location = DataSet.Tables(discreteTable).Rows(rowNum)("Location"),
                .CourseNumber = DataSet.Tables(discreteTable).Rows(rowNum)("CourseNumber")
            }
            DiscreteCourse.UpdateStartAndEndIndicies()
            DiscreteCourseList.Add(DiscreteCourse)
        Next
        Return DiscreteCourseList
    End Function

    Private Function CalculateNumOfDiscreteCourses(AbstractCourse As AbstractCourse)
        Dim NumOfDiscreteCourses As Integer = 0
        For Each Row As DataRow In DataSet.Tables(discreteTable).Rows
            If AbstractCourse.Department = Row.ItemArray(2) And AbstractCourse.CourseNumber = Row.ItemArray(3) Then
                NumOfDiscreteCourses = NumOfDiscreteCourses + 1
            End If
        Next
        Return NumOfDiscreteCourses
    End Function

    Public Sub PopulateReferenceList(AbstractList As List(Of AbstractCourse))
        For Each AbstractCourse As AbstractCourse In AbstractCourseList
            For Each DiscreteCourse As DiscreteCourse In AbstractCourse.DiscreteCourseList
                ReferenceList.Add(DiscreteCourse)
            Next
        Next
    End Sub



    Public Sub PopulateDiscreteDataSet(Department As String, CourseNumber As Integer)
        ProjSQL = "SELECT * FROM " & discreteTable & " WHERE Department = "
        Dim FormattedDepartmentAndCourse As String = "'" & Department & "'" & " AND CourseNumber = " & CourseNumber
        ProjSQL = ProjSQL + FormattedDepartmentAndCourse
        Database.RunSql(ConnectionString, ProjSQL, DataSet, discreteTable)
    End Sub


    Public Sub PopulateDiscreteDataSet(Department As String)
        ProjSQL = "SELECT * FROM " & discreteTable & " WHERE Department = "
        Dim FormattedDepartment As String = "'" & Department & "'"
        ProjSQL = ProjSQL + FormattedDepartment
        Database.RunSql(ConnectionString, ProjSQL, DataSet, discreteTable)
    End Sub

    Public Sub PopulateAbstractTableDataSet(Department As String, CourseNumber As Integer)
        ProjSQL = "SELECT * FROM CourseAbstraction" & " WHERE Department = "
        Dim FormattedDepartmentAndCourse As String = "'" & Department & "'" & " AND CourseNumber = " & CourseNumber
        ProjSQL = ProjSQL + FormattedDepartmentAndCourse
        Database.RunSql(ConnectionString, ProjSQL, DataSet, abstractionTable)
    End Sub

End Class


