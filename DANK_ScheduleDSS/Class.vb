Public Class ClassInst
    'Will be when the class meets from db
    'Public Property classMeetings
    Private Property CRN
    Public Property Professor
    Public Property Title
    Public Property Course
    Public Property Hours
    Public Property Days
    Public Property Location

    'Constructor
    Public Sub New(CRN As String, Professor As String, Title As String, Course As String, Hours As String, Days As String, Location As String)
        Me.CRN = CRN
        Me.Professor = Professor
        Me.Title = Title
        Me.Course = Course
        Me.Hours = Hours
        Me.Days = Days
        Me.Location = Location

    End Sub

    'get morning hours
    Public Function GetMorningHours()

    End Function

    'get evening hours
    Public Function GetEveningHours()

    End Function

    'converts class to a string
    Public Function classToString()

    End Function
End Class
