Imports System.Text.RegularExpressions

Public Class Course

    Public Property CRN As Integer
    Public Property Department As String
    Public Property CourseNumber As Integer
    Public Property Title As String
    Public Property Instructor As String
    Public Property Days As String
    Public Property BeginTime As String
    Public Property EndTime As String
    Public Property Location As String

    Private DayAmtOfIndicies As Integer = 169

    Public Property StartAndEndIndicies As String()

    Private startIndex As Integer
    Private endIndex As Integer

    Private PM As Regex
    Private AM As Regex

    Public Totals() As Integer

    Dim Generator As Random

    Public Sub New()
        Totals = New Integer() {0, 0, 0, 0, 0}
    End Sub

    Public Sub UpdateStartAndEndIndicies()
        PM = New Regex("([PM])\w+")
        AM = New Regex("([AM])\w+")

        IndiciesHelper(BeginTime, startIndex)
        IndiciesHelper(EndTime, endIndex)

    End Sub

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
            'Make better exception
            Throw New Exception()
        End If

    End Sub

    Public Sub UpdateCourseOfferings(ByRef CourseOfferings(,) As Integer, CourseIndex As Integer)
        UpdateCourseOfferingsDaysOfWeek(CourseOfferings, CourseIndex)
        UpdateCourseTotalsDaysOfWeek()
        UpdateCourseTotalsTimeOfDay(CourseOfferings, CourseIndex)
    End Sub

    Private Sub UpdateCourseOfferingsDaysOfWeek(ByRef CourseOfferings(,) As Integer, CourseIndex As Integer)
        Select Case Days
            Case "T R"
                DaysOfWeekHelper(CourseOfferings, CourseIndex, 1)
                DaysOfWeekHelper(CourseOfferings, CourseIndex, 3)
            Case "M W"
                DaysOfWeekHelper(CourseOfferings, CourseIndex, 0)
                DaysOfWeekHelper(CourseOfferings, CourseIndex, 2)
            Case "M W F"
                DaysOfWeekHelper(CourseOfferings, CourseIndex, 0)
                DaysOfWeekHelper(CourseOfferings, CourseIndex, 2)
                DaysOfWeekHelper(CourseOfferings, CourseIndex, 4)
            Case Else
                Throw New Exception(message:="Invalid Days")
        End Select
    End Sub

    Private Sub DaysOfWeekHelper(ByRef CourseOfferings(,) As Integer, CourseIndex As Integer, Day As Integer)
        For i = 0 To 168
            If i >= startIndex And i < endIndex Then
                CourseOfferings(CourseIndex, i + DayAmtOfIndicies * Day) = 1
            End If
        Next
    End Sub

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

    Private Sub UpdateCourseTotalsTimeOfDay(ByRef CourseOfferings(,) As Integer, CourseIndex As Integer)
        'Monday Morning
        For i = 0 To 47
            Totals(1) = CourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Monday Evening
        For i = 48 To 168
            Totals(0) = CourseOfferings(CourseIndex, i) + Totals(0)
        Next

        'Tuesday Morning
        For i = 169 To 216
            Totals(1) = CourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Tuesday Evening
        For i = 217 To 337
            Totals(0) = CourseOfferings(CourseIndex, i) + Totals(0)
        Next

        'Wednesday Morning
        For i = 338 To 385
            Totals(1) = CourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Wednesday Evening
        For i = 386 To 506
            Totals(0) = CourseOfferings(CourseIndex, i) + Totals(0)
        Next

        'Thursday Morning
        For i = 507 To 554
            Totals(1) = CourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Thursday Evening
        For i = 555 To 675
            Totals(0) = CourseOfferings(CourseIndex, i) + Totals(0)
        Next

        'Friday Morning
        For i = 676 To 723
            Totals(1) = CourseOfferings(CourseIndex, i) + Totals(1)
        Next

        'Friday Evening
        For i = 724 To 844
            Totals(0) = CourseOfferings(CourseIndex, i) + Totals(0)
        Next

    End Sub

    Public Function Clone()
        Return Me.MemberwiseClone()
    End Function

End Class
