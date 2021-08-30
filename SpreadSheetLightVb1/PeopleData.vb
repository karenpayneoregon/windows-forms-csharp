Public Class PeopleData
    Public Shared Function List() As List(Of Person)
        Return New List(Of Person) From {
            New Person() With {.FirstName = "John", .LastName = "Doe"},
            New Person() With {.FirstName = "Mary", .LastName = "Adams"},
            New Person() With {.FirstName = "Bob", .LastName = "Wills"}}
    End Function
End Class