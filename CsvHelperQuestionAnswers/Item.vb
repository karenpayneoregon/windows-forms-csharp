Public Class Item
    Public Property Id () As Integer
    Public Property Question() As String
    Public Property Explanation() As String

    Public Overrides Function ToString() As String
        Return Id.ToString()
    End Function
End Class