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
    public partial class CaNhan : Form
    {
        public CaNhan()
        {
            InitializeComponent();
            userNameTextBox.Text = DangNhap.userName;                  
        }

        MyControl myControl = new MyControl();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }       

        private void changeButton_Click(object sender, EventArgs e)
        {
            changePassPanel.Visible = true;
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked == true)
            {
                passWordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passWordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            String query = "SELECT passWord FROM Users WHERE UserName='" + DangNhap.userName.Trim() + "'";
            String oldPassWord;
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();
                SqlCommand commandCheck = new SqlCommand(query, connection);
                 oldPassWord= (String)commandCheck.ExecuteScalar();
                connection.Close();
            }
            if(oldPassWord.CompareTo(oldPassTextBox.Text.Trim())!=0){
                MessageBox.Show("Mật khẩu cũ chưa đúng");
                oldPassTextBox.Text = "";
            }else{
                if (newPassTextBox.Text.Trim().Length < 4)
                {
                    MessageBox.Show("Mật khẩu phải từ 4 ký tự trở lên");
                }
                else
                {
                    if (newPassTextBox.Text.Trim().CompareTo(corfimNewPassTextBox.Text.Trim()) == 0)
                    {
                        String query2 = "UPDATE Users SET passWord= '" + newPassTextBox.Text.Trim() + "' WHERE userName = '" + userNameTextBox.Text.Trim() + "'";
                        MessageBox.Show("" + myControl.ExecuteMyQuery(query2));
                        changePassPanel.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu chưa khớp");
                    }
                }
            }
        }

        private void newPassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (newPassTextBox.Text.Trim().Length == 0)
            {
                recommendNewPass.Text = "";
            }
            else if (newPassTextBox.Text.Trim().Length < 4)
            {
                recommendNewPass.Text = "Mật khẩu yếu";
                recommendNewPass.ForeColor = Color.Red;
            }
            else if (newPassTextBox.Text.Trim().Length < 8)
            {
                recommendNewPass.Text = "Mật khẩu trung bình";
                recommendNewPass.ForeColor = Color.Yellow;
            }
            else
            {
                recommendNewPass.Text = "Mật khẩu đủ mạnh";
                recommendNewPass.ForeColor = Color.Green;
            }
        }

        private void corfimNewPassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (corfimNewPassTextBox.Text.Trim().Length == 0)
            {
                recommendCorfimNewPass.Text = "";
            }
            else if (newPassTextBox.Text.Trim().CompareTo(corfimNewPassTextBox.Text.Trim()) != 0)
            {
                recommendCorfimNewPass.ForeColor = Color.Red;
                recommendCorfimNewPass.Text = "Mật khẩu chưa khớp";
            }
            else
            {
                recommendCorfimNewPass.ForeColor = Color.Green;
                recommendCorfimNewPass.Text = "Mật khẩu đã khớp";
            }
        }        
    }
}
