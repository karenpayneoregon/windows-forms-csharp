
namespace PlumbingExample
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
            this.Service1CheckBox = new System.Windows.Forms.CheckBox();
            this.Service2CheckBox = new System.Windows.Forms.CheckBox();
            this.Service3CheckBox = new System.Windows.Forms.CheckBox();
            this.serviceTotalText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Service1CheckBox
            // 
            this.Service1CheckBox.AutoSize = true;
            this.Service1CheckBox.Location = new System.Drawing.Point(12, 23);
            this.Service1CheckBox.Name = "Service1CheckBox";
            this.Service1CheckBox.Size = new System.Drawing.Size(71, 17);
            this.Service1CheckBox.TabIndex = 0;
            this.Service1CheckBox.Text = "Service 1";
            this.Service1CheckBox.UseVisualStyleBackColor = true;
            // 
            // Service2CheckBox
            // 
            this.Service2CheckBox.AutoSize = true;
            this.Service2CheckBox.Location = new System.Drawing.Point(12, 46);
            this.Service2CheckBox.Name = "Service2CheckBox";
            this.Service2CheckBox.Size = new System.Drawing.Size(71, 17);
            this.Service2CheckBox.TabIndex = 1;
            this.Service2CheckBox.Text = "Service 2";
            this.Service2CheckBox.UseVisualStyleBackColor = true;
            // 
            // Service3CheckBox
            // 
            this.Service3CheckBox.AutoSize = true;
            this.Service3CheckBox.Location = new System.Drawing.Point(12, 69);
            this.Service3CheckBox.Name = "Service3CheckBox";
            this.Service3CheckBox.Size = new System.Drawing.Size(71, 17);
            this.Service3CheckBox.TabIndex = 2;
            this.Service3CheckBox.Text = "Service 3";
            this.Service3CheckBox.UseVisualStyleBackColor = true;
            // 
            // serviceTotalText
            // 
            this.serviceTotalText.AutoSize = true;
            this.serviceTotalText.Location = new System.Drawing.Point(18, 126);
            this.serviceTotalText.Name = "serviceTotalText";
            this.serviceTotalText.Size = new System.Drawing.Size(31, 13);
            this.serviceTotalText.TabIndex = 3;
            this.serviceTotalText.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 230);
            this.Controls.Add(this.serviceTotalText);
            this.Controls.Add(this.Service3CheckBox);
            this.Controls.Add(this.Service2CheckBox);
            this.Controls.Add(this.Service1CheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Service1CheckBox;
        private System.Windows.Forms.CheckBox Service2CheckBox;
        private System.Windows.Forms.CheckBox Service3CheckBox;
        private System.Windows.Forms.Label serviceTotalText;
    }
}

