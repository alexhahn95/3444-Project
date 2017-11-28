Public Class frmSchedule

    Private evening As Integer
    Private morning As Integer
    Private TR As Integer
    Private MW As Integer
    Private MWF As Integer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        evening = txtEvening.Text
        morning = txtMorning.Text
        TR = txtTR.Text
        MW = txtMW.Text
        MWF = txtMWF.Text

        Dim Opt = New Optimization With {
            .AmountRequestedCourses = txtRequestedCourses.Text,
            .GoalAmounts = New Integer() {evening, morning, TR, MW, MWF}
        }

        Opt.BuildModel()

    End Sub

    Private Sub frmSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fall2017ClassesDataSet.Classes' table. You can move, or remove it, as needed.
        Me.ClassesTableAdapter.Fill(Me.Fall2017ClassesDataSet.Classes)

    End Sub
End Class