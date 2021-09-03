<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridToDataTableForm
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
        Me.NumberColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToTableButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumberColumn, Me.DescriptionColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(313, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'NumberColumn
        '
        Me.NumberColumn.HeaderText = "Number"
        Me.NumberColumn.Name = "NumberColumn"
        Me.NumberColumn.ReadOnly = True
        '
        'DescriptionColumn
        '
        Me.DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionColumn.HeaderText = "Description"
        Me.DescriptionColumn.Name = "DescriptionColumn"
        Me.DescriptionColumn.ReadOnly = True
        '
        'ToTableButton
        '
        Me.ToTableButton.Location = New System.Drawing.Point(22, 177)
        Me.ToTableButton.Name = "ToTableButton"
        Me.ToTableButton.Size = New System.Drawing.Size(75, 23)
        Me.ToTableButton.TabIndex = 1
        Me.ToTableButton.Text = "Export"
        Me.ToTableButton.UseVisualStyleBackColor = True
        '
        'GridToDataTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 239)
        Me.Controls.Add(Me.ToTableButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GridToDataTableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export to Excel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToTableButton As Button
    Friend WithEvents NumberColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionColumn As DataGridViewTextBoxColumn
End Class
