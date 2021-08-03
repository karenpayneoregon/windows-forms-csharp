Public Class Form1
    Private _dataTable As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = New DataTable With {.TableName = "MyTable"}

        dt.Columns.Add(New DataColumn With {.ColumnName = "Identifier", .DataType = GetType(Integer)})
        dt.Columns.Add(New DataColumn With {.ColumnName = "Name", .DataType = GetType(String)})
        dt.Columns.Add(New DataColumn With {.ColumnName = "Status", .DataType = GetType(Boolean)})

        dt.Rows.Add(New Object() {100, "Karen", False})
        dt.Rows.Add(New Object() {200, "Marty", True})
        dt.Rows.Add(New Object() {300, "Bill", True})
        dt.Rows.Add(New Object() {400, "Anne", False})
        dt.Rows.Add(New Object() {500, "Greg", True})

        _dataTable = dt

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each row As DataRow In _dataTable.Rows
            Console.WriteLine($"{row.RowId(),-3}{row.Field(Of Integer)("Identifier"),-4}{row.Field(Of String)("Name")}")
        Next
    End Sub
End Class