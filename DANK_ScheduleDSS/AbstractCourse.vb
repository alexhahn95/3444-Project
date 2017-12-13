'Represents the abstraction of a course, for example BIT 3444, instead of a paticular section.
Public Class AbstractCourse

    'Fields for the department, coursenumber, and a list of discrete courses
    Public Property Department As String
    Public Property CourseNumber As Integer
    Public Property DiscreteCourseList As New List(Of DiscreteCourse)

    'Default Constructor
    Public Sub New()
    End Sub

End Class
