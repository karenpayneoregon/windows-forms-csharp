
namespace WindowsFormsApp3
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
            this.timeComboBox1 = new WindowsFormsApp3.Controls.TimeComboBox();
            this.SuspendLayout();
            // 
            // timeComboBox1
            // 
            this.timeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox1.FormattingEnabled = true;
            this.timeComboBox1.Increment = WindowsFormsApp3.Controls.TimeIncrement.Quarterly;
            this.timeComboBox1.IntegralHeight = false;
            this.timeComboBox1.Items.AddRange(new object[] {
            "12:00 AM",
            "12:15 AM",
            "12:30 AM",
            "12:45 AM",
            "01:00 AM",
            "01:15 AM",
            "01:30 AM",
            "01:45 AM",
            "02:00 AM",
            "02:15 AM",
            "02:30 AM",
            "02:45 AM",
            "03:00 AM",
            "03:15 AM",
            "03:30 AM",
            "03:45 AM",
            "04:00 AM",
            "04:15 AM",
            "04:30 AM",
            "04:45 AM",
            "05:00 AM",
            "05:15 AM",
            "05:30 AM",
            "05:45 AM",
            "06:00 AM",
            "06:15 AM",
            "06:30 AM",
            "06:45 AM",
            "07:00 AM",
            "07:15 AM",
            "07:30 AM",
            "07:45 AM",
            "08:00 AM",
            "08:15 AM",
            "08:30 AM",
            "08:45 AM",
            "09:00 AM",
            "09:15 AM",
            "09:30 AM",
            "09:45 AM",
            "10:00 AM",
            "10:15 AM",
            "10:30 AM",
            "10:45 AM",
            "11:00 AM",
            "11:15 AM",
            "11:30 AM",
            "11:45 AM",
            "12:00 PM",
            "12:15 PM",
            "12:30 PM",
            "12:45 PM",
            "01:00 PM",
            "01:15 PM",
            "01:30 PM",
            "01:45 PM",
            "02:00 PM",
            "02:15 PM",
            "02:30 PM",
            "02:45 PM",
            "03:00 PM",
            "03:15 PM",
            "03:30 PM",
            "03:45 PM",
            "04:00 PM",
            "04:15 PM",
            "04:30 PM",
            "04:45 PM",
            "05:00 PM",
            "05:15 PM",
            "05:30 PM",
            "05:45 PM",
            "06:00 PM",
            "06:15 PM",
            "06:30 PM",
            "06:45 PM",
            "07:00 PM",
            "07:15 PM",
            "07:30 PM",
            "07:45 PM",
            "08:00 PM",
            "08:15 PM",
            "08:30 PM",
            "08:45 PM",
            "09:00 PM",
            "09:15 PM",
            "09:30 PM",
            "09:45 PM",
            "10:00 PM",
            "10:15 PM",
            "10:30 PM",
            "10:45 PM",
            "11:00 PM",
            "11:15 PM",
            "11:30 PM",
            "11:45 PM"});
            this.timeComboBox1.Location = new System.Drawing.Point(45, 26);
            this.timeComboBox1.MaxDropDownItems = 10;
            this.timeComboBox1.Name = "timeComboBox1";
            this.timeComboBox1.Size = new System.Drawing.Size(116, 21);
            this.timeComboBox1.TabIndex = 0;
            this.timeComboBox1.Time = "00:00";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 88);
            this.Controls.Add(this.timeComboBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TimeComboBox timeComboBox1;
    }
}