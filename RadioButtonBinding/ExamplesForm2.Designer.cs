
namespace RadioButtonBinding
{
    partial class ExamplesForm2
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
            this.SuffixRadioGroupBox = new RadioButtonBinding.RadioGroupBox();
            this.CurrentSelectionLabel = new System.Windows.Forms.Label();
            this.ClearRadioSelectionButton = new System.Windows.Forms.Button();
            this.GetSelectedChoiceButton = new System.Windows.Forms.Button();
            this.MissRadioButton = new System.Windows.Forms.RadioButton();
            this.MrsRadioButton = new System.Windows.Forms.RadioButton();
            this.MrRadioButton = new System.Windows.Forms.RadioButton();
            this.myPanel1 = new RadioButtonBinding.Controls.MyPanel();
            this.myRadioButton1 = new RadioButtonBinding.Controls.MyRadioButton();
            this.myRadioButton2 = new RadioButtonBinding.Controls.MyRadioButton();
            this.myRadioButton3 = new RadioButtonBinding.Controls.MyRadioButton();
            this.SuffixRadioGroupBox.SuspendLayout();
            this.myPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuffixRadioGroupBox
            // 
            this.SuffixRadioGroupBox.Controls.Add(this.CurrentSelectionLabel);
            this.SuffixRadioGroupBox.Controls.Add(this.ClearRadioSelectionButton);
            this.SuffixRadioGroupBox.Controls.Add(this.GetSelectedChoiceButton);
            this.SuffixRadioGroupBox.Controls.Add(this.MissRadioButton);
            this.SuffixRadioGroupBox.Controls.Add(this.MrsRadioButton);
            this.SuffixRadioGroupBox.Controls.Add(this.MrRadioButton);
            this.SuffixRadioGroupBox.Location = new System.Drawing.Point(36, 38);
            this.SuffixRadioGroupBox.Name = "SuffixRadioGroupBox";
            this.SuffixRadioGroupBox.Selected = 0;
            this.SuffixRadioGroupBox.Size = new System.Drawing.Size(184, 141);
            this.SuffixRadioGroupBox.TabIndex = 14;
            this.SuffixRadioGroupBox.TabStop = false;
            this.SuffixRadioGroupBox.Text = "Suffix";
            // 
            // CurrentSelectionLabel
            // 
            this.CurrentSelectionLabel.AutoSize = true;
            this.CurrentSelectionLabel.Location = new System.Drawing.Point(21, 119);
            this.CurrentSelectionLabel.Name = "CurrentSelectionLabel";
            this.CurrentSelectionLabel.Size = new System.Drawing.Size(40, 13);
            this.CurrentSelectionLabel.TabIndex = 5;
            this.CurrentSelectionLabel.Text = "current";
            // 
            // ClearRadioSelectionButton
            // 
            this.ClearRadioSelectionButton.Location = new System.Drawing.Point(13, 76);
            this.ClearRadioSelectionButton.Name = "ClearRadioSelectionButton";
            this.ClearRadioSelectionButton.Size = new System.Drawing.Size(146, 23);
            this.ClearRadioSelectionButton.TabIndex = 4;
            this.ClearRadioSelectionButton.Text = "Clear selection";
            this.ClearRadioSelectionButton.UseVisualStyleBackColor = true;
            this.ClearRadioSelectionButton.Click += new System.EventHandler(this.ClearRadioSelectionButton_Click);
            // 
            // GetSelectedChoiceButton
            // 
            this.GetSelectedChoiceButton.Location = new System.Drawing.Point(13, 47);
            this.GetSelectedChoiceButton.Name = "GetSelectedChoiceButton";
            this.GetSelectedChoiceButton.Size = new System.Drawing.Size(146, 23);
            this.GetSelectedChoiceButton.TabIndex = 3;
            this.GetSelectedChoiceButton.Text = "Get selected";
            this.GetSelectedChoiceButton.UseVisualStyleBackColor = true;
            this.GetSelectedChoiceButton.Click += new System.EventHandler(this.GetSelectedChoiceButton_Click);
            // 
            // MissRadioButton
            // 
            this.MissRadioButton.AutoSize = true;
            this.MissRadioButton.Location = new System.Drawing.Point(113, 24);
            this.MissRadioButton.Name = "MissRadioButton";
            this.MissRadioButton.Size = new System.Drawing.Size(46, 17);
            this.MissRadioButton.TabIndex = 2;
            this.MissRadioButton.TabStop = true;
            this.MissRadioButton.Tag = "";
            this.MissRadioButton.Text = "Miss";
            this.MissRadioButton.UseVisualStyleBackColor = true;
            // 
            // MrsRadioButton
            // 
            this.MrsRadioButton.AutoSize = true;
            this.MrsRadioButton.Location = new System.Drawing.Point(65, 24);
            this.MrsRadioButton.Name = "MrsRadioButton";
            this.MrsRadioButton.Size = new System.Drawing.Size(42, 17);
            this.MrsRadioButton.TabIndex = 1;
            this.MrsRadioButton.TabStop = true;
            this.MrsRadioButton.Tag = "";
            this.MrsRadioButton.Text = "Mrs";
            this.MrsRadioButton.UseVisualStyleBackColor = true;
            // 
            // MrRadioButton
            // 
            this.MrRadioButton.AutoSize = true;
            this.MrRadioButton.Location = new System.Drawing.Point(13, 24);
            this.MrRadioButton.Name = "MrRadioButton";
            this.MrRadioButton.Size = new System.Drawing.Size(37, 17);
            this.MrRadioButton.TabIndex = 0;
            this.MrRadioButton.TabStop = true;
            this.MrRadioButton.Tag = "";
            this.MrRadioButton.Text = "Mr";
            this.MrRadioButton.UseVisualStyleBackColor = true;
            // 
            // myPanel1
            // 
            this.myPanel1.Controls.Add(this.myRadioButton3);
            this.myPanel1.Controls.Add(this.myRadioButton2);
            this.myPanel1.Controls.Add(this.myRadioButton1);
            this.myPanel1.Location = new System.Drawing.Point(28, 207);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.myPanel1.Size = new System.Drawing.Size(200, 55);
            this.myPanel1.TabIndex = 15;
            // 
            // myRadioButton1
            // 
            this.myRadioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.myRadioButton1.AutoSize = true;
            this.myRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.myRadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.myRadioButton1.FlatAppearance.BorderSize = 2;
            this.myRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myRadioButton1.Location = new System.Drawing.Point(32, 17);
            this.myRadioButton1.Name = "myRadioButton1";
            this.myRadioButton1.Size = new System.Drawing.Size(33, 27);
            this.myRadioButton1.TabIndex = 0;
            this.myRadioButton1.TabStop = true;
            this.myRadioButton1.Text = "Mr";
            this.myRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myRadioButton1.UseVisualStyleBackColor = false;
            // 
            // myRadioButton2
            // 
            this.myRadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.myRadioButton2.AutoSize = true;
            this.myRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.myRadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.myRadioButton2.FlatAppearance.BorderSize = 2;
            this.myRadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myRadioButton2.Location = new System.Drawing.Point(83, 17);
            this.myRadioButton2.Name = "myRadioButton2";
            this.myRadioButton2.Size = new System.Drawing.Size(38, 27);
            this.myRadioButton2.TabIndex = 1;
            this.myRadioButton2.TabStop = true;
            this.myRadioButton2.Text = "Mrs";
            this.myRadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myRadioButton2.UseVisualStyleBackColor = false;
            // 
            // myRadioButton3
            // 
            this.myRadioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.myRadioButton3.AutoSize = true;
            this.myRadioButton3.BackColor = System.Drawing.Color.Transparent;
            this.myRadioButton3.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.myRadioButton3.FlatAppearance.BorderSize = 2;
            this.myRadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myRadioButton3.Location = new System.Drawing.Point(139, 17);
            this.myRadioButton3.Name = "myRadioButton3";
            this.myRadioButton3.Size = new System.Drawing.Size(42, 27);
            this.myRadioButton3.TabIndex = 2;
            this.myRadioButton3.TabStop = true;
            this.myRadioButton3.Text = "Miss";
            this.myRadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myRadioButton3.UseVisualStyleBackColor = false;
            // 
            // ExamplesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 316);
            this.Controls.Add(this.myPanel1);
            this.Controls.Add(this.SuffixRadioGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExamplesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examples";
            this.SuffixRadioGroupBox.ResumeLayout(false);
            this.SuffixRadioGroupBox.PerformLayout();
            this.myPanel1.ResumeLayout(false);
            this.myPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioGroupBox SuffixRadioGroupBox;
        private System.Windows.Forms.RadioButton MissRadioButton;
        private System.Windows.Forms.RadioButton MrsRadioButton;
        private System.Windows.Forms.RadioButton MrRadioButton;
        private System.Windows.Forms.Button GetSelectedChoiceButton;
        private System.Windows.Forms.Button ClearRadioSelectionButton;
        private System.Windows.Forms.Label CurrentSelectionLabel;
        private Controls.MyPanel myPanel1;
        private Controls.MyRadioButton myRadioButton2;
        private Controls.MyRadioButton myRadioButton1;
        private Controls.MyRadioButton myRadioButton3;
    }
}