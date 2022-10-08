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
    public partial class TimKiemKhachHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QuanLyPhongTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public TimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void TimKiemKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            this.khachThueTroTableAdapter.Fill(this.quanLyPhongTroBoTuDataSet.KhachThueTro);
            loadata();
        }
        void loadata()
        {
            this.khachThueTroTableAdapter.Fill(this.quanLyPhongTroBoTuDataSet.KhachThueTro);
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from KhachThueTro";
            adapter.SelectCommand = cmd;
            conn.Open();
        }
private void btnQuayLai_Click(object sender, EventArgs e)
        {
            QlyKH qlyKH = new QlyKH();
            Hide();
            qlyKH.Show();
            this.Close();
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Mời nhập thông tin bạn tìm", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (rdMa.Checked)
                {
                    loadata();
                }
                if (rdTen.Checked)
                {
                    loadata();
                }
            }
        }

        private void dataTimKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadata();
        }
    }
}
