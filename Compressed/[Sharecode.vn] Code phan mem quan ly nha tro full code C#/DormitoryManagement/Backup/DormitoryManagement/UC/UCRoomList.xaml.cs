using System.Windows;
using System.Windows.Controls;

namespace DormitoryManagement.UC
{
    /// <summary>
    /// Interaction logic for UCRoomList.xaml
    /// </summary>
    public partial class UCRoomList : UserControl
    {
        public UCRoomList()
        {
            InitializeComponent();
        }

        private void WindowRoomList_Loaded(object sender, RoutedEventArgs e)
        {
            loadRooms();
        }

        private void loadRooms()
        {
            DMDataContext db = new DMDataContext();
            var rooms = db.spuGetRooms();
            lvRoomList.ItemsSource = rooms;
        }

        private void btAddRoom_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddRoom wa = new DormitoryManagement.Windows.WindowAddRoom();
            wa.done = new DormitoryManagement.Windows.WindowAddRoom.added(loadRooms);
            wa.ShowDialog();
        }

        private void btEditRoom_Click(object sender, RoutedEventArgs e)
        {
            if (lvRoomList.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
            }
            else
            {
                Windows.WindowEditRoom er = new DormitoryManagement.Windows.WindowEditRoom();
                var a = (spuGetRoomsResult) lvRoomList.SelectedItem;
                er.RoomID = a.RoomID;
                er.Finish = new DormitoryManagement.Windows.WindowEditRoom.done(loadRooms);
                er.ShowDialog();
            }
        }

        private void btDeleteRoom_Click(object sender, RoutedEventArgs e)
        {
            if (lvRoomList.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa!");
            }
            else
            {
                var a = (spuGetRoomsResult) lvRoomList.SelectedItem;
                string info = "";

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + a.Name, "Cảnh báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (a.StatusName == "Trống" || a.StatusName == "Hư hỏng")
                    {
                        try
                        {
                            DMDataContext db = new DMDataContext();
                            db.spuDeleteRoom(a.RoomID, ref info);
                            loadRooms();
                            MessageBox.Show(info);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể hủy phòng này! Vui lòng xóa các hóa đơn của phòng " + a.Name);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy phòng này! Vui lòng kiểm tra lại trạng thái của phòng");
                    }
                }
            }
        }        
    }
}
