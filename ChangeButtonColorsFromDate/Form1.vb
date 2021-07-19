Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CheckDateCondition()
    End Sub

    Private Sub CheckDateCondition()
        If Now >= My.Settings.DateSetting Then

            Dim buttonList = Controls.
                    OfType(Of Button).
                    Where(Function(but) but.Name <> "Button1").
                    ToList()

            Button1.BackColor = Color.Red

            For Each button As Button In buttonList

                button.DataBindings.Add(
                    "BackColor",
                    Button1,
                    "BackColor")

            Next
        End If
    End Sub
End Class
