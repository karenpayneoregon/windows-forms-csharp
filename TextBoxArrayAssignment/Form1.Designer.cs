
namespace TextBoxArrayAssignment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCustom5 = new TextBoxArrayAssignment.TextBoxCustom();
            this.textBoxCustom3 = new TextBoxArrayAssignment.TextBoxCustom();
            this.textBoxCustom2 = new TextBoxArrayAssignment.TextBoxCustom();
            this.textBoxCustom1 = new TextBoxArrayAssignment.TextBoxCustom();
            this.textBoxCustom10 = new TextBoxArrayAssignment.TextBoxCustom();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCustom10);
            this.groupBox1.Controls.Add(this.textBoxCustom5);
            this.groupBox1.Controls.Add(this.textBoxCustom3);
            this.groupBox1.Controls.Add(this.textBoxCustom2);
            this.groupBox1.Controls.Add(this.textBoxCustom1);
            this.groupBox1.Location = new System.Drawing.Point(70, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBoxCustom5
            // 
            this.textBoxCustom5.Location = new System.Drawing.Point(25, 91);
            this.textBoxCustom5.Name = "textBoxCustom5";
            this.textBoxCustom5.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustom5.TabIndex = 4;
            // 
            // textBoxCustom3
            // 
            this.textBoxCustom3.Location = new System.Drawing.Point(25, 65);
            this.textBoxCustom3.Name = "textBoxCustom3";
            this.textBoxCustom3.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustom3.TabIndex = 2;
            // 
            // textBoxCustom2
            // 
            this.textBoxCustom2.Location = new System.Drawing.Point(25, 39);
            this.textBoxCustom2.Name = "textBoxCustom2";
            this.textBoxCustom2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustom2.TabIndex = 1;
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.Location = new System.Drawing.Point(25, 13);
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustom1.TabIndex = 0;
            // 
            // textBoxCustom10
            // 
            this.textBoxCustom10.Location = new System.Drawing.Point(25, 117);
            this.textBoxCustom10.Name = "textBoxCustom10";
            this.textBoxCustom10.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustom10.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxCustom textBoxCustom1;
        private TextBoxCustom textBoxCustom2;
        private TextBoxCustom textBoxCustom3;
        private TextBoxCustom textBoxCustom5;
        private System.Windows.Forms.GroupBox groupBox1;
        private TextBoxCustom textBoxCustom10;
    }
}

