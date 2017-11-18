Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services
Imports Microsoft.SolverFoundation.Solvers

Public Class Optimization

    Dim CreateObjects As New CreateObjects
    Dim Solver As SimplexSolver

    'These need to change to be set by the user and maybe change locations
    Public Property AmountRequestedCourses As Integer = 5

    Public Sub BuildModel()

        Solver = New SimplexSolver

        CreateObjects.CreateObjects()

        Dim GoalAmounts = New Integer() {3, 4, 5, 3, 2}

        'Define the decision variables
        Dim dvKey As String
        Dim dvIndex As Integer

        For Each course As Course In CreateObjects.CourseList
            dvKey = course.CRN
            Solver.AddVariable(dvKey, dvIndex)
            Solver.SetIntegrality(dvIndex, True)
            Solver.SetBounds(dvIndex, 0, 1)
        Next

        'Constraint variables
        Dim coefficient As Single
        Dim constraintKey As String
        Dim constraintIndex As Integer

        'Overlap binary constraint
        For period = 1 To CreateObjects.PeriodCount
            constraintKey = "Overlap Constraint: " & period
            Solver.AddRow(constraintKey, constraintIndex)
            For course = 1 To CreateObjects.CourseList.Count
                coefficient = CreateObjects.CourseOfferings(period - 1, course - 1)
                dvKey = CreateObjects.CourseList.ElementAt(course - 1).CRN
                dvIndex = Solver.GetIndexFromKey(dvKey)
                Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
            Next
            Solver.SetBounds(constraintIndex, 0, 1)
        Next

        'Course enrollment constraint
        constraintKey = "Enrollment Constraint"
        Solver.AddRow(constraintKey, constraintIndex)
        For Each course As Course In CreateObjects.CourseList
            coefficient = 1
            dvKey = course.CRN
            dvIndex = Solver.GetIndexFromKey(dvKey)
            Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
        Next
        Solver.SetBounds(constraintIndex, AmountRequestedCourses, AmountRequestedCourses)

        'Objective function
        Dim objKey As String = "Objective Function"
        Dim objIndex As Integer
        Solver.AddRow(objKey, objIndex)
        For section = 0 To CreateObjects.Sections.Count - 1
            For Each course As Course In CreateObjects.CourseList
                If course.Totals(section) > GoalAmounts(section) Then
                    coefficient = course.Totals(section) - GoalAmounts(section)
                ElseIf course.Totals(section) < GoalAmounts(section) Then
                    coefficient = GoalAmounts(section) - course.Totals(section)
                Else
                    coefficient = 0
                End If
                dvKey = course.CRN
                dvIndex = Solver.GetIndexFromKey(dvKey)
                Solver.SetCoefficient(objIndex, dvIndex, coefficient)
            Next
            section = section + 1
        Next

        Solver.AddGoal(objIndex, 0, True)

        Dim solverParam As New SimplexSolverParams With {
            .MixedIntegerGapTolerance = 0.01
        }
        Solver.Solve(solverParam)
        For i = 0 To Solver.VariableIndices.Count - 1
            If Solver.GetValue(i) = 1 Then
                MessageBox.Show(i)
            End If
        Next
    End Sub
End Class