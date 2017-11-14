Public Class frmDataEntry

    Dim eveningHoursGoal As Integer
    Dim tuesdayThursdayGoal As Integer
    Dim mondayWednesdayGoal As Integer
    Dim periods(,) As Byte
    Dim classes() As Byte
    Dim eveningHoursActual As Integer
    Dim tuesdayThursdayActual As Integer
    Dim mondayWednesdayActual As Integer
    Dim bestSchedule(,) As Byte
    Dim totalHours As Integer
    Dim deviationEvening As Integer
    Dim deviationTuesdayThursday As Integer
    Dim deviationMondayWednesday As Integer

    'Reads the input data
    Private Sub ReadData()

    End Sub

    'calculates the hours using the stuff
    Private Function CalculateHours(ByRef goalHours, ByRef deviation)

    End Function

    'scores each possible schedule, which really this might all be solver so possible ignore this
    Private Function CalculateScoreOfSchedule(ByRef periods(,), ByRef rowIndex)

    End Function

    'Mail that data to solver
    Private Sub SendToSolver()

    End Sub

    Private Sub Main()
        'readData()
        'CalculateHours()
        'CalculateScoreOfSchedule()

    End Sub


    'Private Sub ShowWelcome()
    Private Sub ShowWelcome()

    End Sub

    Private Sub ShowTheTeam()

    End Sub

    Private Sub ShowResults()

    End Sub

    Private Sub ShowHomeScreen()

    End Sub

    Private Sub ShowDataEntry()

    End Sub

    Private Sub ReadPassword()

    End Sub

End Class