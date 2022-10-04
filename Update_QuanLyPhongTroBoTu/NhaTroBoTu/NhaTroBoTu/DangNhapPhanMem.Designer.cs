namespace NhaTroBoTu
{
    partial class DangNhapPhanMem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnDNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ PHÒNG TRỌ BỘ TỨ";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(232, 147);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(271, 22);
            this.txtTenDN.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(230, 206);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(273, 22);
            this.txtPass.TabIndex = 2;
            // 
            // btnDNhap
            // 
            this.btnDNhap.Location = new System.Drawing.Point(336, 295);
            this.btnDNhap.Name = "btnDNhap";
            this.btnDNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDNhap.TabIndex = 3;
            this.btnDNhap.Text = "button1";
            this.btnDNhap.UseVisualStyleBackColor = true;
            this.btnDNhap.Click += new System.EventHandler(this.btnDNhap_Click);
            // 
            // DangNhapPhanMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 408);
            this.Controls.Add(this.btnDNhap);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label1);
            this.Name = "DangNhapPhanMem";
            this.Text = "DangNhapPhanMem";
            this.Load += new System.EventHandler(this.DangNhapPhanMem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnDNhap;
    }
}