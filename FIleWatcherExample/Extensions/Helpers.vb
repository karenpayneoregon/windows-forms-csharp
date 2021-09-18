Public Module Helpers
    ''' <summary>
    ''' Add asterisk for wild card to start of string
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension>
    Public Function PrependAsterisk(ByVal sender As String) As String
        Return If(sender.StartsWith("."c), $"*{sender}", sender)
    End Function
End Module
