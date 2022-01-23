
namespace DeconstructCodeSamples
{
    partial class DeconstructForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ConventionButton = new System.Windows.Forms.Button();
            this.DeconstructIdFirstLastButton = new System.Windows.Forms.Button();
            this.DeconstructIdLastButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(26, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 199);
            this.listBox1.TabIndex = 0;
            // 
            // ConventionButton
            // 
            this.ConventionButton.Location = new System.Drawing.Point(222, 12);
            this.ConventionButton.Name = "ConventionButton";
            this.ConventionButton.Size = new System.Drawing.Size(152, 23);
            this.ConventionButton.TabIndex = 1;
            this.ConventionButton.Text = "Conventional";
            this.ConventionButton.UseVisualStyleBackColor = true;
            this.ConventionButton.Click += new System.EventHandler(this.ConventionButton_Click);
            // 
            // DeconstructIdFirstLastButton
            // 
            this.DeconstructIdFirstLastButton.Location = new System.Drawing.Point(222, 41);
            this.DeconstructIdFirstLastButton.Name = "DeconstructIdFirstLastButton";
            this.DeconstructIdFirstLastButton.Size = new System.Drawing.Size(152, 23);
            this.DeconstructIdFirstLastButton.TabIndex = 2;
            this.DeconstructIdFirstLastButton.Text = "Id, First,Last";
            this.DeconstructIdFirstLastButton.UseVisualStyleBackColor = true;
            this.DeconstructIdFirstLastButton.Click += new System.EventHandler(this.DeconstructIdFirstLastButton_Click);
            // 
            // DeconstructIdLastButton
            // 
            this.DeconstructIdLastButton.Location = new System.Drawing.Point(222, 70);
            this.DeconstructIdLastButton.Name = "DeconstructIdLastButton";
            this.DeconstructIdLastButton.Size = new System.Drawing.Size(152, 23);
            this.DeconstructIdLastButton.TabIndex = 3;
            this.DeconstructIdLastButton.Text = "Id,Last";
            this.DeconstructIdLastButton.UseVisualStyleBackColor = true;
            this.DeconstructIdLastButton.Click += new System.EventHandler(this.DeconstructIdLastButton_Click);
            // 
            // DeconstructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 243);
            this.Controls.Add(this.DeconstructIdLastButton);
            this.Controls.Add(this.DeconstructIdFirstLastButton);
            this.Controls.Add(this.ConventionButton);
            this.Controls.Add(this.listBox1);
            this.Name = "DeconstructForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deconstruct code samples";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ConventionButton;
        private System.Windows.Forms.Button DeconstructIdFirstLastButton;
        private System.Windows.Forms.Button DeconstructIdLastButton;
    }
}