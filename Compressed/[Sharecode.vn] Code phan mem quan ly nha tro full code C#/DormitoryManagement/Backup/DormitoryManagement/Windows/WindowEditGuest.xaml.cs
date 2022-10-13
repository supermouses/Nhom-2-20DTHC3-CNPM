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
    /// Interaction logic for WindowEditGuest.xaml
    /// </summary>
    public partial class WindowEditGuest : Window
    {
        public WindowEditGuest()
        {
            InitializeComponent();
        }

        public delegate void added();
        public added done;
       
        int guestID;
        int roomID;
        bool isChangedPhoto = false;
        string photo;

        public int GuestID
        {
            set
            {
                guestID = value;
            }
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
                ImageSource img = new BitmapImage(new Uri(dlg.FileName, UriKind.Absolute));
                pbPhoto.Source = img;
                isChangedPhoto = true;
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

                var room = (spuGetRoomsResult)cbRoom.SelectedItem;
                if (roomID != room.RoomID)
                {
                    int? count = 0;
                    db.spuGetGuestInRoom(roomID, ref count);

                    if (count == 1)
                    {
                        var statusID = (spuGetStatusIDByStatusNameResult) db.spuGetStatusIDByStatusName("Trống").Single();
                        db.spuUpdateRoomStatus(roomID, statusID.StatusID);
                        db.spuUpdateRoomComingDate(room.RoomID, "");
                    }
                }

                if (isChangedPhoto)
                {
                    if (photo == "NoPicture.jpg")
                    {
                        photo = System.IO.Path.GetRandomFileName() +
                    System.IO.Path.GetFileName(pbPhoto.Source.ToString());
                    }
                    string source = pbPhoto.Source.ToString().Substring(8);
                    string location = AppDomain.CurrentDomain.BaseDirectory;
                    File.Copy(source, location + "\\Photos\\" + photo, true);                    
                }
                
                db.spuUpdateGuest(
                                guestID,
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

                var status = (spuGetRoomStatusByIDResult)db.spuGetRoomStatusByID(room.StatusID).Single();
                if (status.StatusName == "Trống")
                {
                    spuGetStatusIDByStatusNameResult t = (spuGetStatusIDByStatusNameResult)db.spuGetStatusIDByStatusName("Sử dụng").Single();
                    db.spuUpdateRoomStatus(room.RoomID, t.StatusID);


                    DateTime today = DateTime.Now;
                    db.spuUpdateRoomComingDate(room.RoomID, today.Date.ToShortDateString());
                }

                MessageBox.Show("Đã cập nhật!");
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

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadRooms();
            loadGuest();
        }

        private void loadRooms()
        {
            DMDataContext db = new DMDataContext();
            cbRoom.ItemsSource = db.spuGetRooms();
        }

        private void loadGuest()
        {
            DMDataContext db = new DMDataContext();

            var g = (spuGetGuestByIDResult)db.spuGetGuestByID(guestID).Single();
            roomID = g.RoomID;
            //Set Item to ComboBox
            int t = 0;
            foreach (var i in cbRoom.Items)
            {
                var temp = (spuGetRoomsResult)i;
                if (temp.RoomID == g.RoomID)
                {
                    break;
                }
                t++;
            }

            lbGuestID.Content = guestID.ToString();
            tbGuestName.Text = g.CustomerName;
            tbAddress.Text = g.Address;
            if (g.Sex)
            {
                rbMale.IsChecked = true;
            }
            else
            {
                rbFeMale.IsChecked = true;
            }
            tbTelephone.Text = g.Telephone;
            tbMobilePhone.Text = g.MobilePhone;
            tbNote.Text = g.Note;

            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;
            Birthday.Text = DateTime.Parse(g.Birthday).ToString();
            cbRoom.SelectedIndex = t;

            photo = g.Photo;
            string location = AppDomain.CurrentDomain.BaseDirectory;

            byte[] buffer = System.IO.File.ReadAllBytes(location + "\\Photos\\" + g.Photo);
            MemoryStream ms = new MemoryStream(buffer);

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = ms;
            image.EndInit();

            pbPhoto.Source = image;
            
            //pbPhoto.Source = new BitmapImage(new Uri(location + "\\Photos\\" + g.Photo)); ;
        }
    }
}
