

''' <summary>
''' 
''' </summary>
Public Class JsonFile
    Public Property DisplayText() As String
    Public Property FileName() As String
    Public Overrides Function ToString() As String
        Return DisplayText
    End Function
End Class