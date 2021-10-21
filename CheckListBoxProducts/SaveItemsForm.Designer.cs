
namespace CheckListBoxProducts
{
    partial class SaveItemsForm
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
            this.SuspendLayout();
            // 
            // ProductCheckedListBox
            // 
            this.ProductCheckedListBox.CheckOnClick = true;
            this.ProductCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductCheckedListBox.FormattingEnabled = true;
            this.ProductCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.ProductCheckedListBox.Name = "ProductCheckedListBox";
            this.ProductCheckedListBox.Size = new System.Drawing.Size(226, 251);
            this.ProductCheckedListBox.TabIndex = 1;
            // 
            // SaveItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 251);
            this.Controls.Add(this.ProductCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaveItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Items to Json file";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ProductCheckedListBox;
    }
}