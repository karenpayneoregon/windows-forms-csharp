
namespace PassingDataBetweenFormsSimple
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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ShowChildButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ShowConfirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(22, 12);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // ShowChildButton
            // 
            this.ShowChildButton.Location = new System.Drawing.Point(22, 38);
            this.ShowChildButton.Name = "ShowChildButton";
            this.ShowChildButton.Size = new System.Drawing.Size(226, 23);
            this.ShowChildButton.TabIndex = 2;
            this.ShowChildButton.Text = "Show Child Form";
            this.ShowChildButton.UseVisualStyleBackColor = true;
            this.ShowChildButton.Click += new System.EventHandler(this.ShowChildButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // ShowConfirmButton
            // 
            this.ShowConfirmButton.Location = new System.Drawing.Point(22, 79);
            this.ShowConfirmButton.Name = "ShowConfirmButton";
            this.ShowConfirmButton.Size = new System.Drawing.Size(226, 23);
            this.ShowConfirmButton.TabIndex = 4;
            this.ShowConfirmButton.Text = "Show confirm form";
            this.ShowConfirmButton.UseVisualStyleBackColor = true;
            this.ShowConfirmButton.Click += new System.EventHandler(this.ShowConfirmButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 114);
            this.Controls.Add(this.ShowConfirmButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ShowChildButton);
            this.Controls.Add(this.FirstNameTextBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button ShowChildButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button ShowConfirmButton;
    }
}

