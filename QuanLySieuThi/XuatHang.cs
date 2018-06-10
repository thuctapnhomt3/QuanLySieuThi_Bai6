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
    public partial class XuatHang : Form
    {
        public XuatHang()
        {
            InitializeComponent();
            setDefault();
            setAutoData();
            showData();
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

        MyControl myControl = new MyControl();


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
            string query = @"SELECT * FROM XuatHang";
            AutoCompleteStringCollection autoData = new AutoCompleteStringCollection();
            DataTable data = getData(query);
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    autoData.Add(data.Rows[i]["maxuat"].ToString().Trim());
                }
            }
            maXuattextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            maXuattextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            maXuattextBox.AutoCompleteCustomSource = autoData;
        }

        private void setData()
        {
            String queryNV = "SELECT * FROM dbo.NhanVien";
            MaNVcomboBox.DisplayMember = "tenNV";
            MaNVcomboBox.ValueMember = "maNV";
            MaNVcomboBox.DataSource = getData(queryNV);

            String queryMH = "SELECT * FROM dbo.MatHang";
            matHangComboBox.DisplayMember = "tenhang";
            matHangComboBox.ValueMember = "mamh";
            matHangComboBox.DataSource = getData(queryMH);
        }

        private void showData()
        {
            string query = "SELECT * FROM XuatHang";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ShowDataXuatHang()
        {
            try
            {
                if (maXuattextBox.Text.Trim().Length != 0)
                {
                    string query = "SELECT nh.maxuat as mx,spx.mamh as mh,mh.tenhang as th,spx.soluong as sl,mh.dongia as dg FROM dbo.XuatHang AS nh, dbo.SpXuat AS spx ,dbo.MatHang AS mh WHERE nh.maxuat = spx.maxuat AND spx.mamh =mh.mamh AND nh.maxuat = '" + maXuattextBox.Text.Trim() + "'";
                    dataGridView2.DataSource = getData(query);
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phiếu xuất");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        int row = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
                maXuattextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();

                ngayXuattextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
                MaNVcomboBox.SelectedValue = dataGridView1.Rows[row].Cells[2].Value;

                maXuattextBox2.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
                ShowDataXuatHang();
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.StackTrace);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0 || maXuattextBox.Text.Trim().Equals("XHxxx"))
            {

                string query = @"INSERT dbo.XuatHang ( maxuat , ngayxuat , mach, manv ) VALUES  ( '" + maXuattextBox.Text.Trim()
                    + "','" + ngayXuattextBox.Text.Trim() + "','" + maNVTextBox.Text.Trim() + "')";

                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                showData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0 || maXuattextBox.Text.Trim().Equals("XHxxx"))
            {
                string query = @"UPDATE dbo.XuatHang SET maxuat ='" + maXuattextBox.Text.Trim() + "',ngayxuat = '"
                    + ngayXuattextBox.Text.Trim() + "' , manv = '" + maNVTextBox.Text.Trim() + "' WHERE  maxuat = '"
                    + maXuattextBox.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                showData();
            }
        }

        void DeleteNhBymanhap(string maxuat)
        {
            string query = @"DELETE dbo.XuatHang WHERE maxuat =  '" + maxuat + "'";
            myControl.ExecuteMyQuery(query);
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            string maxuat = maXuattextBox.Text.Trim();
            if (maXuattextBox.Text.Trim().Length != 0 || maXuattextBox.Text.Trim().Equals("XHxxx"))
            {
                string query = @"DELETE dbo.XuatHang WHERE maxuat = '" + maXuattextBox.Text.Trim() + "'";
                string query2 = @"DELETE dbo.SpXuat WHERE maxuat = '" + maXuattextBox.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    myControl.ExecuteMyQuery(query2);
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                    showData();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quầy hàng");
            }


        }

        private void searchButtonXH_Click(object sender, EventArgs e)
        {           
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Mã nhập":
                    {
                        string query = @"SELECT * FROM dbo.XuatHang WHERE maxuat LIKE'%" + searchTextBox.Text.Trim() + "'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Mã nhân viên":
                    {
                        string query = @"SELECT * FROM dbo.XuatHang WHERE manv LIKE '%" + searchTextBox.Text.Trim() + "'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Ngày nhập":
                    {
                        string query = @"SELECT * FROM dbo.XuatHang WHERE ngayxuat BETWEEN '" + searchDateTextBox1.Text.Trim() + "' AND '" + searchDateTextBox2.Text.Trim() + "'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
            }
        }

        int row2;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row2 = e.RowIndex;
                matHangComboBox.SelectedValue = dataGridView2.Rows[row2].Cells[1].Value;
                soLuongNumericUpDown.Value = (int)dataGridView2.Rows[row2].Cells[3].Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.StackTrace);
            }          
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0)
            {
                string query = @"INSERT dbo.SpXuat VALUES  ( '" + maXuattextBox2.Text.Trim() + "','" + maSPtextBox2.Text.Trim() + "'," + soLuongNumericUpDown.Value.ToString().Trim() + "  )";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                ShowDataXuatHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất");
            }
        }

        private void updateButton2_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0)
            {
                string query = @"UPDATE dbo.SpXuat SET mamh = '" + maSPtextBox2.Text.Trim() + "', soluong = '" + soLuongNumericUpDown.Value.ToString().Trim() + "' WHERE maxuat ='" + maXuattextBox2.Text.Trim() + "'";
                MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                ShowDataXuatHang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất");
            }
        }

        private void delButton2_Click(object sender, EventArgs e)
        {
            if (maXuattextBox.Text.Trim().Length != 0)
            {
                string query = @"DELETE dbo.SpXuat WHERE maxuat = '" + maXuattextBox2.Text.Trim() + "' AND mamh = '" + maSPtextBox2.Text.Trim() + "'";
                if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("" + myControl.ExecuteMyQuery(query));
                    ShowDataXuatHang();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quầy hàng");
            }





            //if (maXuattextBox.Text.Trim().Length != 0)
            //{
            //    string query = @"DELETE dbo.SpXuat WHERE maxuat = '" + maXuattextBox2.Text.Trim() + "' AND mamh = '" + maSPtextBox2.Text.Trim() + "'";
            //    if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
            //        ShowDataXuatHang();
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn phiếu xuất");
            //}
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            maNVTextBox.Text = MaNVcomboBox.SelectedValue.ToString().Trim();
        }

        private void matHangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maSPtextBox2.Text = matHangComboBox.SelectedValue.ToString().Trim();
        }

        private void ngayXuatDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           ngayXuattextBox.Text = ngayXuatDateTimePicker.Value.ToString("yyyy/MM/dd");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            searchDateTextBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd").Trim();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            searchDateTextBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd").Trim();
        }

        private void searchModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Ngày xuất":
                    {
                        searchDatePanel.Visible = true;
                        searchTextBox.Visible = false;
                        break;
                    }
                default:
                    {
                        searchDatePanel.Visible = false;
                        searchTextBox.Visible = true;
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void searchDateTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maXuattextBox_Enter(object sender, EventArgs e)
        {
            if (maXuattextBox.Text == "XHxxx")
            {
                maXuattextBox.Text = "";
                maXuattextBox.ForeColor = Color.Black;
            }
        }

        private void maXuattextBox_Leave(object sender, EventArgs e)
        {
            if (maXuattextBox.Text == "")
            {
                maXuattextBox.Text = "XHxxx";
                maXuattextBox.ForeColor = Color.Gray;
            }
        }
    }
}
