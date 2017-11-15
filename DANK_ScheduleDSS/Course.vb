Public Class Course
    'Will be when the class meets from db
    'Public Property classMeetings
    Public Property CRN
    Public Property Course
    Public Property Title
    Public Property Instructor
    Public Property Days
    Public Property Begin
    Public Property EndInst
    Public Property Location


    'Constructor
    Public Sub New(CRN As String, Professor As String, Title As String, Course As String, Hours As String, Days As String, Location As String)
        Me.CRN = CRN
        Me.Course = Course
        Me.Title = Title
        Me.Course = Course
        Me.Instructor = Instructor
        Me.Days = Days
        Me.Begin = Begin
        Me.EndInst = EndInst
        Me.Location = Location

    End Sub
End Class
