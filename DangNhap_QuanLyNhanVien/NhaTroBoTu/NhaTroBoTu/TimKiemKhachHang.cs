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
using static System.Net.Mime.MediaTypeNames;

namespace NhaTroBoTu
{
    public partial class TimKiemKhachHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public TimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void TimKiemKhachHang_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            // TODO: This line of code loads data into the 'qlyTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            this.khachThueTroTableAdapter1.Fill(this.qlyTroBoTuDataSet.KhachThueTro);
            // TODO: This line of code loads data into the 'quanLyPhongTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            this.khachThueTroTableAdapter.Fill(this.quanLyPhongTroBoTuDataSet.KhachThueTro);
=======
>>>>>>> Stashed changes
            loadata();
        }
        void loadata()
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaKH,TenKH,GioiTinhKH,DiaChiKH,SDTKH,CCCD,NgaySinhKH from KhachThueTro";
            adapter.SelectCommand = cmd;
            dataTimKhach.DataSource = table1;
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
                    timma();
                }
                if (rdTen.Checked)
                {
                    timten();
                }
            }
        }

        private void dataTimKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadata();
        }

        private void rdMa_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        void timma()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaKH,TenKH,GioiTinhKH,DiaChiKH,SDTKH,CCCD,NgaySinhKH from KhachThueTro where MaKH like '%" + txtTimKiem.Text + "%'";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataTimKhach.DataSource = dt;
        }
        void timten()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaKH,TenKH,GioiTinhKH,DiaChiKH,SDTKH,CCCD,NgaySinhKH from KhachThueTro where TenKH like  N'%" + txtTimKiem.Text + "%'";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataTimKhach.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
                if (rdMa.Checked)
                {
                    timma();
                }
                if (rdTen.Checked)
                {
                    timten();
                }
            }
        }
    }
