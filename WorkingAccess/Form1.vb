Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    Private Sub TestConnectionButton_Click(sender As Object, e As EventArgs) Handles TestConnectionButton.Click
        Dim result = AccessOperations.TestConnection()

        If result.Success Then
            MessageBox.Show("Connected")
        Else
            MessageBox.Show(result.Exception.Message)
        End If
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
End Class
