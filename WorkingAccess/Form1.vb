Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    Private EmployeeBindingSource As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeeBindingSource.DataSource = AccessOperations.ReadEmployees()
        DataGridView1.DataSource = EmployeeBindingSource

    End Sub

    Private Sub CurrentRowButton_Click(sender As Object, e As EventArgs) Handles CurrentRowButton.Click
        If EmployeeBindingSource.Current IsNot Nothing Then
            Dim row = CType(EmployeeBindingSource.Current, DataRowView).Row

            Dim id = row.Field(Of Integer)("EmployeeID")
            Dim FirstName = row.Field(Of String)("FirstName")
            Dim LastName = row.Field(Of String)("LastName")
            Dim Country = row.Field(Of String)("Country")

            MessageBox.Show($"{id},{FirstName},{LastName},{Country}")

        End If
    End Sub

    Private Sub LastRowButton_Click(sender As Object, e As EventArgs) Handles LastRowButton.Click
        Dim row = CType(EmployeeBindingSource(EmployeeBindingSource.Count - 1), DataRowView).Row
        Dim id = row.Field(Of Integer)("EmployeeID")
        Dim FirstName = row.Field(Of String)("FirstName")
        Dim LastName = row.Field(Of String)("LastName")
        Dim Country = row.Field(Of String)("Country")

        MessageBox.Show($"{id},{FirstName},{LastName},{Country}")

    End Sub
End Class

Public Class AccessOperations
    Public Shared Function TestConnection() As (Success As Boolean, Exception As Exception)

        Dim fileName = "Database1.accdb"

        If Not File.Exists(fileName) Then
            Return (False, New FileNotFoundException(fileName))
        End If

        Dim builder =
                New OleDbConnectionStringBuilder With
                {
                    .DataSource = "Database1.accdb",
                    .Provider = "Microsoft.ACE.OLEDB.12.0"
                }


        Using cn As New OleDbConnection With {.ConnectionString = builder.ConnectionString}
            Try

                cn.Open()

                Return (True, Nothing)

            Catch ex As Exception
                Return (False, ex)
            End Try
        End Using

    End Function

    Public Shared Function ReadEmployees() As DataTable
        Dim builder =
                New OleDbConnectionStringBuilder With
                {
                    .DataSource = "Database1.accdb",
                    .Provider = "Microsoft.ACE.OLEDB.12.0"
                }

        Using cn As New OleDbConnection With {.ConnectionString = builder.ConnectionString}
            Using cmd As New OleDbCommand With {.Connection = cn}
                cmd.CommandText = "SELECT EmployeeID, LastName, FirstName, Country FROM Employees;"
                cn.Open()
                Dim dt As New DataTable
                dt.Load(cmd.ExecuteReader())
                Return dt
            End Using
        End Using

    End Function
End Class
