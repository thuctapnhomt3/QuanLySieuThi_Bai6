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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            setDefault(DangNhap.checkAceccpt);
            showData();
            showData2();
            setAutoData();
            setData();
        }

        public void setDefault(int checkAccept)
        {
            if (checkAccept == 0)
            {
                addButton.Enabled = false;
                changeButton.Enabled = false;
                deleteButton.Enabled = false;

                addButton2.Enabled = false;
                changeButton2.Enabled = false;
                deleteButton2.Enabled = false;
            }
            else
            {
                if (checkAccept == 1 || checkAccept == 2)
                {
                    addButton.Enabled = true;
                    changeButton.Enabled = true;
                    deleteButton.Enabled = true;
                }
                if (checkAccept == 1)
                {
                    addButton2.Enabled = true;
                    changeButton2.Enabled = true;
                    deleteButton2.Enabled = true;
                }
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

        private void setAutoData()
        {
            string queryPB = @"SELECT * FROM PhongBan";
            AutoCompleteStringCollection autoDataPB = new AutoCompleteStringCollection();
            DataTable dataPB = getData(queryPB);
            if (dataPB.Rows.Count > 0)
            {
                for (int i = 0; i < dataPB.Rows.Count; i++)
                {
                    autoDataPB.Add(dataPB.Rows[i]["maphong"].ToString().Trim());
                }
            }
            maPhongTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            maPhongTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            maPhongTextBox.AutoCompleteCustomSource = autoDataPB;

            string queryNV = @"SELECT * FROM NhanVien";
            AutoCompleteStringCollection autoData = new AutoCompleteStringCollection();
            DataTable data = getData(queryNV);
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    autoData.Add(data.Rows[i]["maNV"].ToString().Trim());
                }
            }
            maNVTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            maNVTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            maNVTextBox.AutoCompleteCustomSource = autoData;
        }

        private void showData2()
        {
            string query = "SELECT * FROM PhongBan";
            dataGridView2.DataSource = getData(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        private void showData()
        {
            string query = "SELECT * FROM NhanVien";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showNVData(string maPhong)
        {
            string query = "SELECT * FROM dbo.NhanVien WHERE maPhong ='" + maPhong + "'";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void setData()
        {
            String queryPB = "SELECT * FROM PhongBan";
            phongComboBox.DisplayMember = "tenphong";
            phongComboBox.ValueMember = "maphong";
            phongComboBox.DataSource = getData(queryPB);

            String queryNV = "SELECT * FROM NhanVien";
            NVComboBox.DisplayMember = "tenNV";
            NVComboBox.ValueMember = "maNV";
            NVComboBox.DataSource = getData(queryNV);

            gioiTinhComboBox.SelectedIndex = 0;

            searchModeComboBox.SelectedIndex = 0;
            searchSexComboBox.SelectedIndex = 0;

            ngaySinhTextBox.Text = ngaySinhDateTimePicker.Value.ToString("yyyy/MM/dd").Trim();
        }

        MyControl myControl = new MyControl();

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void maNVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nuRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            searchDateTextBox1.Text = searchDateTimePicker1.Value.ToString("yyyy/MM/dd").Trim();
        }
        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
                //MessageBox.Show(""+row);
                maNVTextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
                tenNVTextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();

                sdtTextBox.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();

                if (dataGridView1.Rows[row].Cells[3].Value.ToString().Trim().Length != 0)
                {
                    ngaySinhDateTimePicker.Value = (DateTime)dataGridView1.Rows[row].Cells[3].Value;
                }

                gioiTinhComboBox.SelectedItem = dataGridView1.Rows[row].Cells[4].Value;
                luongTextBox.Text = dataGridView1.Rows[row].Cells[5].Value.ToString().Trim();

                phongComboBox.SelectedValue = dataGridView1.Rows[row].Cells[6].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        int row2;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row2 = e.RowIndex;
                maPhongTextBox.Text = dataGridView2.Rows[row2].Cells[0].Value.ToString().Trim();
                tenPhongTextBox.Text = dataGridView2.Rows[row2].Cells[1].Value.ToString().Trim();
                NVComboBox.SelectedValue = dataGridView2.Rows[row2].Cells[2].Value.ToString().Trim();
                

                showNVData(maPhongTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }   
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //if (maNVTextBox.Text.Trim().Length != 0 || maNVTextBox.Text.Trim().Equals("NVxxx"))
            //{
            //    String query = @"INSERT dbo.NhanVien( maNV ,tenNV, sdt, ngaySinh, gioiTinh, luong, maPhong, maNQL)
            //                    VALUES  ( '" + maNVTextBox.Text.Trim() + "',N'" + tenNVTextBox.Text.Trim() + "','" 
            //                                 + sdtTextBox.Text.Trim() + "','" + ngaySinhDateTimePicker.Value.ToString("yyyy/MM/dd").Trim()
            //                                 + "',N'" + gioiTinhComboBox.SelectedItem.ToString().Trim() + "'," + luongTextBox.Text.Trim() + ",'" 
            //                                 + phongTextBox.Text.Trim() + "','" + nqlTextBox.Text.Trim() + "')";                
            //    MessageBox.Show(""+query+"\n" + myControl.ExecuteMyQuery(query));
            //    showNVData(phongTextBox.Text.Trim());
            //}
            //else
            //{
            //    MessageBox.Show("Không được để trống mã nhân viên");
            //}
        }

        

        private void changeButton_Click(object sender, EventArgs e)
        {
            //if (maNVTextBox.Text.Trim().Length != 0 || maNVTextBox.Text.Trim().Equals("NVxxx"))
            //{
            //    string query = @"UPDATE dbo.NhanVien SET tenNV=N'" + tenNVTextBox.Text.Trim() + "',sdt='" + sdtTextBox.Text.Trim()
            //        + "',ngaySinh='" + ngaySinhDateTimePicker.Value.ToString("yyyy/MM/dd").Trim() + "',gioiTinh=N'" + gioiTinhComboBox.SelectedItem.ToString().Trim()
            //        + "',luong=" + luongTextBox.Text.Trim() + ",maPhong='" + phongTextBox.Text.Trim() + "',maNQL='" + nqlTextBox.Text.Trim() + "' WHERE maNV= '" + maNVTextBox.Text.Trim() + "'";
            //    MessageBox.Show("" + myControl.ExecuteMyQuery(query));
            //    showNVData(phongTextBox.Text.Trim());
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn nhân viên");
            //}
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string manv = maNVTextBox.Text.Trim();
            //if (maNVTextBox.Text.Trim().Length != 0 || maNVTextBox.Text.Trim().Equals("NVxxx"))
            //{
            //    string query = @"EXEC dbo.xoa_NhanVien @maNV_ = '" + maNVTextBox.Text.Trim() + "'";
            //    if (MessageBox.Show("Muốn xóa nhân viên! Phải xóa hóa đơn , nhập, xuất hàng liên quan tới nhân viên! ! Bạn chắc chắn muốn xóa ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        MessageBox.Show("" + myControl.ExecuteMyQuery(query));
            //        showNVData(phongTextBox.Text.Trim());
            //    }
            //    // MessageBox.Show("" + myControl.ExecuteMyQuery(query)); 
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn quầy hàng");
            //}



        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Mã nhân viên":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE maNV LIKE '%" + searchTextBox.Text.Trim() + "%'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Tên nhân viên":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE tenNV LIKE N'%" + searchTextBox.Text.Trim() + "%'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Số điện thoại":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE sdt LIKE '%" + searchTextBox.Text.Trim() + "%'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Ngày sinh":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE ngaySinh BETWEEN '" + searchDateTextBox1.Text.Trim() + "' AND '" + searchDateTextBox2.Text.Trim() + "'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Giới tính":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE gioiTinh LIKE N'%" + searchSexComboBox.SelectedItem.ToString().Trim() + "%'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Lương":
                    {
                        string query = @"SELECT * FROM dbo.NhanVien WHERE Luong BETWEEN " + searchLuongTextBox1.Text.Trim() + " AND " + searchLuongTextBox2.Text.Trim();
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
            }
        }

        private void setNQL()
        {
            string query = @"SELECT COUNT(*) FROM dbo.PhongBan WHERE maNQL = '" + maQuanLyTextBox.Text.Trim() + "' AND maPhong != '" + maPhongTextBox.Text.Trim() + "'";
            string ressult = myControl.ExecuteMyQueryScalar(query);
            String query2 = @"EXEC dbo.capnhat_QuanLyPhongBan @maNV_ = '" + maQuanLyTextBox.Text.Trim() + "', @maPB_ = '" + maPhongTextBox.Text.Trim() + "'";
            if (ressult == "1")
            {
                if (MessageBox.Show("Nhân viên này đang quản lý phòng ban khác \nBạn có muốn nhân viên đó rời đi ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                    
                    myControl.ExecuteMyQuery(query2);
                }
            }
            else
            {
                myControl.ExecuteMyQuery(query2);
            }
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            if (maPhongTextBox.Text.Trim().Length != 0)
            {
                setNQL();
                string query = @"INSERT dbo.PhongBan( maphong,tenphong,maNQL)
                                VALUES  ( '" + maPhongTextBox.Text.Trim() + "',N'" + tenPhongTextBox.Text.Trim() + "','" + maQuanLyTextBox.Text.Trim() + "')";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                
                showData2();
                showNVData(maPhongTextBox.Text.Trim());
                setData();
            }
            else
            {
                MessageBox.Show("Không được để trống mã phòng ");
            }
        }

        private void changeButton2_Click(object sender, EventArgs e)
        {
            if (maPhongTextBox.Text.Trim().Length != 0)
            {
                setNQL();
                string query = @"UPDATE dbo.PhongBan SET tenphong=N'" + tenPhongTextBox.Text.Trim() +"',maNQL = '"+maQuanLyTextBox.Text.Trim()+"' WHERE maphong= '" 
                    + maPhongTextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
               
                showData2();
                showNVData(maPhongTextBox.Text.Trim());
                setData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phòng");
            }
        }      

        private void deleteButton2_Click(object sender, EventArgs e)
        {

            string maphong = maPhongTextBox.Text.Trim();
            if (maPhongTextBox.Text.Trim().Length != 0)
            {
                string query = @"EXEC dbo.xoa_PhongBan @maphong_ = '" + maphong + "'";
                if (MessageBox.Show("Nhân viên thuộc phòng ban sẽ bị xóa ! ! Bạn chắc chắn muốn xóa ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                  
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                    showData2();
                    showData();
                    setData();
                }
                // MessageBox.Show("" + myControl.ExecuteMyQuery(query));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quầy hàng");
            }
        }

        private void searchButton2_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM dbo.PhongBan WHERE (maphong LIKE'%" + searchTextBox2.Text.Trim()
                + "%') OR (tenphong LIKE N'%" + searchTextBox2.Text.Trim() + "%') OR ( maNQL LIKE '%" + searchTextBox2.Text.Trim() + "%')";
            dataGridView2.DataSource = getData(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void sdtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int) e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void luongTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void searchTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                searchButton2_Click(null, null);
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                searchButton_Click(null, null);
            }
        }

        private void phongComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            phongTextBox.Text = phongComboBox.SelectedValue.ToString().Trim();
            string query = @"SELECT maNQL FROM dbo.PhongBan WHERE maphong = '" + phongComboBox.SelectedValue.ToString().Trim() + "'";
            nqlTextBox.Text = myControl.ExecuteMyQueryScalar(query);
            string query2 = @"SELECT tenNV FROM dbo.NhanVien WHERE maNV = '" + nqlTextBox.Text.Trim() + "'";
            tenNQLTextBox.Text = myControl.ExecuteMyQueryScalar(query2);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString())
            {
                case "Lương":
                    {
                        searchLuongPanel.Visible = true;
                        searchTextBox.Visible = false;
                        searchDatePanel.Visible = false;
                        searchSexPanel.Visible = false;
                        break;
                    }
                case "Ngày sinh":
                    {
                        searchDatePanel.Visible = true;
                        searchTextBox.Visible = false;
                        searchLuongPanel.Visible = false;
                        searchSexPanel.Visible = false;
                        break;
                    }
                case "Giới tính":
                    {
                        searchSexPanel.Visible = true;
                        searchLuongPanel.Visible = false;
                        searchDatePanel.Visible = false;
                        searchTextBox.Visible = false;
                        break;
                    }
                default:
                    {
                        searchTextBox.Visible = true;
                        searchLuongPanel.Visible = false;
                        searchDatePanel.Visible = false;
                        searchSexPanel.Visible = false;
                        break;
                    }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8 && (int)e.KeyChar!=13)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (int)e.KeyChar != 8 && (int)e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            searchDateTextBox2.Text = searchDateTimePicker2.Value.ToString("yyyy/MM/dd").Trim();
        }

        private void ngaySinhDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ngaySinhTextBox.Text = ngaySinhDateTimePicker.Value.ToString("yyyy/MM/dd").Trim();
        }

        private void searchDateTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maNVTextBox_Enter(object sender, EventArgs e)
        {
            if (maNVTextBox.Text == "NVxxx")
            {
                maNVTextBox.Text = "";
                maNVTextBox.ForeColor = Color.Black;
            }
        }

        private void maNVTextBox_Leave(object sender, EventArgs e)
        {
            if (maNVTextBox.Text == "")
            {
                maNVTextBox.Text = "NVxxx";
                maNVTextBox.ForeColor = Color.Gray;
            }
        }

        private void NVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(NVComboBox.SelectedValue!=null){
                maQuanLyTextBox.Text = NVComboBox.SelectedValue.ToString().Trim();
            }
            else
            {
                maQuanLyTextBox.Text = "";
            }
        }

        private void maNVTextBox_TextChanged_1(object sender, EventArgs e)
        {
            maNVTextBox.ForeColor = Color.Black;
        }
    }
}



           