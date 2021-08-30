Imports System.Data.SqlClient

Public Class DataOperationsSqlServer
    Private Shared ConnectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=NorthWindAzure1;Integrated Security=True"
    Public Shared LastException As Exception
    Public Shared Function LoadCustomerRecordsUsingDataTable() As DataTable

        Dim selectStatement =
                "SELECT Cust.CustomerIdentifier, CT.ContactTypeIdentifier, Cust.CompanyName, Cust.ContactName," &
                " CT.ContactTitle, Cust.Street, Cust.City, Countries.CountryName, Cust.PostalCode, Cust.Phone, " &
                " Cust.ModifiedDate FROM Customers AS Cust " &
                " INNER JOIN ContactType AS CT ON Cust.ContactTypeIdentifier = CT.ContactTypeIdentifier " &
                " INNER JOIN Countries ON Cust.CountryIdentifier = Countries.id"

        Dim customerDataTable = New DataTable

        Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
            Using cmd As New SqlCommand With {.Connection = cn}
                Try
                    cmd.CommandText = selectStatement

                    cn.Open()

                    customerDataTable.Load(cmd.ExecuteReader())

                    customerDataTable.Columns("CustomerIdentifier").ColumnMapping = MappingType.Hidden
                    customerDataTable.Columns("ContactTypeIdentifier").ColumnMapping = MappingType.Hidden
                    'customerDataTable.Columns("ModifiedDate").ColumnMapping = MappingType.Hidden

                Catch ex As Exception
                    LastException = ex
                End Try
            End Using
        End Using

        Return customerDataTable

    End Function

End Class