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
    public partial class XoaNhanVien : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-AA8F4MMK;Initial Catalog=QuanLyNhaTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public XoaNhanVien()
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
            dataXoaNhanVien.DataSource = dt;
        }
        private void btnCanelXoaNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            Hide();
            qlnv.Show();
            this.Close();
        }

        private void btnOkXoaNV_Click(object sender, EventArgs e)
        {          
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from NhanVien where MaNV= '" + txtXoaMa.Text + "'";
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void XoaNhanVien_Load(object sender, EventArgs e)
        {          
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from ChucVuNV";
            adapter.SelectCommand = cmd;
            adapter.Fill(table1);
            cmbXoaCV.DataSource = table1;
            cmbXoaCV.DisplayMember = "TenCV";
            cmbXoaCV.ValueMember = "MaCV";
            cmbXoaCV.SelectedItem = null;
            cmbXoaCV.Text = "";
            conn.Open();
            loaddata();
        }

        private void dataXoaNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataXoaNhanVien.CurrentRow.Index;
            txtXoaMa.Text = dataXoaNhanVien.Rows[i].Cells[0].Value.ToString();
            txtXoaTen.Text = dataXoaNhanVien.Rows[i].Cells[1].Value.ToString();
            txtXoaSDT.Text = dataXoaNhanVien.Rows[i].Cells[2].Value.ToString();
            txtXoaDiaChi.Text = dataXoaNhanVien.Rows[i].Cells[3].Value.ToString();
            datimeXoaNgayS.Text = dataXoaNhanVien.Rows[i].Cells[4].Value.ToString();
            if (dataXoaNhanVien.Rows[i].Cells[5].Value.ToString() == "Nam")
            {
                radXoaNam.Checked = true;
            }
            if (dataXoaNhanVien.Rows[i].Cells[5].Value.ToString() == "Nữ")
            {
                radXoaNu.Checked = true;

            }
            else
            {
                radXoaKhac.Checked = true;
            }
            string ChucVuNV = dataXoaNhanVien.CurrentRow.Cells[6].Value.ToString();
            cmbXoaCV.Text = ChucVuNV;
        }
    }
}
