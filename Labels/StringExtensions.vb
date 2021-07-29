Public Module StringExtensions
    <Runtime.CompilerServices.Extension>
    Public Function ContainsInsensitive(source As String, toCheck As String) As Boolean
        Return source.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase) >= 0
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function ContainsAll(source As String, ParamArray values() As String) As Boolean
        Return values.All(Function(x) source.ContainsInsensitive(x))
    End Function

End Module