Public Class frmHomeScreen
    Private Sub btnViewTeam_Click(sender As Object, e As EventArgs) Handles btnViewTeam.Click
        My.Forms.frmTeam.Show()
    End Sub

    Private Sub btnResultsView_Click(sender As Object, e As EventArgs) Handles btnResultsView.Click
        Try
            My.Forms.frmResults.Show()
        Catch ex As Exception
            MessageBox.Show("You must create a schedule first")
        End Try

    End Sub

    Private Sub btnSetSchedule_Click(sender As Object, e As EventArgs) Handles btnSetSchedule.Click
        My.Forms.FrmSchedule.Show()
    End Sub

    Private Sub btnInstructions_Click(sender As Object, e As EventArgs) Handles btnInstructions.Click
        My.Forms.FrmInstructions.Show()
    End Sub

    Private Sub frmHomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class