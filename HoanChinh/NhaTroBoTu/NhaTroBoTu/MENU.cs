using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void btnQlyPhong_Click(object sender, EventArgs e)
        {
            MenuQlyPhong menuQlyPhong = new MenuQlyPhong();
            Hide();
            menuQlyPhong.ShowDialog();
        }
    }
}
