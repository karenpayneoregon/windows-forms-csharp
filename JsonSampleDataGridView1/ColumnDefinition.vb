Public Class ColumnDefinition
    Public Property HeaderText() As String
    Public Property DataPropertyName() As String
    Public Property Visible() As Boolean
    Public Overrides Function ToString() As String
        Return DataPropertyName
    End Function
End Class