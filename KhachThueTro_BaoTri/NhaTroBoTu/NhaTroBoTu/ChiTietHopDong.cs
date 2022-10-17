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
    public partial class ChiTietHopDong : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        string _Ma;
        
        public ChiTietHopDong(string MaCTHopDong)
        {
            InitializeComponent();
            _Ma = MaCTHopDong;
        }
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from ChiTietHopDong where ChiTietHopDong.MaHD = @MaHD";
            cmd.Parameters.Add("@MaHD", SqlDbType.NChar);
            cmd.Parameters["@MaHD"].Value = _Ma;
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataCTHopDong.DataSource = dt;
        }

        private void ChiTietBaoTri_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from KhachThueTro";
            adapter.SelectCommand = cmd;
            adapter.Fill(table1);
            cmbCTKH.DataSource = table1;
            cmbCTKH.DisplayMember = "TenKH";
            cmbCTKH.ValueMember = "MaKH";
            cmbCTKH.SelectedItem = true;
            cmbCTKH.Text = "";
            DataTable table2 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from HopDong";
            adapter.SelectCommand = cmd;
            adapter.Fill(table2);
            txtMaHD.DataSource = table2;
            txtMaHD.DisplayMember = "MaHD";
            txtMaHD.ValueMember = "MaHD";
            txtMaHD.SelectedItem = true;
            cmbCTKH.Text = "";
            conn.Open();
            loadata();
        }

        private void dataBaoTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemBT_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || cmbCTKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into ChiTietHopDong values('" + txtCTHD.Text + "',N'"+ cmbCTKH.SelectedValue.ToString()+ "',N'" + txtMaHD.SelectedValue.ToString() + "',N'" + txtPhong.Text +"',N'" + dtNgaylap.Value.ToString() +"', '" + dtNgay.Value.ToString() + "', '"+ txtND.Text + "')";
                cmd.ExecuteNonQuery();
                loadata();
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chưa??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from ChiTietHopDong where MaCTHopDong= '" + txtCTHD.Text + "'";
                cmd.ExecuteNonQuery();
                loadata();
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnSuaBT_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            //cmd.CommandText = "update ChiTietHopDong set MaCTHopDong = N'" + cmbCTKH.SelectedValue.ToString() + "', N'" + txtMaHD.SelectedValue.ToString() + "',N '" + txtPhong.Text + "',N '"+ dtNgaylap.Value.ToString() +"','" + dtNgay.Value.ToString() + "', '" + txtND.Text + "'where MaCTHopDong = N'" + txtCTHD.Text + "'";
            cmd.CommandText = "update ChiTietHopDong set MaKH = N'" + cmbCTKH.SelectedValue.ToString() + "',MaHD=N'" + txtMaHD.SelectedValue.ToString() +"',MaPT=N'"+ txtPhong.Text +"',NgayLapHopDong='"+dtNgaylap.Value.ToString()+"',NgayHanHopDong='"+dtNgay.Value.ToString()+"',NoiDung=N'"+txtND.Text+"'where MaCTHopDong = N'" + txtCTHD.Text + "'";
            cmd.ExecuteNonQuery(); 
            loadata();
            MessageBox.Show("Sửa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnCancelBT_Click(object sender, EventArgs e)
        {
            //QlyBT qlt = new QlyBT();
            //Hide();
            //qlt.Show();
            this.Dispose();
        }

        private void dataCTHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataCTHopDong.CurrentRow.Index;
            txtCTHD.Text = dataCTHopDong.Rows[i].Cells[0].Value.ToString();
            string Kh = dataCTHopDong.CurrentRow.Cells[1].Value.ToString();
            cmbCTKH.Text = Kh;
            string hd = dataCTHopDong.CurrentRow.Cells[2].Value.ToString();
            txtMaHD.Text = hd;
            txtPhong.Text = dataCTHopDong.Rows[i].Cells[3].Value.ToString();
            dtNgaylap.Text = dataCTHopDong.Rows[i].Cells[4].Value.ToString();
            dtNgay.Text = dataCTHopDong.Rows[i].Cells[5].Value.ToString();
            txtND.Text = dataCTHopDong.Rows[i].Cells[6].Value.ToString();
        }
    }
}
