﻿Public Class frmSchedule

    Private evening As Integer
    Private morning As Integer
    Private TR As Integer
    Private MW As Integer
    Private MWF As Integer

    Private NumberOfCoursesRequested As Integer

    Public Shared Opt As Optimization

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        SetGoalAmounts()
        CreateOptimization()
        AddRequestedCourses()
        ShowResultsForm()
    End Sub

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



        Opt.AmountRequestedCourses = NumberOfCoursesRequested
        Opt.BuildModel()
    End Sub

    Private Sub CreateOptimization()
        Opt = New Optimization With {
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
        'TODO: This line of code loads data into the 'Fall2017ClassesDataSet.CourseAbstraction' table. You can move, or remove it, as needed.
        Me.CourseAbstractionTableAdapter.Fill(Me.Fall2017ClassesDataSet.CourseAbstraction)

    End Sub

End Class