Public Class LimitedForm
    Private Sub LimitedForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DataGridView1.DataSource = ExcelOperations3.Read()
        For Each dataGridViewColumn As DataGridViewColumn In DataGridView1.Columns
            dataGridViewColumn.HeaderText = dataGridViewColumn.HeaderText.SplitCamelCase()
        Next
        DataGridView1.ExpandColumns()
    End Sub

End Class