Namespace Classes
    Public Module Dialogs

        Public Function Question(text As String) As Boolean
            Return (MessageBox.Show(text, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes)
        End Function


    End Module
End Namespace