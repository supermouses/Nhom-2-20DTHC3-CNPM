using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DormitoryManagement
{
	/// <summary>
	/// Interaction logic for WindowAddRoomType.xaml
	/// </summary>
	public partial class WindowAddRoomType : Window
	{
		public WindowAddRoomType()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        public delegate void added();
        public added done;

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            if (validateData())
            {
                addData();
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

        private void addData()
        {
            DMDataContext db = new DMDataContext();
            db.spuAddRoomType(tbTypeName.Text, decimal.Parse(tbPrice.Text));
            MessageBox.Show("Thêm thành công");
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
	}
}