
namespace SimpleSingleton
{
    partial class Form2
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
            this.GetUserInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetUserInfoButton
            // 
            this.GetUserInfoButton.Location = new System.Drawing.Point(125, 55);
            this.GetUserInfoButton.Name = "GetUserInfoButton";
            this.GetUserInfoButton.Size = new System.Drawing.Size(75, 23);
            this.GetUserInfoButton.TabIndex = 0;
            this.GetUserInfoButton.Text = "Get";
            this.GetUserInfoButton.UseVisualStyleBackColor = true;
            this.GetUserInfoButton.Click += new System.EventHandler(this.GetUserInfoButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 144);
            this.Controls.Add(this.GetUserInfoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetUserInfoButton;
    }
}