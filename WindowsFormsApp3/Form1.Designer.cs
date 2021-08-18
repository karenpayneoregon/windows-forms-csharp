
namespace WindowsFormsApp3
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
            this.DateTimeValueTextBox = new System.Windows.Forms.TextBox();
            this.ShowCalendarButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // DateTimeValueTextBox
            // 
            this.DateTimeValueTextBox.BackColor = System.Drawing.Color.White;
            this.DateTimeValueTextBox.Location = new System.Drawing.Point(64, 45);
            this.DateTimeValueTextBox.Name = "DateTimeValueTextBox";
            this.DateTimeValueTextBox.ReadOnly = true;
            this.DateTimeValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.DateTimeValueTextBox.TabIndex = 0;
            // 
            // ShowCalendarButton
            // 
            this.ShowCalendarButton.Image = global::WindowsFormsApp3.Properties.Resources.Calendar_16x;
            this.ShowCalendarButton.Location = new System.Drawing.Point(164, 43);
            this.ShowCalendarButton.Name = "ShowCalendarButton";
            this.ShowCalendarButton.Size = new System.Drawing.Size(27, 23);
            this.ShowCalendarButton.TabIndex = 1;
            this.ShowCalendarButton.UseVisualStyleBackColor = true;
            this.ShowCalendarButton.Click += new System.EventHandler(this.ShowCalendarButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 113);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ShowCalendarButton);
            this.Controls.Add(this.DateTimeValueTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Handle DateTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DateTimeValueTextBox;
        private System.Windows.Forms.Button ShowCalendarButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

