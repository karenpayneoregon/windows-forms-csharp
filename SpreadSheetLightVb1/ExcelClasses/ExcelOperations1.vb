Imports System.IO
Imports SpreadsheetLight

Public Class ExcelOperations1
    Public Delegate Sub OnErrorDelegate(exception As Exception)
    Public Shared Event OnErrorEvent As OnErrorDelegate
    ''' <summary>
    ''' Insert DataTable into an existing Excel WorkSheet
    ''' </summary>
    ''' <param name="pFileName">Existing Excel file</param>
    ''' <param name="pSheetName">Existing WorkSheet in pFileName</param>
    ''' <param name="pDataTable">DataTable</param>
    ''' <param name="pColumnHeaders">Use column name from DataTable as headers</param>
    ''' <param name="pStartRow">Row to start the import</param>
    Public Shared Function Import(pFileName As String, pSheetName As String, pDataTable As DataTable, pColumnHeaders As Boolean, Optional pStartRow As Integer = 3) As Boolean

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

    Private Shared Sub CopyFile(pFileName As String)

        Dim originalFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ExcelFiles", pFileName)
        Dim targetFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pFileName)

        File.Copy(originalFile, targetFile, True)

    End Sub
    Public Shared Function SheetExists(doc As SLDocument, pSheetName As String) As Boolean
        Return doc.GetSheetNames(False).Any(Function(sheetName) sheetName.ToLower() = pSheetName.ToLower())
    End Function
    Public Function SheetNames(pFileName As String) As List(Of String)
        Using doc = New SLDocument(pFileName)
            Return doc.GetSheetNames(False)
        End Using
    End Function
    ''' <summary>
    ''' Remove a sheet if it exists.
    ''' </summary>
    ''' <param name="pFileName">Existing Excel file</param>
    ''' <param name="pSheetName"></param>
    ''' <returns></returns>
    Public Function RemoveWorkSheet(pFileName As String, pSheetName As String) As Boolean

        Using doc As New SLDocument(pFileName)

            Dim workSheets = doc.GetSheetNames(False)

            If workSheets.Any(Function(sheetName) sheetName.ToLower() = pSheetName.ToLower()) Then

                If workSheets.Count > 1 Then
                    doc.SelectWorksheet(doc.GetSheetNames().FirstOrDefault(Function(sName) sName.ToLower() <> pSheetName.ToLower()))
                ElseIf workSheets.Count = 1 Then
                    RaiseEvent OnErrorEvent(New Exception("Can not delete the sole worksheet"))
                End If

                doc.DeleteWorksheet(pSheetName)
                doc.Save()

                Return True

            Else
                Return False
            End If

        End Using

    End Function
    ''' <summary>
    ''' Add a new sheet if it does not currently exists.
    ''' </summary>
    ''' <param name="pFileName"></param>
    ''' <param name="pSheetName"></param>
    ''' <returns></returns>
    Public Function AddNewSheet(pFileName As String, pSheetName As String) As Boolean

        Using doc = New SLDocument(pFileName)

            If Not (SheetExists(doc, pSheetName)) Then

                doc.AddWorksheet(pSheetName)
                doc.Save()

                Return True

            Else
                Return False
            End If

        End Using

    End Function
End Class
