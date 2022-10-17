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
    public partial class QlyHD : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public QlyHD()
        {
            InitializeComponent();
        }
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from HopDong";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataHopDong.DataSource = dt;
        }

        private void QlyBT_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from KhachThueTro";
            adapter.SelectCommand = cmd;
            adapter.Fill(table1);
            cmbKHHD.DataSource = table1;
            cmbKHHD.DisplayMember = "TenKH";
            cmbKHHD.ValueMember = "MaKH";
            cmbKHHD.SelectedItem = true;
            cmbKHHD.Text = "";
            conn.Open();
            loadata();
        }

        private void dataBaoTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataHopDong.CurrentRow.Index;
            txtMaHD.Text = dataHopDong.Rows[i].Cells[0].Value.ToString();
            string c = dataHopDong.CurrentRow.Cells[1].Value.ToString();
            cmbKHHD.Text = c;
        }

        private void btnCancelBT_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Dispose();
            MENU m = new MENU();
            m.Show();
        }

        private void btnThemBT_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || cmbKHHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //try
                //{
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into HopDong values('" + txtMaHD.Text + "',N'" + cmbKHHD.SelectedValue.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    loadata();
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Đã Tồn Tại mã này.");
                //}
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chưa??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from HopDong where MaHD= '" + txtMaHD.Text + "'";
                cmd.ExecuteNonQuery();
                loadata();
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnSuaBT_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update HopDong set MaHD = N'" + cmbKHHD.SelectedValue.ToString() + "'where MaHD = N'" + txtMaHD.Text + "'";
            cmd.ExecuteNonQuery();
            loadata();
            MessageBox.Show("Sửa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void QlyBT_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void dataBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMaPBT.Enabled = false;
            int i;
            i = dataHopDong.CurrentRow.Index;
            txtMaHD.Text = dataHopDong.Rows[i].Cells[0].Value.ToString();
            string Kh = dataHopDong.CurrentRow.Cells[1].Value.ToString();
            cmbKHHD.Text = Kh;
        }

        private void dataBaoTri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string s;
            if (MessageBox.Show("Bạn có muốn hiện thị thông tin chi tiết ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                s = dataHopDong.CurrentRow.Cells["MaHD"].Value.ToString();
                ChiTietHopDong ctiet = new ChiTietHopDong(s);
                ctiet.StartPosition = FormStartPosition.CenterParent;
                ctiet.ShowDialog();
            }
        }
    }
}
