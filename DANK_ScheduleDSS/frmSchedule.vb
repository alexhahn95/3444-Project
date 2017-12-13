Public Class frmSchedule

    'Fields for different sections
    Private evening As Integer
    Private morning As Integer
    Private TR As Integer
    Private MW As Integer
    Private MWF As Integer

    'Number of courses the student wishes to take
    Private NumberOfCoursesRequested As Integer

    'Optimization object
    Public Shared Opt As Optimization

    'Tries to create an optimal schedule. Shows a messagebox if input is invalid.
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            SetGoalAmounts()
            CreateOptimization()
            AddRequestedCourses()
            ShowResultsForm()
        Catch ex As Exception
            MessageBox.Show("Goal Amounts must be nonzero,nonnegative integers and you must select from 1 to 6 classes")
        End Try

    End Sub

    'Creates the Optimization
    Private Sub CreateOptimization()
        Opt = New Optimization With {
            .GoalAmounts = New Integer() {evening, morning, TR, MW, MWF}
        }

    End Sub

    'Adds the requested courses to the dataset
    Private Sub AddRequestedCourses()

        Dim Department As String
        Dim CourseNumber As Integer
        Dim Checked As Boolean

        NumberOfCoursesRequested = 0

        For Each row As DataGridViewRow In DataGridView.Rows

            Checked = row.Cells(0).Value
            Department = row.Cells(1).Value
            CourseNumber = row.Cells(2).Value

            If Checked Then
                Opt.ObjectCreator.PopulateDiscreteDataSet(Department, CourseNumber)
                Opt.ObjectCreator.PopulateAbstractTableDataSet(Department, CourseNumber)
                NumberOfCoursesRequested = NumberOfCoursesRequested + 1
            End If
        Next

        If NumberOfCoursesRequested = 0 Or NumberOfCoursesRequested > 6 Then
            MessageBox.Show("Invalid course amount")
        End If

        Opt.AmountRequestedCourses = NumberOfCoursesRequested
        Opt.BuildModel()
    End Sub

    'Sets goal amounts from the UI
    Private Sub SetGoalAmounts()
        If IsNumeric(txtEvening.Text) And IsNumeric(txtMorning.Text) And IsNumeric(txtTR.Text) And IsNumeric(txtMW.Text) And IsNumeric(txtMWF.Text) Then
            evening = txtEvening.Text
            morning = txtMorning.Text
            TR = txtTR.Text
            MW = txtMW.Text
            MWF = txtMWF.Text
        Else
            Throw New Exception()
        End If

        If txtEvening.Text <= 0 Or txtMorning.Text <= 0 Or txtTR.Text <= 0 Or txtMW.Text <= 0 Or txtMWF.Text <= 0 Then
            Throw New Exception()
        End If

    End Sub

    'Shows results form
    Private Sub ShowResultsForm()
        My.Forms.frmResults.Show()
        Me.Close()
    End Sub

    'Load form event handler
    Private Sub frmSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fall2017ClassesDataSet.CourseAbstraction' table. You can move, or remove it, as needed.
        Me.CourseAbstractionTableAdapter.Fill(Me.Fall2017ClassesDataSet.CourseAbstraction)
    End Sub

End Class