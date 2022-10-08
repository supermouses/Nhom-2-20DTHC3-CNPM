namespace NhaTroBoTu
{
    partial class TimKiemKhachHang
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataTimKhach = new System.Windows.Forms.DataGridView();
            this.khachThueTroBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongTroBoTuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongTroBoTuDataSet = new NhaTroBoTu.QuanLyPhongTroBoTuDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.khachThueTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroTableAdapter = new NhaTroBoTu.QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.khachThueTroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qlyTroBoTuDataSet = new NhaTroBoTu.QlyTroBoTuDataSet();
            this.qlyTroBoTuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroTableAdapter1 = new NhaTroBoTu.QlyTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTimKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(389, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(439, 62);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tìm Khách Thuê Trọ";
            // 
            // dataTimKhach
            // 
            this.dataTimKhach.AllowUserToAddRows = false;
            this.dataTimKhach.AllowUserToDeleteRows = false;
            this.dataTimKhach.AutoGenerateColumns = false;
            this.dataTimKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTimKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.gioiTinhKHDataGridViewTextBoxColumn,
            this.diaChiKHDataGridViewTextBoxColumn,
            this.sDTKHDataGridViewTextBoxColumn,
            this.cCCDDataGridViewTextBoxColumn,
            this.ngaySinhKHDataGridViewTextBoxColumn});
            this.dataTimKhach.DataSource = this.khachThueTroBindingSource3;
            this.dataTimKhach.Location = new System.Drawing.Point(211, 131);
            this.dataTimKhach.Name = "dataTimKhach";
            this.dataTimKhach.ReadOnly = true;
            this.dataTimKhach.RowHeadersWidth = 51;
            this.dataTimKhach.Size = new System.Drawing.Size(745, 267);
            this.dataTimKhach.TabIndex = 36;
            this.dataTimKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTimKhach_CellContentClick);
            // 
            // khachThueTroBindingSource2
            // 
            this.khachThueTroBindingSource2.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource2.DataSource = this.quanLyPhongTroBoTuDataSetBindingSource;
            // 
            // quanLyPhongTroBoTuDataSetBindingSource
            // 
            this.quanLyPhongTroBoTuDataSetBindingSource.DataSource = this.quanLyPhongTroBoTuDataSet;
            this.quanLyPhongTroBoTuDataSetBindingSource.Position = 0;
            // 
            // quanLyPhongTroBoTuDataSet
            // 
            this.quanLyPhongTroBoTuDataSet.DataSetName = "QuanLyPhongTroBoTuDataSet";
            this.quanLyPhongTroBoTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.rdTen);
            this.groupBox1.Controls.Add(this.rdMa);
            this.groupBox1.Controls.Add(this.btnTimKiemKH);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(236, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 63);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Khách Hàng";
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(162, 23);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(49, 19);
            this.rdTen.TabIndex = 5;
            this.rdTen.TabStop = true;
            this.rdTen.Text = "Tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Location = new System.Drawing.Point(108, 25);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(46, 19);
            this.rdMa.TabIndex = 4;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Mã";
            this.rdMa.UseVisualStyleBackColor = true;
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Location = new System.Drawing.Point(534, 23);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemKH.TabIndex = 3;
            this.btnTimKiemKH.Text = "Tìm Kiếm ";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(356, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(172, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ Tìm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Theo";
            // 
            // khachThueTroBindingSource
            // 
            this.khachThueTroBindingSource.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource.DataSource = this.quanLyPhongTroBoTuDataSetBindingSource;
            // 
            // khachThueTroTableAdapter
            // 
            this.khachThueTroTableAdapter.ClearBeforeFill = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(979, 352);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(78, 61);
            this.btnQuayLai.TabIndex = 38;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // khachThueTroBindingSource1
            // 
            this.khachThueTroBindingSource1.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource1.DataSource = this.quanLyPhongTroBoTuDataSetBindingSource;
            // 
            // qlyTroBoTuDataSet
            // 
            this.qlyTroBoTuDataSet.DataSetName = "QlyTroBoTuDataSet";
            this.qlyTroBoTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qlyTroBoTuDataSetBindingSource
            // 
            this.qlyTroBoTuDataSetBindingSource.DataSource = this.qlyTroBoTuDataSet;
            this.qlyTroBoTuDataSetBindingSource.Position = 0;
            // 
            // khachThueTroBindingSource3
            // 
            this.khachThueTroBindingSource3.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource3.DataSource = this.qlyTroBoTuDataSetBindingSource;
            // 
            // khachThueTroTableAdapter1
            // 
            this.khachThueTroTableAdapter1.ClearBeforeFill = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            this.maKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            this.tenKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhKHDataGridViewTextBoxColumn
            // 
            this.gioiTinhKHDataGridViewTextBoxColumn.DataPropertyName = "GioiTinhKH";
            this.gioiTinhKHDataGridViewTextBoxColumn.HeaderText = "GioiTinhKH";
            this.gioiTinhKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhKHDataGridViewTextBoxColumn.Name = "gioiTinhKHDataGridViewTextBoxColumn";
            this.gioiTinhKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioiTinhKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiKHDataGridViewTextBoxColumn
            // 
            this.diaChiKHDataGridViewTextBoxColumn.DataPropertyName = "DiaChiKH";
            this.diaChiKHDataGridViewTextBoxColumn.HeaderText = "DiaChiKH";
            this.diaChiKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiKHDataGridViewTextBoxColumn.Name = "diaChiKHDataGridViewTextBoxColumn";
            this.diaChiKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTKHDataGridViewTextBoxColumn
            // 
            this.sDTKHDataGridViewTextBoxColumn.DataPropertyName = "SDTKH";
            this.sDTKHDataGridViewTextBoxColumn.HeaderText = "SDTKH";
            this.sDTKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTKHDataGridViewTextBoxColumn.Name = "sDTKHDataGridViewTextBoxColumn";
            this.sDTKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            this.cCCDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCCDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhKHDataGridViewTextBoxColumn
            // 
            this.ngaySinhKHDataGridViewTextBoxColumn.DataPropertyName = "NgaySinhKH";
            this.ngaySinhKHDataGridViewTextBoxColumn.HeaderText = "NgaySinhKH";
            this.ngaySinhKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhKHDataGridViewTextBoxColumn.Name = "ngaySinhKHDataGridViewTextBoxColumn";
            this.ngaySinhKHDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // TimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 425);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataTimKhach);
            this.Controls.Add(this.label6);
            this.Name = "TimKiemKhachHang";
            this.Text = "TimKiemKhachHang";
            this.Load += new System.EventHandler(this.TimKiemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTimKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataTimKhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource quanLyPhongTroBoTuDataSetBindingSource;
        private QuanLyPhongTroBoTuDataSet quanLyPhongTroBoTuDataSet;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource;
        private QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource1;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource2;
        private System.Windows.Forms.BindingSource qlyTroBoTuDataSetBindingSource;
        private QlyTroBoTuDataSet qlyTroBoTuDataSet;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource3;
        private QlyTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhKHDataGridViewTextBoxColumn;
    }
}