Public Class Form1
    Private ReadOnly EmployeeBindingSource As BindingSource = New BindingSource()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Code sample"
        EmployeeBindingSource.DataSource = Operations.ReadEmployee()
        EmployeeComboBox.DataSource = EmployeeBindingSource
    End Sub

    Private Sub CurrentButton_Click(sender As Object, ea As EventArgs) Handles CurrentButton.Click
        Dim e = CType(EmployeeBindingSource.Current, Employee)
        MessageBox.Show($"{e.TitleOfCourtesy} {e.LastName}{vbCr}{e.BirthDate.ToShortDateString()}{vbCr}{e.HomePhone}")
    End Sub
End Class
