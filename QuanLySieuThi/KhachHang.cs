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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
            setDefault(DangNhap.checkAceccpt);
            setAutoData();
            showData();
        }       

        public void setDefault(int checkAccept)
        {
            if (checkAccept == 0)
            {
                addButton.Enabled = false;
                changeButton.Enabled = false;
                deleteButton.Enabled = false;              
            }
            else
            {
                if (checkAccept == 1 || checkAccept == 2)
                {
                    addButton.Enabled = true;
                    changeButton.Enabled = true;
                    deleteButton.Enabled = true;
                }              
            }

            if (HoaDon.select_KH == "Null")
            {
                this.Height = 420;
                selectButton.Visible = true;
            }
            else
            {
                this.Height = 370;
                selectButton.Visible = false;
            }
        }

        private DataTable getData(String query)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.StackTrace);
            }
            return data;
        }

        private void setAutoData(){
            string query = @"SELECT * FROM KhachHang";
            AutoCompleteStringCollection autoData =new AutoCompleteStringCollection();
            DataTable data = getData(query);
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    autoData.Add(data.Rows[i]["makh"].ToString().Trim());
                }
            }
            maKHTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            maKHTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            maKHTextBox.AutoCompleteCustomSource = autoData;

            AutoCompleteStringCollection autoDataSDT = new AutoCompleteStringCollection();
            DataTable dataSDT = getData(query);
            if (dataSDT.Rows.Count > 0)
            {
                for (int i = 0; i < dataSDT.Rows.Count; i++)
                {
                    autoData.Add(dataSDT.Rows[i]["sdt"].ToString().Trim());
                }
            }
            sdtTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            sdtTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            sdtTextBox.AutoCompleteCustomSource = autoData; 
        }

        private void showData()
        {
            string query = @"SELECT * FROM KhachHang";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        MyControl myControl=new MyControl();

        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
                maKHTextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
                tenKHTextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
                sdtTextBox.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();
                diaChiTextBox.Text = dataGridView1.Rows[row].Cells[3].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.StackTrace);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (maKHTextBox.Text.Trim().Length != 0 || maKHTextBox.Text.Trim().Equals("KHxxx"))
            {
                string query = @"INSERT dbo.KHachHang( makh ,tenkh, sdt, diachi)
                                VALUES  ( '" + maKHTextBox.Text.Trim() + "',N'" + tenKHTextBox.Text.Trim() + "','" 
                                             + sdtTextBox.Text.Trim() + "',N'" + diaChiTextBox.Text.Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
            }
            else
            {
                MessageBox.Show("Không được để trống mã khách hàng ");
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (maKHTextBox.Text.Trim().Length != 0 || maKHTextBox.Text.Trim().Equals("KHxxx"))
            {
                string query = @"UPDATE dbo.KhachHang SET tenkh=N'" + tenKHTextBox.Text.Trim() + "', sdt='" 
                    + sdtTextBox.Text.Trim() + "', diachi=N'" + diaChiTextBox.Text.Trim() + "' WHERE makh= '" 
                    + maKHTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));                 
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng");
            }
        }


        // xoa khach hang


        public void DeleteTtBymahd(string mahd)
        {
            string query = @"DELETE dbo.ThanhToan WHERE mahd = '" + mahd + "'";
            myControl.ExecuteMyQuery(query);

        }

        public void DeleteKhBymakh(string makh)
        {
            //DeleteHDBymakh(makh);
            string query = @"DELETE dbo.KhachHang WHERE makh = '" + makh + "'";
            myControl.ExecuteMyQuery(query);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string makh = maKHTextBox.Text.Trim();
            if (maKHTextBox.Text.Trim().Length != 0 || maKHTextBox.Text.Trim().Equals("KHxxx"))
            {
                string query = @"DELETE FROM dbo.KhachHang Where makh='" + maKHTextBox.Text.Trim() + "'";
                if (MessageBox.Show("Thông tin hóa đơn sẽ bị ảnh hường, Bạn chắc chắn muốn xóa ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                    showData();
                }
                // MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quầy hàng");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.KhachHang WHERE (makh LIKE'%" + searchTextBox.Text.Trim() 
                + "%') OR (tenkh LIKE N'%" + searchTextBox.Text.Trim() + "%') OR (sdt LIKE '%" + searchTextBox.Text.Trim() 
                + "%') OR (diachi LIKE N'%" + searchTextBox.Text.Trim() + "%')";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void sdtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                button1_Click(null, null);
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            HoaDon.select_KH = maKHTextBox.Text.Trim();
            HoaDon.tenKH = tenKHTextBox.Text.Trim();
            this.Close();
        }

        private void maKHTextBox_Enter(object sender, EventArgs e)
        {
            if (maKHTextBox.Text == "KHxxx")
            {
                maKHTextBox.Text = "";
                maKHTextBox.ForeColor = Color.Black;
            }
        }

        private void maKHTextBox_Leave(object sender, EventArgs e)
        {
            if (maKHTextBox.Text == "")
            {
                maKHTextBox.Text = "KHxxx";
                maKHTextBox.ForeColor = Color.Gray;
            }
        }

        private void maKHTextBox_TextChanged(object sender, EventArgs e)
        {
            //maKHTextBox.ForeColor = Color.Black;
            //if (maKHTextBox.TextLength == 0 || maKHTextBox.Text=="KHxxx")
            //{
            //    inforButton.Enabled = false;
            //}
            //else
            //{
            //    inforButton.Enabled = true;
            //}
        }

        public static String maKH = null;
        private void inforButton_Click(object sender, EventArgs e)
        {
            //maKH = maKHTextBox.Text.Trim();
            //new ThongTinMuaHang().ShowDialog();
        }
    }
}
