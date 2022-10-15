using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhaTroBoTu
{
    public partial class ChiTietBaoTri : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public string txtMACTBT { get; internal set; }

        public ChiTietBaoTri()
        {
            InitializeComponent();
        }
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from ChiTietPhieuBaoTri";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataBaoTri.DataSource = dt;
        }

        private void ChiTietBaoTri_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from ChiTietPhieuBaoTri";
            adapter.SelectCommand = cmd;
            conn.Open();
            loadata();
        }

        private void dataBaoTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadata();
            //int i;
            //i = dataBaoTri.CurrentRow.Index;
            //txtCTBT.Text = dataBaoTri.Rows[i].Cells[0].Value.ToString();
            //txtMaPBT.Text = dataBaoTri.Rows[i].Cells[1].Value.ToString();
            //txtPhong.Text = dataBaoTri.Rows[i].Cells[2].Value.ToString();
            //dtNgaylap.Text = dataBaoTri.Rows[i].Cells[3].Value.ToString();
            //dtNgay.Text = dataBaoTri.Rows[i].Cells[4].Value.ToString();
            //txtND.Text = dataBaoTri.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThemBT_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaBT_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelBT_Click(object sender, EventArgs e)
        {
            QlyBT qlt = new QlyBT();
            Hide();
            qlt.Show();
            this.Close();
        }
    }
}
