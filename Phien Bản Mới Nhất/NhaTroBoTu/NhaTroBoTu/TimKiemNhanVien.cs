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
    public partial class TimKiemNhanVien : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-AA8F4MMK;Initial Catalog=QuanLyNhaTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public TimKiemNhanVien()
        {
            InitializeComponent();
        }     
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaNV,TenNV,SĐT,DiaChi,NgaySinh,GioiTinh,TenCV,Luong from NhanVien,ChucVuNV where NhanVien.MaCV = ChucVuNV.MaCV ";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataTimNhanVien.DataSource = dt;
        }
        void loadtimma()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaNV,TenNV,SĐT,DiaChi,NgaySinh,GioiTinh,TenCV,Luong from NhanVien,ChucVuNV where NhanVien.MaCV = ChucVuNV.MaCV and NhanVien.MaNV = N'" + txtTim.Text+"'";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataTimNhanVien.DataSource = dt;
        }
        void loadtimten()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaNV,TenNV,SĐT,DiaChi,NgaySinh,GioiTinh,TenCV,Luong from NhanVien,ChucVuNV where NhanVien.MaCV = ChucVuNV.MaCV and NhanVien.TenNV  like N'%" + txtTim.Text + "%'";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataTimNhanVien.DataSource = dt;
        }

        private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from ChucVuNV";
            adapter.SelectCommand = cmd;
            adapter.Fill(table1);
            conn.Open();
            loaddata();
            cmbTim.Text = "Mã Nhân Viên";
        }
        private void dataTimNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    cmd = conn.CreateCommand();
        //    if (cmbTim.Text == "Mã Nhân Viên")
        //    {
        //        loadtimma();
             
        //    }
        //    if(cmbTim.Text == "Tên Nhân Viên")
        //    {
        //        loadtimten();
        //    }    
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            Hide();
            quanLyNhanVien.Show();
            this.Close();
        }

        private void dataTimNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (cmbTim.Text == "Mã Nhân Viên")
            {
                loadtimma();

            }
            if (cmbTim.Text == "Tên Nhân Viên")
            {
                loadtimten();
            }
        }
    }
}
