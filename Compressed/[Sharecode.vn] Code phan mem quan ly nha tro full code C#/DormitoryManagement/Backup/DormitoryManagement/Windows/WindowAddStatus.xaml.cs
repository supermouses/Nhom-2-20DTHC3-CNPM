using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DormitoryManagement.Windows
{
    /// <summary>
    /// Interaction logic for WindowAddStatus.xaml
    /// </summary>
    public partial class WindowAddStatus : Window
    {
        public WindowAddStatus()
        {
            InitializeComponent();
        }

        public delegate void added();
        public added done;

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            addData();

            if (done != null)
            {
                done();
            }
        }

        private void addData()
        {
            if (validateData())
            {
                DMDataContext db = new DMDataContext();

                db.spuAddStatus(tbStatus.Text);
                MessageBox.Show("Một Trạng Thái đã được thêm");
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private bool validateData()
        {
            if (tbStatus.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
    }
}
