
namespace SmtpConfigurationExample
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
            this.GetEmailSettingsButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.GetConnectionButton = new System.Windows.Forms.Button();
            this.FilePathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetEmailSettingsButton
            // 
            this.GetEmailSettingsButton.Location = new System.Drawing.Point(153, 20);
            this.GetEmailSettingsButton.Name = "GetEmailSettingsButton";
            this.GetEmailSettingsButton.Size = new System.Drawing.Size(135, 23);
            this.GetEmailSettingsButton.TabIndex = 0;
            this.GetEmailSettingsButton.Text = "Email";
            this.GetEmailSettingsButton.UseVisualStyleBackColor = true;
            this.GetEmailSettingsButton.Click += new System.EventHandler(this.GetEmailSettingsButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(12, 59);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(442, 84);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // GetConnectionButton
            // 
            this.GetConnectionButton.Location = new System.Drawing.Point(12, 20);
            this.GetConnectionButton.Name = "GetConnectionButton";
            this.GetConnectionButton.Size = new System.Drawing.Size(135, 23);
            this.GetConnectionButton.TabIndex = 2;
            this.GetConnectionButton.Text = "Connection string";
            this.GetConnectionButton.UseVisualStyleBackColor = true;
            this.GetConnectionButton.Click += new System.EventHandler(this.GetConnectionButton_Click);
            // 
            // FilePathButton
            // 
            this.FilePathButton.Location = new System.Drawing.Point(319, 20);
            this.FilePathButton.Name = "FilePathButton";
            this.FilePathButton.Size = new System.Drawing.Size(135, 23);
            this.FilePathButton.TabIndex = 3;
            this.FilePathButton.Text = "File path";
            this.FilePathButton.UseVisualStyleBackColor = true;
            this.FilePathButton.Click += new System.EventHandler(this.FilePathButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 171);
            this.Controls.Add(this.FilePathButton);
            this.Controls.Add(this.GetConnectionButton);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.GetEmailSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetEmailSettingsButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button GetConnectionButton;
        private System.Windows.Forms.Button FilePathButton;
    }
}

