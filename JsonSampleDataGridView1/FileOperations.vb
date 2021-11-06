Imports System.IO

Public Class FileOperations
    Public Shared Function GetJsonFile() As List(Of JsonFile)

        Dim list = New List(Of JsonFile)
        Dim files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.json")

        For Each file As String In files
            list.Add(New JsonFile() With {.FileName = file, .DisplayText = Path.GetFileName(file)})
        Next

        Return list

    End Function

End Class