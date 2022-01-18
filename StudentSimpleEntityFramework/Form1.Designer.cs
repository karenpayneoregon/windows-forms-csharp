
namespace StudentSimpleEntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstOrDefaultIdButton = new System.Windows.Forms.Button();
            this.FirstOrDefaultIdNameButton = new System.Windows.Forms.Button();
            this.FindByIdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstOrDefaultIdButton
            // 
            this.FirstOrDefaultIdButton.Location = new System.Drawing.Point(12, 12);
            this.FirstOrDefaultIdButton.Name = "FirstOrDefaultIdButton";
            this.FirstOrDefaultIdButton.Size = new System.Drawing.Size(232, 23);
            this.FirstOrDefaultIdButton.TabIndex = 0;
            this.FirstOrDefaultIdButton.Text = "FirstOrDefault id only";
            this.FirstOrDefaultIdButton.UseVisualStyleBackColor = true;
            this.FirstOrDefaultIdButton.Click += new System.EventHandler(this.FirstOrDefaultIdButton_Click);
            // 
            // FirstOrDefaultIdNameButton
            // 
            this.FirstOrDefaultIdNameButton.Location = new System.Drawing.Point(12, 54);
            this.FirstOrDefaultIdNameButton.Name = "FirstOrDefaultIdNameButton";
            this.FirstOrDefaultIdNameButton.Size = new System.Drawing.Size(232, 23);
            this.FirstOrDefaultIdNameButton.TabIndex = 1;
            this.FirstOrDefaultIdNameButton.Text = "FirstOrDefault id and name only";
            this.FirstOrDefaultIdNameButton.UseVisualStyleBackColor = true;
            this.FirstOrDefaultIdNameButton.Click += new System.EventHandler(this.FirstOrDefaultIdNameButton_Click);
            // 
            // FindByIdButton
            // 
            this.FindByIdButton.Location = new System.Drawing.Point(12, 96);
            this.FindByIdButton.Name = "FindByIdButton";
            this.FindByIdButton.Size = new System.Drawing.Size(232, 23);
            this.FindByIdButton.TabIndex = 2;
            this.FindByIdButton.Text = "Find by id";
            this.FindByIdButton.UseVisualStyleBackColor = true;
            this.FindByIdButton.Click += new System.EventHandler(this.FindByIdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 143);
            this.Controls.Add(this.FindByIdButton);
            this.Controls.Add(this.FirstOrDefaultIdNameButton);
            this.Controls.Add(this.FirstOrDefaultIdButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FirstOrDefaultIdButton;
        private System.Windows.Forms.Button FirstOrDefaultIdNameButton;
        private System.Windows.Forms.Button FindByIdButton;
    }
}

