
namespace DataGridViewCheckedSum
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
            this.GetCheckedButton = new System.Windows.Forms.Button();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.CurrentRowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(206, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // GetCheckedButton
            // 
            this.GetCheckedButton.Location = new System.Drawing.Point(23, 188);
            this.GetCheckedButton.Name = "GetCheckedButton";
            this.GetCheckedButton.Size = new System.Drawing.Size(75, 23);
            this.GetCheckedButton.TabIndex = 1;
            this.GetCheckedButton.Text = "Get";
            this.GetCheckedButton.UseVisualStyleBackColor = true;
            this.GetCheckedButton.Click += new System.EventHandler(this.GetCheckedButton_Click);
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(104, 188);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(121, 20);
            this.sumTextBox.TabIndex = 2;
            // 
            // CurrentRowButton
            // 
            this.CurrentRowButton.Location = new System.Drawing.Point(23, 217);
            this.CurrentRowButton.Name = "CurrentRowButton";
            this.CurrentRowButton.Size = new System.Drawing.Size(75, 23);
            this.CurrentRowButton.TabIndex = 3;
            this.CurrentRowButton.Text = "Current";
            this.CurrentRowButton.UseVisualStyleBackColor = true;
            this.CurrentRowButton.Click += new System.EventHandler(this.CurrentRowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 245);
            this.Controls.Add(this.CurrentRowButton);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.GetCheckedButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Sample";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetCheckedButton;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Button CurrentRowButton;
    }
}

