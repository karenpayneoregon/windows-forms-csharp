
namespace CheckListBoxProducts
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
            this.ProductCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.GetCheckedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductCheckedListBox
            // 
            this.ProductCheckedListBox.FormattingEnabled = true;
            this.ProductCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.ProductCheckedListBox.Name = "ProductCheckedListBox";
            this.ProductCheckedListBox.Size = new System.Drawing.Size(195, 184);
            this.ProductCheckedListBox.TabIndex = 0;
            // 
            // GetCheckedButton
            // 
            this.GetCheckedButton.Location = new System.Drawing.Point(12, 202);
            this.GetCheckedButton.Name = "GetCheckedButton";
            this.GetCheckedButton.Size = new System.Drawing.Size(195, 23);
            this.GetCheckedButton.TabIndex = 1;
            this.GetCheckedButton.Text = "Get checked";
            this.GetCheckedButton.UseVisualStyleBackColor = true;
            this.GetCheckedButton.Click += new System.EventHandler(this.GetCheckedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 239);
            this.Controls.Add(this.GetCheckedButton);
            this.Controls.Add(this.ProductCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Get checked";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ProductCheckedListBox;
        private System.Windows.Forms.Button GetCheckedButton;
    }
}

