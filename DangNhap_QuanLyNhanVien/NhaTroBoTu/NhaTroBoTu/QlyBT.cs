using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace NhaTroBoTu
{
    public partial class QlyBT : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public QlyBT()
        {
            InitializeComponent();
        }

        private void QlyBT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlyTroBoTuDataSet.PhieuBaoTri' table. You can move, or remove it, as needed.
            this.phieuBaoTriTableAdapter.Fill(this.qlyTroBoTuDataSet.PhieuBaoTri);
            // TODO: This line of code loads data into the 'qlyTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            this.khachThueTroTableAdapter.Fill(this.qlyTroBoTuDataSet.KhachThueTro);
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from PhieuBaoTri";
            adapter.SelectCommand = cmd;
            conn.Open();

        }
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from PhieuBaoTri";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataBaoTri.DataSource = dt;
        }

        private void dataBaoTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataBaoTri.CurrentRow.Index;
            txtPBT.Text = dataBaoTri.Rows[i].Cells[0].Value.ToString();
            txtMaNVBT.Text = dataBaoTri.Rows[i].Cells[1].Value.ToString();
            txtMaPhong.Text = dataBaoTri.Rows[i].Cells[2].Value.ToString();
            txtMaTN.Text = dataBaoTri.Rows[i].Cells[3].Value.ToString();
            dtNgayBT.Text = dataBaoTri.Rows[i].Cells[4].Value.ToString();
            dtLapPBT.Text = dataBaoTri.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThemBT_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into PhieuBaoTri values('" + txtPBT.Text + "' , N'" + txtMaNVBT.Text + "' ,'" + txtMaPhong.Text + "', '" + txtMaTN.Text + "' ,'" + dtNgayBT.Value + "' , '" + dtLapPBT.Value.ToString() + "')";
            cmd.ExecuteNonQuery();
            loadata();
            MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnrollbackBT_Click(object sender, EventArgs e)
        {
            MENU mENU = new MENU();
            Hide();
            mENU.Show();
            this.Close();
        }
    }
}
