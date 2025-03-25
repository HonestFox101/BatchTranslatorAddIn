namespace BatchTranslatorAddIn.Views
{
    partial class ProgressForm
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
            System.Windows.Forms.Panel ButtonPanel;
            this.CancelButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            ButtonPanel = new System.Windows.Forms.Panel();
            ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(this.CancelButton);
            ButtonPanel.Controls.Add(this.CompleteButton);
            ButtonPanel.Location = new System.Drawing.Point(9, 210);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(455, 37);
            ButtonPanel.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(381, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 31);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Enabled = false;
            this.CompleteButton.Location = new System.Drawing.Point(3, 4);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(75, 31);
            this.CompleteButton.TabIndex = 0;
            this.CompleteButton.Text = "完成";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(9, 9);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(455, 25);
            this.ProgressBar.TabIndex = 1;
            // 
            // LogBox
            // 
            this.LogBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogBox.DetectUrls = false;
            this.LogBox.HideSelection = false;
            this.LogBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LogBox.Location = new System.Drawing.Point(9, 49);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LogBox.ShortcutsEnabled = false;
            this.LogBox.Size = new System.Drawing.Size(457, 157);
            this.LogBox.TabIndex = 2;
            this.LogBox.TabStop = false;
            this.LogBox.Text = "";
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 254);
            this.ControlBox = false;
            this.Controls.Add(ButtonPanel);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.ProgressBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressForm";
            this.ShowIcon = false;
            this.Text = "批量翻译";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CompleteButton;
    }
}