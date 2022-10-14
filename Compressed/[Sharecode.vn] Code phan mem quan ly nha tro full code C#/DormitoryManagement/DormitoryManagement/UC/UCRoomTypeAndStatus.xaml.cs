using System.Windows;
using System.Windows.Controls;

namespace DormitoryManagement.UC
{
    /// <summary>
    /// Interaction logic for UCRoomTypeAndStatus.xaml
    /// </summary>
    public partial class UCRoomTypeAndStatus : UserControl
    {
        public UCRoomTypeAndStatus()
        {
            InitializeComponent();
        }

        private void btAddRoomType_Click(object sender, RoutedEventArgs e)
        {
            WindowAddRoomType rt = new WindowAddRoomType();
            rt.done = new WindowAddRoomType.added(loadRoomType);
            rt.ShowDialog();
        }

        private void btEditRoomType_Click(object sender, RoutedEventArgs e)
        {
            if (lvRoomType.SelectedItem != null)
            {
                Windows.WindowEditRoomType ert = new DormitoryManagement.Windows.WindowEditRoomType();
                var typeID = (spuGetRoomTypeResult)lvRoomType.SelectedItem;
                ert.TypeID = typeID.TypeID;
                ert.done = new DormitoryManagement.Windows.WindowEditRoomType.added(loadRoomType);
                ert.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn loại cần thay đổi thông tin!");
            }
        }

        private void btDeleteRoomType_Click(object sender, RoutedEventArgs e)
        {
            if (lvRoomType.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại cần xóa!");
            }
            else
            {
                var a = (spuGetRoomTypeResult)lvRoomType.SelectedItem;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + a.TypeName, "Cảnh báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {                    
                    string error = "";
                    DMDataContext db = new DMDataContext();
                    db.spuDeleteRoomTypeByID(a.TypeID,ref error);
                    loadRoomType();
                    MessageBox.Show(error);
                }
            }
        }

        private void btAddStatus_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddStatus ast = new DormitoryManagement.Windows.WindowAddStatus();
            ast.done = new DormitoryManagement.Windows.WindowAddStatus.added(loadStatus);
            ast.ShowDialog();
        }

        private void btEditStatus_Click(object sender, RoutedEventArgs e)
        {
            if (lvRoomStatus.SelectedItem != null)
            {
                var statusID = (spuGetRoomStatusResult)lvRoomStatus.SelectedItem;
                Windows.WindowEditStatus es = new DormitoryManagement.Windows.WindowEditStatus();
                es.StatusID = statusID.StatusID;
                es.done = new DormitoryManagement.Windows.WindowEditStatus.added(loadStatus);
                es.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chọn trạng thái cần thay đổi thông tin!");
            }            
        }

        private void btDeleteStatus_Click(object sender, RoutedEventArgs e)
        {
            if (lvRoomStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn Trạng Thái cần xóa!");
            }
            else
            {
                var a = (spuGetRoomStatusResult)lvRoomStatus.SelectedItem;

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + a.StatusName, "Cảnh báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    string error = "";
                    DMDataContext db = new DMDataContext();
                    db.spuDeleteStatus(a.StatusID, ref error);
                    loadStatus();
                    MessageBox.Show(error);
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            loadRoomType();
            loadStatus();
        }

        private void loadStatus()
        {
            DMDataContext db = new DMDataContext();

            lvRoomStatus.ItemsSource = db.spuGetRoomStatus();
        }

        private void loadRoomType()
        {
            DMDataContext db = new DMDataContext();
            //Load Room Type                  
            lvRoomType.ItemsSource = db.spuGetRoomType();
        }
    }
}
