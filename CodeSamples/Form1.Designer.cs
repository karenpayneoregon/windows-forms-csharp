
namespace CodeSamples
{
    partial class Form1
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstNameListBox = new System.Windows.Forms.ListBox();
            this.LastNameListBox = new System.Windows.Forms.ListBox();
            this.GetCurrentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(29, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(318, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FirstName";
            this.Column1.HeaderText = "First name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "LastName";
            this.Column2.HeaderText = "Last name";
            this.Column2.Name = "Column2";
            // 
            // FirstNameListBox
            // 
            this.FirstNameListBox.FormattingEnabled = true;
            this.FirstNameListBox.Location = new System.Drawing.Point(368, 32);
            this.FirstNameListBox.Name = "FirstNameListBox";
            this.FirstNameListBox.Size = new System.Drawing.Size(120, 147);
            this.FirstNameListBox.TabIndex = 1;
            // 
            // LastNameListBox
            // 
            this.LastNameListBox.FormattingEnabled = true;
            this.LastNameListBox.Location = new System.Drawing.Point(503, 32);
            this.LastNameListBox.Name = "LastNameListBox";
            this.LastNameListBox.Size = new System.Drawing.Size(120, 147);
            this.LastNameListBox.TabIndex = 2;
            // 
            // GetCurrentButton
            // 
            this.GetCurrentButton.Location = new System.Drawing.Point(32, 202);
            this.GetCurrentButton.Name = "GetCurrentButton";
            this.GetCurrentButton.Size = new System.Drawing.Size(75, 23);
            this.GetCurrentButton.TabIndex = 3;
            this.GetCurrentButton.Text = "Current";
            this.GetCurrentButton.UseVisualStyleBackColor = true;
            this.GetCurrentButton.Click += new System.EventHandler(this.GetCurrentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 235);
            this.Controls.Add(this.GetCurrentButton);
            this.Controls.Add(this.LastNameListBox);
            this.Controls.Add(this.FirstNameListBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ListBox FirstNameListBox;
        private System.Windows.Forms.ListBox LastNameListBox;
        private System.Windows.Forms.Button GetCurrentButton;
    }
}

