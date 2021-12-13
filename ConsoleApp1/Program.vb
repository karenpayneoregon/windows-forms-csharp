Imports System

Module Program
    Sub Main(args As String())
        Dim lines = Enumerable.Range(1, 252).Select(Function(x) $"Line {x}").ToArray()

        For Each item As IEnumerable(Of String) In lines.Split(84).ToArray()
            Debug.WriteLine(item.FirstOrDefault())
        Next

    End Sub
End Module
Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Iterator Function Split(Of T)(array() As T, size As Integer) As IEnumerable(Of IEnumerable(Of T))
        For index = 0 To (CSng(array.Length) / size) - 1
            Yield array.Skip(index * size).Take(size)
        Next
    End Function
End Module
