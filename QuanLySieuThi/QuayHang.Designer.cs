namespace QuanLySieuThi
{
    partial class QuayHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuayHang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maQuay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQuay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton1 = new System.Windows.Forms.Button();
            this.changeButton1 = new System.Windows.Forms.Button();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.searchTextBox2 = new System.Windows.Forms.TextBox();
            this.maQHTextBox = new System.Windows.Forms.TextBox();
            this.tenQHTextBox = new System.Windows.Forms.TextBox();
            this.maNVLabel = new System.Windows.Forms.Label();
            this.tenNVLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mamh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanhso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tenSPTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.giaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maQHTextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.doanhSoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nsxTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ttinTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.trangThaiTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addButton2 = new System.Windows.Forms.Button();
            this.changeButton2 = new System.Windows.Forms.Button();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchGiaPanel = new System.Windows.Forms.Panel();
            this.searchGiaTextBox2 = new System.Windows.Forms.TextBox();
            this.searchGiaTextBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.searchModeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.giamGiaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.matHangComboBox = new System.Windows.Forms.ComboBox();
            this.nhapHangButton = new System.Windows.Forms.Button();
            this.quayHangComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.searchGiaPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maQuay,
            this.tenQuay});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(13, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(256, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maQuay
            // 
            this.maQuay.DataPropertyName = "maQuay";
            this.maQuay.HeaderText = "Mã quầy";
            this.maQuay.Name = "maQuay";
            this.maQuay.ReadOnly = true;
            // 
            // tenQuay
            // 
            this.tenQuay.DataPropertyName = "tenQuay";
            this.tenQuay.HeaderText = "Tên quầy";
            this.tenQuay.Name = "tenQuay";
            this.tenQuay.ReadOnly = true;
            // 
            // addButton1
            // 
            this.addButton1.Enabled = false;
            this.addButton1.Location = new System.Drawing.Point(15, 117);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(82, 46);
            this.addButton1.TabIndex = 9;
            this.addButton1.Text = "Thêm";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // changeButton1
            // 
            this.changeButton1.Enabled = false;
            this.changeButton1.Location = new System.Drawing.Point(103, 117);
            this.changeButton1.Name = "changeButton1";
            this.changeButton1.Size = new System.Drawing.Size(80, 46);
            this.changeButton1.TabIndex = 10;
            this.changeButton1.Text = "Sửa";
            this.changeButton1.UseVisualStyleBackColor = true;
            this.changeButton1.Click += new System.EventHandler(this.changeButton1_Click);
            // 
            // deleteButton1
            // 
            this.deleteButton1.Enabled = false;
            this.deleteButton1.Location = new System.Drawing.Point(189, 117);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(80, 46);
            this.deleteButton1.TabIndex = 11;
            this.deleteButton1.Text = "Xóa";
            this.deleteButton1.UseVisualStyleBackColor = true;
            this.deleteButton1.Click += new System.EventHandler(this.deleteButton1_Click);
            // 
            // searchButton2
            // 
            this.searchButton2.Location = new System.Drawing.Point(834, 4);
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.Size = new System.Drawing.Size(92, 46);
            this.searchButton2.TabIndex = 12;
            this.searchButton2.Text = "Tìm kiếm";
            this.searchButton2.UseVisualStyleBackColor = true;
            this.searchButton2.Click += new System.EventHandler(this.searchButton2_Click);
            // 
            // searchTextBox2
            // 
            this.searchTextBox2.Location = new System.Drawing.Point(607, 15);
            this.searchTextBox2.Name = "searchTextBox2";
            this.searchTextBox2.Size = new System.Drawing.Size(221, 22);
            this.searchTextBox2.TabIndex = 13;
            // 
            // maQHTextBox
            // 
            this.maQHTextBox.Location = new System.Drawing.Point(13, 30);
            this.maQHTextBox.Name = "maQHTextBox";
            this.maQHTextBox.Size = new System.Drawing.Size(170, 22);
            this.maQHTextBox.TabIndex = 14;
            // 
            // tenQHTextBox
            // 
            this.tenQHTextBox.Location = new System.Drawing.Point(15, 89);
            this.tenQHTextBox.Name = "tenQHTextBox";
            this.tenQHTextBox.Size = new System.Drawing.Size(254, 22);
            this.tenQHTextBox.TabIndex = 15;
            // 
            // maNVLabel
            // 
            this.maNVLabel.AutoSize = true;
            this.maNVLabel.Location = new System.Drawing.Point(10, 10);
            this.maNVLabel.Name = "maNVLabel";
            this.maNVLabel.Size = new System.Drawing.Size(98, 17);
            this.maNVLabel.TabIndex = 21;
            this.maNVLabel.Text = "Mã quầy hàng";
            this.maNVLabel.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // tenNVLabel
            // 
            this.tenNVLabel.AutoSize = true;
            this.tenNVLabel.Location = new System.Drawing.Point(12, 67);
            this.tenNVLabel.Name = "tenNVLabel";
            this.tenNVLabel.Size = new System.Drawing.Size(104, 17);
            this.tenNVLabel.TabIndex = 29;
            this.tenNVLabel.Text = "Tên quầy hàng";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamh,
            this.tenhang,
            this.dongia,
            this.maquay2,
            this.doanhso,
            this.ghichu,
            this.giamgia,
            this.trangthai,
            this.hangsx});
            this.dataGridView2.Location = new System.Drawing.Point(9, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(917, 348);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // mamh
            // 
            this.mamh.DataPropertyName = "mamh";
            this.mamh.HeaderText = "Mã hàng";
            this.mamh.Name = "mamh";
            this.mamh.ReadOnly = true;
            // 
            // tenhang
            // 
            this.tenhang.DataPropertyName = "tenhang";
            this.tenhang.HeaderText = "Tên hàng";
            this.tenhang.Name = "tenhang";
            this.tenhang.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // maquay2
            // 
            this.maquay2.DataPropertyName = "maquay";
            this.maquay2.HeaderText = "Mã quầy";
            this.maquay2.Name = "maquay2";
            this.maquay2.ReadOnly = true;
            // 
            // doanhso
            // 
            this.doanhso.DataPropertyName = "doanhso";
            this.doanhso.HeaderText = "Doanh số";
            this.doanhso.Name = "doanhso";
            this.doanhso.ReadOnly = true;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            this.ghichu.ReadOnly = true;
            // 
            // giamgia
            // 
            this.giamgia.DataPropertyName = "giamgia";
            this.giamgia.HeaderText = "Giảm giá";
            this.giamgia.Name = "giamgia";
            this.giamgia.ReadOnly = true;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            // 
            // hangsx
            // 
            this.hangsx.DataPropertyName = "hangsx";
            this.hangsx.HeaderText = "Hãng sản xuất";
            this.hangsx.Name = "hangsx";
            this.hangsx.ReadOnly = true;
            // 
            // maSPTextBox
            // 
            this.maSPTextBox.ForeColor = System.Drawing.Color.Gray;
            this.maSPTextBox.Location = new System.Drawing.Point(111, 10);
            this.maSPTextBox.Name = "maSPTextBox";
            this.maSPTextBox.Size = new System.Drawing.Size(156, 22);
            this.maSPTextBox.TabIndex = 14;
            this.maSPTextBox.Text = "MHxxx";
            this.maSPTextBox.TextChanged += new System.EventHandler(this.maSPTextBox_TextChanged);
            this.maSPTextBox.Enter += new System.EventHandler(this.maSPTextBox_Enter);
            this.maSPTextBox.Leave += new System.EventHandler(this.maSPTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã sản phẩm";
            this.label1.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // tenSPTextBox
            // 
            this.tenSPTextBox.Location = new System.Drawing.Point(111, 38);
            this.tenSPTextBox.Name = "tenSPTextBox";
            this.tenSPTextBox.Size = new System.Drawing.Size(259, 22);
            this.tenSPTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên sản phẩm";
            this.label2.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // giaTextBox
            // 
            this.giaTextBox.Location = new System.Drawing.Point(519, 9);
            this.giaTextBox.Name = "giaTextBox";
            this.giaTextBox.Size = new System.Drawing.Size(156, 22);
            this.giaTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Giá";
            this.label3.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // maQHTextBox2
            // 
            this.maQHTextBox2.Location = new System.Drawing.Point(774, 72);
            this.maQHTextBox2.Name = "maQHTextBox2";
            this.maQHTextBox2.ReadOnly = true;
            this.maQHTextBox2.Size = new System.Drawing.Size(152, 22);
            this.maQHTextBox2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quầy hàng";
            this.label4.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // doanhSoTextBox
            // 
            this.doanhSoTextBox.Location = new System.Drawing.Point(774, 38);
            this.doanhSoTextBox.Name = "doanhSoTextBox";
            this.doanhSoTextBox.ReadOnly = true;
            this.doanhSoTextBox.Size = new System.Drawing.Size(156, 22);
            this.doanhSoTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Doanh số";
            this.label5.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Giảm giá";
            this.label6.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // nsxTextBox
            // 
            this.nsxTextBox.Location = new System.Drawing.Point(111, 95);
            this.nsxTextBox.Name = "nsxTextBox";
            this.nsxTextBox.Size = new System.Drawing.Size(259, 22);
            this.nsxTextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nhà sản xuất";
            this.label7.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // ttinTextBox
            // 
            this.ttinTextBox.Location = new System.Drawing.Point(111, 67);
            this.ttinTextBox.Name = "ttinTextBox";
            this.ttinTextBox.Size = new System.Drawing.Size(259, 22);
            this.ttinTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Thông tin";
            this.label8.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // trangThaiTextBox
            // 
            this.trangThaiTextBox.Location = new System.Drawing.Point(774, 9);
            this.trangThaiTextBox.Name = "trangThaiTextBox";
            this.trangThaiTextBox.ReadOnly = true;
            this.trangThaiTextBox.Size = new System.Drawing.Size(156, 22);
            this.trangThaiTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(695, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Trạng thái";
            this.label9.Click += new System.EventHandler(this.maNVLabel_Click);
            // 
            // addButton2
            // 
            this.addButton2.Enabled = false;
            this.addButton2.Location = new System.Drawing.Point(519, 117);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(82, 46);
            this.addButton2.TabIndex = 9;
            this.addButton2.Text = "Thêm";
            this.addButton2.UseVisualStyleBackColor = true;
            this.addButton2.Click += new System.EventHandler(this.addButton2_Click);
            // 
            // changeButton2
            // 
            this.changeButton2.Enabled = false;
            this.changeButton2.Location = new System.Drawing.Point(607, 117);
            this.changeButton2.Name = "changeButton2";
            this.changeButton2.Size = new System.Drawing.Size(82, 46);
            this.changeButton2.TabIndex = 10;
            this.changeButton2.Text = "Sửa";
            this.changeButton2.UseVisualStyleBackColor = true;
            this.changeButton2.Click += new System.EventHandler(this.changeButton2_Click);
            // 
            // deleteButton2
            // 
            this.deleteButton2.Enabled = false;
            this.deleteButton2.Location = new System.Drawing.Point(695, 117);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(82, 46);
            this.deleteButton2.TabIndex = 11;
            this.deleteButton2.Text = "Xóa";
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.addButton1);
            this.panel1.Controls.Add(this.tenNVLabel);
            this.panel1.Controls.Add(this.changeButton1);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.deleteButton1);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.maQHTextBox);
            this.panel1.Controls.Add(this.tenQHTextBox);
            this.panel1.Controls.Add(this.maNVLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 597);
            this.panel1.TabIndex = 31;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(189, 182);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 46);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Tìm kiếm";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(15, 194);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(168, 22);
            this.searchTextBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchGiaPanel);
            this.panel2.Controls.Add(this.searchModeComboBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.searchTextBox2);
            this.panel2.Controls.Add(this.searchButton2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(303, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 420);
            this.panel2.TabIndex = 32;
            // 
            // searchGiaPanel
            // 
            this.searchGiaPanel.Controls.Add(this.searchGiaTextBox2);
            this.searchGiaPanel.Controls.Add(this.searchGiaTextBox1);
            this.searchGiaPanel.Controls.Add(this.label12);
            this.searchGiaPanel.Controls.Add(this.label11);
            this.searchGiaPanel.Location = new System.Drawing.Point(239, 5);
            this.searchGiaPanel.Name = "searchGiaPanel";
            this.searchGiaPanel.Size = new System.Drawing.Size(292, 45);
            this.searchGiaPanel.TabIndex = 33;
            // 
            // searchGiaTextBox2
            // 
            this.searchGiaTextBox2.Location = new System.Drawing.Point(178, 10);
            this.searchGiaTextBox2.Name = "searchGiaTextBox2";
            this.searchGiaTextBox2.Size = new System.Drawing.Size(100, 22);
            this.searchGiaTextBox2.TabIndex = 1;
            this.searchGiaTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchGiaTextBox2_KeyPress);
            // 
            // searchGiaTextBox1
            // 
            this.searchGiaTextBox1.Location = new System.Drawing.Point(34, 9);
            this.searchGiaTextBox1.Name = "searchGiaTextBox1";
            this.searchGiaTextBox1.Size = new System.Drawing.Size(100, 22);
            this.searchGiaTextBox1.TabIndex = 1;
            this.searchGiaTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchGiaTextBox1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(140, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "đến";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Từ";
            // 
            // searchModeComboBox
            // 
            this.searchModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchModeComboBox.FormattingEnabled = true;
            this.searchModeComboBox.Items.AddRange(new object[] {
            "Mã hàng",
            "Tên hàng",
            "Giá",
            "Giảm giá (Đang giảm giá)",
            "Giảm giá (Không giảm giá)",
            "Trạng thái (Còn hàng)",
            "Trạng thái (Hết hàng)",
            "Hãng sản xuất "});
            this.searchModeComboBox.Location = new System.Drawing.Point(111, 12);
            this.searchModeComboBox.Name = "searchModeComboBox";
            this.searchModeComboBox.Size = new System.Drawing.Size(121, 24);
            this.searchModeComboBox.TabIndex = 32;
            this.searchModeComboBox.SelectedIndexChanged += new System.EventHandler(this.searchModeComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tìm kiếm theo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.giamGiaNumericUpDown);
            this.panel3.Controls.Add(this.matHangComboBox);
            this.panel3.Controls.Add(this.nhapHangButton);
            this.panel3.Controls.Add(this.quayHangComboBox);
            this.panel3.Controls.Add(this.maQHTextBox2);
            this.panel3.Controls.Add(this.maSPTextBox);
            this.panel3.Controls.Add(this.deleteButton2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.changeButton2);
            this.panel3.Controls.Add(this.tenSPTextBox);
            this.panel3.Controls.Add(this.addButton2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.giaTextBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.doanhSoTextBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.nsxTextBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ttinTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.trangThaiTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(303, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 171);
            this.panel3.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(608, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "%";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // giamGiaNumericUpDown
            // 
            this.giamGiaNumericUpDown.Location = new System.Drawing.Point(519, 36);
            this.giamGiaNumericUpDown.Name = "giamGiaNumericUpDown";
            this.giamGiaNumericUpDown.Size = new System.Drawing.Size(82, 22);
            this.giamGiaNumericUpDown.TabIndex = 25;
            // 
            // matHangComboBox
            // 
            this.matHangComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matHangComboBox.FormattingEnabled = true;
            this.matHangComboBox.Location = new System.Drawing.Point(273, 7);
            this.matHangComboBox.Name = "matHangComboBox";
            this.matHangComboBox.Size = new System.Drawing.Size(97, 24);
            this.matHangComboBox.TabIndex = 24;
            this.matHangComboBox.Visible = false;
            // 
            // nhapHangButton
            // 
            this.nhapHangButton.Location = new System.Drawing.Point(832, 117);
            this.nhapHangButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapHangButton.Name = "nhapHangButton";
            this.nhapHangButton.Size = new System.Drawing.Size(94, 46);
            this.nhapHangButton.TabIndex = 23;
            this.nhapHangButton.Text = "Cập  nhật";
            this.nhapHangButton.UseVisualStyleBackColor = true;
            this.nhapHangButton.Click += new System.EventHandler(this.nhapHangButton_Click);
            // 
            // quayHangComboBox
            // 
            this.quayHangComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quayHangComboBox.FormattingEnabled = true;
            this.quayHangComboBox.Location = new System.Drawing.Point(519, 72);
            this.quayHangComboBox.Name = "quayHangComboBox";
            this.quayHangComboBox.Size = new System.Drawing.Size(249, 24);
            this.quayHangComboBox.TabIndex = 22;
            this.quayHangComboBox.SelectedIndexChanged += new System.EventHandler(this.quayHangComboBox_SelectedIndexChanged);
            // 
            // QuayHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuayHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuayHang";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.searchGiaPanel.ResumeLayout(false);
            this.searchGiaPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button changeButton1;
        private System.Windows.Forms.Button deleteButton1;
        private System.Windows.Forms.Button searchButton2;
        private System.Windows.Forms.TextBox searchTextBox2;
        private System.Windows.Forms.TextBox maQHTextBox;
        private System.Windows.Forms.TextBox tenQHTextBox;
        private System.Windows.Forms.Label maNVLabel;
        private System.Windows.Forms.Label tenNVLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox maSPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenSPTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox giaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maQHTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doanhSoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nsxTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ttinTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox trangThaiTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.Button changeButton2;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQuay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQuay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanhso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangsx;
        private System.Windows.Forms.ComboBox quayHangComboBox;
        private System.Windows.Forms.ComboBox searchModeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel searchGiaPanel;
        private System.Windows.Forms.TextBox searchGiaTextBox2;
        private System.Windows.Forms.TextBox searchGiaTextBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button nhapHangButton;
        private System.Windows.Forms.ComboBox matHangComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown giamGiaNumericUpDown;
    }
}