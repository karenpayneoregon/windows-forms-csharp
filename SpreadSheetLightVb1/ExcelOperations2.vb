Imports System.IO
Imports SpreadsheetLight

''' <summary>
''' 
''' Requires NuGet package SpreadsheetLight, free to use
''' 
''' For .NET Framework          Install-Package SpreadsheetLight -Version 3.5.0
''' For .NET Core Framework     Install-Package SpreadsheetLight.Core -Version 3.4.0
''' </summary>
''' <remarks>
''' SpreadSheetLight home page which has a help file
''' https://spreadsheetlight.com/
''' </remarks>
Public Class ExcelOperations2
    ''' <summary>
    ''' Writes three values to the default worksheet
    ''' </summary>
    ''' <param name="fileName">Existing file</param>
    ''' <param name="value1">first value to write</param>
    ''' <param name="value2">second value to write</param>
    ''' <param name="value3">three value to write</param>
    Public Shared Sub SimpleWrite(fileName As String, value1 As String, value2 As String, value3 As String)

        If Not File.Exists(fileName) Then
            Throw New FileNotFoundException($"Dude failed to find {fileName}")
        End If

        If Not String.IsNullOrWhiteSpace(value1) AndAlso Not String.IsNullOrWhiteSpace(value2) AndAlso Not String.IsNullOrWhiteSpace(value3) Then

            Try

                Using doc As New SLDocument(fileName)
                    '
                    ' SLConvert.ToColumnName(1) converts 1 to A, if you want B use 2 etc.
                    ' So value1 is written to A2, value2 to A3 etc.
                    '
                    doc.SetCellValue($"{SLConvert.ToColumnName(1)}2", value1)
                    doc.SetCellValue($"{SLConvert.ToColumnName(1)}3", value2)
                    doc.SetCellValue($"{SLConvert.ToColumnName(1)}4", value3)

                    doc.Save()

                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        Else
            Console.WriteLine("Missing one or more values")
        End If

    End Sub
    Public Shared Sub SimpleWrite(fileName As String, workSheetName As String, value1 As String, value2 As String, value3 As String)

        If Not File.Exists(fileName) Then
            Throw New FileNotFoundException($"Dude failed to find {fileName}")
        End If

        If Not String.IsNullOrWhiteSpace(value1) AndAlso Not String.IsNullOrWhiteSpace(value2) AndAlso Not String.IsNullOrWhiteSpace(value3) Then

            Try

                Using doc As New SLDocument(fileName)

                    If SheetExists(doc, workSheetName) Then
                        doc.SelectWorksheet(workSheetName)
                    End If


                    doc.SetCellValue($"{SLConvert.ToColumnName(1)}2", value1)
                    doc.SetCellValue($"{SLConvert.ToColumnName(1)}3", value2)
                    doc.SetCellValue($"{SLConvert.ToColumnName(1)}4", value3)

                    doc.Save()

                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try

        Else
            Console.WriteLine("Missing one or more values")
        End If

    End Sub
    Public Shared Function SheetExists(doc As SLDocument, pSheetName As String) As Boolean
        Return doc.GetSheetNames(False).Any(Function(sheetName) sheetName.ToLower() = pSheetName.ToLower())
    End Function
End Class
