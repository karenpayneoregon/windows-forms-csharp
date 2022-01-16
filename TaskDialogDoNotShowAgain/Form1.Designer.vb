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
        Me.DoNoShowAgainButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DoNoShowAgainButton
        '
        Me.DoNoShowAgainButton.Location = New System.Drawing.Point(28, 25)
        Me.DoNoShowAgainButton.Name = "DoNoShowAgainButton"
        Me.DoNoShowAgainButton.Size = New System.Drawing.Size(162, 23)
        Me.DoNoShowAgainButton.TabIndex = 0
        Me.DoNoShowAgainButton.Text = "Do not show again"
        Me.DoNoShowAgainButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 157)
        Me.Controls.Add(Me.DoNoShowAgainButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DoNoShowAgainButton As Button
End Class
