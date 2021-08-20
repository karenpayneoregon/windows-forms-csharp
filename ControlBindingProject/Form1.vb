Imports ControlBindingProject.Classes

Public Class Form1
    WithEvents lastNameBindingSource As New BindingSource
    WithEvents firstNameBindingSource As New BindingSource

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        firstNameBindingSource.DataSource = Mocked.FirstNames()
        FirstNameComboBox.DataSource = firstNameBindingSource

        lastNameBindingSource.DataSource = Mocked.LastNames()
        LastNameComboBox.DataSource = lastNameBindingSource

        ChangePosition()

    End Sub
    ''' <summary>
    ''' When either ComboBox selection changes update NameTextBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BindingSources_PositionChanged(sender As Object, e As EventArgs) _
        Handles firstNameBindingSource.PositionChanged,
                lastNameBindingSource.PositionChanged

        ChangePosition()

    End Sub

    Private Sub ChangePosition()

        If firstNameBindingSource.Current IsNot Nothing AndAlso lastNameBindingSource.Current IsNot Nothing Then
            NameTextBox.Text = $"{FirstNameComboBox.Text} {LastNameComboBox.Text}"
        End If

    End Sub
End Class