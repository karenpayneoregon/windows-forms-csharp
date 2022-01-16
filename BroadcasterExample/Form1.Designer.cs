
namespace BroadcasterExample
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
            this.PassButton = new System.Windows.Forms.Button();
            this.OpenChildFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 147);
            this.listBox1.TabIndex = 0;
            // 
            // PassButton
            // 
            this.PassButton.Location = new System.Drawing.Point(12, 205);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(75, 23);
            this.PassButton.TabIndex = 1;
            this.PassButton.Text = "Pass to child";
            this.PassButton.UseVisualStyleBackColor = true;
            this.PassButton.Click += new System.EventHandler(this.PassButton_Click);
            // 
            // OpenChildFormButton
            // 
            this.OpenChildFormButton.Location = new System.Drawing.Point(12, 176);
            this.OpenChildFormButton.Name = "OpenChildFormButton";
            this.OpenChildFormButton.Size = new System.Drawing.Size(75, 23);
            this.OpenChildFormButton.TabIndex = 2;
            this.OpenChildFormButton.Text = "Show child";
            this.OpenChildFormButton.UseVisualStyleBackColor = true;
            this.OpenChildFormButton.Click += new System.EventHandler(this.OpenChildFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 244);
            this.Controls.Add(this.OpenChildFormButton);
            this.Controls.Add(this.PassButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button PassButton;
        private System.Windows.Forms.Button OpenChildFormButton;
    }
}

