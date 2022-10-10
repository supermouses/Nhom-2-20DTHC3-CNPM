using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
<<<<<<< Updated upstream
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
=======
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream

        private void QlyBT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlyTroBoTuDataSet.PhieuBaoTri' table. You can move, or remove it, as needed.
            this.phieuBaoTriTableAdapter.Fill(this.qlyTroBoTuDataSet.PhieuBaoTri);
            // TODO: This line of code loads data into the 'qlyTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            this.khachThueTroTableAdapter.Fill(this.qlyTroBoTuDataSet.KhachThueTro);
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from PhieuBaoTri";
            adapter.SelectCommand = cmd;
            conn.Open();

        }
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from PhieuBaoTri";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataBaoTri.DataSource = dt;
=======
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaPBT,MaNV,MaPT,MaTN,NgayBT,NgayLapPBT from PhieuBaoTri";
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
            cmd.CommandText = "select MaPBT,MaNV,MaPT,MaTN,NgayBT,NgayLapPBT from PhieuBaoTri";
            adapter.SelectCommand = cmd;
            conn.Open();
            loadata();
>>>>>>> Stashed changes
        }

        private void dataBaoTri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataBaoTri.CurrentRow.Index;
<<<<<<< Updated upstream
            txtPBT.Text = dataBaoTri.Rows[i].Cells[0].Value.ToString();
            txtMaNVBT.Text = dataBaoTri.Rows[i].Cells[1].Value.ToString();
            txtMaPhong.Text = dataBaoTri.Rows[i].Cells[2].Value.ToString();
            txtMaTN.Text = dataBaoTri.Rows[i].Cells[3].Value.ToString();
            dtNgayBT.Text = dataBaoTri.Rows[i].Cells[4].Value.ToString();
            dtLapPBT.Text = dataBaoTri.Rows[i].Cells[5].Value.ToString();
=======
            txtMaPBT.Text = dataBaoTri.Rows[i].Cells[0].Value.ToString();
            txtNVBT.Text = dataBaoTri.Rows[i].Cells[1].Value.ToString();
            txtPhong.Text = dataBaoTri.Rows[i].Cells[2].Value.ToString();
            txtTN.Text = dataBaoTri.Rows[i].Cells[3].Value.ToString();
            dtNgay.Text = dataBaoTri.Rows[i].Cells[4].Value.ToString();
            dtNgaylap.Text = dataBaoTri.Rows[i].Cells[5].Value.ToString();
        }

        private void btnCancelBT_Click(object sender, EventArgs e)
        {
            MENU m = new MENU();
            Hide();
            m.Show();
            this.Close();
>>>>>>> Stashed changes
        }

        private void btnThemBT_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into PhieuBaoTri values('" + txtPBT.Text + "' , N'" + txtMaNVBT.Text + "' ,'" + txtMaPhong.Text + "', '" + txtMaTN.Text + "' ,'" + dtNgayBT.Value + "' , '" + dtLapPBT.Value.ToString() + "')";
            cmd.ExecuteNonQuery();
            loadata();
            MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnrollbackBT_Click(object sender, EventArgs e)
        {
            MENU mENU = new MENU();
            Hide();
            mENU.Show();
            this.Close();
=======
            if (txtMaPBT.Text == "" || txtNVBT.Text == "" || txtPhong.Text == "" || txtTN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cmd = conn.CreateCommand();
                    string gt;
                    cmd.CommandText = "insert into KhachThueTro values('" + txtMaPBT.Text + "' ,N'" + txtNVBT.Text + "', N'" + txtPhong.Text + "' ,'" + txtTN.Text + "',N'" + dtNgay.Value.ToString() + "','" + dtNgaylap.Value.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    loadata();
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Tồn Tại mã này.");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from PhieuBaoTri where MaPBT= '" + txtMaPBT.Text + "'";
            cmd.ExecuteNonQuery();
            loadata();
            MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnSuaBT_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            string gt;
            cmd.CommandText = "update PhieuBaoTri set MaNV = N'" + txtNVBT.Text + "' ,MaNV=N'" + txtPhong.Text + "',MaPT=N'" + txtTN.Text + "',MaTN=N'" + dtNgay.Value.ToString() + dtNgaylap.Value.ToString() + "'where MaPBT = N'" + txtMaPBT.Text + "'";
            cmd.ExecuteNonQuery();
            loadata();
            MessageBox.Show("Sửa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
>>>>>>> Stashed changes
        }
    }
}
