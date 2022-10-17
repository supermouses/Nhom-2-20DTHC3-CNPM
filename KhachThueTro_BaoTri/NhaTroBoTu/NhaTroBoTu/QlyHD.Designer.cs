namespace NhaTroBoTu
{
    partial class QlyHD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKHHD = new System.Windows.Forms.ComboBox();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnCancelHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataHopDong = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbKHHD);
            this.groupBox1.Controls.Add(this.btnSuaHD);
            this.groupBox1.Controls.Add(this.btnCancelHD);
            this.groupBox1.Controls.Add(this.btnXoaHD);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.btnThemHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(13, 434);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(469, 166);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chung";
            // 
            // cmbKHHD
            // 
            this.cmbKHHD.FormattingEnabled = true;
            this.cmbKHHD.Items.AddRange(new object[] {
            "NV01",
            "NV02",
            "NV03",
            "NV04"});
            this.cmbKHHD.Location = new System.Drawing.Point(181, 65);
            this.cmbKHHD.Name = "cmbKHHD";
            this.cmbKHHD.Size = new System.Drawing.Size(278, 24);
            this.cmbKHHD.TabIndex = 42;
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Location = new System.Drawing.Point(234, 95);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(86, 47);
            this.btnSuaHD.TabIndex = 40;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaBT_Click);
            // 
            // btnCancelHD
            // 
            this.btnCancelHD.Location = new System.Drawing.Point(327, 96);
            this.btnCancelHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelHD.Name = "btnCancelHD";
            this.btnCancelHD.Size = new System.Drawing.Size(85, 47);
            this.btnCancelHD.TabIndex = 36;
            this.btnCancelHD.Text = "Hủy";
            this.btnCancelHD.UseVisualStyleBackColor = true;
            this.btnCancelHD.Click += new System.EventHandler(this.btnCancelBT_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(141, 96);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(87, 47);
            this.btnXoaHD.TabIndex = 39;
            this.btnXoaHD.Text = "Xóa ";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(181, 26);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(280, 22);
            this.txtMaHD.TabIndex = 37;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(43, 95);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(91, 47);
            this.btnThemHD.TabIndex = 35;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(3, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tên Khách Hàng";
            // 
            // dataHopDong
            // 
            this.dataHopDong.AllowUserToDeleteRows = false;
            this.dataHopDong.AllowUserToResizeColumns = false;
            this.dataHopDong.AllowUserToResizeRows = false;
            this.dataHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHopDong.Location = new System.Drawing.Point(13, 75);
            this.dataHopDong.Margin = new System.Windows.Forms.Padding(4);
            this.dataHopDong.Name = "dataHopDong";
            this.dataHopDong.RowHeadersWidth = 51;
            this.dataHopDong.RowTemplate.Height = 25;
            this.dataHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHopDong.Size = new System.Drawing.Size(469, 351);
            this.dataHopDong.TabIndex = 37;
            this.dataHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaoTri_CellClick);
            this.dataHopDong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaoTri_CellContentClick);
            this.dataHopDong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaoTri_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(27, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 62);
            this.label6.TabIndex = 34;
            this.label6.Text = "Quản Lý Hợp Đồng";
            // 
            // QlyHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataHopDong);
            this.Controls.Add(this.label6);
            this.Name = "QlyHD";
            this.Text = "QlyBT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QlyBT_FormClosed);
            this.Load += new System.EventHandler(this.QlyBT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnCancelHD;
        private System.Windows.Forms.DataGridView dataHopDong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.ComboBox cmbKHHD;
    }
}