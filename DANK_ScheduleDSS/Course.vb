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

    Private DayAmtOfIndicies As Integer = 169

    Public Property StartAndEndIndicies As String()

    Private startIndex As Integer
    Private endIndex As Integer

    Dim PM As Regex
    Dim AM As Regex
    Public Property Location As String
    Public Totals() As Integer

    Dim Generator As Random

    Public Sub New()
        Totals = New Integer() {0, 0, 0, 0, 0}
    End Sub

    Public Sub CalculateStartAndEndIndicies()
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
        UpdateCourseOfferingsTimeOfDay()
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
        End Select
    End Sub

    Private Sub DaysOfWeekHelper(ByRef CourseOfferings(,) As Integer, CourseIndex As Integer, Day As Integer)
        For i = 0 To 168
            If i >= startIndex And i < endIndex Then
                CourseOfferings(CourseIndex, i + DayAmtOfIndicies * Day) = 1
            End If
        Next
    End Sub

    Private Sub UpdateCourseOfferingsTimeOfDay()

    End Sub

End Class
