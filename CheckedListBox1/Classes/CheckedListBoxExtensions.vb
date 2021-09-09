Imports System.IO
Imports System.Runtime.CompilerServices
Imports Newtonsoft.Json

Namespace Classes
    Public Module CheckedListBoxExtensions

        Private ReadOnly Property JsonFileName() As String
            Get
                Return "Months.json"
            End Get
        End Property

        ''' <summary>
        ''' Responsible for loading CheckedListBox from a json file
        ''' </summary>
        ''' <param name="sender"></param>
        <Extension>
        Public Sub LoadJson(sender As CheckedListBox)
            Dim list = JsonConvert.DeserializeObject(Of List(Of MonthItem))(File.ReadAllText(JsonFileName()))
            For index As Integer = 0 To list.Count - 1
                sender.Items.Add(list(index).Text)
                sender.SetItemChecked(index, list(index).Checked)
            Next

        End Sub

        ''' <summary>
        ''' Responsible for saving data to our json file
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <Extension>
        Public Function SaveToJson(sender As CheckedListBox) As Boolean
            Dim list = New List(Of MonthItem)

            Try
                For index As Integer = 0 To sender.Items.Count - 1
                    If sender.GetItemChecked(index) = True Then
                        list.Add(New MonthItem() With {.Checked = True, .Text = sender.Items(index).ToString()})
                    Else
                        list.Add(New MonthItem() With {.Checked = False, .Text = sender.Items(index).ToString()})
                    End If
                Next

                Dim json = JsonConvert.SerializeObject(list, Formatting.Indented)
                File.WriteAllText(JsonFileName(), json)

                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Module
End NameSpace