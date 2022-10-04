namespace WinFormsApp1
{
    partial class DangNhapQlyPhongTro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangNhap.Location = new System.Drawing.Point(503, 123);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(113, 117);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng Nhập ";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTaiKhoan.Location = new System.Drawing.Point(222, 123);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(244, 39);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatKhau.Location = new System.Drawing.Point(222, 196);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(244, 39);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài Khoản ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(71, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "PHẦN MỀM QUẢN LÝ PHÒNG TRỌ";
            // 
            // DangNhapQlyPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DangNhapQlyPhongTro";
            this.Text = "PHẦN MỀM QUẢN LÝ PHÒNG TRỌ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangNhapQlyPhongTro_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDangNhap;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}