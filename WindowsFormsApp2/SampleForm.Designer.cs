
namespace DataGridViewGetCellStyle
{
    partial class SampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentIdButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.ProcessColumn,
            this.ProductColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // ProcessColumn
            // 
            this.ProcessColumn.DataPropertyName = "Process";
            this.ProcessColumn.HeaderText = "Process";
            this.ProcessColumn.Name = "ProcessColumn";
            this.ProcessColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductColumn
            // 
            this.ProductColumn.DataPropertyName = "Product";
            this.ProductColumn.HeaderText = "Products";
            this.ProductColumn.Name = "ProductColumn";
            // 
            // CurrentIdButton
            // 
            this.CurrentIdButton.Location = new System.Drawing.Point(14, 220);
            this.CurrentIdButton.Name = "CurrentIdButton";
            this.CurrentIdButton.Size = new System.Drawing.Size(75, 23);
            this.CurrentIdButton.TabIndex = 1;
            this.CurrentIdButton.Text = "Current Id";
            this.CurrentIdButton.UseVisualStyleBackColor = true;
            this.CurrentIdButton.Click += new System.EventHandler(this.CurrentIdButton_Click);
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 264);
            this.Controls.Add(this.CurrentIdButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.Load += new System.EventHandler(this.SourceChangedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CurrentIdButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ProcessColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
    }
}