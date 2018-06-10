namespace QuanLySieuThi
{
    partial class CaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaNhan));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.showPassCheckBox = new System.Windows.Forms.CheckBox();
            this.changePassPanel = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.corfimNewPassTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oldPassTextBox = new System.Windows.Forms.TextBox();
            this.recommendOldPass = new System.Windows.Forms.Label();
            this.recommendNewPass = new System.Windows.Forms.Label();
            this.recommendCorfimNewPass = new System.Windows.Forms.Label();
            this.changePassPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(201, 55);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(163, 22);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Location = new System.Drawing.Point(201, 92);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(163, 22);
            this.passWordTextBox.TabIndex = 1;
            this.passWordTextBox.Text = "00000000";
            this.passWordTextBox.UseSystemPasswordChar = true;
            this.passWordTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(389, 92);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(100, 46);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Đổi mật khẩu";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(198, 173);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // showPassCheckBox
            // 
            this.showPassCheckBox.AutoSize = true;
            this.showPassCheckBox.Location = new System.Drawing.Point(201, 131);
            this.showPassCheckBox.Name = "showPassCheckBox";
            this.showPassCheckBox.Size = new System.Drawing.Size(121, 21);
            this.showPassCheckBox.TabIndex = 4;
            this.showPassCheckBox.Text = "Hiện mật khẩu";
            this.showPassCheckBox.UseVisualStyleBackColor = true;
            this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showPassCheckBox_CheckedChanged);
            // 
            // changePassPanel
            // 
            this.changePassPanel.Controls.Add(this.button);
            this.changePassPanel.Controls.Add(this.label6);
            this.changePassPanel.Controls.Add(this.corfimNewPassTextBox);
            this.changePassPanel.Controls.Add(this.label5);
            this.changePassPanel.Controls.Add(this.newPassTextBox);
            this.changePassPanel.Controls.Add(this.label4);
            this.changePassPanel.Controls.Add(this.oldPassTextBox);
            this.changePassPanel.Controls.Add(this.recommendOldPass);
            this.changePassPanel.Controls.Add(this.recommendNewPass);
            this.changePassPanel.Controls.Add(this.recommendCorfimNewPass);
            this.changePassPanel.Location = new System.Drawing.Point(55, 158);
            this.changePassPanel.Name = "changePassPanel";
            this.changePassPanel.Size = new System.Drawing.Size(479, 135);
            this.changePassPanel.TabIndex = 5;
            this.changePassPanel.Visible = false;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(165, 93);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(87, 39);
            this.button.TabIndex = 2;
            this.button.Text = "Xác nhận";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Xác nhận mật khẩu mới";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // corfimNewPassTextBox
            // 
            this.corfimNewPassTextBox.Location = new System.Drawing.Point(165, 65);
            this.corfimNewPassTextBox.Name = "corfimNewPassTextBox";
            this.corfimNewPassTextBox.Size = new System.Drawing.Size(145, 22);
            this.corfimNewPassTextBox.TabIndex = 1;
            this.corfimNewPassTextBox.UseSystemPasswordChar = true;
            this.corfimNewPassTextBox.TextChanged += new System.EventHandler(this.corfimNewPassTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu mới";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(165, 36);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(145, 22);
            this.newPassTextBox.TabIndex = 1;
            this.newPassTextBox.UseSystemPasswordChar = true;
            this.newPassTextBox.TextChanged += new System.EventHandler(this.newPassTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu cũ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.Location = new System.Drawing.Point(165, 8);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.Size = new System.Drawing.Size(145, 22);
            this.oldPassTextBox.TabIndex = 1;
            this.oldPassTextBox.UseSystemPasswordChar = true;
            this.oldPassTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // recommendOldPass
            // 
            this.recommendOldPass.AutoSize = true;
            this.recommendOldPass.Location = new System.Drawing.Point(316, 15);
            this.recommendOldPass.Name = "recommendOldPass";
            this.recommendOldPass.Size = new System.Drawing.Size(0, 17);
            this.recommendOldPass.TabIndex = 0;
            this.recommendOldPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // recommendNewPass
            // 
            this.recommendNewPass.AutoSize = true;
            this.recommendNewPass.Location = new System.Drawing.Point(316, 43);
            this.recommendNewPass.Name = "recommendNewPass";
            this.recommendNewPass.Size = new System.Drawing.Size(0, 17);
            this.recommendNewPass.TabIndex = 0;
            this.recommendNewPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // recommendCorfimNewPass
            // 
            this.recommendCorfimNewPass.AutoSize = true;
            this.recommendCorfimNewPass.Location = new System.Drawing.Point(318, 72);
            this.recommendCorfimNewPass.Name = "recommendCorfimNewPass";
            this.recommendCorfimNewPass.Size = new System.Drawing.Size(0, 17);
            this.recommendCorfimNewPass.TabIndex = 0;
            this.recommendCorfimNewPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // CaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 336);
            this.Controls.Add(this.changePassPanel);
            this.Controls.Add(this.showPassCheckBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaNhan";
            this.Text = "Personal";
            this.changePassPanel.ResumeLayout(false);
            this.changePassPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox showPassCheckBox;
        private System.Windows.Forms.Panel changePassPanel;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox corfimNewPassTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oldPassTextBox;
        private System.Windows.Forms.Label recommendOldPass;
        private System.Windows.Forms.Label recommendNewPass;
        private System.Windows.Forms.Label recommendCorfimNewPass;
    }
}