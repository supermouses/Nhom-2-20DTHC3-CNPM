using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using System.Threading;

namespace DormitoryManagement.Windows
{
    /// <summary>
    /// Interaction logic for WindowEditRoom.xaml
    /// </summary>
    public partial class WindowEditRoom : Window
    {
        public WindowEditRoom()
        {
            InitializeComponent();
        }

        int roomID;
        public delegate void done();
        public done Finish;

        public int RoomID
        {
            set
            {
                roomID = value;
            }
        }

        private void cbRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void cbStatus_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            updateRoom();

            if (Finish != null)
            {
                Finish();
            }
        }

        private void updateRoom()
        {
            if (validateData())
            {
                DMDataContext db = new DMDataContext();

                var rt = (spuGetRoomTypeResult)cbRoomType.SelectedItem;
                var s = (spuGetRoomStatusResult)cbStatus.SelectedItem;

                if (s.StatusName == "Trống" || s.StatusName == "Đặt cọc")
                {
                    int? no = 0;
                    db.spuGetNoOfPeople(roomID,ref no);

                    if (no > 0)
                    {
                        MessageBox.Show("Phòng này đang có người ở!");
                        return;
                    }
                }

                db.spuUpdateRoom(
                    roomID, 
                    tbRoomName.Text,
                    rt.TypeID, 
                    s.StatusID,
                    int.Parse(tbCapicity.Text),
                    dateCome.Text,
                    int.Parse(tbElectricNo.Text),
                    int.Parse(tbWaterNo.Text)
                    );
                MessageBox.Show("Đã cập nhật!");
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
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

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {            
            loadRoomType();
            loadRoomStatus();
            loadRoom();
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
        }       

        private void loadRoom()
        {
            DMDataContext db = new DMDataContext();

            var r = (spuGetRoomByIDResult)db.spuGetRoomByID(roomID).Single();

            //Set Item to ComboBox
            int t = 0;
            foreach(var i in cbRoomType.Items)
            {
                var temp = (spuGetRoomTypeResult) i;
                if (temp.TypeID == r.TypeID)
                {
                    break;
                }
                t++;
            }

            lbRoomID.Content = r.RoomID.ToString();
            tbRoomName.Text = r.Name;
            tbCapicity.Text = r.Capacity.ToString();            
            cbRoomType.SelectedIndex = t;
            cbStatus.Text = r.StatusName;
            dateCome.Text = r.ComingDate;
            tbElectricNo.Text = r.ElectricNo.ToString();
            tbWaterNo.Text = r.WaterNo.ToString();
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
    }
}
