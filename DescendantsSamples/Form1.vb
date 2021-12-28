Public Class Form1
    Private Sub ChangePropertiesButton_Click(sender As Object, e As EventArgs) _
        Handles ChangePropertiesButton.Click

        Dim Panel1Buttons = Panel1.Descendants(Of Button).Where(
            Function(b) b.FlatStyle = FlatStyle.Flat AndAlso b.BackColor = Color.Red).ToList()

        For Each panel1Button As Button In Panel1Buttons
            panel1Button.FlatAppearance.MouseOverBackColor = Color.White
        Next

        ListBox1.DataSource = Panel1Buttons.Select(Function(button) button.Name).ToList()
    End Sub
End Class