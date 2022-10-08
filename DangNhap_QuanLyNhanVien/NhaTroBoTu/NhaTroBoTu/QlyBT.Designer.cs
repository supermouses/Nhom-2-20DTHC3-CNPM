namespace NhaTroBoTu
{
    partial class QlyBT
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimBT = new System.Windows.Forms.Button();
            this.btnSuaBT = new System.Windows.Forms.Button();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.btnXoaBT = new System.Windows.Forms.Button();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.btnThemBT = new System.Windows.Forms.Button();
            this.txtPBT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayBT = new System.Windows.Forms.DateTimePicker();
            this.dtLapPBT = new System.Windows.Forms.DateTimePicker();
            this.txtMaNVBT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataBaoTri = new System.Windows.Forms.DataGridView();
            this.maPBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapPBTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuBaoTriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlyTroBoTuDataSet = new NhaTroBoTu.QlyTroBoTuDataSet();
            this.khachThueTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroTableAdapter = new NhaTroBoTu.QlyTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.phieuBaoTriTableAdapter = new NhaTroBoTu.QlyTroBoTuDataSetTableAdapters.PhieuBaoTriTableAdapter();
            this.btnrollbackBT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBaoTriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Bảo Trì ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimBT);
            this.groupBox1.Controls.Add(this.btnSuaBT);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.btnXoaBT);
            this.groupBox1.Controls.Add(this.txtMaTN);
            this.groupBox1.Controls.Add(this.btnThemBT);
            this.groupBox1.Controls.Add(this.txtPBT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtNgayBT);
            this.groupBox1.Controls.Add(this.dtLapPBT);
            this.groupBox1.Controls.Add(this.txtMaNVBT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(64, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 271);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách";
            // 
            // btnTimBT
            // 
            this.btnTimBT.BackgroundImage = global::NhaTroBoTu.Properties.Resources.search;
            this.btnTimBT.Location = new System.Drawing.Point(310, 213);
            this.btnTimBT.Name = "btnTimBT";
            this.btnTimBT.Size = new System.Drawing.Size(48, 46);
            this.btnTimBT.TabIndex = 42;
            this.btnTimBT.UseVisualStyleBackColor = true;
            // 
            // btnSuaBT
            // 
            this.btnSuaBT.Location = new System.Drawing.Point(203, 222);
            this.btnSuaBT.Name = "btnSuaBT";
            this.btnSuaBT.Size = new System.Drawing.Size(75, 37);
            this.btnSuaBT.TabIndex = 36;
            this.btnSuaBT.Text = "Sửa";
            this.btnSuaBT.UseVisualStyleBackColor = true;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(173, 84);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(201, 20);
            this.txtMaPhong.TabIndex = 40;
            // 
            // btnXoaBT
            // 
            this.btnXoaBT.Location = new System.Drawing.Point(108, 222);
            this.btnXoaBT.Name = "btnXoaBT";
            this.btnXoaBT.Size = new System.Drawing.Size(79, 37);
            this.btnXoaBT.TabIndex = 36;
            this.btnXoaBT.Text = "Xóa";
            this.btnXoaBT.UseVisualStyleBackColor = true;
            // 
            // txtMaTN
            // 
            this.txtMaTN.Location = new System.Drawing.Point(173, 120);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(201, 20);
            this.txtMaTN.TabIndex = 41;
            // 
            // btnThemBT
            // 
            this.btnThemBT.Location = new System.Drawing.Point(11, 222);
            this.btnThemBT.Name = "btnThemBT";
            this.btnThemBT.Size = new System.Drawing.Size(79, 37);
            this.btnThemBT.TabIndex = 36;
            this.btnThemBT.Text = "Thêm";
            this.btnThemBT.UseVisualStyleBackColor = true;
            this.btnThemBT.Click += new System.EventHandler(this.btnThemBT_Click);
            // 
            // txtPBT
            // 
            this.txtPBT.Location = new System.Drawing.Point(173, 19);
            this.txtPBT.Multiline = true;
            this.txtPBT.Name = "txtPBT";
            this.txtPBT.Size = new System.Drawing.Size(201, 25);
            this.txtPBT.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã Tiện Nghi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mã Phòng ";
            // 
            // dtNgayBT
            // 
            this.dtNgayBT.Location = new System.Drawing.Point(173, 149);
            this.dtNgayBT.Name = "dtNgayBT";
            this.dtNgayBT.Size = new System.Drawing.Size(201, 20);
            this.dtNgayBT.TabIndex = 36;
            // 
            // dtLapPBT
            // 
            this.dtLapPBT.Location = new System.Drawing.Point(173, 184);
            this.dtLapPBT.Name = "dtLapPBT";
            this.dtLapPBT.Size = new System.Drawing.Size(201, 20);
            this.dtLapPBT.TabIndex = 36;
            // 
            // txtMaNVBT
            // 
            this.txtMaNVBT.Location = new System.Drawing.Point(173, 58);
            this.txtMaNVBT.Name = "txtMaNVBT";
            this.txtMaNVBT.Size = new System.Drawing.Size(201, 20);
            this.txtMaNVBT.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label7.Location = new System.Drawing.Point(6, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Ngày Lập Phiếu BT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.Location = new System.Drawing.Point(2, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã Phiếu Bảo Trì ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(2, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Mã Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ngày Bảo Trì ";
            // 
            // dataBaoTri
            // 
            this.dataBaoTri.AutoGenerateColumns = false;
            this.dataBaoTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaoTri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPBTDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.maPTDataGridViewTextBoxColumn,
            this.maTNDataGridViewTextBoxColumn,
            this.ngayBTDataGridViewTextBoxColumn,
            this.ngayLapPBTDataGridViewTextBoxColumn});
            this.dataBaoTri.DataSource = this.phieuBaoTriBindingSource;
            this.dataBaoTri.Location = new System.Drawing.Point(450, 99);
            this.dataBaoTri.Name = "dataBaoTri";
            this.dataBaoTri.RowHeadersWidth = 51;
            this.dataBaoTri.Size = new System.Drawing.Size(804, 248);
            this.dataBaoTri.TabIndex = 35;
            this.dataBaoTri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaoTri_CellContentClick);
            // 
            // maPBTDataGridViewTextBoxColumn
            // 
            this.maPBTDataGridViewTextBoxColumn.DataPropertyName = "MaPBT";
            this.maPBTDataGridViewTextBoxColumn.HeaderText = "MaPBT";
            this.maPBTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPBTDataGridViewTextBoxColumn.Name = "maPBTDataGridViewTextBoxColumn";
            this.maPBTDataGridViewTextBoxColumn.Width = 125;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPTDataGridViewTextBoxColumn
            // 
            this.maPTDataGridViewTextBoxColumn.DataPropertyName = "MaPT";
            this.maPTDataGridViewTextBoxColumn.HeaderText = "MaPT";
            this.maPTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPTDataGridViewTextBoxColumn.Name = "maPTDataGridViewTextBoxColumn";
            this.maPTDataGridViewTextBoxColumn.Width = 125;
            // 
            // maTNDataGridViewTextBoxColumn
            // 
            this.maTNDataGridViewTextBoxColumn.DataPropertyName = "MaTN";
            this.maTNDataGridViewTextBoxColumn.HeaderText = "MaTN";
            this.maTNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTNDataGridViewTextBoxColumn.Name = "maTNDataGridViewTextBoxColumn";
            this.maTNDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayBTDataGridViewTextBoxColumn
            // 
            this.ngayBTDataGridViewTextBoxColumn.DataPropertyName = "NgayBT";
            this.ngayBTDataGridViewTextBoxColumn.HeaderText = "NgayBT";
            this.ngayBTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayBTDataGridViewTextBoxColumn.Name = "ngayBTDataGridViewTextBoxColumn";
            this.ngayBTDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapPBTDataGridViewTextBoxColumn
            // 
            this.ngayLapPBTDataGridViewTextBoxColumn.DataPropertyName = "NgayLapPBT";
            this.ngayLapPBTDataGridViewTextBoxColumn.HeaderText = "NgayLapPBT";
            this.ngayLapPBTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapPBTDataGridViewTextBoxColumn.Name = "ngayLapPBTDataGridViewTextBoxColumn";
            this.ngayLapPBTDataGridViewTextBoxColumn.Width = 125;
            // 
            // phieuBaoTriBindingSource
            // 
            this.phieuBaoTriBindingSource.DataMember = "PhieuBaoTri";
            this.phieuBaoTriBindingSource.DataSource = this.qlyTroBoTuDataSet;
            // 
            // qlyTroBoTuDataSet
            // 
            this.qlyTroBoTuDataSet.DataSetName = "QlyTroBoTuDataSet";
            this.qlyTroBoTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachThueTroBindingSource
            // 
            this.khachThueTroBindingSource.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource.DataSource = this.qlyTroBoTuDataSet;
            // 
            // khachThueTroTableAdapter
            // 
            this.khachThueTroTableAdapter.ClearBeforeFill = true;
            // 
            // phieuBaoTriTableAdapter
            // 
            this.phieuBaoTriTableAdapter.ClearBeforeFill = true;
            // 
            // btnrollbackBT
            // 
            this.btnrollbackBT.AutoSize = true;
            this.btnrollbackBT.BackgroundImage = global::NhaTroBoTu.Properties.Resources.back_2;
            this.btnrollbackBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnrollbackBT.Location = new System.Drawing.Point(1186, 353);
            this.btnrollbackBT.Name = "btnrollbackBT";
            this.btnrollbackBT.Size = new System.Drawing.Size(61, 54);
            this.btnrollbackBT.TabIndex = 36;
            this.btnrollbackBT.UseVisualStyleBackColor = true;
            this.btnrollbackBT.Click += new System.EventHandler(this.btnrollbackBT_Click);
            // 
            // QlyBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 411);
            this.Controls.Add(this.btnrollbackBT);
            this.Controls.Add(this.dataBaoTri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QlyBT";
            this.Text = "QlyBT";
            this.Load += new System.EventHandler(this.QlyBT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuBaoTriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.TextBox txtPBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayBT;
        private System.Windows.Forms.DateTimePicker dtLapPBT;
        private System.Windows.Forms.TextBox txtMaNVBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataBaoTri;
        private QlyTroBoTuDataSet qlyTroBoTuDataSet;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource;
        private QlyTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter;
        private System.Windows.Forms.BindingSource phieuBaoTriBindingSource;
        private QlyTroBoTuDataSetTableAdapters.PhieuBaoTriTableAdapter phieuBaoTriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapPBTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnThemBT;
        private System.Windows.Forms.Button btnXoaBT;
        private System.Windows.Forms.Button btnSuaBT;
        private System.Windows.Forms.Button btnTimBT;
        private System.Windows.Forms.Button btnrollbackBT;
    }
}