Public Class frmSchedule
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Opt = New Optimization With {
            .AmountRequestedCourses = txtRequestedCourses.Text,
            .GoalAmounts = New Integer() {txtEvening.Text, txtMorning.Text, txtTR.Text, txtMW.Text, txtMWF.Text}
        }
        Opt.BuildModel()
    End Sub
End Class