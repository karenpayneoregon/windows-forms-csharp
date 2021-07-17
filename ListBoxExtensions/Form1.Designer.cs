
namespace MediaFileDemo
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GetFileNameButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteCurrentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(19, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(378, 121);
            this.listBox1.TabIndex = 0;
            // 
            // GetFileNameButton
            // 
            this.GetFileNameButton.Location = new System.Drawing.Point(19, 147);
            this.GetFileNameButton.Name = "GetFileNameButton";
            this.GetFileNameButton.Size = new System.Drawing.Size(108, 23);
            this.GetFileNameButton.TabIndex = 1;
            this.GetFileNameButton.Text = "Get file name";
            this.GetFileNameButton.UseVisualStyleBackColor = true;
            this.GetFileNameButton.Click += new System.EventHandler(this.GetFileNameButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(133, 147);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(108, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteCurrentButton
            // 
            this.DeleteCurrentButton.Location = new System.Drawing.Point(289, 147);
            this.DeleteCurrentButton.Name = "DeleteCurrentButton";
            this.DeleteCurrentButton.Size = new System.Drawing.Size(108, 23);
            this.DeleteCurrentButton.TabIndex = 3;
            this.DeleteCurrentButton.Text = "Delete";
            this.DeleteCurrentButton.UseVisualStyleBackColor = true;
            this.DeleteCurrentButton.Click += new System.EventHandler(this.DeleteCurrentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 188);
            this.Controls.Add(this.DeleteCurrentButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GetFileNameButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button GetFileNameButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteCurrentButton;
    }
}

