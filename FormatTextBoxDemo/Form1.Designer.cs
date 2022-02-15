
namespace FormatTextBoxDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.DemoControl = new FormatTextBoxDemo.UserControl1();
            this.formattedTextBox1 = new FormatTextBoxDemo.FormattedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DemoControl
            // 
            this.DemoControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DemoControl.Location = new System.Drawing.Point(32, 134);
            this.DemoControl.Name = "DemoControl";
            this.DemoControl.Size = new System.Drawing.Size(159, 59);
            this.DemoControl.TabIndex = 2;
            // 
            // formattedTextBox1
            // 
            this.formattedTextBox1.Location = new System.Drawing.Point(28, 29);
            this.formattedTextBox1.MaxLength = 6;
            this.formattedTextBox1.Name = "formattedTextBox1";
            this.formattedTextBox1.PadWith = 3;
            this.formattedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.formattedTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 230);
            this.Controls.Add(this.DemoControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formattedTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormattedTextBox formattedTextBox1;
        private System.Windows.Forms.Button button1;
        private UserControl1 DemoControl;
    }
}

