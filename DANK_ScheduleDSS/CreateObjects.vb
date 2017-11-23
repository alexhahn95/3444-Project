Imports System.Text.RegularExpressions

Public Class CreateObjects

    'TODO: Update comments
    Public Property CourseList As New List(Of Course)
    Public Property WeightList As New List(Of Weight)
    Public Sections() As String
    Public CourseOfferings(,) As Integer
    Public Property PeriodCount As Integer = 845

    Public Database As New Database
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Fall2017Classes.accdb"
    Public ProjSQL As String
    Public DataSet As New DataSet
    Public DayAmtOfIndicies As Integer = 169
    Public tableName As String = "Classes"

    Public Sub CreateObjects()

        PopulateDataSet("ECON", 3104)
        'PopulateDataSet("BIT", 3444)
        'PopulateDataSet("BIT", 2406)
        'PopulateDataSet("CS", 2505)
        'PopulateDataSet("MATH", 2534)
        ActuallyCreateObjects()

        'Creates Sections
        'TODO change to enum implementation
        Sections = New String() {"Evening", "Morning", "TuesThurs", "MonWedFri", "MonWed"}

        'Initializes Course Offerings Paramater 2D array
        CourseOfferings = New Integer(CourseList.Count - 1, PeriodCount - 1) {}

        'WORST CODE ALEX HAS EVER WRITTEN. SO UGLY. WHY DID I EVEN READ THAT CLEAN CODE BOOK???
        Dim PM As Regex
        Dim AM As Regex
        Dim startIndex As Integer
        Dim endIndex As Integer
        Dim time As String()
        Dim iter As Integer = 0 'Iterates over course indicies for CourseOffering array assignments


        For Each course As Course In CourseList
            course.CalculateStartAndEndIndicies1()

            Select Case course.Days
                Case "T R"
                    For i = 0 To 168
                        If i >= startIndex And i < endIndex Then
                            CourseOfferings(iter, i + DayAmtOfIndicies) = 1
                        End If

                        If i >= startIndex And i < endIndex Then
                            CourseOfferings(iter, i + DayAmtOfIndicies + DayAmtOfIndicies + DayAmtOfIndicies) = 1
                        End If
                    Next
                Case "M W"
                    For i = 0 To 168
                        If i >= startIndex And i < endIndex Then
                            CourseOfferings(iter, i) = 1
                        End If

                        If i >= startIndex And i < endIndex Then
                            CourseOfferings(iter, i + DayAmtOfIndicies + DayAmtOfIndicies) = 1
                        End If
                    Next
                Case "M W F"
                    For i = 0 To 168
                        If i >= startIndex And i < endIndex Then
                            CourseOfferings(iter, i) = 1
                        End If

                        If i >= startIndex And i < endIndex Then
                            CourseOfferings(iter, i + DayAmtOfIndicies + DayAmtOfIndicies) = 1
                        End If

                        If i >= startIndex And i < endIndex Then
                            CourseOfferings(iter, i + DayAmtOfIndicies + DayAmtOfIndicies + DayAmtOfIndicies + DayAmtOfIndicies) = 1
                        End If
                    Next

            End Select

            Select Case course.Days
                Case "T R"
                    course.Totals(2) = 2 * (endIndex - startIndex)
                Case "M W F"
                    course.Totals(3) = 3 * (endIndex - startIndex)
                Case "M W"
                    course.Totals(4) = 2 * (endIndex - startIndex)
            End Select

            'TIME OF DAY TOTALS
            'Monday Morning
            For i = 0 To 47
                course.Totals(1) = CourseOfferings(iter, i) + course.Totals(1)
            Next

            'Monday Evening
            For i = 48 To 168
                course.Totals(0) = CourseOfferings(iter, i) + course.Totals(0)
            Next

            'Tuesday Morning
            For i = 169 To 216
                course.Totals(1) = CourseOfferings(iter, i) + course.Totals(1)
            Next

            'Tuesday Evening
            For i = 217 To 337
                course.Totals(0) = CourseOfferings(iter, i) + course.Totals(0)
            Next

            'Wednesday Morning
            For i = 338 To 385
                course.Totals(1) = CourseOfferings(iter, i) + course.Totals(1)
            Next

            'Wednesday Evening
            For i = 386 To 506
                course.Totals(0) = CourseOfferings(iter, i) + course.Totals(0)
            Next

            'Thursday Morning
            For i = 507 To 554
                course.Totals(1) = CourseOfferings(iter, i) + course.Totals(1)
            Next

            'Thursday Evening
            For i = 555 To 675
                course.Totals(0) = CourseOfferings(iter, i) + course.Totals(0)
            Next

            'Friday Morning
            For i = 676 To 723
                course.Totals(1) = CourseOfferings(iter, i) + course.Totals(1)
            Next

            'Friday Evening
            For i = 724 To 844
                course.Totals(0) = CourseOfferings(iter, i) + course.Totals(0)
            Next

            iter = iter + 1

        Next

    End Sub

    'Rename? LOL
    Public Sub ActuallyCreateObjects()
        For rowNum As Integer = 0 To DataSet.Tables(tableName).Rows.Count - 1
            Dim Course As New Course With {
                .CRN = DataSet.Tables(Me.tableName).Rows(rowNum)("CRN"),
                .Department = DataSet.Tables(Me.tableName).Rows(rowNum)("Department"),
                .Title = DataSet.Tables(Me.tableName).Rows(rowNum)("Title"),
                .Instructor = DataSet.Tables(Me.tableName).Rows(rowNum)("Instructor"),
                .Days = DataSet.Tables(Me.tableName).Rows(rowNum)("Days"),
                .BeginTime = DataSet.Tables(Me.tableName).Rows(rowNum)("Begin"),
                .EndTime = DataSet.Tables(Me.tableName).Rows(rowNum)("End"),
                .Location = DataSet.Tables(Me.tableName).Rows(rowNum)("Location"),
                .CourseNumber = DataSet.Tables(Me.tableName).Rows(rowNum)("CourseNumber")
            }

            CourseList.Add(Course)
        Next
    End Sub

    Public Sub PopulateDataSet(Department As String, CourseNumber As Integer)
        ProjSQL = "SELECT * FROM " & tableName & " WHERE Department = "
        Dim FormattedDepartment As String = "'" & Department & "'" & " AND CourseNumber = " & CourseNumber
        ProjSQL = ProjSQL + FormattedDepartment

        Database.RunSql(ConnectionString, ProjSQL, DataSet, tableName)
    End Sub

    Public Sub PopulateDataSet(Department As String)
        ProjSQL = "SELECT * FROM " & tableName & " WHERE Department = "
        Dim FormattedDepartment As String = "'" & Department & "'"
        ProjSQL = ProjSQL + FormattedDepartment

        Database.RunSql(ConnectionString, ProjSQL, DataSet, tableName)
    End Sub

End Class


