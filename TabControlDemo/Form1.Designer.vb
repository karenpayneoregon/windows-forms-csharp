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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.InventoryEditTab = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ViewInventoryTab = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.InventoryEditTab.SuspendLayout()
        Me.ViewInventoryTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.InventoryEditTab)
        Me.TabControl1.Controls.Add(Me.ViewInventoryTab)
        Me.TabControl1.ItemSize = New System.Drawing.Size(0, 1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(503, 245)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'InventoryEditTab
        '
        Me.InventoryEditTab.Controls.Add(Me.Button1)
        Me.InventoryEditTab.Location = New System.Drawing.Point(4, 5)
        Me.InventoryEditTab.Name = "InventoryEditTab"
        Me.InventoryEditTab.Padding = New System.Windows.Forms.Padding(3)
        Me.InventoryEditTab.Size = New System.Drawing.Size(495, 236)
        Me.InventoryEditTab.TabIndex = 0
        Me.InventoryEditTab.Text = "TabPage1"
        Me.InventoryEditTab.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ViewInventoryTab
        '
        Me.ViewInventoryTab.Controls.Add(Me.Button2)
        Me.ViewInventoryTab.Location = New System.Drawing.Point(4, 5)
        Me.ViewInventoryTab.Name = "ViewInventoryTab"
        Me.ViewInventoryTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ViewInventoryTab.Size = New System.Drawing.Size(495, 236)
        Me.ViewInventoryTab.TabIndex = 1
        Me.ViewInventoryTab.Text = "TabPage2"
        Me.ViewInventoryTab.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(521, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 281)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.InventoryEditTab.ResumeLayout(False)
        Me.ViewInventoryTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents InventoryEditTab As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents ViewInventoryTab As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
