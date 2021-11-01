Imports System.IO
Imports Newtonsoft.Json

Public Class Operations
    Public Shared Function ReadEmployee() As List(Of Employee)
        Return JsonConvert.DeserializeObject(Of List(Of Employee))(File.ReadAllText("Employees.json"))
    End Function
End Class