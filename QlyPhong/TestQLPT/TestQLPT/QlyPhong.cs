using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace TestQLPT
{

    public partial class QlyPhong : Form
    {
        public QlyPhong()
        {
            InitializeComponent();
        }
        Phong phong = new Phong();
        Boolean them;
        void HienThiDSPhong()
        {
            DataTable dt = phong.LayDSPhong();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        void Settext()
        {
            txtMaPT.Text = "";
            txtTenPT.Text = "";
            txtTT.Text = "";
            txtMoTa.Text = "";
        }
        void Khoatext(bool value)
        {
            txtMaPT.ReadOnly = value;
            txtTenPT.ReadOnly = value;
            txtTT.ReadOnly = value;
            txtMoTa.ReadOnly = value;
            //comboBox1.Enabled= !value;
        }
        void Setbtn(bool value)
        {
            btnThem.Enabled = value;
            btnLuu.Enabled = !value;
            btnHuy.Enabled = !value;
            btnXoa.Enabled = value;
            btnSua.Enabled = value;
            btnTimKiem.Enabled = value;
        }

        void HienThiLoaiPhong()
        {
            DataTable dt = phong.LayLoaiPhongLenComboBox();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "LoaiPhong";
            comboBox1.ValueMember = "MaLoaiPhong";
            
        }

        private void QlyPhong_Load(object sender, EventArgs e)
        {
            rdbTimKiemMa.Visible=false;
            rdbTimKiemTen.Visible=false;
            txtTim.Visible = false;
            btnTim.Visible = false;
            HienThiDSPhong();
            Settext();
            Setbtn(true);
            Khoatext(true);
            HienThiLoaiPhong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Setbtn(false);
            Khoatext(false);
            Settext();
            them = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                if (txtTenPT.Text == "" || txtTenPT.Text == "" || txtMoTa.Text == "" || txtTT.Text == "")
                {
                    MessageBox.Show("Bạn vui lòng nhập đầy đủ thông tin", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    phong.ThemPhong(txtMaPT.Text, txtTenPT.Text, txtMoTa.Text, txtTT.Text, comboBox1.SelectedValue.ToString());
                    listView1.Items.Clear();
                    HienThiDSPhong();
                }
            }
            else if (them == false)
            {
                phong.SuaPhong(txtMaPT.Text, txtTenPT.Text, txtMoTa.Text, txtTT.Text, comboBox1.SelectedValue.ToString());
            }
            listView1.Items.Clear();
            HienThiDSPhong();
            Setbtn(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dr=MessageBox.Show("Bạn có chắc chắn muốn xoá", "THÔNG BÁO", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    phong.XoaPhong(listView1.SelectedItems[0].SubItems[0].Text);
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                    Settext();
                }
            } 
            else
            {
                MessageBox.Show("Bạn phải chọn dòng để xoá", "Thông Báo");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtMaPT.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtTenPT.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtTT.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtMoTa.Text = listView1.SelectedItems[0].SubItems[3].Text;
                comboBox1.SelectedIndex = comboBox1.FindString(listView1.SelectedItems[0].SubItems[4].Text);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Settext();
            Khoatext(true);
            Setbtn(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Setbtn(false);
            Khoatext(false);
            them = false;
        }
     

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            rdbTimKiemTen.Visible = true;
            rdbTimKiemMa.Visible = true;
            txtTim.Visible = true;
            btnTim.Visible = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            rdbTimKiemTen.Visible = false;
            rdbTimKiemMa.Visible = false;
            txtTim.Visible = false;
            btnTim.Visible = false;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (rdbTimKiemMa.Checked)
            {
                phong.Timma(txtTim.Text);
            }
            else if (rdbTimKiemTen.Checked)
            {
                phong.Timten(txtTim.Text);
            }
        }
    }
}

