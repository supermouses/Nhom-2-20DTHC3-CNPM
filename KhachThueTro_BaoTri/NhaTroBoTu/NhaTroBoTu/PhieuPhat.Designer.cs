namespace NhaTroBoTu
{
    partial class PhieuPhat
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
            this.btnSuaPP = new System.Windows.Forms.Button();
            this.txtMoneyPP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPP = new System.Windows.Forms.TextBox();
            this.dtNgayPP = new System.Windows.Forms.DateTimePicker();
            this.txtMaKHPP = new System.Windows.Forms.TextBox();
            this.btnThemPP = new System.Windows.Forms.Button();
            this.btnCancelPP = new System.Windows.Forms.Button();
            this.dataPhieuPhat = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaPP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuPhat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuaPP
            // 
            this.btnSuaPP.Location = new System.Drawing.Point(213, 298);
            this.btnSuaPP.Name = "btnSuaPP";
            this.btnSuaPP.Size = new System.Drawing.Size(86, 47);
            this.btnSuaPP.TabIndex = 47;
            this.btnSuaPP.Text = "Sửa";
            this.btnSuaPP.UseVisualStyleBackColor = true;
            this.btnSuaPP.Click += new System.EventHandler(this.btnSuaPP_Click);
            // 
            // txtMoneyPP
            // 
            this.txtMoneyPP.Location = new System.Drawing.Point(155, 108);
            this.txtMoneyPP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoneyPP.Name = "txtMoneyPP";
            this.txtMoneyPP.Size = new System.Drawing.Size(304, 22);
            this.txtMoneyPP.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ngày Lập Phiếu Phạt ";
            // 
            // txtMaPP
            // 
            this.txtMaPP.Location = new System.Drawing.Point(157, 26);
            this.txtMaPP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPP.Name = "txtMaPP";
            this.txtMaPP.Size = new System.Drawing.Size(304, 22);
            this.txtMaPP.TabIndex = 37;
            // 
            // dtNgayPP
            // 
            this.dtNgayPP.Location = new System.Drawing.Point(188, 152);
            this.dtNgayPP.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayPP.Name = "dtNgayPP";
            this.dtNgayPP.Size = new System.Drawing.Size(304, 22);
            this.dtNgayPP.TabIndex = 36;
            // 
            // txtMaKHPP
            // 
            this.txtMaKHPP.Location = new System.Drawing.Point(155, 65);
            this.txtMaKHPP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKHPP.Name = "txtMaKHPP";
            this.txtMaKHPP.Size = new System.Drawing.Size(304, 22);
            this.txtMaKHPP.TabIndex = 32;
            // 
            // btnThemPP
            // 
            this.btnThemPP.Location = new System.Drawing.Point(21, 298);
            this.btnThemPP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemPP.Name = "btnThemPP";
            this.btnThemPP.Size = new System.Drawing.Size(91, 47);
            this.btnThemPP.TabIndex = 42;
            this.btnThemPP.Text = "Thêm";
            this.btnThemPP.UseVisualStyleBackColor = true;
            this.btnThemPP.Click += new System.EventHandler(this.btnThemPP_Click);
            // 
            // btnCancelPP
            // 
            this.btnCancelPP.Location = new System.Drawing.Point(306, 298);
            this.btnCancelPP.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelPP.Name = "btnCancelPP";
            this.btnCancelPP.Size = new System.Drawing.Size(85, 47);
            this.btnCancelPP.TabIndex = 43;
            this.btnCancelPP.Text = "Hủy";
            this.btnCancelPP.UseVisualStyleBackColor = true;
            this.btnCancelPP.Click += new System.EventHandler(this.btnCancelPP_Click);
            // 
            // dataPhieuPhat
            // 
            this.dataPhieuPhat.AllowUserToDeleteRows = false;
            this.dataPhieuPhat.AllowUserToResizeColumns = false;
            this.dataPhieuPhat.AllowUserToResizeRows = false;
            this.dataPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhieuPhat.Location = new System.Drawing.Point(544, 86);
            this.dataPhieuPhat.Margin = new System.Windows.Forms.Padding(4);
            this.dataPhieuPhat.Name = "dataPhieuPhat";
            this.dataPhieuPhat.RowHeadersWidth = 51;
            this.dataPhieuPhat.RowTemplate.Height = 25;
            this.dataPhieuPhat.Size = new System.Drawing.Size(657, 252);
            this.dataPhieuPhat.TabIndex = 44;
            this.dataPhieuPhat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPhieuPhat_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(430, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 62);
            this.label6.TabIndex = 41;
            this.label6.Text = "Quản Lý Phiếu Phạt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Phí Phạt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Phiếu Phạt";
            // 
            // btnXoaPP
            // 
            this.btnXoaPP.Location = new System.Drawing.Point(119, 298);
            this.btnXoaPP.Name = "btnXoaPP";
            this.btnXoaPP.Size = new System.Drawing.Size(87, 47);
            this.btnXoaPP.TabIndex = 46;
            this.btnXoaPP.Text = "Xóa ";
            this.btnXoaPP.UseVisualStyleBackColor = true;
            this.btnXoaPP.Click += new System.EventHandler(this.btnXoaPP_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(3, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Mã Khách Hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMoneyPP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPP);
            this.groupBox1.Controls.Add(this.dtNgayPP);
            this.groupBox1.Controls.Add(this.txtMaKHPP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(523, 197);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách";
            // 
            // PhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 358);
            this.Controls.Add(this.btnSuaPP);
            this.Controls.Add(this.btnThemPP);
            this.Controls.Add(this.btnCancelPP);
            this.Controls.Add(this.dataPhieuPhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoaPP);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhieuPhat";
            this.Text = "PhieuPhat";
            this.Load += new System.EventHandler(this.PhieuPhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuPhat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuaPP;
        private System.Windows.Forms.TextBox txtMoneyPP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPP;
        private System.Windows.Forms.DateTimePicker dtNgayPP;
        private System.Windows.Forms.TextBox txtMaKHPP;
        private System.Windows.Forms.Button btnThemPP;
        private System.Windows.Forms.Button btnCancelPP;
        private System.Windows.Forms.DataGridView dataPhieuPhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaPP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}