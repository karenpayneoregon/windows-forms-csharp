Public Module StringExtensions
    <Runtime.CompilerServices.Extension>
    Public Function ContainsInsensitive(source As String, toCheck As String) As Boolean
        Return source.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase) >= 0
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function ContainsAll(source As String, ParamArray values() As String) As Boolean
        Return values.All(Function(x) source.ContainsInsensitive(x))
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function ContainsAny(sender As String, ParamArray items() As String) As Boolean
        Return items.Any(Function(value) sender.ContainsInsensitive(value))
    End Function

End Module