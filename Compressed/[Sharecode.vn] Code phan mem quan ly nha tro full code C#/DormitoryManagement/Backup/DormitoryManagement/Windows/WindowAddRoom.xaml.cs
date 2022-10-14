using System;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using System.Threading;

namespace DormitoryManagement.Windows
{
    /// <summary>
    /// Interaction logic for WindowAddRoom.xaml
    /// </summary>
    public partial class WindowAddRoom : Window
    {
        public WindowAddRoom()
        {
            InitializeComponent();
        }

        public delegate void added();
        public added done;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {            
            loadRoomType();
            loadRoomStatus();
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
        }       

        private void loadRoomStatus()
        {
            DMDataContext db = new DMDataContext();            
            cbStatus.ItemsSource = db.spuGetRoomStatus();            
        }

        private void loadRoomType()
        {
            DMDataContext db = new DMDataContext();
            //Load Room Type                  
            cbRoomType.Items.Clear();
            var types = db.spuGetRoomType();

            foreach (var t in types)
            {
                cbRoomType.Items.Add(t);
            }
            spuGetRoomTypeResult temp = new spuGetRoomTypeResult();
            temp.Price = 0;
            temp.TypeID = 999;
            temp.TypeName = "Thêm mới";
            cbRoomType.Items.Add(temp);
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

                var rt = (spuGetRoomTypeResult)cbRoomType.SelectedItem;
                var s = (spuGetRoomStatusResult)cbStatus.SelectedItem;
                db.spuAddRoom(
                    tbRoomName.Text,
                    rt.TypeID,
                    s.StatusID, 
                    int.Parse(tbCapicity.Text), 
                    dateCome.Text,
                    int.Parse(tbElectricNo.Text),
                    int.Parse(tbWaterNo.Text)
                    );
                MessageBox.Show("Một phòng đã được thêm");
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private bool validateData()
        {
            if (tbRoomName.Text.Trim() == "" || tbCapicity.Text.Trim() == "" || cbStatus.Text.Trim() == ""
                || cbRoomType.Text == "")
            {
                return false;
            }

            try
            {
                int.Parse(tbCapicity.Text);
                int.Parse(tbElectricNo.Text);
                int.Parse(tbWaterNo.Text);
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void cbRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (spuGetRoomTypeResult) cbRoomType.SelectedItem;
            if (a!= null && a.TypeName == "Thêm mới")
            {
                WindowAddRoomType rt = new WindowAddRoomType();
                rt.ShowDialog();                
                loadRoomType();
            }
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbStatus_LostFocus(object sender, RoutedEventArgs e)
        {
            var a = cbStatus.SelectedItem;

            if (a == null && cbStatus.Text.Trim() != "")
            {
                foreach (var i in cbStatus.Items)
                {
                    if (((spuGetRoomStatusResult)i).StatusName == cbStatus.Text.Trim())
                    {
                        return;
                    }
                }

                DMDataContext db = new DMDataContext();
                db.spuAddStatus(cbStatus.Text);
                loadRoomStatus();
            }          
        }
    }
}
