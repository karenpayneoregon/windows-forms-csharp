
namespace CheckListBoxProducts
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
            this.OpenForm1Button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OpenForm1Button
            // 
            this.OpenForm1Button.Location = new System.Drawing.Point(22, 19);
            this.OpenForm1Button.Name = "OpenForm1Button";
            this.OpenForm1Button.Size = new System.Drawing.Size(137, 23);
            this.OpenForm1Button.TabIndex = 0;
            this.OpenForm1Button.Text = "Open form";
            this.OpenForm1Button.UseVisualStyleBackColor = true;
            this.OpenForm1Button.Click += new System.EventHandler(this.OpenForm1Button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(165, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 147);
            this.listBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 168);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.OpenForm1Button);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenForm1Button;
        private System.Windows.Forms.ListBox listBox1;
    }
}