Public Class Course

    Public Property CRN As Integer
    Public Property Department As String
    Public Property CourseNumber As Integer
    Public Property Title As String
    Public Property Instructor As String
    Public Property Days As String
    Public Property Begin As String
    Public Property EndInst As String
    Public Property Location As String
    Public Totals() As Integer

    Dim Generator As Random

    Public Sub New()

        'Generator = New Random
        'Period = Generator.Next(1, 20)



        'Currently not built out yet b/c not using real period data ALH,
        'need to parse out start/end time strings and go from there

        'Determine Morning or Evening and which period class is in
        'Very bad ugly code!!!! Needs refactoring ALH

        'In order: Evening, Morning, TuesThurs, MonWedFri, MonWed
        Totals = New Integer() {0, 0, 0, 0, 0}


    End Sub

End Class
