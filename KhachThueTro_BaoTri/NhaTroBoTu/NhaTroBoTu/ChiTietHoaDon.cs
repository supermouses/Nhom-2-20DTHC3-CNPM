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
    public partial class ChiTietHoaDon : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaCTHoaDon,MaHoaDon,SoDienDau,SoDienCuoi,SoNuocDau,SoNuocCuoi,TongTien from ChiTietHoaDon";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataCTHoaDon.DataSource = dt;
        }
        void loadtimma()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaCTHoaDon,MaHoaDon,SoDienDau,SoDienCuoi,SoNuocDau,SoNuocCuoi,TongTien from ChiTietHoaDon where ChiTietHoaDon.MaCTHoaDon like N'%" + txtTimKiem.Text + "%'";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataCTHoaDon.DataSource = dt;
        }
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void TONG74_Click(object sender, EventArgs e)
        {

        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from ChiTietHoaDon";
            conn.Open();
            loaddata();
        }

        private void dataCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataCTHoaDon.CurrentRow.Index;
            txtMaCTHD.Text = dataCTHoaDon.Rows[i].Cells[0].Value.ToString();
            txtMaHD.Text = dataCTHoaDon.Rows[i].Cells[1].Value.ToString();
            txtDienDau.Text = dataCTHoaDon.Rows[i].Cells[2].Value.ToString();
            txtDienCuoi.Text = dataCTHoaDon.Rows[i].Cells[3].Value.ToString();
            txtNuocDau.Text = dataCTHoaDon.Rows[i].Cells[4].Value.ToString();
            txtNuocCuoi.Text = dataCTHoaDon.Rows[i].Cells[5].Value.ToString();
            txtTien.Text = dataCTHoaDon.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtMaCTHD.Text == "" || txtMaHD.Text == "" || txtDienDau.Text == "" || txtDienCuoi.Text == "" || txtNuocDau.Text == "" || txtNuocCuoi.Text == "" || txtTien.Text == "" )
            //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông Báo", MessageBoxButtons.OK);
            //    else
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into ChiTietHoaDon values(N'" + txtMaCTHD.Text + "'  ,N'" + txtMaHD.Text + "'  ,N'" + txtDienDau.Text + "'  ,N'" + txtDienCuoi.Text + "'  ,N'" + txtNuocDau.Text + "'  ,N'" + txtNuocCuoi.Text + "'  , N'" + txtTien.Text + "')";
            cmd.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }
    
            

            //catch
            //{
            //    MessageBox.Show("Mã bị trùng! Vui lòng nhập lại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        //}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này không? Lưu ý: Dữ liệu sẽ bị mất hoàn toàn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from ChiTietHoaDon where MaCTHoaDon= '" + txtMaCTHD.Text + "'";
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnSuaNew_Click(object sender, EventArgs e)
        //{
        //    if (txtMaCTHD.Text == "" || txtMaHD.Text == "" || txtDienDau.Text == "" || txtDienCuoi.Text == "" || txtNuocDau.Text == "" || txtNuocCuoi.Text == "" || txtTien.Text == "" )
        //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!", "Thông Báo", MessageBoxButtons.OK);
        //    else
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "update ChiTietHoaDon set  MaHoaDon = N'" + txtMaHD.Text + "', SoDienDau ='" + txtDienDau.Text + "', SoDienCuoi ='" + txtDienCuoi.Text + "', SoNuocDau ='" + txtNuocDau.Text + "', SoNuocCuoi = '" + txtNuocCuoi.Text + "', TongTien = '" + txtTien.Text + "'where MaCTHoaDon = N'"+txtMaCTHD.Text+ "'";
                cmd.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //QuanLyHoaDon QLHD = new QuanLyHoaDon();
            //Hide();
            //QLHD.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadtimma();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           //PrintHopDong print = new PrintHopDong();
           //Hide();
           //print.Show();
        }
    }
}
