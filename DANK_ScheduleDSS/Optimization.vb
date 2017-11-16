Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services
Imports Microsoft.SolverFoundation.Solvers

Public Class Optimization

    Dim CreateObjects As New CreateObjects
    Dim Solver As SimplexSolver
    Public Sub BuildModel()

        Solver = New SimplexSolver

        CreateObjects.CreateObjects()

        'Define the decision variables
        Dim dvKey As String
        Dim dvIndex As Integer

        For Each course As Course In CreateObjects.CourseList
            dvKey = course.CRN
            Solver.AddVariable(dvKey, dvIndex)
            Solver.SetIntegrality(dvIndex, True)
            Solver.SetBounds(dvIndex, 0, 1)
        Next

        'Declare variables used for constraints
        Dim coefficient As Single
        Dim constraintKey As String
        Dim constraintIndex As Integer

        'Create Overlap constraints
        For Each period As Period In CreateObjects.PeriodList
            constraintKey = "Overlap Constraint: " & period.Period
            Solver.AddRow(constraintKey, constraintIndex)
            For Each course As Course In CreateObjects.CourseList
                coefficient = course.Enrollment
                dvKey = course.CRN
                dvIndex = Solver.GetIndexFromKey(dvKey)
                Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
            Next
            Solver.SetBounds(constraintIndex, 0, 1)
        Next

        'Objective function mothafuckas
        Dim objKey As String = "Objective Function"
        Dim objIndex As Integer
        Solver.AddRow(objKey, objIndex)
        Dim i As Integer = 0
        For Each section As Section In CreateObjects.SectionList
            For Each course As Course In CreateObjects.CourseList
                coefficient = course.TotalsList(i).Hours
                dvKey = course.CRN
                dvIndex = Solver.GetIndexFromKey(dvKey)
                Solver.SetCoefficient(objIndex, dvIndex, coefficient)
            Next
            i = i + 1
        Next

        Solver.AddGoal(objIndex, 0, True)

        Dim solverParam As New SimplexSolverParams With {
            .MixedIntegerGapTolerance = 0.01
        }
        Solver.Solve(solverParam)
        Solver.GetValue(dvIndex)

    End Sub
End Class