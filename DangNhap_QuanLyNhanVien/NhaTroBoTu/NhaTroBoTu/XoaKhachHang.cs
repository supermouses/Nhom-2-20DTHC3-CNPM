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
using WinFormsApp1;

namespace NhaTroBoTu
{
    public partial class XoaKhachHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public XoaKhachHang()
        {
            InitializeComponent();
        }
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaKH,TenKH,GioiTinhKH,DiaChiKH,SDTKH,CCCD,NgaySinhKH from KhachThueTro";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataXoaKhach.DataSource = dt;
        }
        private void dataXoaKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataXoaKhach.CurrentRow.Index;
            txtmaXoaKhach.Text = dataXoaKhach.Rows[i].Cells[0].Value.ToString();
            txtTenXoaKH.Text = dataXoaKhach.Rows[i].Cells[1].Value.ToString();
            if (dataXoaKhach.Rows[i].Cells[2].Value.ToString() == "Nam")
            {
                rdXoaNamKH.Checked = true;
            }
            if (dataXoaKhach.Rows[i].Cells[2].Value.ToString() == "Nữ")
            {
                rdXoaNUKH.Checked = true;

            }
            else
            {
                rdXoaKhacKH.Checked = false;
            }
            txtXoaSDTKH.Text = dataXoaKhach.Rows[i].Cells[3].Value.ToString();
            txtXoaDiaChiKH.Text = dataXoaKhach.Rows[i].Cells[4].Value.ToString();
            txtXoaCCCDKH.Text = dataXoaKhach.Rows[i].Cells[5].Value.ToString();
            dtXoaKH.Text = dataXoaKhach.Rows[i].Cells[6].Value.ToString();
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from KhachThueTro where MaKH= '" + txtmaXoaKhach.Text + "'";
            cmd.ExecuteNonQuery();
            loadata();
            MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnXoaCancelKH_Click(object sender, EventArgs e)
        {
            QlyKH qlyKH = new QlyKH();
            Hide();
            qlyKH.Show();
            this.Close();
        }

        private void XoaKhachHang_Load(object sender, EventArgs e)
<<<<<<< Updated upstream
        {
            // TODO: This line of code loads data into the 'qlyTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            this.khachThueTroTableAdapter.Fill(this.qlyTroBoTuDataSet.KhachThueTro);
=======
        {;
>>>>>>> Stashed changes
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from MaKH";
            adapter.SelectCommand = cmd;
            conn.Open();
            loadata();
        }
    }
}
