﻿
namespace LoadDataGridViewProgressBar
{
    partial class Form3
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
            this.customerDataGridView = new LoadDataGridViewProgressBar.Controls.DataGridViewJumper();
            this.LoadDataGridViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(29, 24);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(741, 339);
            this.customerDataGridView.TabIndex = 0;
            // 
            // LoadDataGridViewButton
            // 
            this.LoadDataGridViewButton.Location = new System.Drawing.Point(32, 384);
            this.LoadDataGridViewButton.Name = "LoadDataGridViewButton";
            this.LoadDataGridViewButton.Size = new System.Drawing.Size(75, 23);
            this.LoadDataGridViewButton.TabIndex = 1;
            this.LoadDataGridViewButton.Text = "Load";
            this.LoadDataGridViewButton.UseVisualStyleBackColor = true;
            this.LoadDataGridViewButton.Click += new System.EventHandler(this.LoadDataGridViewButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadDataGridViewButton);
            this.Controls.Add(this.customerDataGridView);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DataGridViewJumper customerDataGridView;
        private System.Windows.Forms.Button LoadDataGridViewButton;
    }
}