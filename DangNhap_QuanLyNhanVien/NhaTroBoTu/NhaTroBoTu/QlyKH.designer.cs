using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp1
{
    partial class QlyKH
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< Updated upstream
            this.khachThueTroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongTroBoTuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyPhongTroBoTuDataSet = new NhaTroBoTu.QuanLyPhongTroBoTuDataSet();
=======
>>>>>>> Stashed changes
            this.btnThoatKH = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dtKH = new System.Windows.Forms.DateTimePicker();
            this.rdKhacKH = new System.Windows.Forms.RadioButton();
            this.rdNuKH = new System.Windows.Forms.RadioButton();
            this.rdNamKH = new System.Windows.Forms.RadioButton();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemKH = new System.Windows.Forms.Button();
<<<<<<< Updated upstream
            this.khachThueTroTableAdapter = new NhaTroBoTu.QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.qlyTroBoTuDataSet = new NhaTroBoTu.QlyTroBoTuDataSet();
            this.qlyTroBoTuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.khachThueTroTableAdapter1 = new NhaTroBoTu.QlyTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKHDataGridViewTextBoxColumn,
            this.tenKHDataGridViewTextBoxColumn,
            this.gioiTinhKHDataGridViewTextBoxColumn,
            this.diaChiKHDataGridViewTextBoxColumn,
            this.sDTKHDataGridViewTextBoxColumn,
            this.cCCDDataGridViewTextBoxColumn,
            this.ngaySinhKHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.khachThueTroBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
=======
            this.dataGridView1.Location = new System.Drawing.Point(16, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> Stashed changes
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 324);
            this.dataGridView1.TabIndex = 28;
<<<<<<< Updated upstream
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
=======
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
>>>>>>> Stashed changes
            // 
            // btnThoatKH
            // 
            this.btnThoatKH.Location = new System.Drawing.Point(1089, 428);
            this.btnThoatKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoatKH.Name = "btnThoatKH";
            this.btnThoatKH.Size = new System.Drawing.Size(96, 37);
            this.btnThoatKH.TabIndex = 20;
            this.btnThoatKH.Text = "Thoát ";
            this.btnThoatKH.UseVisualStyleBackColor = true;
            this.btnThoatKH.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(321, 406);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 59);
            this.button4.TabIndex = 19;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(229, 406);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 59);
            this.button3.TabIndex = 23;
            this.button3.Text = "Sửa ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 406);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 59);
            this.button2.TabIndex = 18;
            this.button2.Text = "Xóa ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(268, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 62);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quản Lý Khách Thuê Trọ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDTKH);
            this.groupBox1.Controls.Add(this.txtDiaChiKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.dtKH);
            this.groupBox1.Controls.Add(this.rdKhacKH);
            this.groupBox1.Controls.Add(this.rdNuKH);
            this.groupBox1.Controls.Add(this.rdNamKH);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(531, 475);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(356, 284);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(80, 140);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(257, 22);
            this.txtSDTKH.TabIndex = 40;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(92, 172);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(92, 23);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(245, 22);
            this.txtMaKH.TabIndex = 37;
            // 
            // dtKH
            // 
            this.dtKH.CustomFormat = "dd/MM/yyyy";
            this.dtKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKH.Location = new System.Drawing.Point(115, 236);
            this.dtKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtKH.Name = "dtKH";
            this.dtKH.Size = new System.Drawing.Size(228, 22);
            this.dtKH.TabIndex = 36;
            // 
            // rdKhacKH
            // 
            this.rdKhacKH.AutoSize = true;
            this.rdKhacKH.Location = new System.Drawing.Point(251, 112);
            this.rdKhacKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdKhacKH.Name = "rdKhacKH";
<<<<<<< Updated upstream
            this.rdKhacKH.Size = new System.Drawing.Size(56, 19);
=======
            this.rdKhacKH.Size = new System.Drawing.Size(58, 20);
>>>>>>> Stashed changes
            this.rdKhacKH.TabIndex = 35;
            this.rdKhacKH.TabStop = true;
            this.rdKhacKH.Text = "Khác";
            this.rdKhacKH.UseVisualStyleBackColor = true;
            // 
            // rdNuKH
            // 
            this.rdNuKH.AutoSize = true;
            this.rdNuKH.Location = new System.Drawing.Point(191, 111);
            this.rdNuKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNuKH.Name = "rdNuKH";
<<<<<<< Updated upstream
            this.rdNuKH.Size = new System.Drawing.Size(44, 19);
=======
            this.rdNuKH.Size = new System.Drawing.Size(45, 20);
>>>>>>> Stashed changes
            this.rdNuKH.TabIndex = 35;
            this.rdNuKH.TabStop = true;
            this.rdNuKH.Text = "Nữ";
            this.rdNuKH.UseVisualStyleBackColor = true;
            // 
            // rdNamKH
            // 
            this.rdNamKH.AutoSize = true;
            this.rdNamKH.Location = new System.Drawing.Point(123, 111);
            this.rdNamKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNamKH.Name = "rdNamKH";
<<<<<<< Updated upstream
            this.rdNamKH.Size = new System.Drawing.Size(58, 19);
