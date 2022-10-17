using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

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
            loadata();
        }
        void loadata()
        {
            dataTimKhach.Enabled = false;
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from KhachThueTro";
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
            //if (txtTimKiem.Text == "")
            //{
            //    MessageBox.Show("Mời nhập thông tin bạn tìm", "Thông báo", MessageBoxButtons.OK);
            //}
            //else
            //{
            //    if (rdMa.Checked)
            //    {
            //        timma();
            //    }
            //    if (rdTen.Checked)
            //    {
            //        timten();
            //    }
            //}
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
            loadata();
        }
        void timten()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaKH,TenKH,GioiTinhKH,DiaChiKH,SDTKH,CCCD,NgaySinhKH from KhachThueTro where TenKH like  N'%" + txtTimKiem.Text + "%'";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataTimKhach.DataSource = dt;
            loadata();
        }
        void trong()
        {
            //cmd = conn.CreateCommand();
            //cmd.CommandText = "select *from KhachThueTro where MaKH is null ";
            //adapter.SelectCommand = cmd;
            //dt.Clear();
            //adapter.Fill(dt);
            //dataTimKhach.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            //if (txtTimKiem.Text == "");
            //{
            //    trong();
            //}
                if (rdMa.Checked)
            {
                timma();
            }
            if (rdTen.Checked)
            {
                timten();
            }
        }
        private void TimKiemKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void dataTimKhach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
