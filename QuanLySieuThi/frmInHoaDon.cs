﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class frmInHoaDon : Form
    {
        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThucTapCSDL2DataSet.InHoaDon' table. You can move, or remove it, as needed.
            this.InHoaDonTableAdapter.Fill(this.ThucTapCSDL2DataSet.InHoaDon, HoaDon.mahoadon);

            this.reportViewer1.RefreshReport();
        }
    }
}
