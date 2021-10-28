
namespace CheckListBoxProducts
{
    partial class ProductsForm
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.SelectAllColumnsButton = new System.Windows.Forms.Button();
            this.ToggleStateCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(10, 217);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(174, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(10, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(174, 199);
            this.checkedListBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 202);
            this.dataGridView1.TabIndex = 2;
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Location = new System.Drawing.Point(190, 24);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(46, 23);
            this.MoveUpButton.TabIndex = 3;
            this.MoveUpButton.Text = "Up";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Location = new System.Drawing.Point(190, 53);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(46, 23);
            this.MoveDownButton.TabIndex = 4;
            this.MoveDownButton.Text = "Down";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // SelectAllColumnsButton
            // 
            this.SelectAllColumnsButton.Location = new System.Drawing.Point(10, 246);
            this.SelectAllColumnsButton.Name = "SelectAllColumnsButton";
            this.SelectAllColumnsButton.Size = new System.Drawing.Size(59, 23);
            this.SelectAllColumnsButton.TabIndex = 5;
            this.SelectAllColumnsButton.Text = "Toggle";
            this.SelectAllColumnsButton.UseVisualStyleBackColor = true;
            this.SelectAllColumnsButton.Click += new System.EventHandler(this.SelectAllColumnsButton_Click);
            // 
            // ToggleStateCheckBox
            // 
            this.ToggleStateCheckBox.AutoSize = true;
            this.ToggleStateCheckBox.Location = new System.Drawing.Point(75, 250);
            this.ToggleStateCheckBox.Name = "ToggleStateCheckBox";
            this.ToggleStateCheckBox.Size = new System.Drawing.Size(51, 17);
            this.ToggleStateCheckBox.TabIndex = 6;
            this.ToggleStateCheckBox.Text = "State";
            this.ToggleStateCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 333);
            this.Controls.Add(this.ToggleStateCheckBox);
            this.Controls.Add(this.SelectAllColumnsButton);
            this.Controls.Add(this.MoveDownButton);
            this.Controls.Add(this.MoveUpButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.LoadButton);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button SelectAllColumnsButton;
        private System.Windows.Forms.CheckBox ToggleStateCheckBox;
    }
}