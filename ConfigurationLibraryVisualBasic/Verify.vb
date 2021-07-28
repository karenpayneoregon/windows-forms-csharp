Option Infer On
Public Class Verify
    Public Property FileName() As String
    Public Property Count() As Integer
    Public ReadOnly Property ItemArray() As String()
        Get
            Return {FileName, Count.ToString()}
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return FileName
    End Function
End Class