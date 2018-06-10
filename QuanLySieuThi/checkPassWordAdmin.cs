using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class checkPassWordAdmin : Form
    {
        public checkPassWordAdmin()
        {
            InitializeComponent();
        }

        private void corfimButton_Click(object sender, EventArgs e)
        {
            String query = @"Select passWord From Users Where userName = '" + DangNhap.userName.Trim()+"'";
            if(passWordTextBox.Text== new MyControl().ExecuteMyQueryScalar(query)){
                quanLyTaiKhoan.checkPass = true;
                this.Close();
            }
            else
            {
                passWordTextBox.Text = "";
                statusLabel.Text = "Mật khẩu không đúng";
            }
        }

        private void passWordTextBox_Enter(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }
    }
}
