namespace NhaTroBoTu
{
    partial class XoaNhanVien
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
            this.btnCanelXoaNV = new System.Windows.Forms.Button();
            this.cmbXoaCV = new System.Windows.Forms.ComboBox();
            this.datimeXoaNgayS = new System.Windows.Forms.DateTimePicker();
            this.radXoaKhac = new System.Windows.Forms.RadioButton();
            this.radXoaNu = new System.Windows.Forms.RadioButton();
            this.radXoaNam = new System.Windows.Forms.RadioButton();
            this.txtXoaTen = new System.Windows.Forms.TextBox();
            this.txtXoaDiaChi = new System.Windows.Forms.TextBox();
            this.txtXoaSDT = new System.Windows.Forms.TextBox();
            this.txtXoaMa = new System.Windows.Forms.TextBox();
            this.dataXoaNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOkXoaNV = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataXoaNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCanelXoaNV
            // 
            this.btnCanelXoaNV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCanelXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanelXoaNV.Location = new System.Drawing.Point(669, 497);
            this.btnCanelXoaNV.Name = "btnCanelXoaNV";
            this.btnCanelXoaNV.Size = new System.Drawing.Size(114, 41);
            this.btnCanelXoaNV.TabIndex = 35;
            this.btnCanelXoaNV.Text = "CANCEL";
            this.btnCanelXoaNV.UseVisualStyleBackColor = false;
            this.btnCanelXoaNV.Click += new System.EventHandler(this.btnCanelXoaNV_Click);
            // 
            // cmbXoaCV
            // 
            this.cmbXoaCV.FormattingEnabled = true;
            this.cmbXoaCV.Items.AddRange(new object[] {
            "Vệ Sinh",
            "Bảo Trì"});
            this.cmbXoaCV.Location = new System.Drawing.Point(137, 114);
            this.cmbXoaCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbXoaCV.Name = "cmbXoaCV";
            this.cmbXoaCV.Size = new System.Drawing.Size(120, 24);
            this.cmbXoaCV.TabIndex = 4;
            this.cmbXoaCV.Text = "Bảo Trì";
            // 
            // datimeXoaNgayS
            // 
            this.datimeXoaNgayS.Location = new System.Drawing.Point(864, 30);
            this.datimeXoaNgayS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datimeXoaNgayS.Name = "datimeXoaNgayS";
            this.datimeXoaNgayS.Size = new System.Drawing.Size(276, 22);
            this.datimeXoaNgayS.TabIndex = 3;
            // 
            // radXoaKhac
            // 
            this.radXoaKhac.AutoSize = true;
            this.radXoaKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radXoaKhac.Location = new System.Drawing.Point(1035, 72);
            this.radXoaKhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radXoaKhac.Name = "radXoaKhac";
            this.radXoaKhac.Size = new System.Drawing.Size(67, 22);
            this.radXoaKhac.TabIndex = 2;
            this.radXoaKhac.TabStop = true;
            this.radXoaKhac.Text = "Khác";
            this.radXoaKhac.UseVisualStyleBackColor = true;
            // 
            // radXoaNu
            // 
            this.radXoaNu.AutoSize = true;
            this.radXoaNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radXoaNu.Location = new System.Drawing.Point(951, 72);
            this.radXoaNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radXoaNu.Name = "radXoaNu";
            this.radXoaNu.Size = new System.Drawing.Size(50, 22);
            this.radXoaNu.TabIndex = 2;
            this.radXoaNu.TabStop = true;
            this.radXoaNu.Text = "Nữ";
            this.radXoaNu.UseVisualStyleBackColor = true;
            // 
            // radXoaNam
            // 
            this.radXoaNam.AutoSize = true;
            this.radXoaNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radXoaNam.Location = new System.Drawing.Point(857, 72);
            this.radXoaNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radXoaNam.Name = "radXoaNam";
            this.radXoaNam.Size = new System.Drawing.Size(64, 22);
            this.radXoaNam.TabIndex = 2;
            this.radXoaNam.TabStop = true;
            this.radXoaNam.Text = "Nam";
            this.radXoaNam.UseVisualStyleBackColor = true;
            // 
            // txtXoaTen
            // 
            this.txtXoaTen.Location = new System.Drawing.Point(134, 66);
            this.txtXoaTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXoaTen.Name = "txtXoaTen";
            this.txtXoaTen.Size = new System.Drawing.Size(237, 22);
            this.txtXoaTen.TabIndex = 1;
            // 
            // txtXoaDiaChi
            // 
            this.txtXoaDiaChi.Location = new System.Drawing.Point(491, 67);
            this.txtXoaDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXoaDiaChi.Name = "txtXoaDiaChi";
            this.txtXoaDiaChi.Size = new System.Drawing.Size(211, 22);
            this.txtXoaDiaChi.TabIndex = 1;
            // 
            // txtXoaSDT
            // 
            this.txtXoaSDT.Location = new System.Drawing.Point(491, 30);
            this.txtXoaSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXoaSDT.Name = "txtXoaSDT";
            this.txtXoaSDT.Size = new System.Drawing.Size(211, 22);
            this.txtXoaSDT.TabIndex = 1;
            // 
            // txtXoaMa
            // 
            this.txtXoaMa.Location = new System.Drawing.Point(134, 31);
            this.txtXoaMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXoaMa.Name = "txtXoaMa";
            this.txtXoaMa.Size = new System.Drawing.Size(237, 22);
            this.txtXoaMa.TabIndex = 1;
            // 
            // dataXoaNhanVien
            // 
            this.dataXoaNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataXoaNhanVien.Location = new System.Drawing.Point(69, 297);
            this.dataXoaNhanVien.Name = "dataXoaNhanVien";
            this.dataXoaNhanVien.RowHeadersWidth = 51;
            this.dataXoaNhanVien.RowTemplate.Height = 25;
            this.dataXoaNhanVien.Size = new System.Drawing.Size(1049, 154);
            this.dataXoaNhanVien.TabIndex = 34;
            this.dataXoaNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataXoaNhanVien_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label1.Location = new System.Drawing.Point(375, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 62);
            this.label1.TabIndex = 33;
            this.label1.Text = "Xóa Nhân Viên ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(748, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới Tính:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(413, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(746, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(49, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên NV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(413, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "SĐT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(49, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV:";
            // 
            // btnOkXoaNV
            // 
            this.btnOkXoaNV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOkXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkXoaNV.Location = new System.Drawing.Point(458, 497);
            this.btnOkXoaNV.Name = "btnOkXoaNV";
            this.btnOkXoaNV.Size = new System.Drawing.Size(114, 41);
            this.btnOkXoaNV.TabIndex = 36;
            this.btnOkXoaNV.Text = "OK";
            this.btnOkXoaNV.UseVisualStyleBackColor = false;
            this.btnOkXoaNV.Click += new System.EventHandler(this.btnOkXoaNV_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(52, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chức Vụ:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cmbXoaCV);
            this.groupBox1.Controls.Add(this.datimeXoaNgayS);
            this.groupBox1.Controls.Add(this.radXoaKhac);
            this.groupBox1.Controls.Add(this.radXoaNu);
            this.groupBox1.Controls.Add(this.radXoaNam);
            this.groupBox1.Controls.Add(this.txtXoaTen);
            this.groupBox1.Controls.Add(this.txtXoaDiaChi);
            this.groupBox1.Controls.Add(this.txtXoaSDT);
            this.groupBox1.Controls.Add(this.txtXoaMa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 151);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // XoaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 573);
            this.Controls.Add(this.btnCanelXoaNV);
            this.Controls.Add(this.dataXoaNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkXoaNV);
            this.Controls.Add(this.groupBox1);
            this.Name = "XoaNhanVien";
            this.Text = "XoaNhanVien";
            this.Load += new System.EventHandler(this.XoaNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataXoaNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCanelXoaNV;
        private System.Windows.Forms.ComboBox cmbXoaCV;
        private System.Windows.Forms.DateTimePicker datimeXoaNgayS;
        private System.Windows.Forms.RadioButton radXoaKhac;
        private System.Windows.Forms.RadioButton radXoaNu;
        private System.Windows.Forms.RadioButton radXoaNam;
        private System.Windows.Forms.TextBox txtXoaTen;
        private System.Windows.Forms.TextBox txtXoaDiaChi;
        private System.Windows.Forms.TextBox txtXoaSDT;
        private System.Windows.Forms.TextBox txtXoaMa;
        private System.Windows.Forms.DataGridView dataXoaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOkXoaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}