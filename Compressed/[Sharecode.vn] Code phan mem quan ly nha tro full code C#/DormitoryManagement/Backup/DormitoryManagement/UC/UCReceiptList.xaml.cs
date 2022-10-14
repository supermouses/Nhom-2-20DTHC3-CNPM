using System.Windows;
using System.Windows.Controls;

namespace DormitoryManagement.UC
{
    /// <summary>
    /// Interaction logic for UCReceiptList.xaml
    /// </summary>
    public partial class UCReceiptList : UserControl
    {
        public UCReceiptList()
        {
            InitializeComponent();
        }

        private void btAddReceipt_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddReceipt ar = new DormitoryManagement.Windows.WindowAddReceipt();
            ar.done = new DormitoryManagement.Windows.WindowAddReceipt.added(loadReceipts);
            ar.ShowDialog();
        }

        private void btEditReceipt_Click(object sender, RoutedEventArgs e)
        {
            var receipt = (spuGetReceiptsResult)lvReceiptList.SelectedItem;

            if (receipt.StatusName == "Đã Thanh Toán")
            {
                MessageBox.Show("Không thể thay đổi thông tin hóa đơn đã thanh toán!");
                return;
            }

            Windows.WindowEditReceipt er = new DormitoryManagement.Windows.WindowEditReceipt();
            er.ReceiptID = receipt.ReceiptID;
            er.done = new DormitoryManagement.Windows.WindowEditReceipt.added(loadReceipts);
            er.ShowDialog();
        }

        private void btDeleteReceipt_Click(object sender, RoutedEventArgs e)
        {
            if (lvReceiptList.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!");
            }
            else
            {
                var a = (spuGetReceiptsResult)lvReceiptList.SelectedItem;                

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn " + a.ReceiptID.ToString(), "Cảnh báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    DMDataContext db = new DMDataContext();
                    db.spuDeleteReceipt(a.ReceiptID);
                    db.spuDeleteElectricity(a.RoomID, a.Date);
                    db.spuDeleteWater(a.RoomID, a.Date);
                    MessageBox.Show("Đã xóa!");
                    loadReceipts();
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            loadReceipts();
        }

        private void loadReceipts()
        {
            DMDataContext db = new DMDataContext();
            lvReceiptList.ItemsSource = db.spuGetReceipts();
        }
    }
}
