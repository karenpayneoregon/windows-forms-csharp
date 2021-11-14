Public Class Form1
    Private Sub dataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) _
        Handles dataGridView1.RowsAdded

        If CStr(dataGridView1.Rows(e.RowIndex).Cells(1).Value) <> "1" Then
            dataGridView1.Rows(e.RowIndex).Cells(0).Value = False
            dataGridView1.Rows(e.RowIndex).Cells(0) = New DataGridViewTextBoxCell()
            dataGridView1.Rows(e.RowIndex).Cells(0).Value = ""
            dataGridView1.Rows(e.RowIndex).Cells(0).ReadOnly = True
        End If

    End Sub

    Private Sub AddRowsButton_Click(sender As Object, e As EventArgs) _
        Handles AddRowsButton.Click

        For index As Integer = 0 To 5
            If CBool(index Mod 2) Then
                dataGridView1.Rows.Add(False, "0")
            Else
                dataGridView1.Rows.Add(False, "1")
            End If
        Next

    End Sub
End Class
