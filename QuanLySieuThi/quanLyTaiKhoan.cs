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
    public partial class quanLyTaiKhoan : Form
    {
        public quanLyTaiKhoan()
        {
            InitializeComponent();
            showData();
        }

        public static Boolean checkPass = false;

        private void showData()
        {
            string query = "SELECT userName,phanQuyen FROM Users";
            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
        }

        MyControl myControl = new MyControl();

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Length != 0)           
            {
                int quyen;
                if (adminRadioButton.Checked == true)
                {
                    quyen = 1;
                }
                else
                {
                    quyen = 2;
                }
                string query = @"UPDATE dbo.Users SET phanQuyen=" + quyen + " WHERE userName= '" + userNameTextBox.Text.Trim() + "'";
                new checkPassWordAdmin().ShowDialog();
                if (checkPass)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                }                                
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà tài khoản");
            }
        }

        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
                userNameTextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                if (dataGridView1.Rows[row].Cells[1].Value.ToString() == "1")
                {
                    adminRadioButton.Checked = true;
                }
                else
                {
                    staffRadioButton.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.StackTrace);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Length != 0)
            {
                string query = @"DELETE FROM dbo.Users Where userName = '" + userNameTextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new checkPassWordAdmin().ShowDialog();
                    if (checkPass)
                    {
                        MessageBox.Show("" + myControl.ExecuteMyQuery(query)); 
                    }                              
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cửa hàng");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = @"SELECT userName,phanQuyen FROM dbo.Users WHERE (userName LIKE'%" + searchTextBox.Text + "%')";

            using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                connection.Close();
            }
        }
    }
}
