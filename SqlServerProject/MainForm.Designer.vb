<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShowChildFormButton = New System.Windows.Forms.Button()
        Me.GetRowsButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(520, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "FirstName"
        Me.Column1.HeaderText = "First"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "LastName"
        Me.Column2.HeaderText = "Last"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "HireDate"
        Me.Column3.HeaderText = "Hired"
        Me.Column3.Name = "Column3"
        '
        'ShowChildFormButton
        '
        Me.ShowChildFormButton.Location = New System.Drawing.Point(538, 12)
        Me.ShowChildFormButton.Name = "ShowChildFormButton"
        Me.ShowChildFormButton.Size = New System.Drawing.Size(158, 23)
        Me.ShowChildFormButton.TabIndex = 1
        Me.ShowChildFormButton.Text = "Show child"
        Me.ShowChildFormButton.UseVisualStyleBackColor = True
        '
        'GetRowsButton
        '
        Me.GetRowsButton.Location = New System.Drawing.Point(538, 41)
        Me.GetRowsButton.Name = "GetRowsButton"
        Me.GetRowsButton.Size = New System.Drawing.Size(158, 23)
        Me.GetRowsButton.TabIndex = 2
        Me.GetRowsButton.Text = "Get"
        Me.GetRowsButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 215)
        Me.Controls.Add(Me.GetRowsButton)
        Me.Controls.Add(Me.ShowChildFormButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main - Code sample"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ShowChildFormButton As Button
    Friend WithEvents GetRowsButton As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
