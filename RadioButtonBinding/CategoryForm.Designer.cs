
namespace RadioButtonBinding
{
    partial class CategoryForm
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
            this.CategoryFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SelectedButton = new System.Windows.Forms.Button();
            this.SelectedLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryFlowLayoutPanel
            // 
            this.CategoryFlowLayoutPanel.Location = new System.Drawing.Point(7, 12);
            this.CategoryFlowLayoutPanel.Name = "CategoryFlowLayoutPanel";
            this.CategoryFlowLayoutPanel.Size = new System.Drawing.Size(465, 72);
            this.CategoryFlowLayoutPanel.TabIndex = 0;
            // 
            // SelectedButton
            // 
            this.SelectedButton.Location = new System.Drawing.Point(20, 144);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(142, 23);
            this.SelectedButton.TabIndex = 1;
            this.SelectedButton.Text = "Selected";
            this.SelectedButton.UseVisualStyleBackColor = true;
            this.SelectedButton.Click += new System.EventHandler(this.SelectedButton_Click);
            // 
            // SelectedLabel
            // 
            this.SelectedLabel.AutoSize = true;
            this.SelectedLabel.Location = new System.Drawing.Point(17, 117);
            this.SelectedLabel.Name = "SelectedLabel";
            this.SelectedLabel.Size = new System.Drawing.Size(49, 13);
            this.SelectedLabel.TabIndex = 2;
            this.SelectedLabel.Text = "Selected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CategoryFlowLayoutPanel);
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 98);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 179);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectedLabel);
            this.Controls.Add(this.SelectedButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category example";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel CategoryFlowLayoutPanel;
        private System.Windows.Forms.Button SelectedButton;
        private System.Windows.Forms.Label SelectedLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}