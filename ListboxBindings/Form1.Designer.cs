
namespace ListboxBindings
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RemoveCurrentButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 173);
            this.listBox1.TabIndex = 0;
            // 
            // RemoveCurrentButton
            // 
            this.RemoveCurrentButton.Location = new System.Drawing.Point(217, 18);
            this.RemoveCurrentButton.Name = "RemoveCurrentButton";
            this.RemoveCurrentButton.Size = new System.Drawing.Size(121, 23);
            this.RemoveCurrentButton.TabIndex = 1;
            this.RemoveCurrentButton.Text = "Remove current";
            this.RemoveCurrentButton.UseVisualStyleBackColor = true;
            this.RemoveCurrentButton.Click += new System.EventHandler(this.RemoveCurrentButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(217, 47);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(121, 23);
            this.AddPersonButton.TabIndex = 2;
            this.AddPersonButton.Text = "Add person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(217, 102);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(121, 23);
            this.CurrentButton.TabIndex = 4;
            this.CurrentButton.Text = "Current person";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 209);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.RemoveCurrentButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button RemoveCurrentButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CurrentButton;
    }
}

