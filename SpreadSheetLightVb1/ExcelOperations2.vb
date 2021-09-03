Imports System.IO
Imports DocumentFormat.OpenXml.Spreadsheet
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

    Public Shared Sub DataGridViewExport(dataTable As DataTable)

        Dim document As New SLDocument()


        For index As Integer = 0 To dataTable.Columns.Count - 1
            document.SetCellValue(1, index + 1, dataTable.Columns(index).ColumnName)
        Next


        For index As Integer = 0 To dataTable.Rows.Count - 1
            document.SetCellValue(index + 2, 1, dataTable.Rows(index)(0).ToString())
            document.SetCellValue(index + 2, 2, dataTable.Rows(index)(1).ToString())
        Next

        Dim style As SLStyle = document.CreateStyle()
        style.Font.Bold = True
        document.SetRowStyle(1, 1, style)

        document.AutoFitColumn(1, 2)

        style = document.CreateStyle()
        style.SetHorizontalAlignment(HorizontalAlignmentValues.Right)
        document.SetColumnStyle(1, style)

        document.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Whatever you want")

        document.SaveAs("ExportedFormatted.xlsx")

    End Sub
    Public Shared Sub Numbers()
        Dim sl As New SLDocument()


        '123456789.12345
        Dim a1Value = "00001"
        sl.SetCellValue("A1", a1Value)
        sl.SetCellValue(2, 1, -123456789.12345)
        sl.SetCellValue(3, 1, New DateTime(2123, 4, 15))
        sl.SetCellValue(4, 1, 12.3456)
        sl.SetCellValue(5, 1, 12.3456)
        sl.SetCellValue("A6", 123456789.12345)

        Dim style As SLStyle = sl.CreateStyle()
        'style.FormatCode = "#,##0.000"
        'sl.SetCellStyle("A1", style)
        style.SetHorizontalAlignment(HorizontalAlignmentValues.Right)
        sl.SetCellStyle("A1", style)

        style = sl.CreateStyle()
        style.FormatCode = "$#,##0.00_);[Red]($#,##0.00)"
        sl.SetCellStyle(2, 1, style)

        style = sl.CreateStyle()
        style.FormatCode = "d mmm yyyy"
        sl.SetCellStyle(3, 1, style)

        ' we can just reassign like this because the only property
        ' we just used was the FormatCode property

        style.FormatCode = "0.00%"
        sl.SetCellStyle("A4", style)

        ' this means "number with fractional part (2 digit denominator)"
        style.FormatCode = "# ??/??"
        sl.SetCellStyle(5, 1, style)

        style.FormatCode = "0.000E+00"
        sl.SetCellStyle(6, 1, style)

        sl.AutoFitColumn(1, 10)

        sl.SaveAs("NumberFormat.xlsx")
        Console.WriteLine("End of program")
    End Sub
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
