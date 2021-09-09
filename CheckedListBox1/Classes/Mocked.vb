Imports System.IO
Imports Newtonsoft.Json

Namespace Classes
    ''' <summary>
    ''' Code to create initial json file
    ''' </summary>
    Public Module Mocked
        Public Function MonthList() As List(Of MonthItem)
            Return New List(Of MonthItem) From {
                New MonthItem() With {.Text = "January", .Checked = False},
                New MonthItem() With {.Text = "February", .Checked = False},
                New MonthItem() With {.Text = "March", .Checked = False},
                New MonthItem() With {.Text = "April", .Checked = False},
                New MonthItem() With {.Text = "May", .Checked = False},
                New MonthItem() With {.Text = "June", .Checked = False},
                New MonthItem() With {.Text = "July", .Checked = False},
                New MonthItem() With {.Text = "August", .Checked = False},
                New MonthItem() With {.Text = "September", .Checked = False},
                New MonthItem() With {.Text = "October", .Checked = False},
                New MonthItem() With {.Text = "November", .Checked = False},
                New MonthItem() With {.Text = "December", .Checked = False}
                }

        End Function

        Public Sub CreateJsonFile()
            Dim json = JsonConvert.SerializeObject(MonthList(), Formatting.Indented)
            File.WriteAllText("Months.json", json)
        End Sub
    End Module
End Namespace