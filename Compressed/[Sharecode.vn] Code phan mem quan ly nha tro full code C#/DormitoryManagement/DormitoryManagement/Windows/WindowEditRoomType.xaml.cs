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
    /// Interaction logic for WindowEditRoomType.xaml
    /// </summary>
    public partial class WindowEditRoomType : Window
    {
        public WindowEditRoomType()
        {
            InitializeComponent();
        }

        public delegate void added();
        public added done;

        int typeID;

        public int TypeID
        {
            set
            {
                typeID = value;
            }
        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            if (validateData())
            {
                updateData();
                if (done != null)
                {
                    done();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void updateData()
        {
            DMDataContext db = new DMDataContext();
            db.spuUpdateRoomType(typeID, tbTypeName.Text, decimal.Parse(tbPrice.Text));
            MessageBox.Show("Đã cập nhật!");
        }

        private bool validateData()
        {
            if (tbPrice.Text.Trim() == "" || tbTypeName.Text.Trim() == "")
            {
                return false;
            }

            try
            {
                var t = decimal.Parse(tbPrice.Text);

                if (t < 0)
                    return false;
            }
            catch
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
            var rt = (spuGetRoomTypeByIDResult) db.spuGetRoomTypeByID(typeID).Single();

            lbTypeID.Content = typeID.ToString();
            tbPrice.Text = rt.Price.ToString();
            tbTypeName.Text = rt.TypeName;
        }
    }
}
