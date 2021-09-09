
Namespace Classes
    ''' <summary>
    ''' Class for CheckedListBox
    ''' </summary>
    Public Class MonthItem
        Public Property Text() As String
        Public Property Checked As Boolean

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class
End Namespace