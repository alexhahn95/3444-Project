﻿Imports Microsoft.SolverFoundation.Common
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

        'constraintKey = "Satisfaction"
        'For Each course As Course In CreateObjects.CourseList

        'Next

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

        ''Capacity Constraints
        'For Each capacity As Capacity In IC5CreateObjects.CapacityList
        '    constraintKey = "Capacity Constraint_" & capacity.DepartmentName
        '    Solver.AddRow(constraintKey, constraintIndex)
        '    For Each activity As Activity In CreateObjects.ActivityList
        '        coefficient = 1
        '        dvKey = "BIT_Activity 1"
        '        dvIndex = IC5Solver.GetIndexFromKey(dvKey)
        '        IC5Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
        '    Next
        '    Solver.SetBounds(constraintIndex, 0, capacity.Capacity)

        'Next

        ''Acitivty Coverage Constraints
        'For Each activity As Activity In IC5CreateObjects.ActivityList
        '    constraintKey = "Activity Constraint_" & activity.ActivityName
        '    IC5Solver.AddRow(constraintKey, constraintIndex)
        '    For Each capacity As Capacity In IC5CreateObjects.CapacityList
        '        coefficient = 1
        '        dvKey = "BIT_Activity 1"
        '        dvIndex = IC5Solver.GetIndexFromKey(dvKey)
        '        IC5Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
        '    Next
        '    IC5Solver.SetBounds(constraintIndex, 0, Capacity.Capacity)

        'Next

        ''Define the objective
        'Dim objKey As String = "Objective Function"
        'Dim objIndex As Integer
        'Solver.AddRow(objKey, objIndex)
        'For Each effect As Effectiveness In IC5CreateObjects.EffList
        '    For Each activity As Activity In IC5CreateObjects.ActivityList
        '        dvKey = effect.DepartmentName & "_" & activity.ActivityName
        '        dvIndex = Solver.GetIndexFromKey(dvKey)
        '        If activity.ActivityName = "activty 1" Then coefficient = effect.Effectiveness1
        '        If activity.ActivityName = "activty 2" Then coefficient = effect.Effectiveness2
        '        If activity.ActivityName = "activty 3" Then coefficient = effect.Effectiveness3
        '        If activity.ActivityName = "activty 4" Then coefficient = effect.

        '           Solver.SetCoefficient(objIndex, dvIndex, coefficient)
        '    Next
        'Next
        'Solver.AddGoal(objIndex, 0, False)
        ''************************************************************************************************

        ''Solve the optimization
        'Dim mySolverParams As New SimplexSolverParams
        'mySolverParams.MixedIntegerGapTolerance = 0.01
        'Solver.Solve(mySolverParams)
        'Solver.GetValue(dvIndex)
    End Sub
End Class