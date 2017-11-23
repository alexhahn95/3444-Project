Imports Microsoft.SolverFoundation.Common
Imports Microsoft.SolverFoundation.Services
Imports Microsoft.SolverFoundation.Solvers

Public Class Optimization

    Dim ObjectCreator As New ObjectCreator
    Dim Solver As SimplexSolver

    'These need to change to be set by the user and maybe change locations
    Public Property AmountRequestedCourses As Integer = 1

    Public Sub BuildModel()

        Solver = New SimplexSolver

        ObjectCreator.CreateObjects()

        'In order: Evening, Morning, TR, MW, MWF 
        Dim GoalAmounts = New Integer() {1, 1, 1, 1, 1}

        'Define the decision variables
        Dim dvKey As String
        Dim dvIndex As Integer

        For Each course As Course In ObjectCreator.CourseList
            dvKey = course.CRN
            Solver.AddVariable(dvKey, dvIndex)
            Solver.SetIntegrality(dvIndex, True)
            Solver.SetBounds(dvIndex, 0, 1)
        Next

        'Constraint variables
        Dim coefficient As Single
        Dim constraintKey As String
        Dim constraintIndex As Integer

        For period = 0 To ObjectCreator.PeriodCount - 1
            constraintKey = "Overlap Constraint: " & period
            Solver.AddRow(constraintKey, constraintIndex)
            Dim iter As Integer = 0
            For Each course As Course In ObjectCreator.CourseList
                coefficient = ObjectCreator.CourseOfferings(iter, period)
                iter = iter + 1
                dvKey = course.CRN
                dvIndex = Solver.GetIndexFromKey(dvKey)
                Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
            Next
            Solver.SetBounds(constraintIndex, 0, 1)
        Next

        'Course enrollment constraint
        constraintKey = "Enrollment Constraint"
        Solver.AddRow(constraintKey, constraintIndex)
        For Each course As Course In ObjectCreator.CourseList
            coefficient = 1
            dvKey = course.CRN
            dvIndex = Solver.GetIndexFromKey(dvKey)
            Solver.SetCoefficient(constraintIndex, dvIndex, coefficient)
        Next
        Solver.SetBounds(constraintIndex, AmountRequestedCourses, AmountRequestedCourses)

        'Objective Function
        Dim objKey As String = "Objective Function"
        Dim objIndex As Integer
        Dim coefficients(,) As Integer
        coefficients = New Integer(1, 4) {} 'Used for debugging purposes
        Solver.AddRow(objKey, objIndex)
        For section = 0 To ObjectCreator.Sections.Count - 1
            For Each course As Course In ObjectCreator.CourseList
                coefficient = Math.Abs(course.Totals(section) - GoalAmounts(section))
                dvKey = course.CRN
                dvIndex = Solver.GetIndexFromKey(dvKey)
                Solver.SetCoefficient(objIndex, dvIndex, coefficient)
            Next
        Next

        Solver.AddGoal(objIndex, 0, True)

        Dim mySolverParms As New SimplexSolverParams
        'With {
        '.MixedIntegerGapTolerance = 1,
        '.VariableFeasibilityTolerance = 0.00001,
        '.MaxPivotCount = 1000
        '}

        Solver.Solve(mySolverParms)
        MessageBox.Show("Obj function: " & Solver.GetValue(objIndex).ToString)

        For i = 0 To Solver.VariableIndices.Count - 1
            MessageBox.Show(Solver.GetKeyFromIndex(i) & ": " & Solver.GetValue(i).ToDouble)

        Next
    End Sub
End Class