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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.BackgroundTranslator = new System.ComponentModel.BackgroundWorker();
            ButtonPanel = new System.Windows.Forms.Panel();
            ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(13, 13);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(683, 37);
            this.ProgressBar.TabIndex = 1;
            // 
            // LogBox
            // 
            this.LogBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogBox.DetectUrls = false;
            this.LogBox.HideSelection = false;
            this.LogBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LogBox.Location = new System.Drawing.Point(13, 73);
            this.LogBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LogBox.ShortcutsEnabled = false;
            this.LogBox.Size = new System.Drawing.Size(683, 234);
            this.LogBox.TabIndex = 2;
            this.LogBox.TabStop = false;
            this.LogBox.Text = "";
            // 
            // ButtonPanel
            // 
            ButtonPanel.Controls.Add(this.CancelButton);
            ButtonPanel.Controls.Add(this.CompleteButton);
            ButtonPanel.Location = new System.Drawing.Point(13, 315);
            ButtonPanel.Margin = new System.Windows.Forms.Padding(4);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new System.Drawing.Size(683, 56);
            ButtonPanel.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(571, 6);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(112, 46);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Enabled = false;
            this.CompleteButton.Location = new System.Drawing.Point(4, 6);
            this.CompleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(112, 46);
            this.CompleteButton.TabIndex = 0;
            this.CompleteButton.Text = "完成";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.CompleteButton_Click);
            // 
            // BackgroundTranslator
            // 
            this.BackgroundTranslator.WorkerReportsProgress = true;
            this.BackgroundTranslator.WorkerSupportsCancellation = true;
            this.BackgroundTranslator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundTranslator_DoWork);
            this.BackgroundTranslator.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundTranslator_ProgressChanged);
            this.BackgroundTranslator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundTranslator_RunWorkerCompleted);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 381);
            this.ControlBox = false;
            this.Controls.Add(ButtonPanel);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.ProgressBar);
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
        private System.ComponentModel.BackgroundWorker BackgroundTranslator;
    }
}