namespace NhaTroBoTu
{
    partial class ThemKhachHang
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
            this.dataThemKhach = new System.Windows.Forms.DataGridView();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThemSDTKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThemMAKH = new System.Windows.Forms.TextBox();
            this.dtThemKH = new System.Windows.Forms.DateTimePicker();
            this.rdThemNUKH = new System.Windows.Forms.RadioButton();
            this.rdThemNamKH = new System.Windows.Forms.RadioButton();
            this.txThemCCCDKH = new System.Windows.Forms.TextBox();
            this.txtThemTENKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdThemKhacKH = new System.Windows.Forms.RadioButton();
<<<<<<< Updated upstream
            this.khachThueTroTableAdapter = new NhaTroBoTu.QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.quanLyPhongTroBoTuDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.qlyTroBoTuDataSet = new NhaTroBoTu.QlyTroBoTuDataSet();
            this.khachThueTroBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroTableAdapter2 = new NhaTroBoTu.QlyTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.btnCancelKH = new System.Windows.Forms.Button();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)(this.dataThemKhach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataThemKhach
            // 
            this.dataThemKhach.AllowUserToDeleteRows = false;
            this.dataThemKhach.AllowUserToResizeColumns = false;
            this.dataThemKhach.AllowUserToResizeRows = false;
            this.dataThemKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            this.dataThemKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.gioiTinhKHDataGridViewTextBoxColumn,
            this.diaChiKHDataGridViewTextBoxColumn,
            this.sDTKHDataGridViewTextBoxColumn,
            this.cCCDDataGridViewTextBoxColumn,
            this.ngaySinhKHDataGridViewTextBoxColumn});
            this.dataThemKhach.DataSource = this.khachThueTroBindingSource5;
            this.dataThemKhach.Location = new System.Drawing.Point(323, 62);
