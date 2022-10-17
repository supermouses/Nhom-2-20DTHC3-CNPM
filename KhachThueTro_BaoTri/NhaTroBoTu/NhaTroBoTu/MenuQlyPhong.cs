using NhaTroBoTu;
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
    public partial class MenuQlyPhong : Form
    {
        public MenuQlyPhong()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QlyKH menuQlyKH = new QlyKH();
            Hide();
            menuQlyKH.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MENU mn = new MENU();
            Hide();
            mn.ShowDialog();
            this.Close();
        }

        private void MenuQlyPhong_Load(object sender, EventArgs e)
        {

        }

        private void MenuQlyPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QlyHD qlyBT = new QlyHD();
            Hide();
            qlyBT.Show();
        }
    }
}
