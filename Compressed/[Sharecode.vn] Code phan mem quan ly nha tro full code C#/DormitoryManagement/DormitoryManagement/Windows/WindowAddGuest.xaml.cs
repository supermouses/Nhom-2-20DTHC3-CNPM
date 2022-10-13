using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Globalization;
using System.Threading;

namespace DormitoryManagement.Windows
{
    /// <summary>
    /// Interaction logic for WindowAddGuest.xaml
    /// </summary>
    public partial class WindowAddGuest : Window
    {
        public WindowAddGuest()
        {
            InitializeComponent();
        }

        public delegate void added();
        public added done;

        private void WindowAddGuest_Loaded(object sender, RoutedEventArgs e)
        {   
            loadRooms();
            rbMale.IsChecked = true;

            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
        }

        private void loadRooms()
        {
            DMDataContext db = new DMDataContext();
            cbRoom.ItemsSource = db.spuGetRooms();
            
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void pbPhoto_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            
            dlg.DefaultExt = ".jpg"; // Default file extension
            dlg.Filter = "jpg files(.jpg)|*.jpg|Bitmap Files(.bmp)|*.bmp|All Files(*.*)|*.*"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                ImageSource img = new BitmapImage(new Uri(dlg.FileName,UriKind.Absolute));
                pbPhoto.Source = img;
            }            
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
                
                var room = (spuGetRoomsResult) cbRoom.SelectedItem;
                string photo = System.IO.Path.GetRandomFileName() +
                    System.IO.Path.GetFileName(pbPhoto.Source.ToString());

                if (System.IO.Path.GetFileName(pbPhoto.Source.ToString()) == "NoPicture.jpg")
                {
                    photo = "NoPicture.jpg";
                }
                else
                {
                    string location = AppDomain.CurrentDomain.BaseDirectory;
                    string source = pbPhoto.Source.ToString().Substring(8);
                    File.Copy(source, location + "\\Photos\\" +photo);
                }

                db.spuAddGuest(
                                tbGuestName.Text,
                                tbAddress.Text,
                                Birthday.SelectedDate.Value.ToString("dd/MM/yyyy"),
                                rbMale.IsChecked,
                                room.RoomID,
                                tbTelephone.Text,
                                tbMobilePhone.Text,
                                photo,
                                tbNote.Text
                               );
                
                var status =(spuGetRoomStatusByIDResult)db.spuGetRoomStatusByID(room.StatusID).Single();                
                if (status.StatusName == "Trống")
                {
                    spuGetStatusIDByStatusNameResult t = (spuGetStatusIDByStatusNameResult) db.spuGetStatusIDByStatusName("Sử dụng").Single();
                    db.spuUpdateRoomStatus(room.RoomID, t.StatusID);

                    DateTime today = DateTime.Now;                    
                    db.spuUpdateRoomComingDate(room.RoomID, today.Date.ToShortDateString());
                }

                MessageBox.Show("Đã thêm thành công!");
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }

        private bool validateData()
        {
            if (tbGuestName.Text.Trim() == "" || tbAddress.Text.Trim() == "" ||
                cbRoom.SelectedItem == null)
            {
                return false;
            }

            return true;
        }
    }
}
