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
    public partial class QlyKH : Form
    {
        public QlyKH()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            this.khachThueTroTableAdapter.Fill(this.quanLyPhongTroBoTuDataSet.KhachThueTro);

        }
    }
}
