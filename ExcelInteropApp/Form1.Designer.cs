
namespace ExcelInteropApp
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
            this.CreateExcelButton1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ExcelVersionButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateExcelButton1
            // 
            this.CreateExcelButton1.Location = new System.Drawing.Point(12, 24);
            this.CreateExcelButton1.Name = "CreateExcelButton1";
            this.CreateExcelButton1.Size = new System.Drawing.Size(75, 23);
            this.CreateExcelButton1.TabIndex = 0;
            this.CreateExcelButton1.Text = "Run";
            this.CreateExcelButton1.UseVisualStyleBackColor = true;
            this.CreateExcelButton1.Click += new System.EventHandler(this.CreateExcelButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 82);
            this.listBox1.TabIndex = 1;
            // 
            // ExcelVersionButton
            // 
            this.ExcelVersionButton.Location = new System.Drawing.Point(194, 24);
            this.ExcelVersionButton.Name = "ExcelVersionButton";
            this.ExcelVersionButton.Size = new System.Drawing.Size(75, 23);
            this.ExcelVersionButton.TabIndex = 3;
            this.ExcelVersionButton.Text = "Version";
            this.ExcelVersionButton.UseVisualStyleBackColor = true;
            this.ExcelVersionButton.Click += new System.EventHandler(this.ExcelVersionButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(102, 24);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 174);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ExcelVersionButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CreateExcelButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel code sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateExcelButton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ExcelVersionButton;
        private System.Windows.Forms.Button CheckButton;
    }
}

