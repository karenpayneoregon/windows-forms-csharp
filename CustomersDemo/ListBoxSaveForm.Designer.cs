
namespace CustomersDemo
{
    partial class ListBoxSaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBoxSaveForm));
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditCurrentButton = new System.Windows.Forms.Button();
            this.JsonSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(21, 31);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.PlaceholderText = "enter first name";
            this.FirstNameTextBox.Size = new System.Drawing.Size(153, 23);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(21, 84);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.PlaceholderText = "enter last name";
            this.LastNameTextBox.Size = new System.Drawing.Size(153, 23);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 15;
            this.CustomersListBox.Location = new System.Drawing.Point(188, 25);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(304, 94);
            this.CustomersListBox.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(16, 144);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditCurrentButton
            // 
            this.EditCurrentButton.Image = ((System.Drawing.Image)(resources.GetObject("EditCurrentButton.Image")));
            this.EditCurrentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditCurrentButton.Location = new System.Drawing.Point(104, 144);
            this.EditCurrentButton.Name = "EditCurrentButton";
            this.EditCurrentButton.Size = new System.Drawing.Size(75, 23);
            this.EditCurrentButton.TabIndex = 6;
            this.EditCurrentButton.Text = "Edit";
            this.EditCurrentButton.UseVisualStyleBackColor = true;
            this.EditCurrentButton.Click += new System.EventHandler(this.EditCurrentButton_Click);
            // 
            // JsonSaveButton
            // 
            this.JsonSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("JsonSaveButton.Image")));
            this.JsonSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JsonSaveButton.Location = new System.Drawing.Point(417, 144);
            this.JsonSaveButton.Name = "JsonSaveButton";
            this.JsonSaveButton.Size = new System.Drawing.Size(75, 23);
            this.JsonSaveButton.TabIndex = 7;
            this.JsonSaveButton.Text = "Save";
            this.JsonSaveButton.UseVisualStyleBackColor = true;
            this.JsonSaveButton.Click += new System.EventHandler(this.JsonSaveButton_Click);
            // 
            // ListBoxSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 180);
            this.Controls.Add(this.JsonSaveButton);
            this.Controls.Add(this.EditCurrentButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListBoxSaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditCurrentButton;
        private System.Windows.Forms.Button JsonSaveButton;
    }
}