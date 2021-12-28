Public Class MainForm
    Private childRows As IReadOnlyList(Of DataRow)
    Private ReadOnly EmployeeBindingSource As New BindingSource
    Private ChildForm As Form1

    Private Sub Mocked()
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn With {.ColumnName = "EmployeeID", .DataType = GetType(Integer)})
        dt.Columns.Add(New DataColumn With {.ColumnName = "FirstName", .DataType = GetType(String)})
        dt.Columns.Add(New DataColumn With {.ColumnName = "LastName", .DataType = GetType(String)})
        dt.Columns.Add(New DataColumn With {.ColumnName = "HireDate", .DataType = GetType(Date)})
        DataGridView1.AutoGenerateColumns = False
        EmployeeBindingSource.DataSource = dt
        DataGridView1.DataSource = EmployeeBindingSource
    End Sub
    Private Sub ShowChildFormButton_Click(sender As Object, e As EventArgs) Handles ShowChildFormButton.Click
        ChildForm = New Form1
        ChildForm.Show()
        ChildForm.Top = Top
        ChildForm.Left = Left + Width
    End Sub
    ''' <summary>
    ''' Basic code to get rows from child form.
    ''' We could use LINQ/Lambda rather than a for-each
    ''' for obtaining only rows that met some condition
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GetRowsButton_Click(sender As Object, e As EventArgs) Handles GetRowsButton.Click

        If ChildForm IsNot Nothing Then
            childRows = ChildForm.DataRows
            For Each row As DataRow In childRows
                '
                ' Assert if a row should be added rather
                ' than simply adding all rows as done here
                '
                CType(EmployeeBindingSource.DataSource, DataTable).ImportRow(row)
            Next
        End If

    End Sub
    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Mocked()
    End Sub
End Class