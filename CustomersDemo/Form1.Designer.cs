
namespace CustomersDemo
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
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.RemoveCurrentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 15;
            this.listBoxCustomers.Location = new System.Drawing.Point(8, 3);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(226, 139);
            this.listBoxCustomers.TabIndex = 0;
            // 
            // RemoveCurrentButton
            // 
            this.RemoveCurrentButton.Location = new System.Drawing.Point(8, 158);
            this.RemoveCurrentButton.Name = "RemoveCurrentButton";
            this.RemoveCurrentButton.Size = new System.Drawing.Size(226, 23);
            this.RemoveCurrentButton.TabIndex = 1;
            this.RemoveCurrentButton.Text = "Remove current";
            this.RemoveCurrentButton.UseVisualStyleBackColor = true;
            this.RemoveCurrentButton.Click += new System.EventHandler(this.RemoveCurrentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 203);
            this.Controls.Add(this.RemoveCurrentButton);
            this.Controls.Add(this.listBoxCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Button RemoveCurrentButton;
    }
}

