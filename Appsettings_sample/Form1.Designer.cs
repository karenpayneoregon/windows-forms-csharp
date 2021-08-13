
namespace Appsettings_sample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GetConnectionStringButton = new System.Windows.Forms.Button();
            this.TestConnectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetConnectionStringButton
            // 
            this.GetConnectionStringButton.Image = ((System.Drawing.Image)(resources.GetObject("GetConnectionStringButton.Image")));
            this.GetConnectionStringButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetConnectionStringButton.Location = new System.Drawing.Point(6, 13);
            this.GetConnectionStringButton.Name = "GetConnectionStringButton";
            this.GetConnectionStringButton.Size = new System.Drawing.Size(210, 23);
            this.GetConnectionStringButton.TabIndex = 0;
            this.GetConnectionStringButton.Text = "Show Connection String";
            this.GetConnectionStringButton.UseVisualStyleBackColor = true;
            this.GetConnectionStringButton.Click += new System.EventHandler(this.GetConnectionStringButton_Click);
            // 
            // TestConnectionButton
            // 
            this.TestConnectionButton.Image = ((System.Drawing.Image)(resources.GetObject("TestConnectionButton.Image")));
            this.TestConnectionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TestConnectionButton.Location = new System.Drawing.Point(6, 45);
            this.TestConnectionButton.Name = "TestConnectionButton";
            this.TestConnectionButton.Size = new System.Drawing.Size(210, 23);
            this.TestConnectionButton.TabIndex = 1;
            this.TestConnectionButton.Text = "Test connection";
            this.TestConnectionButton.UseVisualStyleBackColor = true;
            this.TestConnectionButton.Click += new System.EventHandler(this.TestConnectionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 80);
            this.Controls.Add(this.TestConnectionButton);
            this.Controls.Add(this.GetConnectionStringButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetConnectionStringButton;
        private System.Windows.Forms.Button TestConnectionButton;
    }
}

