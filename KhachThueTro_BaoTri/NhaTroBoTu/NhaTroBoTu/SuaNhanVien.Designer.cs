namespace NhaTroBoTu
{
    partial class SuaNhanVien
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
            this.btnOkSuaNV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSuaCV = new System.Windows.Forms.ComboBox();
            this.datimeSuaNgayS = new System.Windows.Forms.DateTimePicker();
            this.radSuaKhac = new System.Windows.Forms.RadioButton();
            this.radSuaNu = new System.Windows.Forms.RadioButton();
            this.radSuaNam = new System.Windows.Forms.RadioButton();
            this.txtSuaTen = new System.Windows.Forms.TextBox();
            this.txSuaDiaChi = new System.Windows.Forms.TextBox();
            this.txtSuaSDT = new System.Windows.Forms.TextBox();
            this.txtSuaMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSuaNhanVien = new System.Windows.Forms.DataGridView();
            this.btnCanelSuaNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuaNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOkSuaNV
            // 
            this.btnOkSuaNV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOkSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkSuaNV.Location = new System.Drawing.Point(486, 513);
            this.btnOkSuaNV.Name = "btnOkSuaNV";
            this.btnOkSuaNV.Size = new System.Drawing.Size(114, 41);
            this.btnOkSuaNV.TabIndex = 41;
            this.btnOkSuaNV.Text = "OK";
            this.btnOkSuaNV.UseVisualStyleBackColor = false;
            this.btnOkSuaNV.Click += new System.EventHandler(this.btnOkSuaNV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cmbSuaCV);
            this.groupBox1.Controls.Add(this.datimeSuaNgayS);
            this.groupBox1.Controls.Add(this.radSuaKhac);
            this.groupBox1.Controls.Add(this.radSuaNu);
            this.groupBox1.Controls.Add(this.radSuaNam);
            this.groupBox1.Controls.Add(this.txtSuaTen);
            this.groupBox1.Controls.Add(this.txSuaDiaChi);
            this.groupBox1.Controls.Add(this.txtSuaSDT);
            this.groupBox1.Controls.Add(this.txtSuaMa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(41, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 151);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // cmbSuaCV
            // 
            this.cmbSuaCV.FormattingEnabled = true;
            this.cmbSuaCV.Items.AddRange(new object[] {
            "Vệ Sinh",
            "Bảo Trì"});
            this.cmbSuaCV.Location = new System.Drawing.Point(137, 114);
            this.cmbSuaCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSuaCV.Name = "cmbSuaCV";
            this.cmbSuaCV.Size = new System.Drawing.Size(120, 24);
            this.cmbSuaCV.TabIndex = 4;
            this.cmbSuaCV.Text = "Bảo Trì";
            // 
            // datimeSuaNgayS
            // 
            this.datimeSuaNgayS.Location = new System.Drawing.Point(864, 30);
            this.datimeSuaNgayS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datimeSuaNgayS.Name = "datimeSuaNgayS";
            this.datimeSuaNgayS.Size = new System.Drawing.Size(276, 22);
            this.datimeSuaNgayS.TabIndex = 3;
            // 
            // radSuaKhac
            // 
            this.radSuaKhac.AutoSize = true;
            this.radSuaKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radSuaKhac.Location = new System.Drawing.Point(1035, 72);
            this.radSuaKhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSuaKhac.Name = "radSuaKhac";
            this.radSuaKhac.Size = new System.Drawing.Size(67, 22);
            this.radSuaKhac.TabIndex = 2;
            this.radSuaKhac.TabStop = true;
            this.radSuaKhac.Text = "Khác";
            this.radSuaKhac.UseVisualStyleBackColor = true;
            // 
            // radSuaNu
            // 
            this.radSuaNu.AutoSize = true;
            this.radSuaNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radSuaNu.Location = new System.Drawing.Point(951, 72);
            this.radSuaNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSuaNu.Name = "radSuaNu";
            this.radSuaNu.Size = new System.Drawing.Size(50, 22);
            this.radSuaNu.TabIndex = 2;
            this.radSuaNu.TabStop = true;
            this.radSuaNu.Text = "Nữ";
            this.radSuaNu.UseVisualStyleBackColor = true;
            // 
            // radSuaNam
            // 
            this.radSuaNam.AutoSize = true;
            this.radSuaNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.radSuaNam.Location = new System.Drawing.Point(857, 72);
            this.radSuaNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSuaNam.Name = "radSuaNam";
            this.radSuaNam.Size = new System.Drawing.Size(64, 22);
            this.radSuaNam.TabIndex = 2;
            this.radSuaNam.TabStop = true;
            this.radSuaNam.Text = "Nam";
            this.radSuaNam.UseVisualStyleBackColor = true;
            // 
            // txtSuaTen
            // 
            this.txtSuaTen.Location = new System.Drawing.Point(134, 66);
            this.txtSuaTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuaTen.Name = "txtSuaTen";
            this.txtSuaTen.Size = new System.Drawing.Size(237, 22);
            this.txtSuaTen.TabIndex = 1;
            // 
            // txSuaDiaChi
            // 
            this.txSuaDiaChi.Location = new System.Drawing.Point(491, 67);
            this.txSuaDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSuaDiaChi.Name = "txSuaDiaChi";
            this.txSuaDiaChi.Size = new System.Drawing.Size(211, 22);
            this.txSuaDiaChi.TabIndex = 1;
            // 
            // txtSuaSDT
            // 
            this.txtSuaSDT.Location = new System.Drawing.Point(491, 30);
            this.txtSuaSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuaSDT.Name = "txtSuaSDT";
            this.txtSuaSDT.Size = new System.Drawing.Size(211, 22);
            this.txtSuaSDT.TabIndex = 1;
            // 
            // txtSuaMa
            // 
            this.txtSuaMa.Location = new System.Drawing.Point(134, 31);
            this.txtSuaMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSuaMa.Name = "txtSuaMa";
            this.txtSuaMa.Size = new System.Drawing.Size(237, 22);
            this.txtSuaMa.TabIndex = 1;
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
            // dataSuaNhanVien
            // 
            this.dataSuaNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSuaNhanVien.Location = new System.Drawing.Point(97, 313);
            this.dataSuaNhanVien.Name = "dataSuaNhanVien";
            this.dataSuaNhanVien.RowHeadersWidth = 51;
            this.dataSuaNhanVien.RowTemplate.Height = 25;
            this.dataSuaNhanVien.Size = new System.Drawing.Size(1049, 154);
            this.dataSuaNhanVien.TabIndex = 39;
            this.dataSuaNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSuaNhanVien_CellContentClick);
            // 
            // btnCanelSuaNV
            // 
            this.btnCanelSuaNV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCanelSuaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanelSuaNV.Location = new System.Drawing.Point(697, 513);
            this.btnCanelSuaNV.Name = "btnCanelSuaNV";
            this.btnCanelSuaNV.Size = new System.Drawing.Size(114, 41);
            this.btnCanelSuaNV.TabIndex = 40;
            this.btnCanelSuaNV.Text = "CANCEL";
            this.btnCanelSuaNV.UseVisualStyleBackColor = false;
            this.btnCanelSuaNV.Click += new System.EventHandler(this.btnCanelSuaNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label1.Location = new System.Drawing.Point(403, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 62);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sửa Nhân Viên ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 604);
            this.Controls.Add(this.btnOkSuaNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataSuaNhanVien);
            this.Controls.Add(this.btnCanelSuaNV);
            this.Controls.Add(this.label1);
            this.Name = "SuaNhanVien";
            this.Text = "SuaNhanVien";
            this.Load += new System.EventHandler(this.SuaNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSuaNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkSuaNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSuaCV;
        private System.Windows.Forms.DateTimePicker datimeSuaNgayS;
        private System.Windows.Forms.RadioButton radSuaKhac;
        private System.Windows.Forms.RadioButton radSuaNu;
        private System.Windows.Forms.RadioButton radSuaNam;
        private System.Windows.Forms.TextBox txtSuaTen;
        private System.Windows.Forms.TextBox txSuaDiaChi;
        private System.Windows.Forms.TextBox txtSuaSDT;
        private System.Windows.Forms.TextBox txtSuaMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataSuaNhanVien;
        private System.Windows.Forms.Button btnCanelSuaNV;
        private System.Windows.Forms.Label label1;
    }
}