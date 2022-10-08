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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class QlyKH : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QuanLyPhongTroBoTu;Integrated Security=True");
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
            this.khachThueTroTableAdapter.Fill(this.quanLyPhongTroBoTuDataSet.KhachThueTro);
            conn.Open();
            load();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            MENU mn = new MENU();
            Hide();
            mn.Show();
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
    }
}
