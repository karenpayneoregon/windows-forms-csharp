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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Console.WriteLine(Now)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1_Tick(Nothing, Nothing)
    End Sub
End Class
