namespace WinFormsApp1
{
    partial class MENU
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
            this.btnQlyNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQlyBT = new System.Windows.Forms.Button();
            this.btnQlyPhong = new System.Windows.Forms.Button();
            this.btnQlyPBT = new System.Windows.Forms.Button();
            this.btnQlyHD = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQlyNV
            // 
            this.btnQlyNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQlyNV.Location = new System.Drawing.Point(27, 107);
            this.btnQlyNV.Name = "btnQlyNV";
            this.btnQlyNV.Size = new System.Drawing.Size(436, 62);
            this.btnQlyNV.TabIndex = 0;
            this.btnQlyNV.Text = "Quản Lý Nhân Viên";
            this.btnQlyNV.UseVisualStyleBackColor = true;
            this.btnQlyNV.Click += new System.EventHandler(this.btnQlyNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // btnQlyBT
            // 
            this.btnQlyBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQlyBT.Location = new System.Drawing.Point(27, 300);
            this.btnQlyBT.Name = "btnQlyBT";
            this.btnQlyBT.Size = new System.Drawing.Size(436, 58);
            this.btnQlyBT.TabIndex = 0;
            this.btnQlyBT.Text = "Quản Lý Bảo Trì ";
            this.btnQlyBT.UseVisualStyleBackColor = true;
            // 
            // btnQlyPhong
            // 
            this.btnQlyPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQlyPhong.Location = new System.Drawing.Point(27, 175);
            this.btnQlyPhong.Name = "btnQlyPhong";
            this.btnQlyPhong.Size = new System.Drawing.Size(436, 54);
            this.btnQlyPhong.TabIndex = 0;
            this.btnQlyPhong.Text = "Quản Lý Phòng ";
            this.btnQlyPhong.UseVisualStyleBackColor = true;
            // 
            // btnQlyPBT
            // 
            this.btnQlyPBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQlyPBT.Location = new System.Drawing.Point(27, 235);
            this.btnQlyPBT.Name = "btnQlyPBT";
            this.btnQlyPBT.Size = new System.Drawing.Size(436, 59);
            this.btnQlyPBT.TabIndex = 0;
            this.btnQlyPBT.Text = "Quản Lý Phiếu Bồi Thường ";
            this.btnQlyPBT.UseVisualStyleBackColor = true;
            // 
            // btnQlyHD
            // 
            this.btnQlyHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQlyHD.Location = new System.Drawing.Point(27, 364);
            this.btnQlyHD.Name = "btnQlyHD";
            this.btnQlyHD.Size = new System.Drawing.Size(436, 58);
            this.btnQlyHD.TabIndex = 0;
            this.btnQlyHD.Text = "Quản Lý Hóa Đơn";
            this.btnQlyHD.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangXuat.Location = new System.Drawing.Point(403, 455);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 490);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQlyPBT);
            this.Controls.Add(this.btnQlyPhong);
            this.Controls.Add(this.btnQlyHD);
            this.Controls.Add(this.btnQlyBT);
            this.Controls.Add(this.btnQlyNV);
            this.Name = "MENU";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MENU_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnQlyNV;
        private Label label1;
        private Button btnQlyBT;
        private Button btnQlyPhong;
        private Button btnQlyPBT;
        private Button btnQlyHD;
        private Button btnDangXuat;
    }
}