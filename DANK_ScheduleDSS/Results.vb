Public Class frmResults

    'Outputs the data
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

End Class