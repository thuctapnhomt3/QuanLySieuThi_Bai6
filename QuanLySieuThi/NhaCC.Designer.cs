namespace QuanLySieuThi
{
    partial class NhaCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MHCCButton = new System.Windows.Forms.Button();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.sdtTextBox = new System.Windows.Forms.TextBox();
            this.tenNCCTextBox = new System.Windows.Forms.TextBox();
            this.maNCCTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MHCCButton);
            this.panel1.Controls.Add(this.diaChiTextBox);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.changeButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.sdtTextBox);
            this.panel1.Controls.Add(this.tenNCCTextBox);
            this.panel1.Controls.Add(this.maNCCTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 359);
            this.panel1.TabIndex = 1;
            // 
            // MHCCButton
            // 
            this.MHCCButton.Location = new System.Drawing.Point(17, 211);
            this.MHCCButton.Name = "MHCCButton";
            this.MHCCButton.Size = new System.Drawing.Size(166, 45);
            this.MHCCButton.TabIndex = 4;
            this.MHCCButton.Text = "Mặt hàng đã cung cấp";
            this.MHCCButton.UseVisualStyleBackColor = true;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(17, 172);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(254, 22);
            this.diaChiTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 298);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 46);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Thêm";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(101, 298);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(82, 46);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Sửa";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(189, 298);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 46);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // sdtTextBox
            // 
            this.sdtTextBox.Location = new System.Drawing.Point(17, 118);
            this.sdtTextBox.Name = "sdtTextBox";
            this.sdtTextBox.Size = new System.Drawing.Size(254, 22);
            this.sdtTextBox.TabIndex = 3;
            this.sdtTextBox.TextChanged += new System.EventHandler(this.sdtTextBox_TextChanged);
            this.sdtTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sdtTextBox_KeyPress);
            // 
            // tenNCCTextBox
            // 
            this.tenNCCTextBox.Location = new System.Drawing.Point(17, 64);
            this.tenNCCTextBox.Name = "tenNCCTextBox";
            this.tenNCCTextBox.Size = new System.Drawing.Size(254, 22);
            this.tenNCCTextBox.TabIndex = 3;
            // 
            // maNCCTextBox
            // 
            this.maNCCTextBox.ForeColor = System.Drawing.Color.Gray;
            this.maNCCTextBox.Location = new System.Drawing.Point(137, 11);
            this.maNCCTextBox.Name = "maNCCTextBox";
            this.maNCCTextBox.Size = new System.Drawing.Size(134, 22);
            this.maNCCTextBox.TabIndex = 3;
            this.maNCCTextBox.Text = "NCCxx";
            this.maNCCTextBox.TextChanged += new System.EventHandler(this.maNCCTextBox_TextChanged);
            this.maNCCTextBox.Enter += new System.EventHandler(this.maNCCTextBox_Enter);
            this.maNCCTextBox.Leave += new System.EventHandler(this.maNCCTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "tên nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Location = new System.Drawing.Point(304, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 359);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNCC,
            this.tenNCC,
            this.sdt,
            this.diachi});
            this.dataGridView1.Location = new System.Drawing.Point(17, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(407, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maNCC
            // 
            this.maNCC.DataPropertyName = "maNCC";
            this.maNCC.HeaderText = "Mã nhà cung cấp";
            this.maNCC.Name = "maNCC";
            this.maNCC.ReadOnly = true;
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "tenNCC";
            this.tenNCC.HeaderText = "Tên nhà cung cấp";
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(342, 5);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(82, 46);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Tìm kiếm";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(17, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(298, 22);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // NhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhaCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhaCC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox tenNCCTextBox;
        private System.Windows.Forms.TextBox maNCCTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sdtTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.Button MHCCButton;
    }
}