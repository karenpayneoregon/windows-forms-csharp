Imports System.Text.RegularExpressions

Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Function SplitCamelCase(ByVal sender As String) As String
        Return Regex.Replace(Regex.Replace(sender, "(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), "(\p{Ll})(\P{Ll})", "$1 $2")
    End Function
    <Runtime.CompilerServices.Extension>
    Public Sub ExpandColumns(sender As DataGridView, Optional sizable As Boolean = True)
        For Each col As DataGridViewColumn In sender.Columns
            If col.ValueType.Name <> "ICollection`1" Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Next col

        If Not sizable Then
            Return
        End If

        For index As Integer = 0 To sender.Columns.Count - 1
            Dim columnWidth As Integer = sender.Columns(index).Width

            sender.Columns(index).AutoSizeMode = DataGridViewAutoSizeColumnMode.None

            ' Set Width to calculated AutoSize value:
            sender.Columns(index).Width = columnWidth
        Next index


    End Sub
End Module
