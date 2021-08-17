Imports SqlServerProject.Classes

Public Class Form1
    Private ReadOnly bindingSource As New BindingSource
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        DataGridView1.AutoGenerateColumns = False

        Dim results = EmployeeOperations.Read()

        If results.Success Then
            bindingSource.DataSource = results.DataTable
            DataGridView1.DataSource = bindingSource
        Else
            MessageBox.Show(results.Exceptions.Message)
        End If

    End Sub

    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click

        If Not String.IsNullOrWhiteSpace(FirstNameTextBox.Text) AndAlso Not String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            Dim employee As New Employee With {.FirstName = FirstNameTextBox.Text, .LastName = LastNameTextBox.Text, .HiredDate = DateTimePicker1.Value}
            Dim results = EmployeeOperations.Insert(employee)
            If results.success Then
                Dim table = CType(bindingSource.DataSource, DataTable)
                table.Rows.Add(New Object() {employee.Id, employee.LastName, employee.FirstName, employee.HiredDate})
                MessageBox.Show(employee.Id.ToString())
            Else
                MessageBox.Show(results.exception.Message)
            End If
        End If

    End Sub
End Class
