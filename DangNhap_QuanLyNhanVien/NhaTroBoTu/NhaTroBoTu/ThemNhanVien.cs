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
    public partial class ThemNhanVien : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-AA8F4MMK;Initial Catalog=QuanLyNhaTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public ThemNhanVien()
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
            dataThemNhanVien.DataSource = dt;
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from ChucVuNV";
            adapter.SelectCommand = cmd;
            adapter.Fill(table1);
            cmbThemCV.DataSource = table1;
            cmbThemCV.DisplayMember = "TenCV";
            cmbThemCV.ValueMember = "MaCV";
            cmbThemCV.SelectedItem = null;
            cmbThemCV.Text = "";
            conn.Open();
            loaddata();
        }

        private void dataThemNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataThemNhanVien.CurrentRow.Index;
            txtThemMa.Text = dataThemNhanVien.Rows[i].Cells[0].Value.ToString();
            txtThemTen.Text = dataThemNhanVien.Rows[i].Cells[1].Value.ToString();
            txtThemSDT.Text = dataThemNhanVien.Rows[i].Cells[2].Value.ToString();
            txtThemDiaChi.Text = dataThemNhanVien.Rows[i].Cells[3].Value.ToString();
            datimeThemNgayS.Text = dataThemNhanVien.Rows[i].Cells[4].Value.ToString();
            if (dataThemNhanVien.Rows[i].Cells[5].Value.ToString() == "Nam")
            {
                radThemNam.Checked = true;
            }
            if (dataThemNhanVien.Rows[i].Cells[5].Value.ToString() == "Nữ")
            {
                radThemNu.Checked = true;

            }
            else
            {
                radThemKhac.Checked = true;
            }
            string ChucVuNV = dataThemNhanVien.CurrentRow.Cells[6].Value.ToString();
            cmbThemCV.Text = ChucVuNV;
        }

        private void btnOkThemNV_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            string gt;
            if (radThemNam.Checked)
            {
                gt = "Nam";
            }
            if (radThemNu.Checked)
            {
                gt = "Nữ";
            }
            else
            {
                gt = "Khác";
            }
            cmd.CommandText = "insert into NhanVien values('" + txtThemMa.Text + "' , N'" + txtThemTen.Text + "' , '" + txtThemSDT.Text + "' ,N'" + txtThemDiaChi.Text + "', '" + datimeThemNgayS.Value.ToString() + "', N'" + gt + "' ,N'" + cmbThemCV.SelectedValue.ToString() + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnCanelThemNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            Hide();
            qlnv.Show();
            this.Close();
        }
    }
}
