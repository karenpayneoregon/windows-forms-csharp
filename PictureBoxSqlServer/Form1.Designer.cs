
namespace PictureBoxSqlServer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowFormButton = new System.Windows.Forms.Button();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 177);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ShowFormButton
            // 
            this.ShowFormButton.Location = new System.Drawing.Point(234, 166);
            this.ShowFormButton.Name = "ShowFormButton";
            this.ShowFormButton.Size = new System.Drawing.Size(138, 23);
            this.ShowFormButton.TabIndex = 1;
            this.ShowFormButton.Text = "Show child form";
            this.ShowFormButton.UseVisualStyleBackColor = true;
            this.ShowFormButton.Click += new System.EventHandler(this.ShowFormButton_Click);
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Location = new System.Drawing.Point(234, 12);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(190, 134);
            this.CategoryListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 219);
            this.Controls.Add(this.CategoryListBox);
            this.Controls.Add(this.ShowFormButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image to child form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ShowFormButton;
        private System.Windows.Forms.ListBox CategoryListBox;
    }
}

