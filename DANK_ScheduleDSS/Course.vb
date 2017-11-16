Public Class Course

    Public Property CRN As Integer
    Public Property Department As String
    Public Property CourseName As String
    Public Property Title As String
    Public Property Instructor As String
    Public Property Days As String
    Public Property Begin As String
    Public Property EndInst As String
    Public Property Location As String
    Private Property Period As Integer
    Public Property Enrollment As Integer
    Public Property SectionDays As Section
    Public Property SectionTimeOfDay As Section

    Public Property EveningHours As Integer
    Public Property MorningHours As Integer
    Public Property TuesThurs As Integer
    Public Property MonWedFri As Integer
    Public Property MonWed As Integer

    Public Sub New()
        Dim Generator As Random = New Random()
        Me.Period = Generator.Next(1, 20)
        Me.Enrollment = 0

        EveningHours = 0
        MorningHours = 0
        TuesThurs = 0
        MonWedFri = 0
        MonWed = 0 'Currently not built out yet b/c not using real period data ALH

        'Determine Morning or Evening and which period class is in
        'Very bad ugly code!!!! ALH
        Select Case Period
            Case 1 To 2 'Monday Morning
                MorningHours = 1
                MonWedFri = 1
            Case 3 To 4 'Monday Evening
                EveningHours = 1
                MonWedFri = 1
            Case 5 To 6 'Tues Morning
                MorningHours = 1
                TuesThurs = 1
            Case 7 To 8 'Tues Evening etc...
                EveningHours = 1
                TuesThurs = 1
            Case 9 To 10
                MorningHours = 1
                MonWedFri = 1
            Case 11 To 12
                EveningHours = 1
                MonWedFri = 1
            Case 13 To 14
                MorningHours = 1
                TuesThurs = 1
            Case 15 To 16
                EveningHours = 1
                TuesThurs = 1
            Case 17 To 18
                MorningHours = 1
                MonWedFri = 1
            Case 19 To 20
                EveningHours = 1
                MonWedFri = 1
            Case Else
                Throw New Exception
        End Select

        SectionDays = New Section
        SectionTimeOfDay = New Section

        If EveningHours = 1 Then
            SectionTimeOfDay.SectionTimeOfDay = Section.TimeOfDayEnum.Evening
        Else
            SectionTimeOfDay.SectionTimeOfDay = Section.TimeOfDayEnum.Morning
        End If

        If MonWedFri = 1 Then
            SectionDays.SectionDay = Section.DayEnum.MonWedFri
        Else
            SectionDays.SectionDay = Section.DayEnum.TuesThurs
        End If

    End Sub

End Class
