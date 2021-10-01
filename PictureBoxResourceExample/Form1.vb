Public Class Form1

    Private ReadOnly ImageBindingSource As New BindingSource

    Private Sub SetImageButton_Click(sender As Object, e As EventArgs) Handles SetImageButton.Click

        If ListBox1.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim current = CType(ListBox1.SelectedItem, KeyValuePair(Of String, Bitmap))

        PictureBox1.Image = current.Value
        PictureBox1.ResourceName = current.Key

    End Sub
    Private Sub GetImageNameButton_Click(sender As Object, e As EventArgs) Handles GetImageNameButton.Click
        If Not String.IsNullOrWhiteSpace(PictureBox1.ResourceName) Then
            MessageBox.Show(PictureBox1.ResourceName)
        Else
            MessageBox.Show("Set an image and try again")
        End If
    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim items As New Dictionary(Of String, Bitmap)

        Dim results = My.Images.BitmapNames
        For Each result As String In results
            items.Add(result, My.Images.BitmapFromResource(result))
        Next

        ImageBindingSource.DataSource = items
        ListBox1.DataSource = ImageBindingSource
        ListBox1.DisplayMember = "Key"
        ListBox1.ValueMember = "Value"

        If items.Count > 0 Then
            PictureBox1.Image = items.First().Value
            PictureBox1.ResourceName = items.First().Key
        End If

    End Sub

End Class

