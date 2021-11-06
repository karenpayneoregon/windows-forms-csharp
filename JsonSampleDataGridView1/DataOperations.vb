Imports System.IO
Imports Newtonsoft.Json

Public Class DataOperations
    Public Shared ReadOnly FileName As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Customers.json")
    Public Shared Function ReadConfiguration() As GridConfiguration
        If Not File.Exists(FileName) Then
            MockData()
        End If

        Return JsonConvert.DeserializeObject(Of GridConfiguration)(File.ReadAllText(FileName))
    End Function

    Public Shared Sub Save(ByVal source As GridConfiguration)
        File.WriteAllText(FileName, JsonConvert.SerializeObject(source, Formatting.Indented))
    End Sub

    ''' <summary>
    ''' Create mocked data, save as json
    ''' </summary>
    Public Shared Sub MockData()
        Dim definitions As New List(Of ColumnDefinition) From {
                New ColumnDefinition() With {
                .DataPropertyName = "Identifier",
                .HeaderText = "Id",
                .Visible = False
                },
                New ColumnDefinition() With {
                .DataPropertyName = "CompanyName",
                .HeaderText = "Company",
                .Visible = True
                },
                New ColumnDefinition() With {
                .DataPropertyName = "ContactType",
                .HeaderText = "Contact type",
                .Visible = True
                },
                New ColumnDefinition() With {
                .DataPropertyName = "ContactName",
                .HeaderText = "Contact",
                .Visible = True
                },
                New ColumnDefinition() With {
                .DataPropertyName = "GenderType",
                .HeaderText = "Gender",
                .Visible = True
                },
                New ColumnDefinition() With {
                .DataPropertyName = "ContactTypeIdentifier",
                .HeaderText = "",
                .Visible = False
                },
                New ColumnDefinition() With {
                .DataPropertyName = "GenderIdentifier",
                .HeaderText = "",
                .Visible = False
                }
                }

        Dim customers As New List(Of Customer) From {
                New Customer() With {
                .Identifier = 1,
                .CompanyName = "Alfreds Futterkiste",
                .ContactType = "Owner",
                .ContactName = "Maria Anders",
                .GenderType = "Female",
                .ContactTypeIdentifier = 7,
                .GenderIdentifier = 1
                },
                New Customer() With {
                .Identifier = 2,
                .CompanyName = "Die Wandernde Kuh",
                .ContactType = "Owner",
                .ContactName = "Rita Müller",
                .GenderType = "Female",
                .ContactTypeIdentifier = 7,
                .GenderIdentifier = 1
                },
                New Customer() With {
                .Identifier = 3,
                .CompanyName = "Chop-suey Chinese",
                .ContactType = "Assistant Sales Agent",
                .ContactName = "Yang Wang",
                .GenderType = "Male",
                .ContactTypeIdentifier = 2,
                .GenderIdentifier = 2
                }
                }

        Dim gridConfiguration As New GridConfiguration() With {
                .ColumnDefinitions = definitions,
                .Customers = customers
                }

        Dim json As String = JsonConvert.SerializeObject(gridConfiguration, Formatting.Indented)
        File.WriteAllText(FileName, json)
    End Sub
End Class