Imports System.Data.SqlClient

Public Class Operations
    Private Shared ConnectionString As String = "Your connection string"

    Public Shared Function UpdateOrder(changeDetail As String, issueIdentifier As String) As (success As Boolean, exception As Exception)
        Dim updateStatement = "UPDATE Temp_Table SET change_detail = @ChangeDetail WHERE IssueID = @IssueID"

        Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
            Using cmd As New SqlCommand With {.Connection = cn, .CommandText = updateStatement}

                cmd.Parameters.Add("@ChangeDetail", SqlDbType.NVarChar).Value = changeDetail
                cmd.Parameters.Add("@IssueID", SqlDbType.NVarChar).Value = issueIdentifier

                Try
                    cn.Open()
                    Return (cmd.ExecuteNonQuery = 1, Nothing)
                Catch exception As Exception
                    Return (False, exception)
                End Try
            End Using
        End Using
    End Function
End Class

'Public Module Test
'    Public Sub Tester()
'        Dim results As (success As Boolean, exception As Exception) = Operations.UpdateOrder(txt_req_details.Text, Main_Menu.txt_maxid.Text)
'        If results.success Then
'            ' record updated
'        Else
'            ' show error message -> results.exception.Message
'        End If
'    End Sub
'End Module
