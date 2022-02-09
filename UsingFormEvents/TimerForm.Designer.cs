
namespace UsingFormEvents
{
    partial class TimerForm
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
            this.WhatEverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhatEverButton
            // 
            this.WhatEverButton.Location = new System.Drawing.Point(71, 38);
            this.WhatEverButton.Name = "WhatEverButton";
            this.WhatEverButton.Size = new System.Drawing.Size(75, 23);
            this.WhatEverButton.TabIndex = 0;
            this.WhatEverButton.Text = "button1";
            this.WhatEverButton.UseVisualStyleBackColor = true;
            this.WhatEverButton.Click += new System.EventHandler(this.WhatEverButton_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 96);
            this.Controls.Add(this.WhatEverButton);
            this.Name = "TimerForm";
            this.Text = "TimerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WhatEverButton;
    }
}