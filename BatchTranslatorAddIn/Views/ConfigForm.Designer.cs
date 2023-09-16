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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BaiduSecretTextBox = new System.Windows.Forms.TextBox();
            this.BaiduAppIDTextBox = new System.Windows.Forms.TextBox();
            this.CaiyunGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CaiyunTokenTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BaiduTestBotton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CaiyunTestBotton = new System.Windows.Forms.Button();
            this.BaiduQPSNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CaiyunQPSNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BaiduGroup.SuspendLayout();
            this.CaiyunGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaiduQPSNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaiyunQPSNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BaiduGroup
            // 
            this.BaiduGroup.Controls.Add(this.panel4);
            this.BaiduGroup.Controls.Add(this.panel2);
            this.BaiduGroup.Controls.Add(this.panel1);
            this.BaiduGroup.Location = new System.Drawing.Point(12, 12);
            this.BaiduGroup.Name = "BaiduGroup";
            this.BaiduGroup.Size = new System.Drawing.Size(398, 163);
            this.BaiduGroup.TabIndex = 0;
            this.BaiduGroup.TabStop = false;
            this.BaiduGroup.Text = "百度翻译";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secret：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "AppID：";
            // 
            // BaiduSecretTextBox
            // 
            this.BaiduSecretTextBox.Location = new System.Drawing.Point(83, 3);
            this.BaiduSecretTextBox.Name = "BaiduSecretTextBox";
            this.BaiduSecretTextBox.Size = new System.Drawing.Size(285, 28);
            this.BaiduSecretTextBox.TabIndex = 1;
            this.BaiduSecretTextBox.TextChanged += new System.EventHandler(this.BaiduSecretTextBox_TextChanged);
            // 
            // BaiduAppIDTextBox
            // 
            this.BaiduAppIDTextBox.Location = new System.Drawing.Point(83, 7);
            this.BaiduAppIDTextBox.Name = "BaiduAppIDTextBox";
            this.BaiduAppIDTextBox.Size = new System.Drawing.Size(300, 28);
            this.BaiduAppIDTextBox.TabIndex = 0;
            this.BaiduAppIDTextBox.TextChanged += new System.EventHandler(this.BaiduAppIDTextBox_TextChanged);
            // 
            // CaiyunGroup
            // 
            this.CaiyunGroup.Controls.Add(this.panel5);
            this.CaiyunGroup.Controls.Add(this.panel3);
            this.CaiyunGroup.Location = new System.Drawing.Point(12, 205);
            this.CaiyunGroup.Name = "CaiyunGroup";
            this.CaiyunGroup.Size = new System.Drawing.Size(392, 141);
            this.CaiyunGroup.TabIndex = 1;
            this.CaiyunGroup.TabStop = false;
            this.CaiyunGroup.Text = "彩云翻译";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Token：";
            // 
            // CaiyunTokenTextBox
            // 
            this.CaiyunTokenTextBox.Location = new System.Drawing.Point(83, 13);
            this.CaiyunTokenTextBox.Name = "CaiyunTokenTextBox";
            this.CaiyunTokenTextBox.Size = new System.Drawing.Size(285, 28);
            this.CaiyunTokenTextBox.TabIndex = 0;
            this.CaiyunTokenTextBox.TextChanged += new System.EventHandler(this.CaiyunTokenTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(153, 412);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 39);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BaiduAppIDTextBox);
            this.panel1.Location = new System.Drawing.Point(15, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 40);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BaiduSecretTextBox);
            this.panel2.Location = new System.Drawing.Point(15, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 33);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.CaiyunTokenTextBox);
            this.panel3.Location = new System.Drawing.Point(15, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 51);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.BaiduQPSNumericUpDown);
            this.panel4.Controls.Add(this.BaiduTestBotton);
            this.panel4.Location = new System.Drawing.Point(15, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(371, 45);
            this.panel4.TabIndex = 6;
            // 
            // BaiduTestBotton
            // 
            this.BaiduTestBotton.Location = new System.Drawing.Point(252, 3);
            this.BaiduTestBotton.Name = "BaiduTestBotton";
            this.BaiduTestBotton.Size = new System.Drawing.Size(116, 39);
            this.BaiduTestBotton.TabIndex = 3;
            this.BaiduTestBotton.Text = "测试";
            this.BaiduTestBotton.UseVisualStyleBackColor = true;
            this.BaiduTestBotton.Click += new System.EventHandler(this.BaiduTestBotton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.CaiyunQPSNumericUpDown);
            this.panel5.Controls.Add(this.CaiyunTestBotton);
            this.panel5.Location = new System.Drawing.Point(15, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 45);
            this.panel5.TabIndex = 7;
            // 
            // CaiyunTestBotton
            // 
            this.CaiyunTestBotton.Location = new System.Drawing.Point(252, 3);
            this.CaiyunTestBotton.Name = "CaiyunTestBotton";
            this.CaiyunTestBotton.Size = new System.Drawing.Size(116, 39);
            this.CaiyunTestBotton.TabIndex = 3;
            this.CaiyunTestBotton.Text = "测试";
            this.CaiyunTestBotton.UseVisualStyleBackColor = true;
            this.CaiyunTestBotton.Click += new System.EventHandler(this.CaiyunTestBotton_Click);
            // 
            // BaiduQPSNumericUpDown
            // 
            this.BaiduQPSNumericUpDown.Location = new System.Drawing.Point(71, 11);
            this.BaiduQPSNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduQPSNumericUpDown.Name = "BaiduQPSNumericUpDown";
            this.BaiduQPSNumericUpDown.Size = new System.Drawing.Size(84, 28);
            this.BaiduQPSNumericUpDown.TabIndex = 7;
            this.BaiduQPSNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BaiduQPSNumericUpDown.ValueChanged += new System.EventHandler(this.BaiduQPSNumericUpDown_ValueChanged);
            // 
            // CaiyunQPSNumericUpDown
            // 
            this.CaiyunQPSNumericUpDown.Location = new System.Drawing.Point(71, 11);
            this.CaiyunQPSNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.CaiyunQPSNumericUpDown.Name = "CaiyunQPSNumericUpDown";
            this.CaiyunQPSNumericUpDown.Size = new System.Drawing.Size(84, 28);
            this.CaiyunQPSNumericUpDown.TabIndex = 9;
            this.CaiyunQPSNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CaiyunQPSNumericUpDown.ValueChanged += new System.EventHandler(this.CaiyunQPSNumericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(11, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "QPS：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.Location = new System.Drawing.Point(11, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "QPS：";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 463);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CaiyunGroup);
            this.Controls.Add(this.BaiduGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.ShowIcon = false;
            this.Text = "设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.BaiduGroup.ResumeLayout(false);
            this.CaiyunGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BaiduQPSNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaiyunQPSNumericUpDown)).EndInit();
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