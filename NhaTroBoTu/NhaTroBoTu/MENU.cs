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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void btnQlyNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien NV = new QuanLyNhanVien();
            NV.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
