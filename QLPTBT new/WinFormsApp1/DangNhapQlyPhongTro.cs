namespace WinFormsApp1
{
    public partial class DangNhapQlyPhongTro : Form
    {
        string taikhoan = "admin";
        string matkhau ="admin";
        public DangNhapQlyPhongTro()
        {
            InitializeComponent();
        }

        private void DangNhapQlyPhongTro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                MENU menu = new MENU();
                Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai Tên Tài Khoảng Hoặc Mật Khẩu", "Thông Báo");
            }
        }
        bool KiemTraDangNhap (string taikhoan, string matkhau)
        {
            if (taikhoan == this.taikhoan && matkhau==this.matkhau)
            {
                return true;
            }
            return false;
        }
    }
}