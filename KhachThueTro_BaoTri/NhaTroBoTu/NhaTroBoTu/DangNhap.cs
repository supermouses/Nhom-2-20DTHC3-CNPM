using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Threading;

namespace NhaTroBoTu
{
    public partial class DangNhap : Form
    {
        string tendangnhap = "admin";
        string matkhau = "admin";
        public DangNhap()
        {
            InitializeComponent();
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                MENU menu = new MENU();
                Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai Tên Tài Khoảng Hoặc Mật Khẩu", "Thông Báo");
            }
        }
        bool KiemTraDangNhap(string tendangnhap, string matkhau)
        {
            if (tendangnhap == this.tendangnhap && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
