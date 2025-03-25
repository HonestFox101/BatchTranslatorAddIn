namespace BatchTranslatorAddIn.Views
{
    partial class ConfigForm
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
            this.BaiduGroup = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BaiduQPSNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BaiduTestBotton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BaiduSecretTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BaiduAppIDTextBox = new System.Windows.Forms.TextBox();
            this.CaiyunGroup = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CaiyunQPSNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CaiyunTestBotton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CaiyunTokenTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BaiduGroup.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaiduQPSNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CaiyunGroup.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaiyunQPSNumericUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaiduGroup
            // 
            this.BaiduGroup.Controls.Add(this.panel4);
            this.BaiduGroup.Controls.Add(this.panel2);
            this.BaiduGroup.Controls.Add(this.panel1);
            this.BaiduGroup.Location = new System.Drawing.Point(8, 8);
            this.BaiduGroup.Margin = new System.Windows.Forms.Padding(2);
            this.BaiduGroup.Name = "BaiduGroup";
            this.BaiduGroup.Padding = new System.Windows.Forms.Padding(2);
            this.BaiduGroup.Size = new System.Drawing.Size(265, 109);
            this.BaiduGroup.TabIndex = 0;
            this.BaiduGroup.TabStop = false;
            this.BaiduGroup.Text = "百度翻译";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.BaiduQPSNumericUpDown);
            this.panel4.Controls.Add(this.BaiduTestBotton);
            this.panel4.Location = new System.Drawing.Point(10, 75);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 30);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "QPS：";
            // 
            // BaiduQPSNumericUpDown
            // 
            this.BaiduQPSNumericUpDown.Location = new System.Drawing.Point(47, 7);
            this.BaiduQPSNumericUpDown.Name = "BaiduQPSNumericUpDown";
            this.BaiduQPSNumericUpDown.Size = new System.Drawing.Size(56, 21);
            this.BaiduQPSNumericUpDown.TabIndex = 7;
            this.BaiduQPSNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BaiduQPSNumericUpDown.ValueChanged += new System.EventHandler(this.BaiduQPSNumericUpDown_ValueChanged);
            // 
            // BaiduTestBotton
            // 
            this.BaiduTestBotton.Location = new System.Drawing.Point(168, 2);
            this.BaiduTestBotton.Margin = new System.Windows.Forms.Padding(2);
            this.BaiduTestBotton.Name = "BaiduTestBotton";
            this.BaiduTestBotton.Size = new System.Drawing.Size(77, 26);
            this.BaiduTestBotton.TabIndex = 3;
            this.BaiduTestBotton.Text = "测试";
            this.BaiduTestBotton.UseVisualStyleBackColor = true;
            this.BaiduTestBotton.Click += new System.EventHandler(this.BaiduTestBotton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BaiduSecretTextBox);
            this.panel2.Location = new System.Drawing.Point(10, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 22);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secret：";
            // 
            // BaiduSecretTextBox
            // 
            this.BaiduSecretTextBox.Location = new System.Drawing.Point(55, -1);
            this.BaiduSecretTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BaiduSecretTextBox.Name = "BaiduSecretTextBox";
            this.BaiduSecretTextBox.Size = new System.Drawing.Size(190, 21);
            this.BaiduSecretTextBox.TabIndex = 1;
            this.BaiduSecretTextBox.TextChanged += new System.EventHandler(this.BaiduSecretTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BaiduAppIDTextBox);
            this.panel1.Location = new System.Drawing.Point(10, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 27);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "AppID：";
            // 
            // BaiduAppIDTextBox
            // 
            this.BaiduAppIDTextBox.Location = new System.Drawing.Point(55, 2);
            this.BaiduAppIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BaiduAppIDTextBox.Name = "BaiduAppIDTextBox";
            this.BaiduAppIDTextBox.Size = new System.Drawing.Size(190, 21);
            this.BaiduAppIDTextBox.TabIndex = 0;
            this.BaiduAppIDTextBox.TextChanged += new System.EventHandler(this.BaiduAppIDTextBox_TextChanged);
            // 
            // CaiyunGroup
            // 
            this.CaiyunGroup.Controls.Add(this.panel5);
            this.CaiyunGroup.Controls.Add(this.panel3);
            this.CaiyunGroup.Location = new System.Drawing.Point(8, 137);
            this.CaiyunGroup.Margin = new System.Windows.Forms.Padding(2);
            this.CaiyunGroup.Name = "CaiyunGroup";
            this.CaiyunGroup.Padding = new System.Windows.Forms.Padding(2);
            this.CaiyunGroup.Size = new System.Drawing.Size(261, 94);
            this.CaiyunGroup.TabIndex = 1;
            this.CaiyunGroup.TabStop = false;
            this.CaiyunGroup.Text = "彩云翻译";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.CaiyunQPSNumericUpDown);
            this.panel5.Controls.Add(this.CaiyunTestBotton);
            this.panel5.Location = new System.Drawing.Point(10, 56);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 34);
            this.panel5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "QPS：";
            // 
            // CaiyunQPSNumericUpDown
            // 
            this.CaiyunQPSNumericUpDown.Location = new System.Drawing.Point(47, 7);
            this.CaiyunQPSNumericUpDown.Name = "CaiyunQPSNumericUpDown";
            this.CaiyunQPSNumericUpDown.Size = new System.Drawing.Size(56, 21);
            this.CaiyunQPSNumericUpDown.TabIndex = 9;
            this.CaiyunQPSNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CaiyunQPSNumericUpDown.ValueChanged += new System.EventHandler(this.CaiyunQPSNumericUpDown_ValueChanged);
            // 
            // CaiyunTestBotton
            // 
            this.CaiyunTestBotton.Location = new System.Drawing.Point(168, 2);
            this.CaiyunTestBotton.Margin = new System.Windows.Forms.Padding(2);
            this.CaiyunTestBotton.Name = "CaiyunTestBotton";
            this.CaiyunTestBotton.Size = new System.Drawing.Size(77, 26);
            this.CaiyunTestBotton.TabIndex = 3;
            this.CaiyunTestBotton.Text = "测试";
            this.CaiyunTestBotton.UseVisualStyleBackColor = true;
            this.CaiyunTestBotton.Click += new System.EventHandler(this.CaiyunTestBotton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.CaiyunTokenTextBox);
            this.panel3.Location = new System.Drawing.Point(10, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 34);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Token：";
            // 
            // CaiyunTokenTextBox
            // 
            this.CaiyunTokenTextBox.Location = new System.Drawing.Point(47, 6);
            this.CaiyunTokenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CaiyunTokenTextBox.Name = "CaiyunTokenTextBox";
            this.CaiyunTokenTextBox.Size = new System.Drawing.Size(191, 21);
            this.CaiyunTokenTextBox.TabIndex = 0;
            this.CaiyunTokenTextBox.TextChanged += new System.EventHandler(this.CaiyunTokenTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(102, 275);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 26);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 309);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CaiyunGroup);
            this.Controls.Add(this.BaiduGroup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.Text = "设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.BaiduGroup.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaiduQPSNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CaiyunGroup.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaiyunQPSNumericUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BaiduGroup;
        private System.Windows.Forms.TextBox BaiduSecretTextBox;
        private System.Windows.Forms.TextBox BaiduAppIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CaiyunGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CaiyunTokenTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BaiduTestBotton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button CaiyunTestBotton;
        private System.Windows.Forms.NumericUpDown BaiduQPSNumericUpDown;
        private System.Windows.Forms.NumericUpDown CaiyunQPSNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}