
namespace SpreadsheetLightDataGridViewExport
{
    partial class PoliciesForm
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
            this.PoliciesListBox = new System.Windows.Forms.ListBox();
            this.FindDuplicatesButton = new System.Windows.Forms.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PoliciesListBox
            // 
            this.PoliciesListBox.FormattingEnabled = true;
            this.PoliciesListBox.Location = new System.Drawing.Point(35, 22);
            this.PoliciesListBox.Name = "PoliciesListBox";
            this.PoliciesListBox.Size = new System.Drawing.Size(120, 108);
            this.PoliciesListBox.TabIndex = 0;
            // 
            // FindDuplicatesButton
            // 
            this.FindDuplicatesButton.Location = new System.Drawing.Point(35, 136);
            this.FindDuplicatesButton.Name = "FindDuplicatesButton";
            this.FindDuplicatesButton.Size = new System.Drawing.Size(120, 23);
            this.FindDuplicatesButton.TabIndex = 1;
            this.FindDuplicatesButton.Text = "Find duplicates";
            this.FindDuplicatesButton.UseVisualStyleBackColor = true;
            this.FindDuplicatesButton.Click += new System.EventHandler(this.FindDuplicatesButton_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.Location = new System.Drawing.Point(161, 22);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(139, 108);
            this.ResultsListBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PoliciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.FindDuplicatesButton);
            this.Controls.Add(this.PoliciesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PoliciesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Policies";
            this.Load += new System.EventHandler(this.PoliciesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PoliciesListBox;
        private System.Windows.Forms.Button FindDuplicatesButton;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Button button1;
    }
}