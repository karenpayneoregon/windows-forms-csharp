Imports System.IO
Imports SpreadsheetLight

Public Class ExcelOperations

    ''' <summary>
    ''' Export a DataTable to Excel
    ''' </summary>
    ''' <param name="pFileName">path and file name to save too, path is optional</param>
    ''' <param name="pSheetName">Name of sheet</param>
    ''' <param name="pDataTable">Populated DataTable</param>
    ''' <param name="pColumnHeaders">True for column names as first row, false no column names</param>
    Public Shared Sub SimpleExportRaw(pFileName As String, pSheetName As String, pDataTable As DataTable, pColumnHeaders As Boolean)

        Using doc As New SLDocument()

            doc.SelectWorksheet(pSheetName)

            doc.ImportDataTable(1, SLConvert.ToColumnIndex("A"), pDataTable, pColumnHeaders)

            SLConvert.ToColumnName(1)

            Dim style As New SLStyle With {.FormatCode = "MM/dd//yyyy"}

            ' Format modified date column
            doc.SetColumnStyle(9, style)

            style.Font.Bold = True
            doc.SetRowStyle(1, 1, style)

            Dim stats = doc.GetWorksheetStatistics()

            ' auto fit all columns
            doc.AutoFitColumn(1, stats.EndColumnIndex)

            ' original default name is Sheet1, let's change it to the name in pSheetName
            doc.RenameWorksheet(SLDocument.DefaultFirstSheetName, pSheetName)

            doc.SaveAs(pFileName)

        End Using

    End Sub
    Public Delegate Sub OnErrorDelegate(exception As Exception)
    Public Shared Event OnErrorEvent As OnErrorDelegate
    ''' <summary>
    ''' DemoExport.xlsx
    ''' Info_Table
    ''' </summary>
    ''' <param name="pFileName"></param>
    ''' <param name="pSheetName"></param>
    ''' <param name="pDataTable"></param>
    ''' <param name="pColumnHeaders"></param>
    ''' <param name="pStartRow"></param>
    Public Shared Function Export(pFileName As String, pSheetName As String, pDataTable As DataTable, pColumnHeaders As Boolean, Optional pStartRow As Integer = 3) As Boolean

        Try

            CopyFile(pFileName)

            Using doc As New SLDocument(pFileName)

                doc.SelectWorksheet(pSheetName)
                doc.ImportDataTable(pStartRow, SLConvert.ToColumnIndex("A"), pDataTable, pColumnHeaders)

                Dim style As New SLStyle With {.FormatCode = "MM/dd//yyyy"}


                If pDataTable.Columns.Contains("ModifiedDate") Then
                    doc.SetColumnStyle(pDataTable.Columns("ModifiedDate").Ordinal + 1, style)
                End If

                doc.Save()

                Return True

            End Using

        Catch ex As Exception
            RaiseEvent OnErrorEvent(ex)
            Return False
        End Try

    End Function
    Public Shared Sub Export(
         pFileName As String, 
         pSheetName As String, 
         pDataSet As DataSet, 
         pTableName As String, 
         pColumnHeaders As Boolean)

        Using doc As New SLDocument()

            doc.SelectWorksheet(pSheetName)
            doc.ImportDataTable(1, SLConvert.ToColumnIndex("A"), pDataSet.Tables(pTableName), pColumnHeaders)
            doc.RenameWorksheet(SLDocument.DefaultFirstSheetName, pSheetName)
            doc.SaveAs(pFileName)

        End Using

    End Sub
    Public Shared Sub ExportTable(pFileName As String, pSheetName As String, pDataTable As DataTable, pColumnHeaders As Boolean)

        Using doc As New SLDocument()
            doc.SelectWorksheet(pSheetName)
            doc.ImportDataTable(1, SLConvert.ToColumnIndex("A"), pDataTable, pColumnHeaders)
            doc.RenameWorksheet(SLDocument.DefaultFirstSheetName, pSheetName)
            doc.SaveAs(pFileName)
        End Using

    End Sub
    Public Shared Sub InsertTable()


    End Sub
    Private Shared Sub CopyFile(pFileName As String)
        Dim originalFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExcelFiles", pFileName)
        Dim targetFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pFileName)

        File.Copy(originalFile, targetFile, True)
    End Sub

    ''' <summary>
    ''' Mocked code sample to load a list
    ''' The try-catch is mainly here to ensure we don't happen
    ''' to run this code with the file open from a prior run
    '''
    ''' Option Strict On
    ''' Option Infer On
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function CreateAndPopulate() As Boolean

        Dim success = True
        Try
            Using doc As New SLDocument()

                Dim style As New SLStyle

                style.Font.Bold = True
                doc.SetRowStyle(1, 1, style)

                doc.SetCellValue("A1", "Last name")
                doc.SetCellValue("B1", "First name")

                Dim people = PeopleData.List()

                Dim rowIndex = 0

                For Each person In people
                    doc.SetCellValue($"A{rowIndex + 2}", people(rowIndex).LastName)
                    doc.SetCellValue($"B{rowIndex + 2}", people(rowIndex).FirstName)
                    rowIndex += 1
                Next


                Dim stats = doc.GetWorksheetStatistics()

                doc.AutoFitColumn(1, stats.EndColumnIndex)
                doc.RenameWorksheet(SLDocument.DefaultFirstSheetName, "People")


                doc.SaveAs("PeopleData.xlsx")

            End Using
        Catch ex As Exception
            Console.WriteLine($"{ex.Message}")
            success = False
        End Try

        Return success

    End Function

    ''' <summary>
    ''' Writes three values to the default worksheet
    ''' </summary>
    ''' <param name="fileName"></param>
    ''' <param name="value1"></param>
    ''' <param name="value2"></param>
    ''' <param name="value3"></param>
    Public Shared Sub SimpleWrite(fileName As String, value1 As String, value2 As String, value3 As String)

        If Not File.Exists(fileName) Then
            Throw New FileNotFoundException($"Dude failed to find {fileName}")
        End If

        If Not String.IsNullOrWhiteSpace(value1) AndAlso Not String.IsNullOrWhiteSpace(value2) AndAlso Not String.IsNullOrWhiteSpace(value3) Then

            Try

                Using doc As New SLDocument(fileName)

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