Imports System.Collections.Immutable
Imports SqlServerProject.Classes

Public Class Form1
    Private ReadOnly EmployeeBindingSource As New BindingSource
    Public Function DataRows() As IReadOnlyList(Of DataRow)
        Return CType(EmployeeBindingSource.DataSource, DataTable).Rows.Cast(Of DataRow).ToImmutableList()
    End Function
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        DataGridView1.AutoGenerateColumns = False

        Dim results As (Success As Boolean, Exceptions As Exception, DataTable As DataTable) = EmployeeOperations.Read()

        If results.Success Then
            EmployeeBindingSource.DataSource = results.DataTable
            DataGridView1.DataSource = EmployeeBindingSource
        Else
            MessageBox.Show(results.Exceptions.Message)
        End If

    End Sub

    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click

        If Not String.IsNullOrWhiteSpace(FirstNameTextBox.Text) AndAlso Not String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then
            Dim employee As New Employee With {.FirstName = FirstNameTextBox.Text, .LastName = LastNameTextBox.Text, .HiredDate = DateTimePicker1.Value}
            Dim results = EmployeeOperations.Insert(employee)
            If results.success Then
                Dim table = CType(EmployeeBindingSource.DataSource, DataTable)
                table.Rows.Add(New Object() {employee.Id, employee.LastName, employee.FirstName, employee.HiredDate})
                MessageBox.Show(employee.Id.ToString())
            Else
                MessageBox.Show(results.exception.Message)
            End If
        End If

    End Sub

    Private Sub RemoveCurrentButton_Click(sender As Object, e As EventArgs) Handles RemoveCurrentButton.Click
        If EmployeeBindingSource.Current IsNot Nothing Then
            If Question("Remove current") Then
                Dim id = CType(EmployeeBindingSource.Current, DataRowView).Row.Field(Of Integer)("EmployeeID")

                Dim results = EmployeeOperations.Remove(id)
                If results.success Then
                    EmployeeBindingSource.RemoveCurrent()
                Else
                    MessageBox.Show(results.exception.Message)
                End If
            End If
        End If

    End Sub


    Private Sub SearchButton_Click(sender As Object, e As EventArgs) _
        Handles SearchButton.Click

        If String.IsNullOrWhiteSpace(SearchTextBox.Text) Then
            EmployeeBindingSource.Filter = ""
        Else
            Dim currentRowCount = EmployeeBindingSource.Count
            EmployeeBindingSource.Filter = $"TRIM(LastName) = '{SearchTextBox.Text}'"
            MessageBox.Show($"Before: {currentRowCount} Now: {EmployeeBindingSource.Count}")
        End If

    End Sub

End Class