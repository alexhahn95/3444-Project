Public Class frmSchedule

    Private evening As Integer
    Private morning As Integer
    Private TR As Integer
    Private MW As Integer
    Private MWF As Integer

    Private NumberOfCoursesRequested As Integer

    Public Shared Opt As Optimization

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CreateOptimization()
        SetGoalAmounts()
        AddRequestedCourses()
        ShowResultsForm()
    End Sub

    Private Sub AddRequestedCourses()

        Dim Department As String
        Dim CourseNumber As Integer
        Dim Checked As Boolean

        NumberOfCoursesRequested = 0

        For Each row As DataGridViewRow In DataGridView.Rows

            Department = row.Cells(0).Value
            CourseNumber = row.Cells(1).Value
            Checked = row.Cells(2).Value

            If Checked Then
                Opt.ObjectCreator.PopulateDataSet(Department, CourseNumber)
                NumberOfCoursesRequested = NumberOfCoursesRequested + 1
            End If
        Next
        Opt.BuildModel()
    End Sub

    Private Sub CreateOptimization()
        Opt = New Optimization With {
            .AmountRequestedCourses = NumberOfCoursesRequested,
            .GoalAmounts = New Integer() {evening, morning, TR, MW, MWF}
        }

    End Sub

    Private Sub SetGoalAmounts()
        evening = txtEvening.Text
        morning = txtMorning.Text
        TR = txtTR.Text
        MW = txtMW.Text
        MWF = txtMWF.Text
    End Sub

    Private Sub ShowResultsForm()
        My.Forms.frmResults.Show()
        Me.Close()
    End Sub

    Private Sub frmSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DistinctTableAdapter.Fill(Me.Fall2017ClassesDataSet.Distinct)
    End Sub

End Class