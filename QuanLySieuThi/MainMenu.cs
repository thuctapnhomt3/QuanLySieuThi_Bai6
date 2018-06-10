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
    public partial class MainMenu : Form
    {
        int checkAccept = 0;
        public MainMenu()
        {
            InitializeComponent();
            
            if (checkAccept != 1)
            {
                setDafaultMenu();
            }           
        }

        private void setDafaultMenu()
        {
            statusLabel.Text = ">> Xin chào, ban đang truy cập với tư cách khách";
            quảnLýTruyCậpToolStripMenuItem.Enabled = false;

            đăngXuấtToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;

            personalButton.Visible = false;
        }
        
        
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap login = new DangNhap();
            login.ShowDialog();

            checkAccept = DangNhap.checkAceccpt;
            if (checkAccept == 1 || checkAccept == 2)
            {
                đăngXuấtToolStripMenuItem.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;

                nhàCungCấpToolStripMenuItem.Enabled = true;
                kháchHàngToolStripMenuItem.Enabled = true;
                phòngBanToolStripMenuItem.Enabled = true;
                nhânViênToolStripMenuItem.Enabled = true;

                personalButton.Visible = true;
            }

            if (checkAccept == 1)
            {
                statusLabel.Text = ">> Xin chào " + DangNhap.userName + ", bạn đang truy cập với tư cách nhà quản trị";
                quảnLýTruyCậpToolStripMenuItem.Enabled = true;

                hóaĐơnToolStripMenuItem.Enabled = true;
                nhạpHàngToolStripMenuItem.Enabled = true;
                xuấtHàngToolStripMenuItem.Enabled = true;
                
            }
            else
            {
                if (checkAccept == 2)
                {
                    statusLabel.Text = ">> Xin chào " + DangNhap.userName + ", bạn đang truy cập với tư cách nhân viên";
                    quảnLýTruyCậpToolStripMenuItem.Enabled = false;                 
                }
            }
            
        }



        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien staff = new NhanVien();
            staff.Show();
        }

        private void nhómMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuayHang produceLine = new QuayHang();
            produceLine.Show();
        }
        

        private void quảnLýTruyCậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanLyTaiKhoan quanLy = new quanLyTaiKhoan();
            quanLy.Show();
        }

        private void quảnLýDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCC nhaCungCap = new NhaCC();
            nhaCungCap.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien staff = new NhanVien();
            staff.Show();
        }

        private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XuatHang xuatHang = new XuatHang();
            xuatHang.Show();
        }

        private void nhạpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapHang nhapHang = new NhapHang();
            nhapHang.Show();
        }

        private void personalButton_Click(object sender, EventArgs e)
        {
            CaNhan personal = new CaNhan();
            personal.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}