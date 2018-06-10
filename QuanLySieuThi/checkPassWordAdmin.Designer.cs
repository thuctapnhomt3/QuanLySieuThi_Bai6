namespace QuanLySieuThi
{
    partial class checkPassWordAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkPassWordAdmin));
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.corfimButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Location = new System.Drawing.Point(159, 24);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(236, 22);
            this.passWordTextBox.TabIndex = 0;
            this.passWordTextBox.UseSystemPasswordChar = true;
            this.passWordTextBox.Enter += new System.EventHandler(this.passWordTextBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xác nhận mật khẩu";
            // 
            // corfimButton
            // 
            this.corfimButton.Location = new System.Drawing.Point(159, 82);
            this.corfimButton.Name = "corfimButton";
            this.corfimButton.Size = new System.Drawing.Size(85, 37);
            this.corfimButton.TabIndex = 2;
            this.corfimButton.Text = "Xác nhận";
            this.corfimButton.UseVisualStyleBackColor = true;
            this.corfimButton.Click += new System.EventHandler(this.corfimButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(159, 53);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 3;
            // 
            // checkPassWordAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 132);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.corfimButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passWordTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "checkPassWordAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button corfimButton;
        private System.Windows.Forms.Label statusLabel;
    }
}