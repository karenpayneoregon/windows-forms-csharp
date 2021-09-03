Public Class GridToDataTableForm
    Private Sub GridToDataTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(New Object() {"000000", "Price adjustment for #02220"})
        DataGridView1.Rows.Add(New Object() {"000001", "BONELESS"})
        DataGridView1.Rows.Add(New Object() {"000002", "COD"})
    End Sub

    Private Sub ToTableButton_Click(sender As Object, e As EventArgs) Handles ToTableButton.Click
        Dim table = DataGridView1.GetDataTable()
        Try
            ExcelOperations2.DataGridViewExport(table)
            MessageBox.Show("Export done")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class