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
    public partial class SuaNhanVien : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=LAPTOP-AA8F4MMK;Initial Catalog=QuanLyNhaTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public SuaNhanVien()
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
            dataSuaNhanVien.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from ChucVuNV";
            adapter.SelectCommand = cmd;
            adapter.Fill(table1);
            cmbSuaCV.DataSource = table1;
            cmbSuaCV.DisplayMember = "TenCV";
            cmbSuaCV.ValueMember = "MaCV";
            cmbSuaCV.SelectedItem = null;
            cmbSuaCV.Text = "";
            conn.Open();
            loaddata();
        }

        private void dataSuaNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataSuaNhanVien.CurrentRow.Index;
            txtSuaMa.Text = dataSuaNhanVien.Rows[i].Cells[0].Value.ToString();
            txtSuaTen.Text = dataSuaNhanVien.Rows[i].Cells[1].Value.ToString();
            txtSuaSDT.Text = dataSuaNhanVien.Rows[i].Cells[2].Value.ToString();
            txSuaDiaChi.Text = dataSuaNhanVien.Rows[i].Cells[3].Value.ToString();
            datimeSuaNgayS.Text = dataSuaNhanVien.Rows[i].Cells[4].Value.ToString();
            if (dataSuaNhanVien.Rows[i].Cells[5].Value.ToString() == "Nam")
            {
                radSuaNam.Checked = true;
            }
            if (dataSuaNhanVien.Rows[i].Cells[5].Value.ToString() == "Nữ")
            {
                radSuaNu.Checked = true;

            }
            else
            {
                radSuaKhac.Checked = true;
            }
            string ChucVuNV = dataSuaNhanVien.CurrentRow.Cells[6].Value.ToString();
            cmbSuaCV.Text = ChucVuNV;
        }

        private void btnOkSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                string gt;
                if (radSuaNam.Checked)
                {
                    gt = "Nam";
                }
                if (radSuaNu.Checked)
                {
                    gt = "Nữ";
                }
                else
                {
                    gt = "Khác";
                }
                cmd.CommandText = "update NhanVien set TenNV = N'" + txtSuaTen.Text + "' ,SĐT=N'" + txtSuaSDT.Text + "' ,DiaChi=N'" + txSuaDiaChi.Text + "' ,NgaySinh='" + datimeSuaNgayS.Value.ToString() + "' ,GioiTinh=N'" + gt + "',MaCV= '" + cmbSuaCV.SelectedValue.ToString() + "'where MaNV=N'" + txtSuaMa.Text + "'";
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Cap nhat du lieu thanh cong!", "Thong Bao", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {

            }
        }

        private void btnCanelSuaNV_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien qlnv = new QuanLyNhanVien();
            Hide();
            qlnv.Show();
            this.Close();
        }
    }
}