=======
            this.dataThemKhach.Location = new System.Drawing.Point(431, 76);
            this.dataThemKhach.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> Stashed changes
            this.dataThemKhach.Name = "dataThemKhach";
            this.dataThemKhach.RowHeadersWidth = 51;
            this.dataThemKhach.RowTemplate.Height = 25;
            this.dataThemKhach.Size = new System.Drawing.Size(899, 284);
            this.dataThemKhach.TabIndex = 32;
            this.dataThemKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(117, 368);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(91, 47);
            this.btnThemKH.TabIndex = 30;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(472, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 62);
            this.label6.TabIndex = 29;
            this.label6.Text = "Thêm Khách Thuê Trọ";
            // 
            // txtThemSDTKH
            // 
            this.txtThemSDTKH.Location = new System.Drawing.Point(92, 173);
            this.txtThemSDTKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtThemSDTKH.Name = "txtThemSDTKH";
            this.txtThemSDTKH.Size = new System.Drawing.Size(245, 22);
            this.txtThemSDTKH.TabIndex = 40;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(92, 144);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(245, 22);
            this.txtDiaChiKH.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(8, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "SĐT";
            // 
            // txtThemMAKH
            // 
            this.txtThemMAKH.Location = new System.Drawing.Point(92, 23);
            this.txtThemMAKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtThemMAKH.Name = "txtThemMAKH";
            this.txtThemMAKH.Size = new System.Drawing.Size(245, 22);
            this.txtThemMAKH.TabIndex = 37;
            // 
            // dtThemKH
            // 
            this.dtThemKH.Location = new System.Drawing.Point(115, 236);
            this.dtThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.dtThemKH.Name = "dtThemKH";
            this.dtThemKH.Size = new System.Drawing.Size(228, 22);
            this.dtThemKH.TabIndex = 36;
            // 
            // rdThemNUKH
            // 
            this.rdThemNUKH.AutoSize = true;
            this.rdThemNUKH.Location = new System.Drawing.Point(191, 111);
            this.rdThemNUKH.Margin = new System.Windows.Forms.Padding(4);
            this.rdThemNUKH.Name = "rdThemNUKH";
            this.rdThemNUKH.Size = new System.Drawing.Size(45, 20);
            this.rdThemNUKH.TabIndex = 35;
            this.rdThemNUKH.TabStop = true;
            this.rdThemNUKH.Text = "Nữ";
            this.rdThemNUKH.UseVisualStyleBackColor = true;
            // 
            // rdThemNamKH
            // 
            this.rdThemNamKH.AutoSize = true;
            this.rdThemNamKH.Location = new System.Drawing.Point(123, 111);
            this.rdThemNamKH.Margin = new System.Windows.Forms.Padding(4);
            this.rdThemNamKH.Name = "rdThemNamKH";
            this.rdThemNamKH.Size = new System.Drawing.Size(60, 20);
            this.rdThemNamKH.TabIndex = 34;
            this.rdThemNamKH.TabStop = true;
            this.rdThemNamKH.Text = "Nam ";
            this.rdThemNamKH.UseVisualStyleBackColor = true;
            // 
            // txThemCCCDKH
            // 
            this.txThemCCCDKH.Location = new System.Drawing.Point(92, 204);
            this.txThemCCCDKH.Margin = new System.Windows.Forms.Padding(4);
            this.txThemCCCDKH.Name = "txThemCCCDKH";
            this.txThemCCCDKH.Size = new System.Drawing.Size(245, 22);
            this.txThemCCCDKH.TabIndex = 33;
            // 
            // txtThemTENKH
            // 
            this.txtThemTENKH.Location = new System.Drawing.Point(92, 66);
            this.txtThemTENKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtThemTENKH.Name = "txtThemTENKH";
            this.txtThemTENKH.Size = new System.Drawing.Size(245, 22);
            this.txtThemTENKH.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Giới Tính ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label7.Location = new System.Drawing.Point(9, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Năm Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(3, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.Location = new System.Drawing.Point(8, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "CCCD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThemSDTKH);
            this.groupBox1.Controls.Add(this.txtDiaChiKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtThemMAKH);
            this.groupBox1.Controls.Add(this.dtThemKH);
            this.groupBox1.Controls.Add(this.rdThemKhacKH);
            this.groupBox1.Controls.Add(this.rdThemNUKH);
            this.groupBox1.Controls.Add(this.rdThemNamKH);
            this.groupBox1.Controls.Add(this.txThemCCCDKH);
            this.groupBox1.Controls.Add(this.txtThemTENKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(37, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(356, 284);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách";
            // 
            // rdThemKhacKH
            // 
            this.rdThemKhacKH.AutoSize = true;
            this.rdThemKhacKH.Location = new System.Drawing.Point(251, 112);
            this.rdThemKhacKH.Margin = new System.Windows.Forms.Padding(4);
            this.rdThemKhacKH.Name = "rdThemKhacKH";
            this.rdThemKhacKH.Size = new System.Drawing.Size(58, 20);
            this.rdThemKhacKH.TabIndex = 35;
            this.rdThemKhacKH.TabStop = true;
            this.rdThemKhacKH.Text = "Khác";
            this.rdThemKhacKH.UseVisualStyleBackColor = true;
            // 
<<<<<<< Updated upstream
            // khachThueTroTableAdapter
            // 
            this.khachThueTroTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyPhongTroBoTuDataSet1
            // 
            // 
            // khachThueTroBindingSource1
            // 
            // 
            // khachThueTroTableAdapter1
            // 
            // 
            // 
            // 
            // 
            // qlyTroBoTuDataSet
            // 
            this.qlyTroBoTuDataSet.DataSetName = "QlyTroBoTuDataSet";
            this.qlyTroBoTuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khachThueTroBindingSource5
            // 
            this.khachThueTroBindingSource5.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource5.DataSource = this.qlyTroBoTuDataSet;
            // 
            // khachThueTroTableAdapter2
            // 
            this.khachThueTroTableAdapter2.ClearBeforeFill = true;
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            // 
            // gioiTinhKHDataGridViewTextBoxColumn
            // 
            this.gioiTinhKHDataGridViewTextBoxColumn.DataPropertyName = "GioiTinhKH";
            this.gioiTinhKHDataGridViewTextBoxColumn.HeaderText = "GioiTinhKH";
            this.gioiTinhKHDataGridViewTextBoxColumn.Name = "gioiTinhKHDataGridViewTextBoxColumn";
            // 
            // diaChiKHDataGridViewTextBoxColumn
            // 
            this.diaChiKHDataGridViewTextBoxColumn.DataPropertyName = "DiaChiKH";
            this.diaChiKHDataGridViewTextBoxColumn.HeaderText = "DiaChiKH";
            this.diaChiKHDataGridViewTextBoxColumn.Name = "diaChiKHDataGridViewTextBoxColumn";
            // 
            // sDTKHDataGridViewTextBoxColumn
            // 
            this.sDTKHDataGridViewTextBoxColumn.DataPropertyName = "SDTKH";
            this.sDTKHDataGridViewTextBoxColumn.HeaderText = "SDTKH";
            this.sDTKHDataGridViewTextBoxColumn.Name = "sDTKHDataGridViewTextBoxColumn";
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            // 
            // ngaySinhKHDataGridViewTextBoxColumn
            // 
            this.ngaySinhKHDataGridViewTextBoxColumn.DataPropertyName = "NgaySinhKH";
            this.ngaySinhKHDataGridViewTextBoxColumn.HeaderText = "NgaySinhKH";
            this.ngaySinhKHDataGridViewTextBoxColumn.Name = "ngaySinhKHDataGridViewTextBoxColumn";
=======
            // btnCancelKH
            // 
            this.btnCancelKH.Location = new System.Drawing.Point(228, 368);
            this.btnCancelKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelKH.Name = "btnCancelKH";
            this.btnCancelKH.Size = new System.Drawing.Size(85, 47);
            this.btnCancelKH.TabIndex = 31;
            this.btnCancelKH.Text = "Hủy";
            this.btnCancelKH.UseVisualStyleBackColor = true;
            this.btnCancelKH.Click += new System.EventHandler(this.btnCancelKH_Click);
>>>>>>> Stashed changes
            // 
            // ThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataThemKhach);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.btnCancelKH);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemKhachHang";
            this.Text = "ThemKhachHang";
            this.Load += new System.EventHandler(this.ThemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataThemKhach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataThemKhach;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnCancelKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThemSDTKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThemMAKH;
        private System.Windows.Forms.DateTimePicker dtThemKH;
        private System.Windows.Forms.RadioButton rdThemNUKH;
        private System.Windows.Forms.RadioButton rdThemNamKH;
        private System.Windows.Forms.TextBox txThemCCCDKH;
        private System.Windows.Forms.TextBox txtThemTENKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdThemKhacKH;
<<<<<<< Updated upstream
        private System.Windows.Forms.BindingSource quanLyPhongTroBoTuDataSetBindingSource;
        private QuanLyPhongTroBoTuDataSet quanLyPhongTroBoTuDataSet;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource;
        private QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource2;
        private System.Windows.Forms.BindingSource quanLyPhongTroBoTuDataSetBindingSource1;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource3;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource4;
        private QlyTroBoTuDataSet qlyTroBoTuDataSet;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource5;
        private QlyTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhKHDataGridViewTextBoxColumn;
=======
>>>>>>> Stashed changes
    }
}