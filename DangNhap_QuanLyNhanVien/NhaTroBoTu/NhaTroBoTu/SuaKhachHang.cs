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
    public partial class SuaKhachHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QuanLyPhongTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public SuaKhachHang()
        {
            InitializeComponent();
        }

        private void dataXoaKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataSuaKhach.CurrentRow.Index;
            txtmaSuaKhach.Text = dataSuaKhach.Rows[i].Cells[0].Value.ToString();
            txtTenSuaKH.Text = dataSuaKhach.Rows[i].Cells[1].Value.ToString();
            if (dataSuaKhach.Rows[i].Cells[2].Value.ToString() == "Nam")
            {
                rdSuaNamKH.Checked = true;
            }
            if (dataSuaKhach.Rows[i].Cells[2].Value.ToString() == "Nữ")
            {
                rdSuaNuKH.Checked = true;

            }
            else
            {
                rdSuaKhacKH.Checked = true;
            }
            txtSuaDiaChiKH.Text = dataSuaKhach.Rows[i].Cells[3].Value.ToString();
            txtSuaSDTKH.Text = dataSuaKhach.Rows[i].Cells[4].Value.ToString();
            txtSuaCCCDKH.Text = dataSuaKhach.Rows[i].Cells[5].Value.ToString();
            dtSuaKH.Text = dataSuaKhach.Rows[i].Cells[6].Value.ToString();
        }
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MAKH,TENKH,GIOITINH,DC,SDT,CCCD,NAMSINH from KhachThueTro";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataSuaKhach.DataSource = dt;
        }

        private void SuaKhachHang_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select MAKH,TENKH,GIOITINH,DC,SDT,CCCD,NAMSINH from KhachThueTro";
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            conn.Open();
            loaddata();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
                cmd = conn.CreateCommand();
                string gt;
                if (rdSuaNamKH.Checked)
                {
                    gt = "Nam";
                }
                if (rdSuaNuKH.Checked)
                {
                    gt = "Nu";
                }
                else
                {
                    gt = "Khác";
                }
                //cmd.CommandText = "update KhachThueTro set TENKH = N'" + txtTenSuaKH.Text + "',GIOITINH=N'" + gt + "',SDT'" + txtSuaSDTKH.Text + "' ,DC=N'" + txtSuaDiaChiKH.Text + "',CCCD'" + txtSuaCCCDKH.Text + "',NAMSINH=N'" + dtSuaKH.Value.ToString() + "'where MAKH = N'" + txtmaSuaKhach.Text + "'";
                  cmd.CommandText = "update KhachThueTro set TENKH = N'" + txtTenSuaKH.Text + "' ,GIOITINH=N'" + gt + "',DC=N'" + txtSuaDiaChiKH.Text + "',SDT = '" + txtSuaSDTKH.Text + "',CCCD ='" + txtSuaCCCDKH.Text + "',NAMSINH=N'" + dtSuaKH.Value.ToString() + "'where MAKH = N'" + txtmaSuaKhach.Text + "'";
                cmd.ExecuteNonQuery();
            /*MAKH = N'" + txtmaSuaKhach.Text + "',*/
            loaddata();
                MessageBox.Show("Sửa dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

private void btnSuaCancelKH_Click(object sender, EventArgs e)
        {
            QlyKH qlyKH = new QlyKH();
            Hide();
            qlyKH.Show();
            this.Close(); ;
            
        }
    }
}
