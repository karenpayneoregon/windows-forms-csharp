Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim results = DataOperations.GetCategoriesList()

        If results.Exception Is Nothing Then
            CategoryComboBox.DataSource = results.Categories
        Else
            MessageBox.Show(results.Exception.Message)
        End If

    End Sub

    Private Sub GetCurrentCategoryButton_Click(sender As Object, e As EventArgs) Handles GetCurrentCategoryButton.Click
        Dim current = CType(CategoryComboBox.SelectedItem, Categories)
        MessageBox.Show($"{current.CategoryId}, {current.Description}")
    End Sub
End Class
Public Class DataOperations
    Private Shared _connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True"

    Public Shared Function GetCategoriesList() As (Categories As List(Of Categories), Exception As Exception)
        Dim list As New List(Of Categories)()

        Try
            Using cn = New SqlConnection(_connectionString)
                Using cmd = New SqlCommand() With {.Connection = cn}
                    cmd.CommandText = "SELECT CategoryID, CategoryName, Description FROM dbo.Categories"
                    cn.Open()
                    Dim reader = cmd.ExecuteReader()
                    Do While reader.Read()
                        list.Add(New Categories() With {.CategoryId = reader.GetInt32(0), .CategoryName = reader.GetString(1), .Description = reader.GetString(2)})
                    Loop
                End Using
            End Using

            Return (list, Nothing)
        Catch ex As Exception
            Return (list, ex)
        End Try



    End Function
End Class

Public Class Categories
    Public Property CategoryId() As Integer
    Public Property CategoryName() As String
    Public Property Description() As String
    Public Overrides Function ToString() As String
        Return CategoryName
    End Function
End Class

