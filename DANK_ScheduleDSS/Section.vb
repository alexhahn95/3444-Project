Public Class Section

    Enum TimeOfDayEnum
        Evening
        Morning
    End Enum

    Enum DayEnum
        MonWedFri
        MonWed
        TuesThurs
    End Enum


    Public Property SectionTimeOfDay As TimeOfDayEnum
    Public Property SectionDay As DayEnum

    Public Sub New()
    End Sub

End Class
