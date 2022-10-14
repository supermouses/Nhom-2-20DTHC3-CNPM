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
    /// Interaction logic for WindowEditStatus.xaml
    /// </summary>
    public partial class WindowEditStatus : Window
    {
        public WindowEditStatus()
        {
            InitializeComponent();
        }

        public delegate void added();
        public added done;

        int statusID;

        public int StatusID
        {
            set
            {
                statusID = value;
            }
        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            updateData();

            if (done != null)
            {
                done();
            }
        }

        private void updateData()
        {
            if (validateData())
            {
                DMDataContext db = new DMDataContext();

                db.spuUpdateStatus(statusID,tbStatus.Text);
                MessageBox.Show("Đã cập nhật!");
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

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DMDataContext db = new DMDataContext();

            var s = (spuGetStatusByIDResult)db.spuGetStatusByID(statusID).Single();

            lbStatusID.Content = s.StatusID;
            tbStatus.Text = s.StatusName;
        }
    }
}
