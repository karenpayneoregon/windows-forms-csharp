
namespace SpreadsheetLightDataGridViewExport
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
            this.ExcelExportButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CloneTableButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(660, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // ExcelExportButton
            // 
            this.ExcelExportButton.Location = new System.Drawing.Point(13, 204);
            this.ExcelExportButton.Name = "ExcelExportButton";
            this.ExcelExportButton.Size = new System.Drawing.Size(208, 23);
            this.ExcelExportButton.TabIndex = 1;
            this.ExcelExportButton.Text = "Export to Excel";
            this.ExcelExportButton.UseVisualStyleBackColor = true;
            this.ExcelExportButton.Click += new System.EventHandler(this.ExcelExportButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(341, 204);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(214, 20);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.Text = "What year is it";
            // 
            // CloneTableButton
            // 
            this.CloneTableButton.Location = new System.Drawing.Point(573, 201);
            this.CloneTableButton.Name = "CloneTableButton";
            this.CloneTableButton.Size = new System.Drawing.Size(75, 23);
            this.CloneTableButton.TabIndex = 4;
            this.CloneTableButton.Text = "Clone";
            this.CloneTableButton.UseVisualStyleBackColor = true;
            this.CloneTableButton.Click += new System.EventHandler(this.CloneTableButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 292);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CloneTableButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExcelExportButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExcelExportButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button CloneTableButton;
        private System.Windows.Forms.Button button2;
    }
}

