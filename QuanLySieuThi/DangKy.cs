using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        MyControl myControl = new MyControl();

        private void saveButton_Click(object sender, EventArgs e)
        {
            int count;
            String query = "SELECT COUNT(*) FROM Users WHERE userName ='" + userNameRecomend.Text.Trim() + "'";
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();
                SqlCommand commandCheck = new SqlCommand(query, connection);
                count=commandCheck.ExecuteNonQuery();
                connection.Close();
            }
            if (count > 0)
            {
                userNameRecomend.Text = "Tên tài khoản đã tồn tại";
            }
            else
            {
                userNameRecomend.Text= "";
                int phanQuyen=0;                
                if (passWordTextBox.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Mật khẩu phải từ 4 ký tự trở lên");
                }
                else
                {
                    if (passWordTextBox.Text.Trim().CompareTo(checkPassTextBox.Text.Trim()) == 0)
                    {
                        String query2 = "INSERT Users (userName,passWord,phanQuyen) VALUES ('" + userNameTextBox.Text.Trim() + "','" + passWordTextBox.Text.Trim() + "'," + phanQuyen + ")";
                        MessageBox.Show("" + myControl.ExecuteMyQuery(query2));  
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu chưa khớp");
                    }
                }
                
            }
        }

        private void checkPassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (checkPassTextBox.Text.Trim().Length == 0)
            {
                checkPassRecomend.Text = "";
            }
            else if (passWordTextBox.Text.Trim().CompareTo(checkPassTextBox.Text.Trim()) != 0)
            {
                checkPassRecomend.ForeColor = Color.Red;
                checkPassRecomend.Text = "Mật khẩu chưa khớp";
            }
            else
            {
                checkPassRecomend.ForeColor = Color.Green;
                checkPassRecomend.Text = "Mật khẩu đã khớp";
            }
        }

        private void passWordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passWordTextBox.Text.Trim().Length == 0)
            {
                passWordRecomend.Text = "";
            }
            else if (passWordTextBox.Text.Trim().Length < 4)
            {
                passWordRecomend.Text = "Mật khẩu yếu";
                passWordRecomend.ForeColor = Color.Red;
            }
            else if (passWordTextBox.Text.Trim().Length < 8)
            {
                passWordRecomend.Text = "Mật khẩu trung bình";
                passWordRecomend.ForeColor = Color.Yellow;
            }
            else 
            {
                passWordRecomend.Text = "Mật khẩu đủ mạnh";
                passWordRecomend.ForeColor = Color.Green;
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
