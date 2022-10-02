using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MENU : Form
    {
        
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhapQlyPhongTro DN = new DangNhapQlyPhongTro();
            this.Hide();
            DN.ShowDialog();
        }

        private void btnQlyNV_Click(object sender, EventArgs e)
        {
            QlyNV NV =new QlyNV();
            Hide();
            NV.ShowDialog();
        }
    }
}
