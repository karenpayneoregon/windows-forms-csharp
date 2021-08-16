
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButtonSI = new System.Windows.Forms.RadioButton();
            this.radioButtonIM = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(22, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 139);
            this.listBox1.TabIndex = 1;
            // 
            // radioButtonSI
            // 
            this.radioButtonSI.AutoSize = true;
            this.radioButtonSI.Location = new System.Drawing.Point(175, 14);
            this.radioButtonSI.Name = "radioButtonSI";
            this.radioButtonSI.Size = new System.Drawing.Size(34, 19);
            this.radioButtonSI.TabIndex = 2;
            this.radioButtonSI.TabStop = true;
            this.radioButtonSI.Tag = "SI";
            this.radioButtonSI.Text = "SI";
            this.radioButtonSI.UseVisualStyleBackColor = true;
            // 
            // radioButtonIM
            // 
            this.radioButtonIM.AutoSize = true;
            this.radioButtonIM.Checked = true;
            this.radioButtonIM.Location = new System.Drawing.Point(175, 39);
            this.radioButtonIM.Name = "radioButtonIM";
            this.radioButtonIM.Size = new System.Drawing.Size(39, 19);
            this.radioButtonIM.TabIndex = 3;
            this.radioButtonIM.TabStop = true;
            this.radioButtonIM.Tag = "IM";
            this.radioButtonIM.Text = "IM";
            this.radioButtonIM.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 178);
            this.Controls.Add(this.radioButtonIM);
            this.Controls.Add(this.radioButtonSI);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButtonSI;
        private System.Windows.Forms.RadioButton radioButtonIM;
    }
}

