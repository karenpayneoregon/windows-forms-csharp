
namespace JsonDefaultValueDemo
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
            this.CreateReadFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateReadFileButton
            // 
            this.CreateReadFileButton.Location = new System.Drawing.Point(12, 12);
            this.CreateReadFileButton.Name = "CreateReadFileButton";
            this.CreateReadFileButton.Size = new System.Drawing.Size(171, 23);
            this.CreateReadFileButton.TabIndex = 0;
            this.CreateReadFileButton.Text = "Create and read";
            this.CreateReadFileButton.UseVisualStyleBackColor = true;
            this.CreateReadFileButton.Click += new System.EventHandler(this.CreateReadFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 50);
            this.Controls.Add(this.CreateReadFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateReadFileButton;
    }
}

