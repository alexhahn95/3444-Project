Public Class Course

    Public Property CRN As Integer
    Public Property Department As String
    Public Property CourseName As String
    Public Property Title As String
    Public Property Instructor As String
    Public Property Days As String
    Public Property Begin As String
    Public Property EndInst As String
    Public Property Location As String
    Public Property Period As Integer
    Public Property Enrollment As Integer

    Public Sub New()
        Dim Generator As Random = New Random()
        Me.Period = Generator.Next(1, 20)
        Me.Enrollment = 0
    End Sub

End Class
