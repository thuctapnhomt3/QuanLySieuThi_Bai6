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
    public partial class QuayHang : Form
    {
        public QuayHang()
        {
            InitializeComponent();
            setDefault();
            setAutoData();
            showData();
            showData2();
            setData();
        }

        private void setDefault()
        {
            if (DangNhap.checkAceccpt == 0)
            {
                addButton1.Enabled = false;
                changeButton1.Enabled = false;
                deleteButton1.Enabled = false;

                addButton2.Enabled = false;
                changeButton2.Enabled = false;
                deleteButton2.Enabled = false;
            }
            else
            {
                if (DangNhap.checkAceccpt == 2)
                {
                    addButton1.Enabled = false;
                    changeButton1.Enabled = false;
                    deleteButton1.Enabled = false;

                    addButton2.Enabled = true;
                    changeButton2.Enabled = true;
                    deleteButton2.Enabled = true;
                }
                else
                {
                    if (DangNhap.checkAceccpt == 1)
                    {
                        addButton1.Enabled = true;
                        changeButton1.Enabled = true;
                        deleteButton1.Enabled = true;

                        addButton2.Enabled = true;
                        changeButton2.Enabled = true;
                        deleteButton2.Enabled = true;
                    }
                }
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            
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

        private void setAutoData()
        {
            string queryQH = @"SELECT * FROM QuayHang";
            AutoCompleteStringCollection autoDataQH = new AutoCompleteStringCollection();
            DataTable dataQH = getData(queryQH);
            if (dataQH.Rows.Count > 0)
            {
                for (int i = 0; i < dataQH.Rows.Count; i++)
                {
                    autoDataQH.Add(dataQH.Rows[i]["maquay"].ToString().Trim());
                }
            }
            maQHTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            maQHTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            maQHTextBox.AutoCompleteCustomSource = autoDataQH;

            string query = @"SELECT * FROM MatHang";
            AutoCompleteStringCollection autoData = new AutoCompleteStringCollection();
            DataTable data = getData(query);
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    autoData.Add(data.Rows[i]["mamh"].ToString().Trim());
                }
            }
            maSPTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            maSPTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            maSPTextBox.AutoCompleteCustomSource = autoData;
        }

        private void setData()
        {
            String query = "SELECT * FROM dbo.Quayhang";
            quayHangComboBox.DisplayMember = "tenquay";
            quayHangComboBox.ValueMember = "maquay";
            quayHangComboBox.DataSource = getData(query);

            String queryMH = "SELECT * FROM dbo.MatHang";
            matHangComboBox.DisplayMember = "tenhang";
            matHangComboBox.ValueMember = "mamh";
            matHangComboBox.DataSource = getData(queryMH);
        }

        private void showData()
        {
            string query = "SELECT * FROM QuayHang";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
       
        private void showData2()
        {
            string query = "SELECT * FROM MatHang";
            dataGridView2.DataSource = getData(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void showMHData()
        {
            string query = "SELECT *FROM dbo.MatHang WHERE maquay='" + maQHTextBox.Text.Trim() + "'";
            dataGridView2.DataSource = getData(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        MyControl myControl = new MyControl();

        private void maNVLabel_Click(object sender, EventArgs e)
        {

        }

        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
                maQHTextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
                tenQHTextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();

                showMHData();
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.StackTrace);
            }
        }

        int row2;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row2 = e.RowIndex;
                maSPTextBox.Text = dataGridView2.Rows[row2].Cells[0].Value.ToString().Trim();
                tenSPTextBox.Text = dataGridView2.Rows[row2].Cells[1].Value.ToString().Trim();
                giaTextBox.Text = dataGridView2.Rows[row2].Cells[2].Value.ToString().Trim();

                quayHangComboBox.SelectedValue = dataGridView2.Rows[row2].Cells[3].Value;

                doanhSoTextBox.Text = dataGridView2.Rows[row2].Cells[4].Value.ToString().Trim();
                ttinTextBox.Text = dataGridView2.Rows[row2].Cells[5].Value.ToString().Trim();
                giamGiaNumericUpDown.Value = (int)dataGridView2.Rows[row2].Cells[6].Value;
                trangThaiTextBox.Text = dataGridView2.Rows[row2].Cells[7].Value.ToString().Trim();
                nsxTextBox.Text = dataGridView2.Rows[row2].Cells[8].Value.ToString().Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.StackTrace);
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            if (maQHTextBox.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.QuayHang( maquay ,tenquay)
                                VALUES  ( '" + maQHTextBox.Text.Trim() + "' ,N'" + tenQHTextBox.Text.Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
                setData();
            }
            else
            {
                MessageBox.Show("Không được để trống mã quầy");
            }
        }

        private void changeButton1_Click(object sender, EventArgs e)
        {
            if (maQHTextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.QuayHang SET tenquay=N'" + tenQHTextBox.Text.Trim() + "' WHERE maquay= '" + maQHTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
                showData();
                setData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quầy quầy");
            }
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM dbo.QuayHang Where maquay='" + maQHTextBox.Text.Trim() + "'";
            String query2 = @"UPDATE dbo.MatHang SET maquay=NULL, ghichu=N'Không kinh doanh', trangthai=0 WHERE maquay='"
                                + maQHTextBox.Text.Trim() + "'";
            if (maQHTextBox.Text.Trim().Length != 0)
            {
                
                if (MessageBox.Show("Các mặt hàng trong quầy sẽ bị xóa\nBạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    myControl.ExecuteMyQuery(query2);
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query)); 
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quầy hàng");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.QuayHang WHERE (maquay LIKE'%" + searchTextBox.Text.Trim() + "%') OR (tenquay LIKE '%" 
                + searchTextBox.Text.Trim() + "%')";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void addButton2_Click(object sender, EventArgs e)
        {
            if (maSPTextBox.Text.Trim().Length != 0 || maSPTextBox.Text.Trim().Equals("MHxxx"))
            {
                string query = @"INSERT dbo.MatHang( mamh ,tenhang, dongia, maquay, doanhso, ghichu, giamgia, trangthai, hangsx)
                                VALUES  ( '" + maSPTextBox.Text.Trim() + "', N'" + tenSPTextBox.Text.Trim() + "', " + giaTextBox.Text.Trim() 
                                             + ", '" + maQHTextBox2.Text.Trim() + "', 0, N'" + ttinTextBox.Text.Trim() + "', " 
                                             + giamGiaNumericUpDown.Value.ToString().Trim() + ", 0, N'" + nsxTextBox.Text.Trim() + "')";
                MessageBox.Show("" + query);
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                showMHData();


                /*using (SqlConnection connection = new SqlConnection(ConnectSQL.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("them_mathang", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@mamh", maSPTextBox.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@tenhang", tenSPTextBox.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@dongia", giaTextBox.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@maquay", maQHTextBox2.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@ghichu", ttinTextBox.Text.Trim()));
                    command.Parameters.Add(new SqlParameter("@giamgia", giamGiaNumericUpDown.Value.ToString().Trim()));
                    command.Parameters.Add(new SqlParameter("@hangsx", nsxTextBox.Text.Trim()));
                    command.ExecuteNonQuery();
                      
                }*/
            }
            else
            {
                MessageBox.Show("Không được để trống mã sản phẩm");
            }
        }

        private void changeButton2_Click(object sender, EventArgs e)
        {
            if (maSPTextBox.Text.Trim().Length != 0 || maSPTextBox.Text.Trim().Equals("MHxxx"))
            {
                string query = @"UPDATE dbo.MatHang SET tenhang=N'" + tenSPTextBox.Text.Trim() + "',dongia=" + giaTextBox.Text.Trim() + ",maquay='" + maQHTextBox2.Text.Trim() 
                                + ",ghichu=N'" + ttinTextBox.Text.Trim() + "',giamgia=" + giamGiaNumericUpDown.Value.ToString().Trim()  + ",hangsx=N'" + nsxTextBox.Text.Trim()
                                + "' WHERE mamh= '" + maSPTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                showMHData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }



        // Xoa mat hang
        public void DeleteSpnBymamh(string mamh)
        {
            string query = @"DELETE dbo.SpNhap WHERE mamh ='" + mamh + "'";
            myControl.ExecuteMyQuery(query);
        }

        public void DeleteSpxBymamh(string mamh)
        {
            string query = @"DELETE dbo.SpXuat WHERE mamh ='" + mamh + "'";
            myControl.ExecuteMyQuery(query);
        }

        public void DeleteTtBymamh(string mamh)
        {
            string query = @"DELETE dbo.ThanhToan WHERE mamh ='" + mamh + "'";
            myControl.ExecuteMyQuery(query);
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            String query = @"UPDATE dbo.MatHang SET maquay=NULL, ghichu=N'Không kinh doanh', trangthai=0 WHERE mamh='"
                                + maSPTextBox.Text.Trim() + "'";
            if (maSPTextBox.Text.Trim().Length != 0 || maSPTextBox.Text.Trim().Equals("MHxxx"))
            {
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                showMHData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Mã hàng":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE mamh LIKE'%" + searchTextBox2.Text.Trim() + "%'";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Tên hàng":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE tenhang LIKE N'%" + searchTextBox2.Text.Trim()+ "%'";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Giá":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE dongia BETWEEN " + searchGiaTextBox1.Text.Trim() + " AND " + searchGiaTextBox2.Text.Trim();
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Giảm giá (Đang giảm giá)":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE giamgia > 0";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }

                case "Giảm giá (Không giảm giá)":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE giamgia = 0";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Trạng thái (Còn hàng)":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE trangthai > 0";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Trạng thái (Hết hàng)":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE trangthai <= 0";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Hãng sản xuất":
                    {
                        string query = @"SELECT * FROM dbo.MatHang WHERE hangsx LIKE N'%" + searchTextBox2.Text.Trim() + "%'";
                        dataGridView2.DataSource = getData(query);
                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
            }
            
        }

        private void searchGiaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8 && (int)e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void searchGiaTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8 && (int)e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void searchModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Mã hàng":
                    {
                        searchTextBox2.Visible = true;
                        searchGiaPanel.Visible = false;
                        break;
                    }
                case "Tên hàng":
                    {
                        searchTextBox2.Visible = true;
                        searchGiaPanel.Visible = false;
                        break;
                    }
                case "Giá":
                    {
                        searchTextBox2.Visible = false;
                        searchGiaPanel.Visible = true;
                        break;
                    }
                case "Giảm giá (Đang giảm giá)":
                    {
                        searchTextBox2.Visible = false;
                        searchGiaPanel.Visible = false;
                        break;
                    }

                case "Giảm giá (Không giảm giá)":
                    {
                        searchTextBox2.Visible = false;
                        searchGiaPanel.Visible = false;
                        break;
                    }
                case "Trạng thái (Còn hàng)":
                    {
                        searchTextBox2.Visible = false;
                        searchGiaPanel.Visible = false;
                        break;
                    }
                case "Trạng thái (Hết hàng)":
                    {
                        searchTextBox2.Visible = false;
                        searchGiaPanel.Visible = false;
                        break;
                    }
                case "Hãng sản xuất":
                    {
                        searchTextBox2.Visible = true;
                        searchGiaPanel.Visible = false;
                        break;
                    }
            }
        }

        private void nhapHangButton_Click(object sender, EventArgs e)
        {
            try
            {
                String temp = "Empty";
                for (int i = 0; i < matHangComboBox.Items.Count; i++)
                {
                    temp = ((DataRowView)matHangComboBox.Items[i])["mamh"].ToString().Trim();
                    String query = @"SELECT dbo.Dem_SoLuong_MH('" + temp + "')";
                    String number = myControl.ExecuteMyQueryScalar(query);
                    String queryUpdate = @"EXECUTE dbo.capNhat_SoLuong_SP @maMH = '" + temp + "', @number = " + number;
                    myControl.ExecuteMyQuery(queryUpdate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.StackTrace);
            }
            MessageBox.Show("Cập nhật thành công !!");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void quayHangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maQHTextBox2.Text = quayHangComboBox.SelectedValue.ToString().Trim();
        }

        private void maSPTextBox_Enter(object sender, EventArgs e)
        {
            if (maSPTextBox.Text == "MHxxx")
            {
                maSPTextBox.Text = "";
                maSPTextBox.ForeColor = Color.Black;
            }
        }

        private void maSPTextBox_Leave(object sender, EventArgs e)
        {
            if (maSPTextBox.Text == "")
            {
                maSPTextBox.Text = "MHxxx";
                maSPTextBox.ForeColor = Color.Gray;
            }
        }

        private void maSPTextBox_TextChanged(object sender, EventArgs e)
        {
            maSPTextBox.ForeColor = Color.Black;
        }
     
    }
}
