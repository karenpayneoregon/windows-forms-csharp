﻿
namespace PleaseWaitExample
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
            this.DoSomeWorkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoSomeWorkButton
            // 
            this.DoSomeWorkButton.Location = new System.Drawing.Point(12, 12);
            this.DoSomeWorkButton.Name = "DoSomeWorkButton";
            this.DoSomeWorkButton.Size = new System.Drawing.Size(75, 23);
            this.DoSomeWorkButton.TabIndex = 0;
            this.DoSomeWorkButton.Text = "button1";
            this.DoSomeWorkButton.UseVisualStyleBackColor = true;
            this.DoSomeWorkButton.Click += new System.EventHandler(this.DoSomeWorkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 230);
            this.Controls.Add(this.DoSomeWorkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DoSomeWorkButton;
    }
}

