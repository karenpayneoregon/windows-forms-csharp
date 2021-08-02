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
