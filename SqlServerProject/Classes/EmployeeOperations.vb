Imports System.Data.SqlClient
Imports SqlServerProject.Classes

' ReSharper disable once CheckNamespace
Public Class EmployeeOperations

    Private Shared _connectionString As String =
                       "Data Source=.\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True"

    Public Shared Function Insert(employee As Employee) As (success As Boolean, exception As Exception)

        Using cn = New SqlConnection With {.ConnectionString = _connectionString}
            Using cmd = New SqlCommand With {.Connection = cn}

                cmd.CommandText =
                    "INSERT INTO dbo.Employees (LastName,FirstName,HireDate)  VALUES (@LastName,@FirstName,@HireDate);" &
                    "SELECT CAST(scope_identity() AS int);"

                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employee.FirstName
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName

                If employee.HiredDate.HasValue Then
                    cmd.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = employee.HiredDate.Value
                Else
                    cmd.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = DBNull.Value
                End If

                Try
                    cn.Open()

                    employee.Id = Convert.ToInt32(cmd.ExecuteScalar())

                    Return (True, Nothing)

                Catch ex As Exception

                    Return (False, ex)

                End Try
            End Using

        End Using
    End Function

    Public Shared Function Read() As (Success As Boolean, Exceptions As Exception, DataTable As DataTable)

        Dim Table As New DataTable

        Try

            Using cn = New SqlConnection With {.ConnectionString = _connectionString}
                Using cmd = New SqlCommand With {.Connection = cn}

                    cmd.CommandText = "SELECT EmployeeID, LastName, FirstName, HireDate FROM dbo.Employees WHERE ACTIVE = 1;"
                    cn.Open()
                    Table.Load(cmd.ExecuteReader())

                End Using

                Return (True, Nothing, Table)

            End Using

        Catch exception As Exception

            Return (False, exception, Nothing)

        End Try
    End Function
    ''' <summary>
    ''' Soft delete rather than a hard delete, see <see cref="Read"/> SELECT for Active column condition
    ''' </summary>
    ''' <param name="identifier"></param>
    ''' <returns></returns>
    Public Shared Function Remove(identifier As Integer) As (success As Boolean, exception As Exception)

        Try
            Using cn = New SqlConnection With {.ConnectionString = _connectionString}

                Using cmd = New SqlCommand With {.Connection = cn}

                    cmd.CommandText = $"UPDATE dbo.Employees SET [Active] = 0 WHERE EmployeeID = @identifier;"
                    cmd.Parameters.AddWithValue("@identifier", identifier)

                    cn.Open()
                    Dim affected = cmd.ExecuteNonQuery()
                    Return (affected = 1, Nothing)
                End Using

            End Using
        Catch exception As Exception
            Return (False, exception)
        End Try

    End Function
    Public Shared Function Update(employee As Employee) As (success As Boolean, exception As Exception)
        Throw New NotImplementedException
    End Function

End Class