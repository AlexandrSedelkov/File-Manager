
namespace File_Manager
{
    partial class PasteForm
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
            this.overwriteButton = new System.Windows.Forms.Button();
            this.overwriteAllButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.skipAllButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // overwriteButton
            // 
            this.overwriteButton.Location = new System.Drawing.Point(12, 161);
            this.overwriteButton.Name = "overwriteButton";
            this.overwriteButton.Size = new System.Drawing.Size(84, 32);
            this.overwriteButton.TabIndex = 0;
            this.overwriteButton.Text = "Overwrite";
            this.overwriteButton.UseVisualStyleBackColor = true;
            this.overwriteButton.Click += new System.EventHandler(this.OverwriteButton_Click);
            // 
            // overwriteAllButton
            // 
            this.overwriteAllButton.Location = new System.Drawing.Point(102, 161);
            this.overwriteAllButton.Name = "overwriteAllButton";
            this.overwriteAllButton.Size = new System.Drawing.Size(100, 32);
            this.overwriteAllButton.TabIndex = 1;
            this.overwriteAllButton.Text = "Overwrite All";
            this.overwriteAllButton.UseVisualStyleBackColor = true;
            this.overwriteAllButton.Click += new System.EventHandler(this.OverwriteAllButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(208, 161);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(82, 32);
            this.skipButton.TabIndex = 2;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // skipAllButton
            // 
            this.skipAllButton.Location = new System.Drawing.Point(296, 161);
            this.skipAllButton.Name = "skipAllButton";
            this.skipAllButton.Size = new System.Drawing.Size(84, 32);
            this.skipAllButton.TabIndex = 3;
            this.skipAllButton.Text = "Skip All";
            this.skipAllButton.UseVisualStyleBackColor = true;
            this.skipAllButton.Click += new System.EventHandler(this.SkipAllButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(386, 161);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 32);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "This file is already exist";
            // 
            // PasteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 237);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.skipAllButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.overwriteAllButton);
            this.Controls.Add(this.overwriteButton);
            this.Name = "PasteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CopyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button overwriteButton;
        private System.Windows.Forms.Button overwriteAllButton;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button skipAllButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
    }
}