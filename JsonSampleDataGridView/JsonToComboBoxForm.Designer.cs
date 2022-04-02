
namespace JsonSampleDataGridView
{
    partial class JsonToComboBoxForm
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
            this.PeopleComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleComboBox
            // 
            this.PeopleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeopleComboBox.FormattingEnabled = true;
            this.PeopleComboBox.Location = new System.Drawing.Point(21, 28);
            this.PeopleComboBox.Name = "PeopleComboBox";
            this.PeopleComboBox.Size = new System.Drawing.Size(184, 21);
            this.PeopleComboBox.TabIndex = 0;
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(221, 28);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(75, 23);
            this.CurrentButton.TabIndex = 1;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // JsonToComboBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 253);
            this.Controls.Add(this.CurrentButton);
            this.Controls.Add(this.PeopleComboBox);
            this.Name = "JsonToComboBoxForm";
            this.Text = "JsonToComboBoxForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PeopleComboBox;
        private System.Windows.Forms.Button CurrentButton;
    }
}