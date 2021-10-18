Imports System.Globalization
Imports System.IO
Imports CsvHelper

Public Class FileOperations
    Public Shared Function Read(fileName As String) As List(Of Item)

        Using reader = New StreamReader(fileName)

            Using csv = New CsvReader(reader, CultureInfo.InvariantCulture)
                Return csv.GetRecords(Of Item)().ToList()
            End Using

        End Using
        
    End Function
    Public Shared Sub Save(fileName As String, records As List(Of Item))

        Using writer As New StreamWriter(fileName)
            Using csvWriter As New CsvWriter(writer, CultureInfo.InvariantCulture)
                csvWriter.WriteRecords(DirectCast(records, IEnumerable))
                csvWriter.Dispose()
            End Using
        End Using

    End Sub
End Class