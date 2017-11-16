Public Class Course

    Public Property CRN
    Public Property Department
    Public Property CourseName
    Public Property Title
    Public Property Instructor
    Public Property Days
    Public Property Begin
    Public Property EndInst
    Public Property Location
    Public Property Period
    Public Property Enrollment

    Public Sub New()
        Dim Generator As Random = New Random()
        Me.Period = Generator.Next(0, 19)
        Me.Enrollment = 0
    End Sub

End Class
