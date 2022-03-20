
namespace LoadDataGridViewProgressBar
{
    partial class BindingListForm
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
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.CompanyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.CompanyNameFilterTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyNameColumn,
            this.ContactTitleColumn,
            this.CountryColumn});
            this.customerDataGridView.Location = new System.Drawing.Point(13, 19);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(480, 369);
            this.customerDataGridView.TabIndex = 0;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.DataPropertyName = "CompanyName";
            this.CompanyNameColumn.HeaderText = "Name";
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            this.CompanyNameColumn.ReadOnly = true;
            // 
            // ContactTitleColumn
            // 
            this.ContactTitleColumn.DataPropertyName = "ContactTitle";
            this.ContactTitleColumn.HeaderText = "Title";
            this.ContactTitleColumn.Name = "ContactTitleColumn";
            this.ContactTitleColumn.ReadOnly = true;
            // 
            // CountryColumn
            // 
            this.CountryColumn.DataPropertyName = "Country";
            this.CountryColumn.HeaderText = "Country";
            this.CountryColumn.Name = "CountryColumn";
            this.CountryColumn.ReadOnly = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(13, 406);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(159, 406);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 3;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // CompanyNameFilterTextBox
            // 
            this.CompanyNameFilterTextBox.Location = new System.Drawing.Point(243, 408);
            this.CompanyNameFilterTextBox.Name = "CompanyNameFilterTextBox";
            this.CompanyNameFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.CompanyNameFilterTextBox.TabIndex = 5;
            // 
            // BindingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.CompanyNameFilterTextBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.customerDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BindingListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BindingList Form";
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryColumn;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.TextBox CompanyNameFilterTextBox;
    }
}