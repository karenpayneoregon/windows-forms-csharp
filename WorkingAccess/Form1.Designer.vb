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
        Me.TestConnectionButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TestConnectionButton
        '
        Me.TestConnectionButton.Location = New System.Drawing.Point(12, 12)
        Me.TestConnectionButton.Name = "TestConnectionButton"
        Me.TestConnectionButton.Size = New System.Drawing.Size(75, 23)
        Me.TestConnectionButton.TabIndex = 0
        Me.TestConnectionButton.Text = "Button1"
        Me.TestConnectionButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 173)
        Me.Controls.Add(Me.TestConnectionButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TestConnectionButton As Button
End Class
