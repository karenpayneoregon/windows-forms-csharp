Imports System.IO
Imports System.Text.RegularExpressions

Module Module1

    Sub Main()
        Console.Title = "Demo"
        Demo()
        Console.ReadLine()
    End Sub

    Private Sub Demo()
        Dim data = New List(Of String) From
                {
                "ThisIsASentence",
                "TheQuickBrownFox",
                "ApplesOrangesGrapes"}

        data.ForEach(Sub(item) Console.WriteLine($"{item,-25}[{item.SplitCamelCase}]"))
    End Sub
    ''' <summary>
    ''' Removed 'mark of the web' from all files in a folder recursively 
    ''' </summary>
    ''' <param name="folderName">folder to perform the operation on</param>
    Public Sub UnblockFiles(folderName As String)
        If Not Directory.Exists(folderName) Then
            Return
        End If

        Dim start = New ProcessStartInfo With {
                .FileName = "powershell.exe",
                .Arguments = $"Get-ChildItem -Path '{folderName}' -Recurse | Unblock-File",
                .CreateNoWindow = True
                }

        Using process As Process = Process.Start(start)

        End Using
    End Sub
End Module
Public Module StringExtensions
    <Runtime.CompilerServices.Extension>
    Public Function SplitCamelCase(sender As String) As String

        Return Regex.Replace(Regex.Replace(sender,
        "(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"),
                             "(\p{Ll})(\P{Ll})",
                             "$1 $2")
    End Function

End Module
