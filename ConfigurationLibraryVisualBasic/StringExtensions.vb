Public Module StringExtensions
    <DebuggerStepThrough>
    <System.Runtime.CompilerServices.Extension>
    Public Function IsNullOrWhiteSpace(ByVal sender As String) As Boolean
        Return String.IsNullOrWhiteSpace(sender)
    End Function

End Module
