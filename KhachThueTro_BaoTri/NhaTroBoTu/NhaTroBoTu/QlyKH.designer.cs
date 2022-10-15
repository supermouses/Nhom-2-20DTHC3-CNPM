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
            this.btnThoatKH = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 150);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1233, 249);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnThoatKH
            // 
            this.btnThoatKH.Location = new System.Drawing.Point(1106, 451);
            this.btnThoatKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoatKH.Name = "btnThoatKH";
            this.btnThoatKH.Size = new System.Drawing.Size(96, 37);
            this.btnThoatKH.TabIndex = 20;
            this.btnThoatKH.Text = "Thoát ";
            this.btnThoatKH.UseVisualStyleBackColor = true;
            this.btnThoatKH.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(849, 407);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 59);
            this.button4.TabIndex = 19;
            this.button4.Text = "Tìm Kiếm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(757, 407);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 59);
            this.button3.TabIndex = 23;
            this.button3.Text = "Sửa ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 407);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
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
            this.label6.Location = new System.Drawing.Point(361, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 62);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quản Lý Khách Thuê Trọ";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(372, 78);
            this.txtSDTKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(243, 22);
            this.txtSDTKH.TabIndex = 40;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(372, 102);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(243, 22);
            this.txtDiaChiKH.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "SĐT";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(42, 76);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(194, 22);
            this.txtMaKH.TabIndex = 37;
            // 
            // dtKH
            // 
            this.dtKH.CustomFormat = "dd/MM/yyyy";
            this.dtKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtKH.Location = new System.Drawing.Point(757, 102);
            this.dtKH.Margin = new System.Windows.Forms.Padding(4);
            this.dtKH.Name = "dtKH";
            this.dtKH.Size = new System.Drawing.Size(215, 22);
            this.dtKH.TabIndex = 36;
            // 
            // rdKhacKH
            // 
            this.rdKhacKH.AutoSize = true;
            this.rdKhacKH.Location = new System.Drawing.Point(995, 105);
            this.rdKhacKH.Margin = new System.Windows.Forms.Padding(4);
            this.rdKhacKH.Name = "rdKhacKH";
            this.rdKhacKH.Size = new System.Drawing.Size(58, 20);
            this.rdKhacKH.TabIndex = 35;
            this.rdKhacKH.TabStop = true;
            this.rdKhacKH.Text = "Khác";
            this.rdKhacKH.UseVisualStyleBackColor = true;
            // 
            // rdNuKH
            // 
            this.rdNuKH.AutoSize = true;
            this.rdNuKH.Location = new System.Drawing.Point(1071, 105);
            this.rdNuKH.Margin = new System.Windows.Forms.Padding(4);
            this.rdNuKH.Name = "rdNuKH";
            this.rdNuKH.Size = new System.Drawing.Size(45, 20);
            this.rdNuKH.TabIndex = 35;
            this.rdNuKH.TabStop = true;
            this.rdNuKH.Text = "Nữ";
            this.rdNuKH.UseVisualStyleBackColor = true;
            // 
            // rdNamKH
            // 
            this.rdNamKH.AutoSize = true;
            this.rdNamKH.Location = new System.Drawing.Point(1071, 76);
            this.rdNamKH.Margin = new System.Windows.Forms.Padding(4);
            this.rdNamKH.Name = "rdNamKH";
            this.rdNamKH.Size = new System.Drawing.Size(60, 20);
            this.rdNamKH.TabIndex = 34;
            this.rdNamKH.TabStop = true;
            this.rdNamKH.Text = "Nam ";
            this.rdNamKH.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(757, 78);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(215, 22);
            this.txtCCCD.TabIndex = 33;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(44, 102);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(192, 22);
            this.txtTenKH.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(991, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Giới Tính ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Năm Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "CCCD";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(372, 407);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(85, 59);
            this.btnThemKH.TabIndex = 18;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 60);
            this.button1.TabIndex = 42;
            this.button1.Text = "Phiếu Phạt ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QlyKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtSDTKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoatKH);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.rdKhacKH);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rdNuKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.rdNamKH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QlyKH";
            this.Text = "Quản Lý Khách Thuê Trọ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QlyKH_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private MenuStrip menuStrip1;
        private Button button1;
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
    }
}