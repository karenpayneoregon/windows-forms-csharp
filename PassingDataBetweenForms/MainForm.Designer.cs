﻿
namespace PassingDataBetweenForms
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
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.ContentsTextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
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
            // EditButton
            // 
            this.EditButton.Image = global::PassingDataBetweenForms.Properties.Resources.Edit_blue;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.Location = new System.Drawing.Point(154, 330);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(128, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
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
            // SortButton
            // 
            this.SortButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SortButton.Location = new System.Drawing.Point(506, 330);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(128, 23);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 373);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ContentsTextBox);
            this.Controls.Add(this.NotesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note-Taker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.TextBox ContentsTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SortButton;
    }
}
