
namespace Appsettings_sample
{
    partial class TaskForm
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
            this.SeveralTaskButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AsyncLazyButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeveralTaskButton
            // 
            this.SeveralTaskButton.Location = new System.Drawing.Point(33, 27);
            this.SeveralTaskButton.Name = "SeveralTaskButton";
            this.SeveralTaskButton.Size = new System.Drawing.Size(155, 23);
            this.SeveralTaskButton.TabIndex = 0;
            this.SeveralTaskButton.Text = "Several Task";
            this.SeveralTaskButton.UseVisualStyleBackColor = true;
            this.SeveralTaskButton.Click += new System.EventHandler(this.SeveralTaskButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(29, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(158, 109);
            this.listBox1.TabIndex = 1;
            // 
            // AsyncLazyButton
            // 
            this.AsyncLazyButton.Location = new System.Drawing.Point(29, 191);
            this.AsyncLazyButton.Name = "AsyncLazyButton";
            this.AsyncLazyButton.Size = new System.Drawing.Size(158, 23);
            this.AsyncLazyButton.TabIndex = 2;
            this.AsyncLazyButton.Text = "AsyncLazy";
            this.AsyncLazyButton.UseVisualStyleBackColor = true;
            this.AsyncLazyButton.Click += new System.EventHandler(this.AsyncLazyButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(29, 244);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(159, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(29, 292);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(113, 292);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 342);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.AsyncLazyButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.SeveralTaskButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code samples async";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SeveralTaskButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AsyncLazyButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
    }
}