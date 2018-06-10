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
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
            setDefault();
            showData();
            setAutoData();
            //ShowDataNhapHang();
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
            string query = @"SELECT * FROM NhapHang";
            AutoCompleteStringCollection autoData = new AutoCompleteStringCollection();
            DataTable data = getData(query);
            if (data.Rows.Count > 0)
            {
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    autoData.Add(data.Rows[i]["manhap"].ToString().Trim());
                }
            }
            MaNhaptextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            MaNhaptextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            MaNhaptextBox.AutoCompleteCustomSource = autoData;
        }

        private void setData()
        {
            String queryNCC = "SELECT * FROM dbo.NhaCC";
            NhacccomboBox.DisplayMember = "tenNCC";
            NhacccomboBox.ValueMember = "maNCC";
            NhacccomboBox.DataSource = getData(queryNCC);

            String queryNV = "SELECT * FROM dbo.NhanVien";
            cbMaNV.DisplayMember = "tenNV";
            cbMaNV.ValueMember = "maNV";
            cbMaNV.DataSource = getData(queryNV);

            String queryMH = "SELECT * FROM dbo.MatHang";
            matHangComboBox.DisplayMember = "tenhang";
            matHangComboBox.ValueMember = "mamh";
            matHangComboBox.DataSource = getData(queryMH);

            searchModeComboBox.SelectedIndex = 0;

            TypeSearch();
        }

        private void showData() //do date len datagridview
        {
            string query = "SELECT * FROM NhapHang";
            dataGridView1.DataSource = getData(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        MyControl myControl = new MyControl();

        int row = 0;// do du lieu tu datagrid len text
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
                MaNhaptextBox.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();

                NgayNhaptextBox.Text = dataGridView1.Rows[row].Cells[1].Value.ToString().Trim();
                if (dataGridView1.Rows[row].Cells[1].Value.ToString().Trim().Length != 0)
                {
                    ngayNhapDateTimePicker.Value = (DateTime)dataGridView1.Rows[row].Cells[1].Value;
                }

                cbMaNV.SelectedValue = dataGridView1.Rows[row].Cells[3].Value;
                NhacccomboBox.SelectedValue = dataGridView1.Rows[row].Cells[2].Value;

                MaNhaptextBox2.Text = dataGridView1.Rows[row].Cells[0].Value.ToString().Trim();
                NhaCCtextBox2.Text = dataGridView1.Rows[row].Cells[2].Value.ToString().Trim();

                ShowDataNhapHang();
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.StackTrace);
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            //if (MaNhaptextBox.Text.Trim().Length != 0 || MaNhaptextBox.Text.Trim().Equals("NHxxx"))
            //{
            //    string query = @"INSERT dbo.NhapHang VALUES ( '" + MaNhaptextBox.Text.Trim() + "','" + NgayNhaptextBox.Text.Trim()
            //        + "','" + NhaCCtextBox.Text.Trim() + "' ,'" + MaNVtextBox.Text.Trim() + "')";

            //    MessageBox.Show("" + myControl.ExecuteMyQuery(query));
            //}
            //else
            //{
            //    MessageBox.Show("Không được để trống mã cửa hàng");
            //}
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //if (MaNhaptextBox.Text.Trim().Length != 0 || MaNhaptextBox.Text.Trim().Equals("NHxxx"))
            //{
            //    string query = "UPDATE dbo.NhapHang SET manhap='" + MaNhaptextBox.Text.Trim() + "' ,ngaynhap = '"
            //        + NgayNhaptextBox.Text.Trim() + "',mancc ='"+ NhaCCtextBox.Text.Trim() + "',manv ='" + MaNVtextBox.Text.Trim() 
            //        + "'WHERE manhap ='"+ MaNhaptextBox.Text.Trim() + "'";
            //    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
            //    showData();
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Mã nhập":
                    {
                        string query = @"SELECT * FROM dbo.NhapHang WHERE manhap LIKE'%" + searchTextBox.Text.Trim() + "'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Mã nhân viên":
                    {
                        string query = @"SELECT * FROM dbo.NhapHang WHERE manv LIKE '%" + searchTextBox.Text.Trim() + "'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Nhà cung cấp":
                    {
                        string query = @"SELECT * FROM dbo.NhapHang WHERE mancc LIKE '%" + searchTextBox.Text.Trim() + "'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
                case "Ngày nhập":
                    {
                        string query = @"SELECT * FROM dbo.NhapHang WHERE ngaynhap BETWEEN '" + searchDateTextBox1.Text.Trim() + "' AND '" + searchDateTextBox2.Text.Trim() + "'";
                        dataGridView1.DataSource = getData(query);
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;
                    }
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            //string manhap = MaNhaptextBox.Text.Trim();
            //if (MaNhaptextBox.Text.Trim().Length != 0 || MaNhaptextBox.Text.Trim().Equals("NHxxx"))
            //{
            //    string query = @"DELETE dbo.NhapHang WHERE manhap = '" + MaNhaptextBox.Text.Trim() + "'";
            //    string query2 = @"DELETE dbo.SpNhap WHERE manhap = '" + MaNhaptextBox.Text.Trim() + "'";
            //    if (MessageBox.Show("Thông tin phiếu nhập sẽ bị mất\nBạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        myControl.ExecuteMyQuery(query2);
            //        MessageBox.Show("" + myControl.ExecuteMyQuery(query));
            //        showData();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn quầy hàng");
            //}


        }

        private void  ShowDataNhapHang()
        {
            string query = "SELECT nh.manhap as mn,spn.mamh as mh,mh.tenhang as th,spn.soluong as sl,mh.dongia as dg FROM dbo.NhapHang AS nh, dbo.SpNhap AS spn ,dbo.MatHang AS mh WHERE nh.manhap = spn.manhap AND spn.mamh =mh.mamh AND nh.manhap = '" + MaNhaptextBox.Text.Trim() + "'";

            dataGridView2.DataSource = getData(query);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        int row2;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row2 = e.RowIndex;
                matHangtextBox2.Text = dataGridView2.Rows[row2].Cells[1].Value.ToString().Trim();
                matHangComboBox.SelectedValue = dataGridView2.Rows[row2].Cells[1].Value;
                soLuongNumericUpDown.Value = (int)dataGridView2.Rows[row2].Cells[3].Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex.StackTrace);
            }     
        }

        private void addButton2_Click_1(object sender, EventArgs e)
        {
            //if (MaNhaptextBox2.Text.Trim().Length != 0)
            //{
            //    string query = @"INSERT dbo.SpNhap ( manhap, mamh, soluong, mancc )
            //                VALUES ('" + MaNhaptextBox2.Text.Trim() + "','" + matHangtextBox2.Text.Trim() + "',"
            //                           + soLuongNumericUpDown.Value + ",'" + NhaCCtextBox2.Text.Trim() + "')";
            //    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
            //    ShowDataNhapHang();
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn phiếu nhập");
            //}
        }

        private void changeButton2_Click(object sender, EventArgs e)
        {
            //if (MaNhaptextBox2.Text.Trim().Length != 0)
            //{
            //    string query = @"UPDATE dbo.SpNhap SET mamh ='" + matHangtextBox2.Text.Trim() + "',soluong ="
            //        + soLuongNumericUpDown.Value + "WHERE manhap = '" + MaNhaptextBox2.Text.Trim() + "'";
            //    MessageBox.Show("" + myControl.ExecuteMyQuery(query));  
            //    ShowDataNhapHang();
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn phiếu nhập");
            //}
        }

        private void Deletebutton2_Click(object sender, EventArgs e)
        {
            //string manhap = MaNhaptextBox2.Text.Trim();
            //if (MaNhaptextBox2.Text.Trim().Length != 0)
            //{
            //    string query = @"DELETE dbo.SpNhap WHERE manhap= '" + MaNhaptextBox2.Text.Trim() + "' AND mamh = '" + matHangtextBox2.Text.Trim() + "'";
            //    if (MessageBox.Show("Bạn có muốn xóa không ??", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        MessageBox.Show("" + myControl.ExecuteMyQuery(query));
            //        ShowDataNhapHang();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn quầy hàng");
            //}
        }
        private void NhacccomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NhaCCtextBox.Text = NhacccomboBox.SelectedValue.ToString().Trim();
        }

        private void MaNhaptextBox_TextChanged(object sender, EventArgs e)
        {
            MaNhaptextBox.ForeColor = Color.Black;
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaNVtextBox.Text = cbMaNV.SelectedValue.ToString().Trim();
        }

        private void NgayNhaptextBox_TextChanged(object sender, EventArgs e)
        {

        }

        void TypeSearch()
        {
            switch (searchModeComboBox.SelectedItem.ToString().Trim())
            {
                case "Ngày nhập":
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
        private void cbTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeSearch();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          searchDateTextBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd").Trim();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            searchDateTextBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd").Trim();
        }

        private void capNhat_Click(object sender, EventArgs e)
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

        private void matHangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            matHangtextBox2.Text = matHangComboBox.SelectedValue.ToString().Trim();
        }

        private void ngayNhapDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            NgayNhaptextBox.Text = ngayNhapDateTimePicker.Value.ToString("yyyy/MM/dd");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void searchDatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaNhaptextBox_Enter(object sender, EventArgs e)
        {
            if (MaNhaptextBox.Text == "NHxxx")
            {
                MaNhaptextBox.Text = "";
                MaNhaptextBox.ForeColor = Color.Black;
            }
        }

        private void MaNhaptextBox_Leave(object sender, EventArgs e)
        {
            if (MaNhaptextBox.Text == "")
            {
                MaNhaptextBox.Text = "NHxxx";
                MaNhaptextBox.ForeColor = Color.Gray;
            }
        }

        public static Boolean select_NCC=false;
        private void button1_Click(object sender, EventArgs e)
        {
            select_NCC = true;
            new NhaCC().ShowDialog();

            String queryNCC = "SELECT * FROM dbo.NhaCC";
            NhacccomboBox.DisplayMember = "tenNCC";
            NhacccomboBox.ValueMember = "maNCC";
            NhacccomboBox.DataSource = getData(queryNCC);
        }        
    }
}
