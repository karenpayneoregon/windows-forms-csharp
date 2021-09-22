Option Infer On

Imports SpreadsheetLight

Namespace Classes
    Public Class SpreadSheetLightSearchOperations
        ''' <summary>
        ''' Find case insensitive token in all used rows/columns in a WorkSheet
        ''' </summary>
        ''' <param name="fileName">Excel file name (.xlsx only)</param>
        ''' <param name="sheetName">Sheet name to run against</param>
        ''' <param name="search">Token to find</param>
        ''' <returns>Name value tuple</returns>
        Public Shared Function Find(fileName As String, sheetName As String, search As String) _
            As (items As List(Of FoundItem), exception As Exception)

            Dim foundList = New List(Of FoundItem)()

            Try

                Using document = New SLDocument(fileName, sheetName)

                    Dim stats = document.GetWorksheetStatistics()

                    Dim columnIndex As Integer = 1
                    Do While columnIndex < stats.EndColumnIndex + 1

                        Dim rowIndex As Integer = 1

                        Do While rowIndex < stats.EndRowIndex + 1

                            If document.GetCellValueAsString(rowIndex, columnIndex).Equals(search, StringComparison.OrdinalIgnoreCase) Then

                                foundList.Add(New FoundItem() With {
                                                 .RowIndex = rowIndex,
                                                 .ColumnIndex = columnIndex,
                                                 .Column = SLConvert.ToColumnName(columnIndex)
                                                 })

                            End If

                            rowIndex += 1

                        Loop

                        columnIndex += 1

                    Loop

                End Using

                Return (foundList, Nothing)

            Catch exception As Exception
                Return (foundList, exception)
            End Try

        End Function
    End Class
    ''' <summary>
    ''' Result container for <see cref="Find"/> method
    ''' </summary>
    Public Class FoundItem
        Public Property RowIndex() As Integer
        Public Property Column() As String
        Public Property ColumnIndex() As Integer
        Public Overrides Function ToString() As String
            Return $"[{Column}:{RowIndex}]"
        End Function
    End Class
End Namespace