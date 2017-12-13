Imports System.Text.RegularExpressions

'Represents a paticular course that a student can enroll into.
Public Class DiscreteCourse

    'Fields with information about the course
    Public Property CRN As Integer
    Public Property Department As String
    Public Property CourseNumber As Integer
    Public Property Title As String
    Public Property Instructor As String
    Public Property Days As String
    Public Property BeginTime As String
    Public Property EndTime As String
    Public Property Location As String

    'Amount of 5 minute blocks their are between 8am and 10pm for a day
    Private DayAmtOfIndicies As Integer = 169

    'Contains DayAmtOfIndicies initialized to 0. Will hold 1s if the course is during that time period of the day
    Public Property StartAndEndIndicies As String()

    'The first and last indicies for a course
    Private startIndex As Integer
    Private endIndex As Integer

    'Used for parsing out the time strings
    Private PM As Regex
    Private AM As Regex

    'Tolds information for the total amount of indicies for a given section
    Public Totals() As Integer

    'Constructor
    Public Sub New()
        Totals = New Integer() {0, 0, 0, 0, 0}
    End Sub

    'Sets indicies for a course
    Public Sub UpdateStartAndEndIndicies()
        PM = New Regex("([PM])\w+")
        AM = New Regex("([AM])\w+")

        IndiciesHelper(BeginTime, startIndex)
        IndiciesHelper(EndTime, endIndex)

    End Sub

    'Helper for setting indicies for a course
    Private Sub IndiciesHelper(BeginOrEndTime As String, ByRef Index As Integer)
        Dim TimeArray() As String

        If PM.Matches(BeginOrEndTime).Count > 0 Then
            TimeArray = PM.Replace(BeginOrEndTime, "").Split(":")
            If TimeArray(0) <> 12 Then
                TimeArray(0) = TimeArray(0) + 12
            End If
            Index = ((TimeArray(0) - 8) * 12 + TimeArray(1) / 5)
        ElseIf AM.Matches(BeginOrEndTime).Count > 0 Then
            TimeArray = AM.Replace(BeginOrEndTime, "").Split(":")
            Index = ((TimeArray(0) - 8) * 12 + TimeArray(1) / 5)
        Else
            Throw New Exception(message:="Invalid Time")
        End If

    End Sub

    'Populates the totals array
    Public Sub UpdateCourseOfferings(ByRef DiscreteCourseOfferings(,) As Integer, CourseIndex As Integer)
        UpdateCourseOfferingsDaysOfWeek(DiscreteCourseOfferings, CourseIndex)
        UpdateCourseTotalsDaysOfWeek()
        UpdateCourseTotalsTimeOfDay(DiscreteCourseOfferings, CourseIndex)
    End Sub

    'Populates the sections for days of the week
    Private Sub UpdateCourseOfferingsDaysOfWeek(ByRef DiscreteCourseOfferings(,) As Integer, CourseIndex As Integer)
        Select Case Days
            Case "T R"
                DaysOfWeekHelper(DiscreteCourseOfferings, CourseIndex, 1)
                DaysOfWeekHelper(DiscreteCourseOfferings, CourseIndex, 3)
            Case "M W"
                DaysOfWeekHelper(DiscreteCourseOfferings, CourseIndex, 0)
                DaysOfWeekHelper(DiscreteCourseOfferings, CourseIndex, 2)
            Case "M W F"
                DaysOfWeekHelper(DiscreteCourseOfferings, CourseIndex, 0)
                DaysOfWeekHelper(DiscreteCourseOfferings, CourseIndex, 2)
                DaysOfWeekHelper(DiscreteCourseOfferings, CourseIndex, 4)
            Case Else
                Throw New Exception(message:="Invalid Days")
        End Select
    End Sub

    'Helper sub for updating days of the week sections
    Private Sub DaysOfWeekHelper(ByRef DiscreteCourseOfferings(,) As Integer, CourseIndex As Integer, Day As Integer)
        For i = 0 To 168
            If i >= startIndex And i < endIndex Then
                DiscreteCourseOfferings(CourseIndex, i + DayAmtOfIndicies * Day) = 1
            End If
        Next
    End Sub

    'Updates days of the week of totals
    Public Sub UpdateCourseTotalsDaysOfWeek()
        Select Case Days
            Case "T R"
                Totals(2) = 2 * (endIndex - startIndex)
            Case "M W F"
                Totals(3) = 3 * (endIndex - startIndex)
            Case "M W"
                Totals(4) = 2 * (endIndex - startIndex)
            Case Else
                Throw New Exception(message:="Invalid Days")
        End Select
    End Sub

    'Updates time of day section of totals
    Private Sub UpdateCourseTotalsTimeOfDay(ByRef DiscreteCourseOfferings(,) As Integer, CourseIndex As Integer)
        'Monday Morning
        For i = 0 To 47
            Totals(1) = DiscreteCourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Monday Evening
        For i = 48 To 168
            Totals(0) = DiscreteCourseOfferings(CourseIndex, i) + Totals(0)
        Next

        'Tuesday Morning
        For i = 169 To 216
            Totals(1) = DiscreteCourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Tuesday Evening
        For i = 217 To 337
            Totals(0) = DiscreteCourseOfferings(CourseIndex, i) + Totals(0)
        Next

        'Wednesday Morning
        For i = 338 To 385
            Totals(1) = DiscreteCourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Wednesday Evening
        For i = 386 To 506
            Totals(0) = DiscreteCourseOfferings(CourseIndex, i) + Totals(0)
        Next

        'Thursday Morning
        For i = 507 To 554
            Totals(1) = DiscreteCourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Thursday Evening
        For i = 555 To 675
            Totals(0) = DiscreteCourseOfferings(CourseIndex, i) + Totals(0)
        Next

        'Friday Morning
        For i = 676 To 723
            Totals(1) = DiscreteCourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Friday Evening
        For i = 724 To 844
            Totals(0) = DiscreteCourseOfferings(CourseIndex, i) + Totals(0)
        Next
    End Sub

    'Returns string representation of the course
    Public Function ToStringy()
        Dim sp As String = " " 'space
        Return CRN.ToString + sp + Department + sp + CourseNumber.ToString + sp + Title + sp + Instructor + sp + Days + sp + BeginTime + sp + EndTime + sp + Location
    End Function

End Class