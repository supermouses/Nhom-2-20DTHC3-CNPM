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
    public partial class QlyBT : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public QlyBT()
        {
            InitializeComponent();
        }
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from PhieuBaoTri";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataBaoTri.DataSource = dt;
        }

        private void QlyBT_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from PhieuBaoTri";
            adapter.SelectCommand = cmd;
            adapter.Fill(table1);
            txtNVBT.DataSource = table1;
            txtNVBT.DisplayMember = "MaNV";
            txtNVBT.ValueMember = "MaNV";
            txtNVBT.SelectedItem = true;
            txtNVBT.Text = "";
            conn.Open();
            loadata();
        }

        private void dataBaoTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataBaoTri.CurrentRow.Index;
            txtMaPBT.Text = dataBaoTri.Rows[i].Cells[0].Value.ToString();
            string c = dataBaoTri.CurrentRow.Cells[1].Value.ToString();
            txtNVBT.Text = c;
            txtMACTBT.Text = dataBaoTri.Rows[i].Cells[2].Value.ToString();
        }

        private void btnCancelBT_Click(object sender, EventArgs e)
        {
            MENU m = new MENU();
            Hide();
            m.Show();
            this.Close();
        }

        private void btnThemBT_Click(object sender, EventArgs e)
        {
            if (txtMaPBT.Text == "" || txtNVBT.Text == "" || txtMACTBT.Text ==  "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //try
                //{
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into PhieuBaoTri values('" + txtMaPBT.Text + "',N'" + txtNVBT.SelectedValue.ToString() + "','" + txtMACTBT.Text + "')";
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
                cmd.CommandText = "delete from PhieuBaoTri where MaPBT= '" + txtMaPBT.Text + "'";
                cmd.ExecuteNonQuery();
                loadata();
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnSuaBT_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update PhieuBaoTri set MaNV = N'" + txtNVBT.SelectedValue.ToString() + "' ,MaCTPBT=N'" + txtMACTBT.Text + "'where MaPBT = N'" + txtMaPBT.Text + "'";
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
            i = dataBaoTri.CurrentRow.Index;
            txtMaPBT.Text = dataBaoTri.Rows[i].Cells[0].Value.ToString();
            string ChucVuNV = dataBaoTri.CurrentRow.Cells[1].Value.ToString();
            txtNVBT.Text = ChucVuNV;
            txtMACTBT.Text = dataBaoTri.Rows[i].Cells[2].Value.ToString();
        }

        private void dataBaoTri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string s;
            if (MessageBox.Show("Bạn có muốn hiện thị thông tin chi tiết ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                s = dataBaoTri.CurrentRow.Cells["MaCTPBT"].Value.ToString();
                ChiTietBaoTri ctiet = new ChiTietBaoTri();
                ctiet.txtMACTBT = s;
                ctiet.StartPosition = FormStartPosition.CenterParent;
                ctiet.ShowDialog();
            }
        }
    }
}
