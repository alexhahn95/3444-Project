Public Class DataEntry

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
    Private Sub readData()

    End Sub

    'calculates the hours using the stuff
    Private Function calculateHours(ByRef goalHours, ByRef deviation)

    End Function

    'scores each possible schedule, which really this might all be solver so possible ignore this
    Private Function calculateScoreOfSchedule(ByRef periods(,), ByRef rowIndex)

    End Function

    'Mail that data to solver
    Private Sub sendToSolver()

    End Sub

    Private Sub Main()
        readData()
        calculateHours()
        calculateScoreOfSchedule()

    End Sub

    Private Sub showWelcome()

    End Sub

    Private Sub showTheTeam()

    End Sub

    Private Sub showResults()

    End Sub

    Private Sub showHomeScreen()

    End Sub

    Private Sub showDataEntry()

    End Sub

    Private Sub readPassword()

    End Sub

End Class