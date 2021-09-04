Imports System.IO
Imports SpreadsheetLight

Public Class ExcelOperations3
    Private Shared ReadOnly Property _excelFileName() As String
        Get
            Return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Customers.xlsx")
        End Get
    End Property

    Private Shared _sheetName As String = "Customers"

    Public Shared ReadOnly Property FileExist() As Boolean
        Get
            Return File.Exists(_excelFileName)
        End Get
    End Property

    Public Shared Property Exception() As Exception
    Public Shared Function Read() As DataTable

        Exception = Nothing

        Dim dt = New DataTable()

        dt.Columns.Add("CompanyName", GetType(String))
        dt.Columns.Add("ContactName", GetType(String))
        dt.Columns.Add("ContactTitle", GetType(String))
        dt.Columns.Add("Country", GetType(String))

        Try

            Using doc = New SLDocument(_excelFileName, _sheetName)

                Dim stats = doc.GetWorksheetStatistics()

                Dim index As Integer = 2

                Do While index < stats.EndRowIndex + 1

                    Dim col1Value = doc.GetCellValueAsString(index, 1)
                    Dim col2Value = doc.GetCellValueAsString(index, 2)
                    Dim col3Value = doc.GetCellValueAsString(index, 3)
                    Dim col4Value = doc.GetCellValueAsString(index, 6)

                    dt.Rows.Add(New Object() {col1Value, col2Value, col3Value, col4Value})

                    index += 1

                Loop


            End Using

        Catch exceptionObject As Exception

            Exception = exceptionObject

        End Try

        Return dt

    End Function

End Class
