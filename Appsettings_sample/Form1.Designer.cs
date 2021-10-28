
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
            this.BuildDateButton = new System.Windows.Forms.Button();
            this.WhenAllButton = new System.Windows.Forms.Button();
            this.RunSomeTaskButton = new System.Windows.Forms.Button();
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DateRangeButton = new System.Windows.Forms.Button();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // GetConnectionStringButton
            // 
            this.GetConnectionStringButton.Image = ((System.Drawing.Image)(resources.GetObject("GetConnectionStringButton.Image")));
            this.GetConnectionStringButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GetConnectionStringButton.Location = new System.Drawing.Point(6, 89);
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
            this.TestConnectionButton.Location = new System.Drawing.Point(12, 160);
            this.TestConnectionButton.Name = "TestConnectionButton";
            this.TestConnectionButton.Size = new System.Drawing.Size(210, 23);
            this.TestConnectionButton.TabIndex = 1;
            this.TestConnectionButton.Text = "Test connection";
            this.TestConnectionButton.UseVisualStyleBackColor = true;
            this.TestConnectionButton.Click += new System.EventHandler(this.TestConnectionButton_Click);
            // 
            // BuildDateButton
            // 
            this.BuildDateButton.Location = new System.Drawing.Point(12, 189);
            this.BuildDateButton.Name = "BuildDateButton";
            this.BuildDateButton.Size = new System.Drawing.Size(210, 23);
            this.BuildDateButton.TabIndex = 2;
            this.BuildDateButton.Text = "Build date";
            this.BuildDateButton.UseVisualStyleBackColor = true;
            this.BuildDateButton.Click += new System.EventHandler(this.BuildDateButton_Click);
            // 
            // WhenAllButton
            // 
            this.WhenAllButton.Location = new System.Drawing.Point(12, 218);
            this.WhenAllButton.Name = "WhenAllButton";
            this.WhenAllButton.Size = new System.Drawing.Size(75, 23);
            this.WhenAllButton.TabIndex = 3;
            this.WhenAllButton.Text = "button1";
            this.WhenAllButton.UseVisualStyleBackColor = true;
            this.WhenAllButton.Click += new System.EventHandler(this.WhenAllButton_Click);
            // 
            // RunSomeTaskButton
            // 
            this.RunSomeTaskButton.Location = new System.Drawing.Point(100, 217);
            this.RunSomeTaskButton.Name = "RunSomeTaskButton";
            this.RunSomeTaskButton.Size = new System.Drawing.Size(75, 23);
            this.RunSomeTaskButton.TabIndex = 4;
            this.RunSomeTaskButton.Text = "button1";
            this.RunSomeTaskButton.UseVisualStyleBackColor = true;
            this.RunSomeTaskButton.Click += new System.EventHandler(this.RunSomeTaskButton_Click);
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Location = new System.Drawing.Point(6, 60);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(75, 23);
            this.ReadFileButton.TabIndex = 5;
            this.ReadFileButton.Text = "button1";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(325, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 274);
            this.listBox1.TabIndex = 6;
            // 
            // DateRangeButton
            // 
            this.DateRangeButton.Location = new System.Drawing.Point(325, 350);
            this.DateRangeButton.Name = "DateRangeButton";
            this.DateRangeButton.Size = new System.Drawing.Size(230, 23);
            this.DateRangeButton.TabIndex = 7;
            this.DateRangeButton.Text = "Date range";
            this.DateRangeButton.UseVisualStyleBackColor = true;
            this.DateRangeButton.Click += new System.EventHandler(this.DateRangeButton_Click);
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(325, 292);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.StartDateTimePicker.TabIndex = 8;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(325, 321);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.EndDateTimePicker.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 422);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.DateRangeButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ReadFileButton);
            this.Controls.Add(this.RunSomeTaskButton);
            this.Controls.Add(this.WhenAllButton);
            this.Controls.Add(this.BuildDateButton);
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
        private System.Windows.Forms.Button BuildDateButton;
        private System.Windows.Forms.Button WhenAllButton;
        private System.Windows.Forms.Button RunSomeTaskButton;
        private System.Windows.Forms.Button ReadFileButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DateRangeButton;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
    }
}

