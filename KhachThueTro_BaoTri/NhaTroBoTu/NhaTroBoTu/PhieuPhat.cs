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
using WinFormsApp1;

namespace NhaTroBoTu
{
    public partial class PhieuPhat : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public PhieuPhat()
        {
            InitializeComponent();
        }
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaPP,MaKH,NgayLapPP,PhiPhat from PhieuPhat";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataPhieuPhat.DataSource = dt;
        }

        private void PhieuPhat_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MaPP,MaKH,NgayLapPP,PhiPhat from PhieuPhat";
            adapter.SelectCommand = cmd;
            conn.Open();
            loadata();
        }

        private void dataPhieuPhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataPhieuPhat.CurrentRow.Index;
            txtMaPP.Text = dataPhieuPhat.Rows[i].Cells[0].Value.ToString();
            txtMaKHPP.Text = dataPhieuPhat.Rows[i].Cells[1].Value.ToString();
            txtMoneyPP.Text = dataPhieuPhat.Rows[i].Cells[3].Value.ToString();
            dtNgayPP.Text = dataPhieuPhat.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThemPP_Click(object sender, EventArgs e)
        {
            if (txtMaPP.Text == "" || txtMaKHPP.Text == "" || txtMoneyPP.Text == "" || dtNgayPP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into PhieuPhat values('" + txtMaPP.Text + "' ,N'" + txtMaKHPP.Text + "', N'" +dtNgayPP.Value.ToString() + "', '" +txtMoneyPP.Text +"')";
                cmd.ExecuteNonQuery();
                loadata();
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoaPP_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from PhieuPhat where MaPP= '" + txtMaPP.Text + "'";
            cmd.ExecuteNonQuery();
            loadata();
            MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnSuaPP_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            //cmd.CommandText = "update PhieuPhat set MaKH = N'" + txtMaKHPP.Text + "',NgayLapPP=N'',PhiPhat=" + txtMoneyPP + "where MaPP =
            cmd.CommandText = "update PhieuPhat set MaKH = N'" + txtMaKHPP.Text + "',NgayLapPP = N'" + dtNgayPP.Value.ToString() + "',PhiPhat ="+ txtMoneyPP.Text.ToString() +"where MaPP =  N'" + txtMaPP.Text +"'";
            cmd.ExecuteNonQuery();
            loadata();
            MessageBox.Show("Sửa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void btnCancelPP_Click(object sender, EventArgs e)
        {
            QlyKH qlyKH = new QlyKH();
            Hide();
            qlyKH.Show();
            this.Close();
        }
    }
}
