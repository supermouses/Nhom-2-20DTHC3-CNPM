namespace NhaTroBoTu
{
    partial class QlyBT
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
            this.txtNVBT = new System.Windows.Forms.ComboBox();
            this.btnSuaBT = new System.Windows.Forms.Button();
            this.btnCancelBT = new System.Windows.Forms.Button();
            this.txtMACTBT = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaPBT = new System.Windows.Forms.TextBox();
            this.btnThemBT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataBaoTri = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoTri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNVBT);
            this.groupBox1.Controls.Add(this.btnSuaBT);
            this.groupBox1.Controls.Add(this.btnCancelBT);
            this.groupBox1.Controls.Add(this.txtMACTBT);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtMaPBT);
            this.groupBox1.Controls.Add(this.btnThemBT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(23, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(469, 215);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách";
            // 
            // txtNVBT
            // 
            this.txtNVBT.FormattingEnabled = true;
            this.txtNVBT.Items.AddRange(new object[] {
            "NV01",
            "NV02",
            "NV03",
            "NV04"});
            this.txtNVBT.Location = new System.Drawing.Point(181, 65);
            this.txtNVBT.Name = "txtNVBT";
            this.txtNVBT.Size = new System.Drawing.Size(278, 24);
            this.txtNVBT.TabIndex = 42;
            // 
            // btnSuaBT
            // 
            this.btnSuaBT.Location = new System.Drawing.Point(231, 149);
            this.btnSuaBT.Name = "btnSuaBT";
            this.btnSuaBT.Size = new System.Drawing.Size(86, 47);
            this.btnSuaBT.TabIndex = 40;
            this.btnSuaBT.Text = "Sửa";
            this.btnSuaBT.UseVisualStyleBackColor = true;
            this.btnSuaBT.Click += new System.EventHandler(this.btnSuaBT_Click);
            // 
            // btnCancelBT
            // 
            this.btnCancelBT.Location = new System.Drawing.Point(324, 150);
            this.btnCancelBT.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelBT.Name = "btnCancelBT";
            this.btnCancelBT.Size = new System.Drawing.Size(85, 47);
            this.btnCancelBT.TabIndex = 36;
            this.btnCancelBT.Text = "Hủy";
            this.btnCancelBT.UseVisualStyleBackColor = true;
            this.btnCancelBT.Click += new System.EventHandler(this.btnCancelBT_Click);
            // 
            // txtMACTBT
            // 
            this.txtMACTBT.Location = new System.Drawing.Point(181, 111);
            this.txtMACTBT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMACTBT.Name = "txtMACTBT";
            this.txtMACTBT.Size = new System.Drawing.Size(278, 22);
            this.txtMACTBT.TabIndex = 41;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(138, 150);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 47);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaPBT
            // 
            this.txtMaPBT.Location = new System.Drawing.Point(181, 26);
            this.txtMaPBT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPBT.Name = "txtMaPBT";
            this.txtMaPBT.Size = new System.Drawing.Size(280, 22);
            this.txtMaPBT.TabIndex = 37;
            // 
            // btnThemBT
            // 
            this.btnThemBT.Location = new System.Drawing.Point(40, 149);
            this.btnThemBT.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemBT.Name = "btnThemBT";
            this.btnThemBT.Size = new System.Drawing.Size(91, 47);
            this.btnThemBT.TabIndex = 35;
            this.btnThemBT.Text = "Thêm";
            this.btnThemBT.UseVisualStyleBackColor = true;
            this.btnThemBT.Click += new System.EventHandler(this.btnThemBT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mã Chi Tiết Bảo Trì";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã Phiếu Bảo Trì";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label8.Location = new System.Drawing.Point(3, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Mã Nhân Viên";
            // 
            // dataBaoTri
            // 
            this.dataBaoTri.AllowUserToDeleteRows = false;
            this.dataBaoTri.AllowUserToResizeColumns = false;
            this.dataBaoTri.AllowUserToResizeRows = false;
            this.dataBaoTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBaoTri.Location = new System.Drawing.Point(502, 86);
            this.dataBaoTri.Margin = new System.Windows.Forms.Padding(4);
            this.dataBaoTri.Name = "dataBaoTri";
            this.dataBaoTri.RowHeadersWidth = 51;
            this.dataBaoTri.RowTemplate.Height = 25;
            this.dataBaoTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBaoTri.Size = new System.Drawing.Size(557, 215);
            this.dataBaoTri.TabIndex = 37;
            this.dataBaoTri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaoTri_CellClick);
            this.dataBaoTri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaoTri_CellContentClick);
            this.dataBaoTri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBaoTri_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F);
            this.label6.Location = new System.Drawing.Point(384, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 62);
            this.label6.TabIndex = 34;
            this.label6.Text = "Quản Lý Bảo Trì";
            // 
            // QlyBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataBaoTri);
            this.Controls.Add(this.label6);
            this.Name = "QlyBT";
            this.Text = "QlyBT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QlyBT_FormClosed);
            this.Load += new System.EventHandler(this.QlyBT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaoTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMACTBT;
        private System.Windows.Forms.TextBox txtMaPBT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThemBT;
        private System.Windows.Forms.Button btnCancelBT;
        private System.Windows.Forms.DataGridView dataBaoTri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSuaBT;
        private System.Windows.Forms.ComboBox txtNVBT;
    }
}