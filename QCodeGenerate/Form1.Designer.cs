
namespace QCodeGenerate
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
            this.UrlButton = new System.Windows.Forms.Button();
            this.TextMessageButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MmsTextBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UrlButton
            // 
            this.UrlButton.Location = new System.Drawing.Point(528, 157);
            this.UrlButton.Name = "UrlButton";
            this.UrlButton.Size = new System.Drawing.Size(133, 23);
            this.UrlButton.TabIndex = 1;
            this.UrlButton.Text = "URL";
            this.UrlButton.UseVisualStyleBackColor = true;
            this.UrlButton.Click += new System.EventHandler(this.UrlButton_Click);
            // 
            // TextMessageButton
            // 
            this.TextMessageButton.Location = new System.Drawing.Point(12, 309);
            this.TextMessageButton.Name = "TextMessageButton";
            this.TextMessageButton.Size = new System.Drawing.Size(133, 23);
            this.TextMessageButton.TabIndex = 2;
            this.TextMessageButton.Text = "Text message";
            this.TextMessageButton.UseVisualStyleBackColor = true;
            this.TextMessageButton.Click += new System.EventHandler(this.TextMessageButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(12, 283);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(721, 20);
            this.MessageTextBox.TabIndex = 3;
            this.MessageTextBox.Text = "Unit testing is the mark of a professional developer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 370);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(721, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Unit testing is the mark of a professional developer";
            // 
            // MmsTextBox
            // 
            this.MmsTextBox.Location = new System.Drawing.Point(12, 396);
            this.MmsTextBox.Name = "MmsTextBox";
            this.MmsTextBox.Size = new System.Drawing.Size(133, 23);
            this.MmsTextBox.TabIndex = 5;
            this.MmsTextBox.Text = "MMS Text message";
            this.MmsTextBox.UseVisualStyleBackColor = true;
            this.MmsTextBox.Click += new System.EventHandler(this.MmsTextBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 469);
            this.Controls.Add(this.MmsTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.TextMessageButton);
            this.Controls.Add(this.UrlButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UrlButton;
        private System.Windows.Forms.Button TextMessageButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button MmsTextBox;
    }
}

