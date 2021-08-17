Namespace Classes
    Public Class Employee
        Public Property Id() As Integer
        Public Property ContactTypeIdentifier() As Integer
        Public Property TitleOfCourtesy() As String
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property HiredDate() As DateTime?
        Public Overrides Function ToString() As String
            Return $"{FirstName} {LastName}"
        End Function
    End Class
End Namespace