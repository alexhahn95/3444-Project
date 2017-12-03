Public Class frmResults
    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each course As DiscreteCourse In frmSchedule.Opt.OptimalCourseList
            cbxResults.Items.Add(course.ToStringy())
        Next

        txtObjFunction.Text = frmSchedule.Opt.ObjectiveFunctionValue

        txtEven.Text = frmSchedule.Opt.SlackSurplus(0)
        txtMorn.Text = frmSchedule.Opt.SlackSurplus(1)
        txtTR.Text = frmSchedule.Opt.SlackSurplus(2)
        txtMW.Text = frmSchedule.Opt.SlackSurplus(3)
        txtMWF.Text = frmSchedule.Opt.SlackSurplus(4)
    End Sub

End Class