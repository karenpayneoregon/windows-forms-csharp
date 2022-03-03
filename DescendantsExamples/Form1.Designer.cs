
namespace DescendantsExamples
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
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.GetSelectionsButton = new System.Windows.Forms.Button();
            this.LevelGroupBox = new System.Windows.Forms.GroupBox();
            this.Level1RadioButton = new System.Windows.Forms.RadioButton();
            this.Level2RadioButton = new System.Windows.Forms.RadioButton();
            this.Level3RadioButton = new System.Windows.Forms.RadioButton();
            this.GenderGroupBox.SuspendLayout();
            this.LevelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.FemaleRadioButton);
            this.GenderGroupBox.Controls.Add(this.MaleRadioButton);
            this.GenderGroupBox.Location = new System.Drawing.Point(10, 16);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(116, 100);
            this.GenderGroupBox.TabIndex = 0;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(16, 27);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioButton.TabIndex = 0;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(17, 58);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 1;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // GetSelectionsButton
            // 
            this.GetSelectionsButton.Location = new System.Drawing.Point(11, 145);
            this.GetSelectionsButton.Name = "GetSelectionsButton";
            this.GetSelectionsButton.Size = new System.Drawing.Size(75, 23);
            this.GetSelectionsButton.TabIndex = 2;
            this.GetSelectionsButton.Text = "Get";
            this.GetSelectionsButton.UseVisualStyleBackColor = true;
            this.GetSelectionsButton.Click += new System.EventHandler(this.GetSelectionsButton_Click);
            // 
            // LevelGroupBox
            // 
            this.LevelGroupBox.Controls.Add(this.Level3RadioButton);
            this.LevelGroupBox.Controls.Add(this.Level2RadioButton);
            this.LevelGroupBox.Controls.Add(this.Level1RadioButton);
            this.LevelGroupBox.Location = new System.Drawing.Point(153, 16);
            this.LevelGroupBox.Name = "LevelGroupBox";
            this.LevelGroupBox.Size = new System.Drawing.Size(112, 100);
            this.LevelGroupBox.TabIndex = 3;
            this.LevelGroupBox.TabStop = false;
            this.LevelGroupBox.Text = "Level";
            // 
            // Level1RadioButton
            // 
            this.Level1RadioButton.AutoSize = true;
            this.Level1RadioButton.Location = new System.Drawing.Point(6, 22);
            this.Level1RadioButton.Name = "Level1RadioButton";
            this.Level1RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Level1RadioButton.TabIndex = 0;
            this.Level1RadioButton.TabStop = true;
            this.Level1RadioButton.Text = "1";
            this.Level1RadioButton.UseVisualStyleBackColor = true;
            // 
            // Level2RadioButton
            // 
            this.Level2RadioButton.AutoSize = true;
            this.Level2RadioButton.Location = new System.Drawing.Point(6, 53);
            this.Level2RadioButton.Name = "Level2RadioButton";
            this.Level2RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Level2RadioButton.TabIndex = 1;
            this.Level2RadioButton.TabStop = true;
            this.Level2RadioButton.Text = "2";
            this.Level2RadioButton.UseVisualStyleBackColor = true;
            // 
            // Level3RadioButton
            // 
            this.Level3RadioButton.AutoSize = true;
            this.Level3RadioButton.Location = new System.Drawing.Point(58, 22);
            this.Level3RadioButton.Name = "Level3RadioButton";
            this.Level3RadioButton.Size = new System.Drawing.Size(31, 17);
            this.Level3RadioButton.TabIndex = 2;
            this.Level3RadioButton.TabStop = true;
            this.Level3RadioButton.Text = "3";
            this.Level3RadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.LevelGroupBox);
            this.Controls.Add(this.GetSelectionsButton);
            this.Controls.Add(this.GenderGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Sample";
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.LevelGroupBox.ResumeLayout(false);
            this.LevelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.Button GetSelectionsButton;
        private System.Windows.Forms.GroupBox LevelGroupBox;
        private System.Windows.Forms.RadioButton Level3RadioButton;
        private System.Windows.Forms.RadioButton Level2RadioButton;
        private System.Windows.Forms.RadioButton Level1RadioButton;
    }
}

