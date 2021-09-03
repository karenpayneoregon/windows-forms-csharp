
namespace DataTableFilterExample
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
            this.FilterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CurrentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(12, 201);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 0;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 183);
            this.dataGridView1.TabIndex = 1;
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(93, 201);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(75, 23);
            this.CurrentButton.TabIndex = 2;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 245);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FilterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CurrentButton;
    }
}

