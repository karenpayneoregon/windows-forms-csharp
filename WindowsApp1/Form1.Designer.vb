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
        Me.AddButton = New System.Windows.Forms.Button()
        Me.IncrementButton = New System.Windows.Forms.Button()
        Me.RemoveButtonButton = New System.Windows.Forms.Button()
        Me.CustomLabel1 = New WindowsApp1.CustomLabel()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(15, 19)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(111, 23)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "Add button"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'IncrementButton
        '
        Me.IncrementButton.Location = New System.Drawing.Point(15, 48)
        Me.IncrementButton.Name = "IncrementButton"
        Me.IncrementButton.Size = New System.Drawing.Size(111, 23)
        Me.IncrementButton.TabIndex = 2
        Me.IncrementButton.Text = "Increment"
        Me.IncrementButton.UseVisualStyleBackColor = True
        '
        'RemoveButtonButton
        '
        Me.RemoveButtonButton.Location = New System.Drawing.Point(15, 77)
        Me.RemoveButtonButton.Name = "RemoveButtonButton"
        Me.RemoveButtonButton.Size = New System.Drawing.Size(111, 23)
        Me.RemoveButtonButton.TabIndex = 3
        Me.RemoveButtonButton.Text = "Remove Button"
        Me.RemoveButtonButton.UseVisualStyleBackColor = True
        '
        'CustomLabel1
        '
        Me.CustomLabel1.AutoSize = True
        Me.CustomLabel1.Identifier = -1
        Me.CustomLabel1.Location = New System.Drawing.Point(132, 24)
        Me.CustomLabel1.Name = "CustomLabel1"
        Me.CustomLabel1.Size = New System.Drawing.Size(74, 13)
        Me.CustomLabel1.TabIndex = 1
        Me.CustomLabel1.Text = "CustomLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 144)
        Me.Controls.Add(Me.RemoveButtonButton)
        Me.Controls.Add(Me.IncrementButton)
        Me.Controls.Add(Me.CustomLabel1)
        Me.Controls.Add(Me.AddButton)
        Me.Name = "Form1"
        Me.Text = "Code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents CustomLabel1 As CustomLabel
    Friend WithEvents IncrementButton As Button
    Friend WithEvents RemoveButtonButton As Button
End Class
