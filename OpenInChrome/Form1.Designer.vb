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
        Me.OpenPageButton = New System.Windows.Forms.Button()
        Me.PageTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'OpenPageButton
        '
        Me.OpenPageButton.Location = New System.Drawing.Point(16, 14)
        Me.OpenPageButton.Name = "OpenPageButton"
        Me.OpenPageButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenPageButton.TabIndex = 0
        Me.OpenPageButton.Text = "Open page"
        Me.OpenPageButton.UseVisualStyleBackColor = true
        '
        'PageTextBox
        '
        Me.PageTextBox.Location = New System.Drawing.Point(94, 12)
        Me.PageTextBox.Name = "PageTextBox"
        Me.PageTextBox.Size = New System.Drawing.Size(299, 23)
        Me.PageTextBox.TabIndex = 1
        Me.PageTextBox.Text = "http://www.google.com"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 58)
        Me.Controls.Add(Me.PageTextBox)
        Me.Controls.Add(Me.OpenPageButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open web page"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents OpenPageButton As Button
    Friend WithEvents PageTextBox As TextBox
End Class
