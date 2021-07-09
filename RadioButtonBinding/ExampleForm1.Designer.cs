
namespace RadioButtonBinding
{
    partial class ExampleForm1
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
            this.ClearCheckedButton = new System.Windows.Forms.Button();
            this.GetSelectedChoiceInGroupBoxButton = new System.Windows.Forms.Button();
            this.GetSelectedChoiceOnFormButton = new System.Windows.Forms.Button();
            this.MissRadioButton = new System.Windows.Forms.RadioButton();
            this.MrsRadioButton = new System.Windows.Forms.RadioButton();
            this.MrRadioButton = new System.Windows.Forms.RadioButton();
            this.SuffixRadioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuffixRadioGroupBox
            // 
            this.SuffixRadioGroupBox.Controls.Add(this.ClearCheckedButton);
            this.SuffixRadioGroupBox.Controls.Add(this.GetSelectedChoiceInGroupBoxButton);
            this.SuffixRadioGroupBox.Controls.Add(this.GetSelectedChoiceOnFormButton);
            this.SuffixRadioGroupBox.Controls.Add(this.MissRadioButton);
            this.SuffixRadioGroupBox.Controls.Add(this.MrsRadioButton);
            this.SuffixRadioGroupBox.Controls.Add(this.MrRadioButton);
            this.SuffixRadioGroupBox.Location = new System.Drawing.Point(26, 18);
            this.SuffixRadioGroupBox.Name = "SuffixRadioGroupBox";
            this.SuffixRadioGroupBox.Selected = 0;
            this.SuffixRadioGroupBox.Size = new System.Drawing.Size(184, 139);
            this.SuffixRadioGroupBox.TabIndex = 15;
            this.SuffixRadioGroupBox.TabStop = false;
            this.SuffixRadioGroupBox.Text = "Suffix";
            // 
            // ClearCheckedButton
            // 
            this.ClearCheckedButton.Location = new System.Drawing.Point(13, 105);
            this.ClearCheckedButton.Name = "ClearCheckedButton";
            this.ClearCheckedButton.Size = new System.Drawing.Size(146, 23);
            this.ClearCheckedButton.TabIndex = 16;
            this.ClearCheckedButton.Text = "Clear checked";
            this.ClearCheckedButton.UseVisualStyleBackColor = true;
            this.ClearCheckedButton.Click += new System.EventHandler(this.ClearCheckedButton_Click);
            // 
            // GetSelectedChoiceInGroupBoxButton
            // 
            this.GetSelectedChoiceInGroupBoxButton.Location = new System.Drawing.Point(13, 76);
            this.GetSelectedChoiceInGroupBoxButton.Name = "GetSelectedChoiceInGroupBoxButton";
            this.GetSelectedChoiceInGroupBoxButton.Size = new System.Drawing.Size(146, 23);
            this.GetSelectedChoiceInGroupBoxButton.TabIndex = 4;
            this.GetSelectedChoiceInGroupBoxButton.Text = "Get selected in GroupBox";
            this.GetSelectedChoiceInGroupBoxButton.UseVisualStyleBackColor = true;
            this.GetSelectedChoiceInGroupBoxButton.Click += new System.EventHandler(this.GetSelectedChoiceInGroupBoxButton_Click);
            // 
            // GetSelectedChoiceOnFormButton
            // 
            this.GetSelectedChoiceOnFormButton.Location = new System.Drawing.Point(13, 47);
            this.GetSelectedChoiceOnFormButton.Name = "GetSelectedChoiceOnFormButton";
            this.GetSelectedChoiceOnFormButton.Size = new System.Drawing.Size(146, 23);
            this.GetSelectedChoiceOnFormButton.TabIndex = 3;
            this.GetSelectedChoiceOnFormButton.Text = "Get selected on form";
            this.GetSelectedChoiceOnFormButton.UseVisualStyleBackColor = true;
            this.GetSelectedChoiceOnFormButton.Click += new System.EventHandler(this.GetSelectedChoiceOnFormButton_Click);
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
            // ExampleForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 181);
            this.Controls.Add(this.SuffixRadioGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExampleForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conventional example";
            this.SuffixRadioGroupBox.ResumeLayout(false);
            this.SuffixRadioGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioGroupBox SuffixRadioGroupBox;
        private System.Windows.Forms.Button GetSelectedChoiceOnFormButton;
        private System.Windows.Forms.RadioButton MissRadioButton;
        private System.Windows.Forms.RadioButton MrsRadioButton;
        private System.Windows.Forms.RadioButton MrRadioButton;
        private System.Windows.Forms.Button GetSelectedChoiceInGroupBoxButton;
        private System.Windows.Forms.Button ClearCheckedButton;
    }
}