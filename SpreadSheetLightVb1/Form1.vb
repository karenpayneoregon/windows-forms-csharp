Imports System.ComponentModel
Imports System.IO
Imports SpreadSheetLightVb1.Classes

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DataGridView1.DataSource = DataOperationsSqlServer.LoadCustomerRecordsUsingDataTable()
        AddHandler ExcelOperations1.OnErrorEvent, AddressOf OnExcelExportError
    End Sub

    Private Sub ExportToExcelButton_Click(sender As Object, e As EventArgs) Handles ExportToExcelButton.Click

        Dim dt = CType(DataGridView1.DataSource, DataTable)
        Dim dtClone = dt.Copy()

        Dim items = dtClone.Columns.OfType(Of DataColumn).
                Where(Function(column) column.ColumnMapping = MappingType.Hidden).ToList()

        For Each column As DataColumn In items
            dtClone.Columns.Remove(column)
        Next

        ExcelOperations.SimpleExportRaw("Customers.xlsx", "Customers", dtClone, True)
        MessageBox.Show("Exported")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ExcelOperations.CreateAndPopulate() Then
            MessageBox.Show("Done")
        Else
            MessageBox.Show("See console window for issues")
        End If
    End Sub

    Private Sub ExportSimpleButton_Click(sender As Object, e As EventArgs) Handles ExportSimpleButton.Click
        Dim dt = CType(DataGridView1.DataSource, DataTable)
        If ExcelOperations1.Import("DemoExport.xlsx", "Info_Table", dt, False) Then
            MessageBox.Show("Done")
        End If
    End Sub
    Private Sub OnExcelExportError(exception As Exception)
        MessageBox.Show(exception.Message)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ExcelOperations2.SimpleWrite("SimpleWriteExample.xlsx", "Karen", "Payne", "Wrote this")
        MessageBox.Show("Done")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SomeFile.xlsx")
        Dim sheetName = "SomeSheetName"

        Dim Results = SpreadSheetLightSearchOperations.Find(fileName, sheetName, FindTextBox.Text)

        If Results.exception IsNot Nothing Then
            For Each foundItem As FoundItem In Results.items
                Debug.WriteLine(foundItem)
            Next
        End If

    End Sub
End Class