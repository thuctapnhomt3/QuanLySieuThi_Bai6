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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public static int checkAceccpt = 0;
        public static string userName = "";
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }


        private void userText_TextChanged(object sender, EventArgs e)
        {

            if (userText.Text.Trim().Length != 0 && passText.Text.Trim().Length != 0)
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }

        private void passText_TextChanged(object sender, EventArgs e)
        {

            if (userText.Text.Trim().Length != 0 && passText.Text.Trim().Length != 0)
            {
                loginButton.Enabled = true;
            }
            else
            {
                loginButton.Enabled = false;
            }
        }

        //MyControl myControl = new MyControl();

        private Boolean checkAccess()
        {
            string query = "SELECT COUNT(*) FROM dbo.Users WHERE (userName = @ID AND passWord = @pass)";
            string queryCheck = "SELECT phanQuyen FROM dbo.Users WHERE (userName = @ID AND passWord = @pass)";
            string queryGetPass = "SELECT passWord FROM dbo.Users WHERE (userName = @ID AND passWord = @pass)";
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@ID", userText.Text.Trim()));
                command.Parameters.Add(new SqlParameter("@pass", passText.Text.Trim()));
                int check = (int)command.ExecuteScalar();
                if (check == 1)
                {
                    SqlCommand commandCheck = new SqlCommand(queryCheck, connection);
                    commandCheck.Parameters.Add(new SqlParameter("@ID", userText.Text.Trim()));
                    commandCheck.Parameters.Add(new SqlParameter("@pass", passText.Text.Trim()));
                    checkAceccpt = (int)commandCheck.ExecuteScalar();

                    SqlCommand commandGetPass = new SqlCommand(queryGetPass, connection);
                    commandGetPass.Parameters.Add(new SqlParameter("@ID", userText.Text.Trim()));
                    commandGetPass.Parameters.Add(new SqlParameter("@pass", passText.Text.Trim()));
                    string tempPass = commandGetPass.ExecuteScalar().ToString().Trim();
                    if (String.Compare(tempPass, passText.Text.Trim()) == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }

                    
                }                             
                return false;                
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (checkAccess())
            {
                userName = userText.Text.Trim();
                MessageBox.Show("Đăng nhập thành công !!");
                this.Close();
            }
            else
            {
                statusLabel.Text = "Tên đăng nhập hoặc mật khẩu sai !!";
                passText.Text = "";
                checkAceccpt = 0;
            }
        }

        private void checkHiddenPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHiddenPass.Checked)
            {
                passText.UseSystemPasswordChar = false;
            }
            else
            {
                passText.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void passText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                loginButton_Click(null, null);
            }
        }
    }
}
