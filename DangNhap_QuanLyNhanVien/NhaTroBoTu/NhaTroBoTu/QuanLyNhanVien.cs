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
    public partial class QuanLyNhanVien : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-AA8F4MMK;Initial Catalog=QuanLyNhaTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public QuanLyNhanVien()
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
            dataNhanVien.DataSource = dt;
        }
        //void load_timMa()
        //{
        //    cmd = conn.CreateCommand();
        //    cmd.CommandText = "select MaNV,TenNV,SĐT,DiaChi,NgaySinh,GioiTinh,TenCV from NhanVien,ChucVuNV where NhanVien.MaCV = ChucVuNV.MaCV and NhanVien.MaNV = '"+ txtMaNV+"'";
        //    adapter.SelectCommand = cmd;
        //    dt.Clear();
        //    adapter.Fill(dt);
        //    dataNhanVien.DataSource = dt;
        //}

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from ChucVuNV";
            adapter.SelectCommand = cmd;
            adapter.Fill(table1);
            cmbChucVu.DataSource = table1;
            cmbChucVu.DisplayMember = "TenCV";
            cmbChucVu.ValueMember = "MaCV";
            cmbChucVu.SelectedItem = null;
            cmbChucVu.Text = "";
            conn.Open();
            loaddata();
        }

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataNhanVien.CurrentRow.Index;
            txtMaNV.Text = dataNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dataNhanVien.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dataNhanVien.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dataNhanVien.Rows[i].Cells[3].Value.ToString();
            dtimeNgayNV.Text = dataNhanVien.Rows[i].Cells[4].Value.ToString();
            if (dataNhanVien.Rows[i].Cells[5].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            if (dataNhanVien.Rows[i].Cells[5].Value.ToString() == "Nữ")
            {
                radNu.Checked = true;

            }
            else
            {
                radKhac.Checked = true;
            }
            string ChucVuNV = dataNhanVien.CurrentRow.Cells[6].Value.ToString();
            cmbChucVu.Text = ChucVuNV;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //cmd = conn.CreateCommand();
            //string gt;
            //if (radNam.Checked)
            //{
            //    gt = "Nam";
            //}
            //if (radNu.Checked)
            //{
            //    gt = "Nữ";
            //}
            //else
            //{
            //    gt = "Khác";
            //}
            //cmd.CommandText = "insert into NhanVien values('" + txtMaNV.Text + "' , N'" + txtTenNV.Text + "' , '" + txtSDT.Text + "' ,N'" + txtDiaChi.Text + "', '" + dtimeNgayNV.Value.ToString() + "', N'" + gt + "' ,N'" + cmbChucVu.SelectedValue.ToString() + "')";
            //cmd.ExecuteNonQuery();
            //loaddata();
            ThemNhanVien NV = new ThemNhanVien();
            Hide();
            NV.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaNhanVien XoaNV = new XoaNhanVien();
            Hide();
            XoaNV.ShowDialog();
            //    cmd = conn.CreateCommand();
            //    cmd.CommandText = "delete from NhanVien where MaNV= '" + txtMaNV.Text + "'";
            //    cmd.ExecuteNonQuery();
            //    loaddata();
            }

            //private void btnSua_Click(object sender, EventArgs e)
            //{
            //    cmd = conn.CreateCommand();
            //    string gt;
            //    if (radNam.Checked)
            //    {
            //        gt = "Nam";
            //    }
            //    if (radNu.Checked)
            //    {
            //        gt = "Nữ";
            //    }
            //    else
            //    {
            //        gt = "Khác";
            //    }
            //    cmd.CommandText = "update NhanVien set TenNV = N'" + txtTenNV.Text + "' ,SĐT=N'" + txtSDT.Text + "' ,DiaChi=N'" + txtDiaChi.Text + "' ,NgaySinh='" + dtimeNgayNV.Value.ToString() + "' ,GioiTinh=N'" + gt + "',MaCV= '" + cmbChucVu.SelectedValue.ToString() + "'where MaNV=N'" + txtMaNV.Text + "'";
            //    cmd.ExecuteNonQuery();
            //    loaddata();
            //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //load_timMa();
            TimKiemNhanVien TimkiemNV = new TimKiemNhanVien();
            Hide();
            TimkiemNV.ShowDialog();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            MENU danhmuc = new MENU();
            Hide();
            danhmuc.Show();         
            this.Close();
        }

        private void btnSuaNew_Click(object sender, EventArgs e)
        {
            //cmd = conn.CreateCommand();
            //string gt;
            //if (radNam.Checked)
            //{
            //    gt = "Nam";
            //}
            //if (radNu.Checked)
            //{
            //    gt = "Nữ";
            //}
            //else
            //{
            //    gt = "Khác";
            //}
            //cmd.CommandText = "update NhanVien set TenNV = N'" + txtTenNV.Text + "' ,SĐT=N'" + txtSDT.Text + "' ,DiaChi=N'" + txtDiaChi.Text + "' ,NgaySinh='" + dtimeNgayNV.Value.ToString() + "' ,GioiTinh=N'" + gt + "',MaCV= '" + cmbChucVu.SelectedValue.ToString() + "'where MaNV=N'" + txtMaNV.Text + "'";
            //cmd.ExecuteNonQuery();
            //loaddata();
            SuaNhanVien SuaNV = new SuaNhanVien();
            Hide();
            SuaNV.ShowDialog();
        }
    }
}
