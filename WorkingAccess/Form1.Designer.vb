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
        Me.CurrentRowButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LastRowButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'CurrentRowButton
        '
        Me.CurrentRowButton.Location = New System.Drawing.Point(12, 251)
        Me.CurrentRowButton.Name = "CurrentRowButton"
        Me.CurrentRowButton.Size = New System.Drawing.Size(75, 23)
        Me.CurrentRowButton.TabIndex = 0
        Me.CurrentRowButton.Text = "Current"
        Me.CurrentRowButton.UseVisualStyleBackColor = true
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(485, 222)
        Me.DataGridView1.TabIndex = 1
        '
        'LastRowButton
        '
        Me.LastRowButton.Location = New System.Drawing.Point(93, 251)
        Me.LastRowButton.Name = "LastRowButton"
        Me.LastRowButton.Size = New System.Drawing.Size(75, 23)
        Me.LastRowButton.TabIndex = 2
        Me.LastRowButton.Text = "Last"
        Me.LastRowButton.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 286)
        Me.Controls.Add(Me.LastRowButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CurrentRowButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents CurrentRowButton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LastRowButton As Button
End Class
