
namespace DirectoryCode
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
            this.CompareButton = new System.Windows.Forms.Button();
            this.TraverseButton = new System.Windows.Forms.Button();
            this.CancelTaskButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(75, 38);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(75, 23);
            this.CompareButton.TabIndex = 0;
            this.CompareButton.Text = "Compare";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // TraverseButton
            // 
            this.TraverseButton.Location = new System.Drawing.Point(75, 81);
            this.TraverseButton.Name = "TraverseButton";
            this.TraverseButton.Size = new System.Drawing.Size(75, 23);
            this.TraverseButton.TabIndex = 1;
            this.TraverseButton.Text = "Traverse";
            this.TraverseButton.UseVisualStyleBackColor = true;
            this.TraverseButton.Click += new System.EventHandler(this.TraverseButton_Click);
            // 
            // CancelTaskButton
            // 
            this.CancelTaskButton.Location = new System.Drawing.Point(156, 81);
            this.CancelTaskButton.Name = "CancelTaskButton";
            this.CancelTaskButton.Size = new System.Drawing.Size(75, 23);
            this.CancelTaskButton.TabIndex = 2;
            this.CancelTaskButton.Text = "Cancel";
            this.CancelTaskButton.UseVisualStyleBackColor = true;
            this.CancelTaskButton.Click += new System.EventHandler(this.CancelTaskButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelTaskButton);
            this.Controls.Add(this.TraverseButton);
            this.Controls.Add(this.CompareButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.Button TraverseButton;
        private System.Windows.Forms.Button CancelTaskButton;
        private System.Windows.Forms.Button button1;
    }
}

