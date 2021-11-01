<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.CurrentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EmployeeComboBox
        '
        Me.EmployeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmployeeComboBox.FormattingEnabled = True
        Me.EmployeeComboBox.Location = New System.Drawing.Point(12, 26)
        Me.EmployeeComboBox.Name = "EmployeeComboBox"
        Me.EmployeeComboBox.Size = New System.Drawing.Size(232, 21)
        Me.EmployeeComboBox.TabIndex = 0
        '
        'CurrentButton
        '
        Me.CurrentButton.Location = New System.Drawing.Point(264, 24)
        Me.CurrentButton.Name = "CurrentButton"
        Me.CurrentButton.Size = New System.Drawing.Size(75, 23)
        Me.CurrentButton.TabIndex = 1
        Me.CurrentButton.Text = "Current"
        Me.CurrentButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 223)
        Me.Controls.Add(Me.CurrentButton)
        Me.Controls.Add(Me.EmployeeComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmployeeComboBox As ComboBox
    Friend WithEvents CurrentButton As Button
End Class
