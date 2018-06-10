namespace QuanLySieuThi
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.checkHiddenPass = new System.Windows.Forms.CheckBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(243, 51);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(105, 17);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "Tên đăng nhập";
            this.userLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(243, 103);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(66, 17);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Mật khẩu";
            this.passLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(354, 51);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(154, 22);
            this.userText.TabIndex = 2;
            this.userText.Text = "admin";
            this.userText.TextChanged += new System.EventHandler(this.userText_TextChanged);
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(354, 98);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(154, 22);
            this.passText.TabIndex = 3;
            this.passText.UseSystemPasswordChar = true;
            this.passText.TextChanged += new System.EventHandler(this.passText_TextChanged);
            this.passText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passText_KeyPress);
            // 
            // loginButton
            // 
            this.loginButton.Enabled = false;
            this.loginButton.Location = new System.Drawing.Point(254, 178);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(94, 34);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(414, 178);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(94, 33);
            this.signupButton.TabIndex = 8;
            this.signupButton.Text = "Đăng ký";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // checkHiddenPass
            // 
            this.checkHiddenPass.AutoSize = true;
            this.checkHiddenPass.Location = new System.Drawing.Point(354, 139);
            this.checkHiddenPass.Name = "checkHiddenPass";
            this.checkHiddenPass.Size = new System.Drawing.Size(121, 21);
            this.checkHiddenPass.TabIndex = 9;
            this.checkHiddenPass.Text = "Hiện mật khẩu";
            this.checkHiddenPass.UseVisualStyleBackColor = true;
            this.checkHiddenPass.CheckedChanged += new System.EventHandler(this.checkHiddenPass_CheckedChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(251, 240);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLySieuThi.Properties.Resources.Le_Quy_Don_Technical_University_logo;
            this.pictureBox1.Location = new System.Drawing.Point(52, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(554, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.checkHiddenPass);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.CheckBox checkHiddenPass;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}