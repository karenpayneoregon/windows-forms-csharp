
namespace DateTimePickerBlank
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
            this.DateTimePicker1 = new DateTimePickerBlank.NullableDateTimePicker();
            this.ValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(15, 12);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(116, 20);
            this.DateTimePicker1.TabIndex = 0;
            this.DateTimePicker1.Value = new System.DateTime(2021, 7, 24, 3, 38, 46, 371);
            // 
            // ValueButton
            // 
            this.ValueButton.Location = new System.Drawing.Point(15, 43);
            this.ValueButton.Name = "ValueButton";
            this.ValueButton.Size = new System.Drawing.Size(116, 23);
            this.ValueButton.TabIndex = 1;
            this.ValueButton.Text = "Value";
            this.ValueButton.UseVisualStyleBackColor = true;
            this.ValueButton.Click += new System.EventHandler(this.ValueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 118);
            this.Controls.Add(this.ValueButton);
            this.Controls.Add(this.DateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NullableDateTimePicker DateTimePicker1;
        private System.Windows.Forms.Button ValueButton;
    }
}

