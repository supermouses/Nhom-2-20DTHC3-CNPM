using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace NhaTroBoTu
{
    public partial class ThemKhachHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QuanLyPhongTroBoTu;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        //static string str = "Data Source=MSI\\MSSQLSERVER2;Initial Catalog=QuanLyPhongTroBoTu;Integrated Security=True";
        //SqlConnection conn = new SqlConnection(str);

        public ThemKhachHang()
        {
            InitializeComponent();
        }
        void loadata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select *from KhachThueTro";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataThemKhach.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataThemKhach.CurrentRow.Index;
            txtThemMAKH.Text = dataThemKhach.Rows[i].Cells[0].Value.ToString();
            txtThemTENKH.Text = dataThemKhach.Rows[i].Cells[1].Value.ToString();
            if (dataThemKhach.Rows[i].Cells[2].Value.ToString() == "Nam")
            {
                rdThemNamKH.Checked = true;
            }
            if (dataThemKhach.Rows[i].Cells[2].Value.ToString() == "Nữ")
            {
                rdThemNUKH.Checked = true;

            }
            else
            {
                rdThemKhacKH.Checked = true;
            }
            txtThemSDTKH.Text = dataThemKhach.Rows[i].Cells[3].Value.ToString();
            txtDiaChiKH.Text = dataThemKhach.Rows[i].Cells[4].Value.ToString();
            txThemCCCDKH.Text = dataThemKhach.Rows[i].Cells[5].Value.ToString();
            dtThemKH.Text = dataThemKhach.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            //if (txtThemMAKH.Equals(""))
            //{
            //    MessageBox.Show("Khong duoc de trong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //try
            //{
            //    if (conn.State == ConnectionState.Closed)
            //        conn.Open();
            //    SqlCommand cmd = new SqlCommand("Insert into QuanLyPhongTroBoTu values(@MAKH,@TENKH,@GIOITINH,@DC,SDT,CCCD,NAMSINH", conn);
            //    cmd.Parameters.AddWithValue("@MAKH", txtThemMAKH.Text);
            //    cmd.Parameters.AddWithValue("@TENKH", txtThemTENKH.Text);
            //    cmd.Parameters.AddWithValue("@DC", txtDiaChiKH.Text);
            //    cmd.Parameters.AddWithValue("@SDT", txtThemSDTKH.Text);
            //    cmd.Parameters.AddWithValue("@CCCD", txThemCCCDKH.Text);
            //    cmd.Parameters.AddWithValue("NAMSINH", dtThemKH.Value.ToString("yyyy / MM / dd"));
            //    cmd = conn.CreateCommand();
            //    if (rdThemNamKH.Checked)
            //    {
            //        cmd.Parameters.AddWithValue("@GIOITINH", true);
            //    }
            //    if (rdThemNUKH.Checked)
            //    {
            //        cmd.Parameters.AddWithValue("@GIOITINH", true);
            //    }
            //    else
            //    {
            //        cmd.Parameters.AddWithValue("@GIOITINH", false);
            //    }
            //    cmd.ExecuteNonQuery();
            //    if (conn.State == ConnectionState.Closed)
            //        conn.Open();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            cmd = conn.CreateCommand();
            string gt;
            if (rdThemNamKH.Checked)
            {
                gt = "Nam";
            }
            else if (rdThemNUKH.Checked)
            {
                gt = "Nu";
            }
            else
            {
                gt = "Khac";
            }
            cmd.CommandText = "insert into KhachThueTro values('" + txtThemMAKH.Text + "' , N'" + txtThemTENKH.Text + "' ,'" + gt + "', '" + txtThemSDTKH.Text + "' ,N'" + txtDiaChiKH.Text + "', '" + txThemCCCDKH.Text + "','" + dtThemKH.Value.ToString() + "')";
            cmd.ExecuteNonQuery();
            loadata();
            MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyPhongTroBoTuDataSet.KhachThueTro' table. You can move, or remove it, as needed.
            this.khachThueTroTableAdapter.Fill(this.quanLyPhongTroBoTuDataSet.KhachThueTro);
            DataTable table1 = new DataTable();
            conn = new SqlConnection(str);
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from KhachThueTro";
            adapter.SelectCommand = cmd;
            conn.Open();
            //loadata();
        }

        private void btnCancelKH_Click(object sender, EventArgs e)
        {
            QlyKH qlyKH = new QlyKH();
            Hide();
            qlyKH.Show();
            this.Close();
        }
        //try
        //{
        //    if (conn.State == ConnectionState.Closed);
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("Select *from KhachThueTro", conn);
        //    SqlDataReader read = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Load(read);
        //    dataThemKhach.DataSource = dt;
        //    if (conn.State == ConnectionState.Open)
        //        conn.Close();
        //}
        //catch(Exception ex)
        //{
        //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
            
