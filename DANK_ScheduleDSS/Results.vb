Public Class frmResults
    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each course As DiscreteCourse In frmSchedule.Opt.OptimalCourseList
                lstResults.Items.Add(course.ToStringy())
            Next

            txtObjFunction.Text = frmSchedule.Opt.ObjectiveFunctionValue

            txtEven.Text = frmSchedule.Opt.SlackSurplus(0)
            txtMorn.Text = frmSchedule.Opt.SlackSurplus(1)
            txtTR.Text = frmSchedule.Opt.SlackSurplus(2)
            txtMW.Text = frmSchedule.Opt.SlackSurplus(3)
            txtMWF.Text = frmSchedule.Opt.SlackSurplus(4)
        Catch
            MessageBox.Show("You must create a schedule first")
            My.Forms.frmResults.Close()
        End Try
    End Sub

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub

    Private Sub lblMW_Click(sender As Object, e As EventArgs) Handles lblMW.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class