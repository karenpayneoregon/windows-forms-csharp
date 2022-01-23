
namespace DeconstructCodeSamples
{
    partial class ConventionalForm
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
            this.StudentGradesButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeconstructButton = new System.Windows.Forms.Button();
            this.CurrentButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentGradesButton
            // 
            this.StudentGradesButton.Location = new System.Drawing.Point(21, 16);
            this.StudentGradesButton.Name = "StudentGradesButton";
            this.StudentGradesButton.Size = new System.Drawing.Size(259, 23);
            this.StudentGradesButton.TabIndex = 0;
            this.StudentGradesButton.Text = "Student grades";
            this.StudentGradesButton.UseVisualStyleBackColor = true;
            this.StudentGradesButton.Click += new System.EventHandler(this.StudentGradesButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(259, 143);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "Grade";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "Letter";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeconstructButton);
            this.groupBox1.Controls.Add(this.CurrentButton);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.StudentGradesButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 253);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DeconstructButton
            // 
            this.DeconstructButton.Location = new System.Drawing.Point(21, 224);
            this.DeconstructButton.Name = "DeconstructButton";
            this.DeconstructButton.Size = new System.Drawing.Size(259, 23);
            this.DeconstructButton.TabIndex = 3;
            this.DeconstructButton.Text = "Deconstruct";
            this.DeconstructButton.UseVisualStyleBackColor = true;
            this.DeconstructButton.Click += new System.EventHandler(this.DeconstructButton_Click);
            // 
            // CurrentButton
            // 
            this.CurrentButton.Location = new System.Drawing.Point(21, 194);
            this.CurrentButton.Name = "CurrentButton";
            this.CurrentButton.Size = new System.Drawing.Size(259, 23);
            this.CurrentButton.TabIndex = 2;
            this.CurrentButton.Text = "Current";
            this.CurrentButton.UseVisualStyleBackColor = true;
            this.CurrentButton.Click += new System.EventHandler(this.CurrentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 277);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deconstruct code sample";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentGradesButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CurrentButton;
        private System.Windows.Forms.Button DeconstructButton;
    }
}

