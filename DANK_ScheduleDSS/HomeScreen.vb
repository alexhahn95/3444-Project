Public Class frmHomeScreen
    Private Sub btnViewTeam_Click(sender As Object, e As EventArgs) Handles btnViewTeam.Click
        My.Forms.frmTeam.Show()
    End Sub

    Private Sub btnResultsView_Click(sender As Object, e As EventArgs) Handles btnResultsView.Click
        My.Forms.frmResults.Show()
    End Sub

    Private Sub btnSetSchedule_Click(sender As Object, e As EventArgs) Handles btnSetSchedule.Click
        My.Forms.frmSchedule.Show()
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        My.Forms.frmInstructions.Show()
    End Sub

    Private Sub frmHomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class