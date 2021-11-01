Public Class Employee
    Public Property EmployeeID As Integer
    Public Property TitleOfCourtesy As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Fullname As String
    Public Property BirthDate As Date
    Public Property HomePhone As String

    Public Overrides Function ToString() As String
        Return Fullname
    End Function
End Class