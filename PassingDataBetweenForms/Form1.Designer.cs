
namespace PassingDataBetweenForms
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
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.ContentsTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotesListBox
            // 
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.Location = new System.Drawing.Point(11, 13);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(623, 108);
            this.NotesListBox.TabIndex = 0;
            // 
            // ContentsTextBox
            // 
            this.ContentsTextBox.Location = new System.Drawing.Point(12, 151);
            this.ContentsTextBox.Multiline = true;
            this.ContentsTextBox.Name = "ContentsTextBox";
            this.ContentsTextBox.Size = new System.Drawing.Size(622, 159);
            this.ContentsTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Image = global::PassingDataBetweenForms.Properties.Resources.Add_8x_16x;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(20, 330);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(128, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 373);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ContentsTextBox);
            this.Controls.Add(this.NotesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note-Taker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.TextBox ContentsTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}

