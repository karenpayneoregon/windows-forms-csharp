Imports System.Text.RegularExpressions

Module Module1

    Sub Main()
        Dim testValue = "(2)"
        Dim value = 0

        If testValue.AlphaToInteger(value) Then
            Console.WriteLine($"Yes: {testValue} can be convert to {value}")
        Else
            Console.WriteLine($"{testValue} is not an int")
        End If

        If Integer.TryParse(testValue, value) Then
            Console.WriteLine(value)
        Else
            Console.WriteLine($"{testValue} is not an int")
        End If

        Console.ReadLine()

    End Sub

End Module

Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Function AlphaToInteger(text As String, ByRef result As Integer) As Boolean
        Dim value = Regex.Replace(text, "[^0-9]", "")
        Return Integer.TryParse(value, result)
    End Function
End Module
