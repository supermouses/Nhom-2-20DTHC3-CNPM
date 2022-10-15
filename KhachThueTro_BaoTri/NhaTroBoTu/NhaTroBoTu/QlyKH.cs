using NhaTroBoTu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class QlyKH : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QlyTroBoTu;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();

        public QlyKH()
        {
            InitializeComponent();
        }
        void load()
        {
            DataTable dt = new DataTable();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from KhachThueTro";
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            //this.khachThueTroTableAdapter.Fill(this.quanLyPhongTroBoTuDataSet.KhachThueTro);
            load();
            conn.Open();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(string.Format(System.Globalization.CultureInfo.CreateSpecificCulture("vi-vn"), "{0:ddd, dd MMM yyyy tt}", dtKH.Value));
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            rdNamKH.Enabled = false;
            rdNuKH.Enabled = false;
            rdKhacKH.Enabled = false;
            txtSDTKH.Enabled = false;
            txtDiaChiKH.Enabled = false;
            txtCCCD.Enabled = false;
            dtKH.Enabled = false;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaKH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Nam")
            {
                rdNamKH.Checked = true;
            }
            else if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Nữ")
            {
                rdNuKH.Checked = true;

            }
            else
            {
                rdKhacKH.Checked = false;
            }
            txtSDTKH.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDiaChiKH.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtCCCD.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            dtKH.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            //string str = "insert into KhachThueTro(MAKH,TENKH,CCCD) values('" + txtMaKH + "','" + txtTenKH + "','" + txtCCCD + "'";

            //if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtCCCD.Text != "")
            //{
            //    cmd = new SqlCommand("insert into KhachThueTro(MAKH,TENKH,CCCD) values('1234','tinh','12354')", conn);
            //    cmd.Parameters.AddWithValue("@MAKH", txtMaKH.Text);
            //    cmd.Parameters.AddWithValue("@TENKH", txtTenKH.Text);
            //    cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
            //    conn.Close();
            //    MessageBox.Show("Them thanh cong!");
            //}
            //else
            //{
            //    MessageBox.Show("Nhap sai du lieu moi nhap lai!");
            //}
            ThemKhachHang KHT = new ThemKhachHang();
            Hide();
            KHT.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuQlyPhong mnpl = new MenuQlyPhong();
            Hide();
            mnpl.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XoaKhachHang xkh = new XoaKhachHang();
            Hide();
            xkh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SuaKhachHang skh = new SuaKhachHang();
            Hide();
            skh.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimKiemKhachHang timKiemKhachHang = new TimKiemKhachHang();
            Hide();
            timKiemKhachHang.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void phieuphatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuPhat pp = new PhieuPhat();
            Hide();
            pp.Show();
            this.Close();
        }

        private void QlyKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhieuPhat pp = new PhieuPhat();
            Hide();
            pp.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            rdNamKH.Enabled = false;
            rdNuKH.Enabled = false;
            rdKhacKH.Enabled = false;
            txtSDTKH.Enabled = false;
            txtDiaChiKH.Enabled = false;
            txtCCCD.Enabled = false;
            dtKH.Enabled = false;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtMaKH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Nam")
            {
                rdNamKH.Checked = true;
            }
            else if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "Nữ")
            {
                rdNuKH.Checked = true;

            }
            else
            {
                rdKhacKH.Checked = false;
            }
            txtSDTKH.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDiaChiKH.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtCCCD.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            dtKH.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }
    }
}
