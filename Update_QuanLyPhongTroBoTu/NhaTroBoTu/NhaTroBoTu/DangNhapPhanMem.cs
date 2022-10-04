using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaTroBoTu
{
    public partial class DangNhapPhanMem : Form
    {
        string taikhoan = "BoTu";
        string matkhauu = "phongtrobotu";
        public DangNhapPhanMem()
        {
            InitializeComponent();
        }

        private void DangNhapPhanMem_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void btnDNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTenDN.Text, txtPass.Text))
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
        bool KiemTraDangNhap(string taikhoan, string matkhauu)
        {
            if (taikhoan == this.taikhoan && matkhauu == this.matkhauu)
            {
                return true;
            }
            return false;
        }
    }
}
