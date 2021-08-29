
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomersBindingNavigator = new WinControlsLibrary.DataGridToolStrip();
            this.PreviousButton = new System.Windows.Forms.ToolStripButton();
            this.NextButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingNavigator)).BeginInit();
            this.CustomersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(800, 437);
            this.customerDataGridView.TabIndex = 3;
            // 
            // CustomersBindingNavigator
            // 
            this.CustomersBindingNavigator.AddNewItem = null;
            this.CustomersBindingNavigator.BindingSource = this.CustomersBindingSource;
            this.CustomersBindingNavigator.CountItem = null;
            this.CustomersBindingNavigator.DeleteItem = null;
            this.CustomersBindingNavigator.EditButton = this.EditButton;
            this.CustomersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreviousButton,
            this.NextButton,
            this.toolStripSeparator1,
            this.EditButton});
            this.CustomersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.CustomersBindingNavigator.MoveFirstItem = null;
            this.CustomersBindingNavigator.MoveLastItem = null;
            this.CustomersBindingNavigator.MoveNextItem = null;
            this.CustomersBindingNavigator.MovePreviousItem = null;
            this.CustomersBindingNavigator.Name = "CustomersBindingNavigator";
            this.CustomersBindingNavigator.NextButton = this.NextButton;
            this.CustomersBindingNavigator.PositionItem = null;
            this.CustomersBindingNavigator.PreviousButton = this.PreviousButton;
            this.CustomersBindingNavigator.Separator = this.toolStripSeparator1;
            this.CustomersBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.CustomersBindingNavigator.TabIndex = 4;
            this.CustomersBindingNavigator.Text = "dataGridToolStrip1";
            // 
            // PreviousButton
            // 
            this.PreviousButton.Enabled = false;
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(23, 22);
            // 
            // NextButton
            // 
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(23, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EditButton
            // 
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(23, 22);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.CustomersBindingNavigator);
            this.Controls.Add(this.customerDataGridView);
            this.Name = "Form2";
            this.Text = "Custom BindingNavigator";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingNavigator)).EndInit();
            this.CustomersBindingNavigator.ResumeLayout(false);
            this.CustomersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private WinControlsLibrary.DataGridToolStrip CustomersBindingNavigator;
        private System.Windows.Forms.ToolStripButton EditButton;
        private System.Windows.Forms.ToolStripButton PreviousButton;
        private System.Windows.Forms.ToolStripButton NextButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}