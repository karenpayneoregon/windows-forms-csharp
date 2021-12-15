Imports System

Module Program
    Sub Main(args As String())
        'Dim lines = Enumerable.Range(1, 252).Select(Function(x) $"Line {x}").ToArray()

        'For Each item As IEnumerable(Of String) In lines.Split(84).ToArray()
        '    Debug.WriteLine(item.FirstOrDefault())
        'Next
        RemoveAtIndex()
    End Sub
    Private Sub RemoveAtIndex()
        Dim NumberArray() As Integer = {1, 2, 3, 12, 4, 5, 6}

        Dim value As Integer = 12
        Dim position As Integer = Array.FindIndex(NumberArray, Function(item) item = value)

        If position > -1 Then
            'NumberArray = NumberArray.Where(Function(source, index) index <> position).ToArray()
            NumberArray = NumberArray.RemoveAtIndex(position)
        End If

        Debug.WriteLine(String.Join(",", NumberArray))

    End Sub
End Module
Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Iterator Function Split(Of T)(array() As T, size As Integer) As IEnumerable(Of IEnumerable(Of T))
        For index = 0 To (CSng(array.Length) / size) - 1
            Yield array.Skip(index * size).Take(size)
        Next
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function RemoveAtIndex(Of T)(source() As T, index As Integer) As T()

        Dim resultArray(source.Length - 2) As T

        If index > 0 Then
            Array.Copy(source, 0, resultArray, 0, index)
        End If

        If index < source.Length - 1 Then
            Array.Copy(source, index + 1, resultArray, index, source.Length - index - 1)
        End If

        Return resultArray

    End Function
End Module