=======
            this.rdNamKH.Size = new System.Drawing.Size(60, 20);
>>>>>>> Stashed changes
            this.rdNamKH.TabIndex = 34;
            this.rdNamKH.TabStop = true;
            this.rdNamKH.Text = "Nam ";
            this.rdNamKH.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(80, 204);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(257, 22);
            this.txtCCCD.TabIndex = 33;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(92, 66);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(245, 22);
            this.txtTenKH.TabIndex = 32;
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
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(47, 406);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(85, 59);
            this.btnThemKH.TabIndex = 18;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
<<<<<<< Updated upstream
            // khachThueTroTableAdapter
            // 
            this.khachThueTroTableAdapter.ClearBeforeFill = true;
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
            // khachThueTroBindingSource1
            // 
            this.khachThueTroBindingSource1.DataMember = "KhachThueTro";
            this.khachThueTroBindingSource1.DataSource = this.qlyTroBoTuDataSetBindingSource;
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
            this.maKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenKHDataGridViewTextBoxColumn
            // 
            this.tenKHDataGridViewTextBoxColumn.DataPropertyName = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.HeaderText = "TenKH";
            this.tenKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKHDataGridViewTextBoxColumn.Name = "tenKHDataGridViewTextBoxColumn";
            this.tenKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhKHDataGridViewTextBoxColumn
            // 
            this.gioiTinhKHDataGridViewTextBoxColumn.DataPropertyName = "GioiTinhKH";
            this.gioiTinhKHDataGridViewTextBoxColumn.HeaderText = "GioiTinhKH";
            this.gioiTinhKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhKHDataGridViewTextBoxColumn.Name = "gioiTinhKHDataGridViewTextBoxColumn";
            this.gioiTinhKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiKHDataGridViewTextBoxColumn
            // 
            this.diaChiKHDataGridViewTextBoxColumn.DataPropertyName = "DiaChiKH";
            this.diaChiKHDataGridViewTextBoxColumn.HeaderText = "DiaChiKH";
            this.diaChiKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiKHDataGridViewTextBoxColumn.Name = "diaChiKHDataGridViewTextBoxColumn";
            this.diaChiKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTKHDataGridViewTextBoxColumn
            // 
            this.sDTKHDataGridViewTextBoxColumn.DataPropertyName = "SDTKH";
            this.sDTKHDataGridViewTextBoxColumn.HeaderText = "SDTKH";
            this.sDTKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTKHDataGridViewTextBoxColumn.Name = "sDTKHDataGridViewTextBoxColumn";
            this.sDTKHDataGridViewTextBoxColumn.Width = 125;
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            this.cCCDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhKHDataGridViewTextBoxColumn
            // 
            this.ngaySinhKHDataGridViewTextBoxColumn.DataPropertyName = "NgaySinhKH";
            this.ngaySinhKHDataGridViewTextBoxColumn.HeaderText = "NgaySinhKH";
            this.ngaySinhKHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhKHDataGridViewTextBoxColumn.Name = "ngaySinhKHDataGridViewTextBoxColumn";
            this.ngaySinhKHDataGridViewTextBoxColumn.Width = 125;
            // 
=======
>>>>>>> Stashed changes
            // QlyKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThoatKH);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QlyKH";
            this.Text = "Quản Lý Khách Thuê Trọ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlyTroBoTuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachThueTroBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnThoatKH;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label6;
        private GroupBox groupBox1;
        private DateTimePicker dtKH;
        private RadioButton rdNuKH;
        private RadioButton rdNamKH;
        private TextBox txtCCCD;
        private TextBox txtTenKH;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label3;
        private TextBox txtMaKH;
        private Label label1;
        private Button btnThemKH;
        private RadioButton rdKhacKH;
        private TextBox txtSDTKH;
        private TextBox txtDiaChiKH;
        private Label label2;
        private Label label4;
<<<<<<< Updated upstream
        private BindingSource quanLyPhongTroBoTuDataSetBindingSource;
        private NhaTroBoTu.QuanLyPhongTroBoTuDataSet quanLyPhongTroBoTuDataSet;
        private BindingSource khachThueTroBindingSource;
        private NhaTroBoTu.QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter;
        private BindingSource qlyTroBoTuDataSetBindingSource;
        private NhaTroBoTu.QlyTroBoTuDataSet qlyTroBoTuDataSet;
        private BindingSource khachThueTroBindingSource1;
        private NhaTroBoTu.QlyTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter1;
        private DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gioiTinhKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaChiKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDTKHDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaySinhKHDataGridViewTextBoxColumn;
=======
        //private BindingSource quanLyPhongTroBoTuDataSetBindingSource;
        //private NhaTroBoTu.QuanLyPhongTroBoTuDataSet quanLyPhongTroBoTuDataSet;
        //private BindingSource khachThueTroBindingSource;
        //private NhaTroBoTu.QuanLyPhongTroBoTuDataSetTableAdapters.KhachThueTroTableAdapter khachThueTroTableAdapter;
        //private DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn gIOITINHDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn dCDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
        //private DataGridViewTextBoxColumn nAMSINHDataGridViewTextBoxColumn;
>>>>>>> Stashed changes
    }
}