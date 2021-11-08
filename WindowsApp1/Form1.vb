Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Operations.TestParameters("Karen", "USA", Nothing, 45)
    End Sub
End Class

Public Class Operations
    Public Shared Sub TestParameters(contactTitle As String, countryName As String, SomeDate As Date?, Id As Integer)
        Using cn = New SqlConnection With {.ConnectionString = ""}
            Using cmd = New SqlCommand With {.Connection = cn}
                cmd.CommandText = <SQL>
                    UPDATE SomeTable 
                    SET ContactName = @ContactTitle, CountryName = @CountryName,SomeDate = @SomeDate 
                    WHERE Id = @Id</SQL>.Value


                cmd.Parameters.Add("@ContactTitle", SqlDbType.DateTime)
                cmd.Parameters.Add("@CountryName", SqlDbType.DateTime)
                cmd.Parameters.Add("@SomeDate", SqlDbType.DateTime)
                cmd.Parameters.Add("@Id", SqlDbType.Int)

                cmd.Parameters("@CountryName").Value = countryName
                cmd.Parameters("@Id").Value = Id

                Dim test = cmd.Parameters.OfType(Of SqlParameter).Any(Function(param) param.Value Is Nothing)

                If test Then

                    For Each sqlParameter As SqlParameter In cmd.Parameters.OfType(Of SqlParameter)
                        Console.WriteLine($"{sqlParameter.ParameterName} -> [" &
                                          $"{If(sqlParameter.Value Is Nothing, "Null", sqlParameter.Value)}]")
                    Next

                End If
            End Using
        End Using
    End Sub

End Class