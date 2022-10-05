using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
