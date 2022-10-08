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
            this.components = new System.ComponentModel.Container();
            this.dataThemKhach = new System.Windows.Forms.DataGridView();
            this.khachThueTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongTroBoTuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongTroBoTuDataSet = new NhaTroBoTu.QuanLyPhongTroBoTuDataSet();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnCancelKH = new System.Windows.Forms.Button();
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
            this.khachThueTroTableAdapter = new NhaTroBoTu.QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataThemKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataThemKhach
            // 
            this.dataThemKhach.AllowUserToDeleteRows = false;
            this.dataThemKhach.AllowUserToResizeColumns = false;
            this.dataThemKhach.AllowUserToResizeRows = false;
            this.dataThemKhach.AutoGenerateColumns = false;
            this.dataThemKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThemKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHDataGridViewTextBoxColumn,
            this.tENKHDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.dCDataGridViewTextBoxColumn,
            this.cCCDDataGridViewTextBoxColumn,
            this.nAMSINHDataGridViewTextBoxColumn});
            this.dataThemKhach.DataSource = this.khachThueTroBindingSource;
            this.dataThemKhach.Location = new System.Drawing.Point(323, 62);
            this.dataThemKhach.Name = "dataThemKhach";
            this.dataThemKhach.RowTemplate.Height = 25;
            this.dataThemKhach.Size = new System.Drawing.Size(674, 231);
            this.dataThemKhach.TabIndex = 32;
            this.dataThemKhach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // khachThueTroBindingSource
            // 
            this.khachThueTroBindingSource.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource.DataSource = this.quanLyPhongTroBoTuDataSetBindingSource;
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
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(88, 299);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(68, 38);
            this.btnThemKH.TabIndex = 30;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnCancelKH
            // 
            this.btnCancelKH.Location = new System.Drawing.Point(171, 299);
            this.btnCancelKH.Name = "btnCancelKH";
            this.btnCancelKH.Size = new System.Drawing.Size(64, 38);
            this.btnCancelKH.TabIndex = 31;
            this.btnCancelKH.Text = "Hủy";
            this.btnCancelKH.UseVisualStyleBackColor = true;
            this.btnCancelKH.Click += new System.EventHandler(this.btnCancelKH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(354, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 50);
            this.label6.TabIndex = 29;
            this.label6.Text = "Thêm Khách Thuê Trọ";
            // 
            // txtThemSDTKH
            // 
            this.txtThemSDTKH.Location = new System.Drawing.Point(60, 114);
            this.txtThemSDTKH.Name = "txtThemSDTKH";
            this.txtThemSDTKH.Size = new System.Drawing.Size(194, 20);
            this.txtThemSDTKH.TabIndex = 40;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(69, 140);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(185, 20);
            this.txtDiaChiKH.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(6, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "SĐT";
            // 
            // txtThemMAKH
            // 
            this.txtThemMAKH.Location = new System.Drawing.Point(69, 19);
            this.txtThemMAKH.Name = "txtThemMAKH";
            this.txtThemMAKH.Size = new System.Drawing.Size(185, 20);
            this.txtThemMAKH.TabIndex = 37;
            // 
            // dtThemKH
            // 
            this.dtThemKH.Location = new System.Drawing.Point(86, 192);
            this.dtThemKH.Name = "dtThemKH";
            this.dtThemKH.Size = new System.Drawing.Size(172, 20);
            this.dtThemKH.TabIndex = 36;
            // 
            // rdThemNUKH
            // 
            this.rdThemNUKH.AutoSize = true;
            this.rdThemNUKH.Location = new System.Drawing.Point(143, 90);
            this.rdThemNUKH.Name = "rdThemNUKH";
            this.rdThemNUKH.Size = new System.Drawing.Size(39, 17);
            this.rdThemNUKH.TabIndex = 35;
            this.rdThemNUKH.TabStop = true;
            this.rdThemNUKH.Text = "Nữ";
            this.rdThemNUKH.UseVisualStyleBackColor = true;
            // 
            // rdThemNamKH
            // 
            this.rdThemNamKH.AutoSize = true;
            this.rdThemNamKH.Location = new System.Drawing.Point(92, 90);
            this.rdThemNamKH.Name = "rdThemNamKH";
            this.rdThemNamKH.Size = new System.Drawing.Size(50, 17);
            this.rdThemNamKH.TabIndex = 34;
            this.rdThemNamKH.TabStop = true;
            this.rdThemNamKH.Text = "Nam ";
            this.rdThemNamKH.UseVisualStyleBackColor = true;
            // 
            // txThemCCCDKH
            // 
            this.txThemCCCDKH.Location = new System.Drawing.Point(60, 166);
            this.txThemCCCDKH.Name = "txThemCCCDKH";
            this.txThemCCCDKH.Size = new System.Drawing.Size(194, 20);
            this.txThemCCCDKH.TabIndex = 33;
            // 
            // txtThemTENKH
            // 
            this.txtThemTENKH.Location = new System.Drawing.Point(69, 54);
            this.txtThemTENKH.Name = "txtThemTENKH";
            this.txtThemTENKH.Size = new System.Drawing.Size(185, 20);
            this.txtThemTENKH.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(2, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Giới Tính ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label7.Location = new System.Drawing.Point(7, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Năm Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(2, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label3.Location = new System.Drawing.Point(6, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(28, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 231);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách";
            // 
            // rdThemKhacKH
            // 
            this.rdThemKhacKH.AutoSize = true;
            this.rdThemKhacKH.Location = new System.Drawing.Point(188, 91);
            this.rdThemKhacKH.Name = "rdThemKhacKH";
            this.rdThemKhacKH.Size = new System.Drawing.Size(50, 17);
            this.rdThemKhacKH.TabIndex = 35;
            this.rdThemKhacKH.TabStop = true;
            this.rdThemKhacKH.Text = "Khác";
            this.rdThemKhacKH.UseVisualStyleBackColor = true;
            // 
            // khachThueTroTableAdapter
            // 
            this.khachThueTroTableAdapter.ClearBeforeFill = true;
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
            // 
            // gIOITINHDataGridViewTextBoxColumn
            // 
            this.gIOITINHDataGridViewTextBoxColumn.DataPropertyName = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.HeaderText = "GIOITINH";
            this.gIOITINHDataGridViewTextBoxColumn.Name = "gIOITINHDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // dCDataGridViewTextBoxColumn
            // 
            this.dCDataGridViewTextBoxColumn.DataPropertyName = "DC";
            this.dCDataGridViewTextBoxColumn.HeaderText = "DC";
            this.dCDataGridViewTextBoxColumn.Name = "dCDataGridViewTextBoxColumn";
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            // 
            // nAMSINHDataGridViewTextBoxColumn
            // 
            this.nAMSINHDataGridViewTextBoxColumn.DataPropertyName = "NAMSINH";
            this.nAMSINHDataGridViewTextBoxColumn.HeaderText = "NAMSINH";
            this.nAMSINHDataGridViewTextBoxColumn.Name = "nAMSINHDataGridViewTextBoxColumn";
            // 
            // ThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataThemKhach);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.btnCancelKH);
            this.Controls.Add(this.label6);
            this.Name = "ThemKhachHang";
            this.Text = "ThemKhachHang";
            this.Load += new System.EventHandler(this.ThemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataThemKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyPhongTroBoTuDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource quanLyPhongTroBoTuDataSetBindingSource;
        private QuanLyPhongTroBoTuDataSet quanLyPhongTroBoTuDataSet;
        private System.Windows.Forms.BindingSource khachThueTroBindingSource;
        private QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMSINHDataGridViewTextBoxColumn;
    }
}