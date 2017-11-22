Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services
Imports Microsoft.SolverFoundation.Solvers

Public Class Optimization

    Dim CreateObjects As New CreateObjects
    Dim Solver As SimplexSolver

    'These need to change to be set by the user and maybe change locations
    Public Property AmountRequestedCourses As Integer = 1

    Public Sub BuildModel()

        Solver = New SimplexSolver

        CreateObjects.CreateObjects()

        'In order: Evening, Morning, TR, MW, MWF 
        Dim GoalAmounts = New Integer() {70, 0, 0, 0, 0}

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

        For period = 0 To CreateObjects.PeriodCount - 1
            constraintKey = "Overlap Constraint: 0"
            Solver.AddRow(constraintKey, constraintIndex)
            Dim iter As Integer = 0
            For Each course As Course In CreateObjects.CourseList
                coefficient = CreateObjects.CourseOfferings(iter, period)
                iter = iter + 1
                dvKey = course.CRN
                dvIndex = Solver.GetIndexFromKey(dvKey)
                Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
            Next
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

        'Objective Function
        Dim objKey As String = "Objective Function"
        Dim objIndex As Integer
        Solver.AddRow(objKey, objIndex)
        For section = 0 To CreateObjects.Sections.Count - 1
            For Each course As Course In CreateObjects.CourseList
                coefficient = course.Totals(section) - GoalAmounts(section)
                dvKey = course.CRN
                dvIndex = Solver.GetIndexFromKey(dvKey)
                Solver.SetCoefficient(objIndex, dvIndex, coefficient)
            Next

        Next

        Solver.AddGoal(objIndex, 0, True)
        Solver.Solve(New SimplexSolverParams())
        MessageBox.Show("Obj function: " & Solver.GetValue(objIndex).ToDouble)

        For i = 0 To Solver.VariableIndices.Count - 1
            MessageBox.Show(Solver.GetKeyFromIndex(i) & ": " & Solver.GetValue(i).ToDouble)
        Next
    End Sub
End Class