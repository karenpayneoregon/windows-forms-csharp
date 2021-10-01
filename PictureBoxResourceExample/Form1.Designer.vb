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
        Me.SetImageButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GetImageNameButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New PictureBoxResourceExample.ImageBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SetImageButton
        '
        Me.SetImageButton.Location = New System.Drawing.Point(16, 154)
        Me.SetImageButton.Name = "SetImageButton"
        Me.SetImageButton.Size = New System.Drawing.Size(153, 23)
        Me.SetImageButton.TabIndex = 0
        Me.SetImageButton.Text = "Set image"
        Me.SetImageButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 14)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(153, 134)
        Me.ListBox1.TabIndex = 1
        '
        'GetImageNameButton
        '
        Me.GetImageNameButton.Location = New System.Drawing.Point(16, 183)
        Me.GetImageNameButton.Name = "GetImageNameButton"
        Me.GetImageNameButton.Size = New System.Drawing.Size(153, 23)
        Me.GetImageNameButton.TabIndex = 3
        Me.GetImageNameButton.Text = "Get image name"
        Me.GetImageNameButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(175, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.ResourceName = Nothing
        Me.PictureBox1.Size = New System.Drawing.Size(278, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 228)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GetImageNameButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SetImageButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SetImageButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GetImageNameButton As Button
    Friend WithEvents PictureBox1 As ImageBox
End Class
