
namespace AccessMultiConnections
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
            this.button1 = new System.Windows.Forms.Button();
            this.Database2Button = new System.Windows.Forms.Button();
            this.Database1Button = new System.Windows.Forms.Button();
            this.ConnectionStringLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Database2Button
            // 
            this.Database2Button.Location = new System.Drawing.Point(309, 121);
            this.Database2Button.Name = "Database2Button";
            this.Database2Button.Size = new System.Drawing.Size(75, 23);
            this.Database2Button.TabIndex = 4;
            this.Database2Button.Text = "2";
            this.Database2Button.UseVisualStyleBackColor = true;
            this.Database2Button.Click += new System.EventHandler(this.Database2Button_Click);
            // 
            // Database1Button
            // 
            this.Database1Button.Location = new System.Drawing.Point(217, 121);
            this.Database1Button.Name = "Database1Button";
            this.Database1Button.Size = new System.Drawing.Size(75, 23);
            this.Database1Button.TabIndex = 3;
            this.Database1Button.Text = "1";
            this.Database1Button.UseVisualStyleBackColor = true;
            this.Database1Button.Click += new System.EventHandler(this.Database1Button_Click);
            // 
            // ConnectionStringLabel
            // 
            this.ConnectionStringLabel.AutoSize = true;
            this.ConnectionStringLabel.Location = new System.Drawing.Point(89, 184);
            this.ConnectionStringLabel.Name = "ConnectionStringLabel";
            this.ConnectionStringLabel.Size = new System.Drawing.Size(35, 13);
            this.ConnectionStringLabel.TabIndex = 5;
            this.ConnectionStringLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectionStringLabel);
            this.Controls.Add(this.Database2Button);
            this.Controls.Add(this.Database1Button);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Database2Button;
        private System.Windows.Forms.Button Database1Button;
        private System.Windows.Forms.Label ConnectionStringLabel;
        private System.Windows.Forms.Label label1;
    }
}