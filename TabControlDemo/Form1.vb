Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If TabControl1.SelectedTab Is InventoryEditTab Then
            TabControl1.SelectedTab = ViewInventoryTab
        Else
            TabControl1.SelectedTab = InventoryEditTab
        End If

    End Sub
End Class
