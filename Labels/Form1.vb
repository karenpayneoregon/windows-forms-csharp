Imports System.IO
Imports System.Xml.Serialization

Public Class Form1
    Private ReadOnly LabelList As New List(Of Label)
    Private ReadOnly RestLabelList As New List(Of Label)

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        LabelList.AddRange(New Label() _
                              {
                                  Label1,
                                  Label2,
                                  Label3,
                                  Label4,
                                  Label5,
                                  Label6,
                                  Label7
                              })

        For Each label As Label In LabelList
            RestLabelList.Add(label)
        Next





    End Sub

    Private Sub WorkButton_Click(sender As Object, e As EventArgs) Handles WorkButton.Click

        Dim parts = ItemTextBox.Text.Split(" "c)

        If LabelList.Any(Function(currentLabel) currentLabel.Text.ContainsAll(parts)) Then
            LabelList.ForEach(
                Sub(label)
                    If label.Text.ContainsAll(parts) Then
                        label.ForeColor = Color.Red
                    End If
                End Sub)
        End If

    End Sub

    Private Sub RestButton_Click(sender As Object, e As EventArgs) Handles RestButton.Click

        For index As Integer = 0 To RestLabelList.Count - 1
            RestLabelList(index).ForeColor = Color.Empty
        Next

    End Sub
End Class