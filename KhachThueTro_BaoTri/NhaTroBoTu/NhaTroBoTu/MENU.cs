using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace NhaTroBoTu
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void btnQlyNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien NV = new QuanLyNhanVien();
            Hide();
            NV.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            Hide();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btnQlyPhong_Click(object sender, EventArgs e)
        {
            MenuQlyPhong menuQlyPhong = new MenuQlyPhong();
            Hide();
            menuQlyPhong.Show();
        }

        private void btnQlyBT_Click(object sender, EventArgs e)
        {

        }

        private void MENU_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void btnQlyHD_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon();
            Hide();
            cthd.Show();
        }
    }
}
