Imports System.ComponentModel

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

        ImageBindingSource.DataSource = My.Images.BitMapImages

        ListBox1.DataSource = ImageBindingSource
        ListBox1.DisplayMember = "Key"
        ListBox1.ValueMember = "Value"

        If My.Images.HasImages Then
            If Not String.IsNullOrWhiteSpace(My.Settings.SelectedImageName) Then
                If My.Images.BitMapImages.ContainsKey(My.Settings.SelectedImageName) Then
                    PictureBox1.Image = My.Images.BitMapImages(My.Settings.SelectedImageName)
                    PictureBox1.ResourceName = My.Settings.SelectedImageName
                    ListBox1.SelectedIndex = ListBox1.FindString(My.Settings.SelectedImageName)
                Else
                    PictureBox1.Image = My.Images.BitMapImages.First().Value
                    PictureBox1.ResourceName = My.Images.BitMapImages.First().Key
                End If
            End If
        End If

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not String.IsNullOrWhiteSpace(PictureBox1.ResourceName) Then
            My.Settings.SelectedImageName = CType(ListBox1.SelectedItem, KeyValuePair(Of String, Bitmap)).Key
        End If
    End Sub
End Class

