Public Class Form1
    Private Sub DoNoShowAgainButton_Click(sender As Object, e As EventArgs) Handles DoNoShowAgainButton.Click
        'My.Resources.QuestionBlue
        Dim options As New NoShowAgain With
                {
                    .Heading = "Question",
                    .Text = "Check something or other each time app starts",
                    .Caption = "Caption",
                    .Icon = My.Resources.QuestionBlue,
                    .VerificationText = "Do not show again",
                    .Owner = Me
                }

        Dim result As (DialogResult As NoShow, ShowAgain As Boolean) = Dialogs.DoNotShowAgain(options)

        MessageBox.Show($"{result.ShowAgain}, {result.DialogResult}")
    End Sub
End Class
Public Enum NoShow
    DoNotShowAgain
    StopOperation
    No
End Enum
Public Class NoShowAgain
    Public Property Heading() As String
    Public Property Text() As String
    Public Property Caption() As String
    Public Property VerificationText() As String
    Public Property Owner() As Form
    Public Property Icon() As Icon
End Class
Public Class Dialogs
    Public Shared Function DoNotShowAgain(Options As NoShowAgain) As (DialogResult As NoShow, ShowAgain As Boolean)

        Dim page = New TaskDialogPage() With
                {
                    .Heading = Options.Heading,
                    .Text = Options.Text,
                    .Caption = Options.Caption,
                    .Icon = New TaskDialogIcon(Options.Icon),
                    .AllowCancel = True,
                    .Verification = New TaskDialogVerificationCheckBox() With {.Text = Options.VerificationText},
                    .Buttons = New TaskDialogButtonCollection() From {TaskDialogButton.Yes, TaskDialogButton.No},
                    .DefaultButton = TaskDialogButton.No
                }

        If TaskDialog.ShowDialog(Options.Owner, page, TaskDialogStartupLocation.CenterOwner) = TaskDialogButton.Yes Then

            Dim showAgain As Boolean

            If page.Verification.Checked Then
                showAgain = False
            Else

                showAgain = True
            End If

            Return (NoShow.StopOperation, showAgain)

        Else

            Return (NoShow.No, True)

        End If

    End Function

End Class
