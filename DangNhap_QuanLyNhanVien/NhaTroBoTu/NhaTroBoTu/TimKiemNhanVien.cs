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
            cmd.CommandText = "select MaNV,TenNV,SĐT,DiaChi,NgaySinh,GioiTinh,TenCV from NhanVien,ChucVuNV where NhanVien.MaCV = ChucVuNV.MaCV";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataTimNhanVien.DataSource = dt;
        }
        private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            this.khachThueTroTableAdapter.Fill(this.quanLyPhongTroBoTuDataSet.KhachThueTro);
            loaddata();
        }
    }
}
