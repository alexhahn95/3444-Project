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

    Public Property StartAndEndIndicies As String()

    Private startIndex As Integer
    Private endIndex As Integer

    Dim PM As Regex
    Dim AM As Regex
    Public Property Location As String
    Public Totals() As Integer

    Dim Generator As Random

    Public Sub New()

        'Generator = New Random
        'Period = Generator.Next(1, 20)



        'Currently not built out yet b/c not using real period data ALH,
        'need to parse out start/end time strings and go from there

        'Determine Morning or Evening and which period class is in
        'Very bad ugly code!!!! Needs refactoring ALH

        'In order: Evening, Morning, TuesThurs, MonWedFri, MonWed
        Totals = New Integer() {0, 0, 0, 0, 0}
    End Sub

    Public Sub CalculateStartAndEndIndicies1()
        PM = New Regex("([PM])\w+")
        AM = New Regex("([AM])\w+")

        'If PM.Matches(BeginTime).Count > 0 Then
        '    TimeArray = PM.Replace(BeginTime, "").Split(":")
        '    If TimeArray(0) <> 12 Then
        '        TimeArray(0) = TimeArray(0) + 12
        '    End If
        '    startIndex = ((TimeArray(0) - 8) * 12 + TimeArray(1) / 5)
        'ElseIf AM.Matches(BeginTime).Count > 0 Then
        '    TimeArray = AM.Replace(BeginTime, "").Split(":")
        '    startIndex = ((TimeArray(0) - 8) * 12 + TimeArray(1) / 5)
        'Else
        '    Throw New Exception()
        'End If

        'If PM.Matches(EndTime).Count > 0 Then
        '    TimeArray = PM.Replace(EndTime, "").Split(":")
        '    If TimeArray(0) <> 12 Then
        '        TimeArray(0) = TimeArray(0) + 12
        '    End If
        '    endINdex = ((TimeArray(0) - 8) * 12 + TimeArray(1) / 5)
        'ElseIf AM.Matches(EndTime).Count > 0 Then
        '    TimeArray = AM.Replace(EndTime, "").Split(":")
        '    endINdex = ((TimeArray(0) - 8) * 12 + TimeArray(1) / 5)
        'Else
        '    Throw New Exception()
        'End If

        CalculateStartAndEndIndicies2(BeginTime, startIndex)
        CalculateStartAndEndIndicies2(EndTime, endIndex)

    End Sub

    Public Sub CalculateStartAndEndIndicies2(BeginOrEndTime As String, ByRef Index As Integer)
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

End Class
