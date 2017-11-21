Imports System.Text.RegularExpressions

Public Class CreateObjects

    'TODO: Update comments
    Public Property CourseList As New List(Of Course)
    Public Property WeightList As New List(Of Weight)
    Public Sections() As String
    Public CourseOfferings(,) As Integer
    Public Property PeriodCount As Integer = 839

    Public Database As New Database
    Public ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Fall2017Classes.accdb"
    Public ProjSQL As String
    Public DataSet As New DataSet
    Public DayAmtOfIndicies As Integer = 169
    Public tableName As String = "Classes"


    Public Sub CreateObjects()

        PopulateDataSet("CS", 2114)
        ActuallyCreateObjects()

        'Next we transfer data from the table to objects

        ProjSQL = "SELECT * FROM " & tableName & " WHERE Department = 'CS'"
        Database.RunSql(ConnectionString, ProjSQL, DataSet, tableName)

        'Creates Sections
        'TODO change to enum implementation
        Sections = New String() {"Evening", "Morning", "TuesThurs", "MonWedFri", "MonWed"}

        'Initializes Course Offerings Paramater 2D array
        CourseOfferings = New Integer(CourseList.Count - 1, PeriodCount - 1) {}

        'WORST CODE ALEX HAS EVER WRITTEN. SO FUCKING UGLY. WHY DID I EVEN READ THAT CLEAN CODE BOOK???
        Dim PM As Regex
        Dim AM As Regex
        Dim startIndex As Integer
        Dim endIndex As Integer
        Dim time As String()
        Dim iter As Integer = 0 'Iterates over course indicies for CourseOffering array assignments 
        For Each course As Course In CourseList
            PM = New Regex("([PM])\w+")
            AM = New Regex("([AM])\w+")
            'Consider refactor
            If PM.Matches(course.Begin).Count > 0 Then
                time = PM.Replace(course.Begin, "").Split(":")
                If time(0) <> 12 Then
                    time(0) = time(0) + 12
                End If
                startIndex = ((time(0) - 8) * 12 + time(1) / 5)
            ElseIf AM.Matches(course.Begin).Count > 0 Then
                time = AM.Replace(course.Begin, "").Split(":")
                startIndex = ((time(0) - 8) * 12 + time(1) / 5)
            Else
                Throw New Exception()
            End If

            If PM.Matches(course.EndInst).Count > 0 Then
                time = PM.Replace(course.EndInst, "").Split(":")
                If time(0) <> 12 Then
                    time(0) = time(0) + 12
                End If
                endIndex = ((time(0) - 8) * 12 + time(1) / 5)
            ElseIf AM.Matches(course.EndInst).Count > 0 Then
                time = AM.Replace(course.EndInst, "").Split(":")
                endIndex = ((time(0) - 8) * 12 + time(1) / 5)
            Else
                Throw New Exception()
            End If

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

            For i = 0 To 168
                If i >= startIndex And i < endIndex Then
                    CourseOfferings(iter, i) = 1
                End If

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
                .Begin = DataSet.Tables(Me.tableName).Rows(rowNum)("Begin"),
                .EndInst = DataSet.Tables(Me.tableName).Rows(rowNum)("End"),
                .Location = DataSet.Tables(Me.tableName).Rows(rowNum)("Location ?"),
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

End Class


