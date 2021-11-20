
namespace DataGridViewCombo1
{
    partial class MainForm
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
            this.ShowFormButton = new System.Windows.Forms.Button();
            this.GetCurrentIdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowFormButton
            // 
            this.ShowFormButton.Location = new System.Drawing.Point(15, 18);
            this.ShowFormButton.Name = "ShowFormButton";
            this.ShowFormButton.Size = new System.Drawing.Size(75, 23);
            this.ShowFormButton.TabIndex = 0;
            this.ShowFormButton.Text = "button1";
            this.ShowFormButton.UseVisualStyleBackColor = true;
            this.ShowFormButton.Click += new System.EventHandler(this.ShowFormButton_Click);
            // 
            // GetCurrentIdButton
            // 
            this.GetCurrentIdButton.Location = new System.Drawing.Point(105, 18);
            this.GetCurrentIdButton.Name = "GetCurrentIdButton";
            this.GetCurrentIdButton.Size = new System.Drawing.Size(75, 23);
            this.GetCurrentIdButton.TabIndex = 1;
            this.GetCurrentIdButton.Text = "button1";
            this.GetCurrentIdButton.UseVisualStyleBackColor = true;
            this.GetCurrentIdButton.Click += new System.EventHandler(this.GetCurrentIdButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 218);
            this.Controls.Add(this.GetCurrentIdButton);
            this.Controls.Add(this.ShowFormButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowFormButton;
        private System.Windows.Forms.Button GetCurrentIdButton;
    }
}