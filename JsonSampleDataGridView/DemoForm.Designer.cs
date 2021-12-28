
namespace JsonSampleDataGridView
{
    partial class DemoForm
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
            this.LastRanLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // LastRanLabel
            // 
            this.LastRanLabel.AutoSize = true;
            this.LastRanLabel.Location = new System.Drawing.Point(18, 20);
            this.LastRanLabel.Name = "LastRanLabel";
            this.LastRanLabel.Size = new System.Drawing.Size(35, 13);
            this.LastRanLabel.TabIndex = 0;
            this.LastRanLabel.Text = "label1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 57);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 50;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 239);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.LastRanLabel);
            this.Name = "DemoForm";
            this.Text = "DemoForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastRanLabel;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}