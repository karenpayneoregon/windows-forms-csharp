Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

        If String.Equals(TextBox1.Text, "karen", StringComparison.OrdinalIgnoreCase) Then
            RemoveHandler TextBox1.TextChanged, AddressOf TextBox1_TextChanged
            TextBox1.Text = "Karen Payne"
            TextBox1.SelectionStart = TextBox1.Text.Length
            TextBox1.SelectionLength = 0
            AddHandler TextBox1.TextChanged, AddressOf TextBox1_TextChanged
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler TextBox1.TextChanged, AddressOf TextBox1_TextChanged
    End Sub
End Class
