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
End Class