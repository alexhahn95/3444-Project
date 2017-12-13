﻿'Home screen
Public Class frmHomeScreen

    'View team event handler
    Private Sub btnViewTeam_Click(sender As Object, e As EventArgs) Handles btnViewTeam.Click
        My.Forms.frmTeam.Show()
    End Sub

    'View results event handler
    Private Sub btnResultsView_Click(sender As Object, e As EventArgs) Handles btnResultsView.Click
        Try
            My.Forms.frmResults.Show()
        Catch ex As Exception
            MessageBox.Show("You must create a schedule first")
        End Try

    End Sub

    'View Schedule event handler
    Private Sub btnSetSchedule_Click(sender As Object, e As EventArgs) Handles btnSetSchedule.Click
        My.Forms.frmSchedule.Show()
    End Sub

    'View Instructions event handler
    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        My.Forms.frmInstructions.Show()
    End Sub

End Class