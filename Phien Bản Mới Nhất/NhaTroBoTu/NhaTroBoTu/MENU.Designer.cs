namespace NhaTroBoTu
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQlyPBT = new System.Windows.Forms.Button();
            this.btnQlyPhong = new System.Windows.Forms.Button();
            this.btnQlyHD = new System.Windows.Forms.Button();
            this.btnQlyBT = new System.Windows.Forms.Button();
            this.btnQlyNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Image = global::NhaTroBoTu.Properties.Resources.icons8_exit_30;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(538, 471);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(148, 60);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 81);
            this.label1.TabIndex = 8;
            this.label1.Text = "MENU";
            // 
            // btnQlyPBT
            // 
            this.btnQlyPBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQlyPBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyPBT.Location = new System.Drawing.Point(188, 248);
            this.btnQlyPBT.Name = "btnQlyPBT";
            this.btnQlyPBT.Size = new System.Drawing.Size(498, 63);
            this.btnQlyPBT.TabIndex = 2;
            this.btnQlyPBT.Text = "Quản Lý Phiếu Bồi Thường ";
            this.btnQlyPBT.UseVisualStyleBackColor = false;
            // 
            // btnQlyPhong
            // 
            this.btnQlyPhong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQlyPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyPhong.Location = new System.Drawing.Point(188, 184);
            this.btnQlyPhong.Name = "btnQlyPhong";
            this.btnQlyPhong.Size = new System.Drawing.Size(498, 58);
            this.btnQlyPhong.TabIndex = 1;
            this.btnQlyPhong.Text = "Quản Lý Phòng ";
            this.btnQlyPhong.UseVisualStyleBackColor = false;
            // 
            // btnQlyHD
            // 
            this.btnQlyHD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQlyHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyHD.Location = new System.Drawing.Point(188, 385);
            this.btnQlyHD.Name = "btnQlyHD";
            this.btnQlyHD.Size = new System.Drawing.Size(498, 62);
            this.btnQlyHD.TabIndex = 4;
            this.btnQlyHD.Text = "Quản Lý Hóa Đơn";
            this.btnQlyHD.UseVisualStyleBackColor = false;
            // 
            // btnQlyBT
            // 
            this.btnQlyBT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQlyBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyBT.Location = new System.Drawing.Point(188, 317);
            this.btnQlyBT.Name = "btnQlyBT";
            this.btnQlyBT.Size = new System.Drawing.Size(498, 62);
            this.btnQlyBT.TabIndex = 3;
            this.btnQlyBT.Text = "Quản Lý Bảo Trì ";
            this.btnQlyBT.UseVisualStyleBackColor = false;
            // 
            // btnQlyNV
            // 
            this.btnQlyNV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQlyNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQlyNV.Location = new System.Drawing.Point(188, 111);
            this.btnQlyNV.Name = "btnQlyNV";
            this.btnQlyNV.Size = new System.Drawing.Size(498, 66);
            this.btnQlyNV.TabIndex = 0;
            this.btnQlyNV.Text = "Quản Lý Nhân Viên";
            this.btnQlyNV.UseVisualStyleBackColor = false;
            this.btnQlyNV.Click += new System.EventHandler(this.btnQlyNV_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 563);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQlyPBT);
            this.Controls.Add(this.btnQlyPhong);
            this.Controls.Add(this.btnQlyHD);
            this.Controls.Add(this.btnQlyBT);
            this.Controls.Add(this.btnQlyNV);
            this.Name = "MENU";
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQlyPBT;
        private System.Windows.Forms.Button btnQlyPhong;
        private System.Windows.Forms.Button btnQlyHD;
        private System.Windows.Forms.Button btnQlyBT;
        private System.Windows.Forms.Button btnQlyNV;
    }
}