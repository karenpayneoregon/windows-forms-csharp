
namespace LoadDataGridViewProgressBar
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.InsertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(610, 448);
            this.customerDataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InsertButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 52);
            this.panel1.TabIndex = 4;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(12, 17);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(145, 23);
            this.InsertButton.TabIndex = 0;
            this.InsertButton.Text = "Insert selected rows";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 500);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Custom BindingNavigator";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private WinControlsLibrary.DataGridToolStrip CustomersBindingNavigator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InsertButton;
    }
}