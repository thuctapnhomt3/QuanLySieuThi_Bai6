namespace QuanLySieuThi
{
    partial class frmInHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ThucTapCSDL2DataSet = new QuanLySieuThi.ThucTapCSDL2DataSet();
            this.InHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InHoaDonTableAdapter = new QuanLySieuThi.ThucTapCSDL2DataSetTableAdapters.InHoaDonTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ThucTapCSDL2DataSet
            // 
            this.ThucTapCSDL2DataSet.DataSetName = "ThucTapCSDL2DataSet";
            this.ThucTapCSDL2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InHoaDonBindingSource
            // 
            this.InHoaDonBindingSource.DataMember = "InHoaDon";
            this.InHoaDonBindingSource.DataSource = this.ThucTapCSDL2DataSet;
            // 
            // InHoaDonTableAdapter
            // 
            this.InHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.InHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.rpFull.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(939, 443);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 443);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInHoaDon";
            this.Text = "frmInHoaDon";
            this.Load += new System.EventHandler(this.frmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource InHoaDonBindingSource;
        private ThucTapCSDL2DataSet ThucTapCSDL2DataSet;
        private ThucTapCSDL2DataSetTableAdapters.InHoaDonTableAdapter InHoaDonTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}