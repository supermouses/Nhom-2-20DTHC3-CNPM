using System.Windows;

namespace DormitoryManagement
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        public WindowMain()
        {
            InitializeComponent();
        }
        UIElement ui;        

        private void MainApplication_Loaded(object sender, RoutedEventArgs e)
        {            
        }

        private void btRoomList_Checked(object sender, RoutedEventArgs e)
        {
            closeOtherUC("RoomList");

            UC.UCRoomList rl = new DormitoryManagement.UC.UCRoomList();
            rl.Margin = new Thickness(0, 0, 0, 0);
            MainFrame.Children.Add(rl);
            ui = rl;
        }

        private void closeOtherUC(string p)
        {
            switch (p)
            {
                case "RoomList":
                    btGuestList.IsChecked = false;
                    btRoomTypeList.IsChecked = false;
                    btBillList.IsChecked = false;
                    btEW.IsChecked = false;
                    break;
                case "RoomTypeList":
                    btGuestList.IsChecked = false;
                    btRoomList.IsChecked = false;
                    btBillList.IsChecked = false;
                    btEW.IsChecked = false;
                    break;
                case "GuestList":
                    btRoomList.IsChecked = false;
                    btRoomTypeList.IsChecked = false;
                    btBillList.IsChecked = false;
                    btEW.IsChecked = false;
                    break;
                case "BillList":
                    btRoomList.IsChecked = false;
                    btRoomTypeList.IsChecked = false;
                    btGuestList.IsChecked = false;
                    btEW.IsChecked = false;
                    break;
                case "ElectricAndWater":
                    btRoomList.IsChecked = false;
                    btRoomTypeList.IsChecked = false;
                    btGuestList.IsChecked = false;
                    btBillList.IsChecked = false;
                    break;
            }
        }

        private void btRoomTypeList_Checked(object sender, RoutedEventArgs e)
        {
            closeOtherUC("RoomTypeList");

            UC.UCRoomTypeAndStatus tas = new DormitoryManagement.UC.UCRoomTypeAndStatus();
            tas.Margin = new Thickness(0, 0, 0, 0);
            MainFrame.Children.Add(tas);
            ui = tas;
        }

        private void btRoomTypeList_Unchecked(object sender, RoutedEventArgs e)
        {
            MainFrame.Children.Remove(ui);
        }

        private void btRoomList_Unchecked(object sender, RoutedEventArgs e)
        {
            MainFrame.Children.Remove(ui);
        }

        private void btGuestList_Checked(object sender, RoutedEventArgs e)
        {
            closeOtherUC("GuestList");

            UC.UCGuestList gl = new DormitoryManagement.UC.UCGuestList();
            gl.Margin = new Thickness(0, 0, 0, 0);
            MainFrame.Children.Add(gl);
            ui = gl;
        }

        private void btGuestList_Unchecked(object sender, RoutedEventArgs e)
        {
            MainFrame.Children.Remove(ui);
        }

        private void btBillList_Checked(object sender, RoutedEventArgs e)
        {
            closeOtherUC("BillList");

            UC.UCReceiptList rl = new DormitoryManagement.UC.UCReceiptList();
            rl.Margin = new Thickness(0, 0, 0, 0);
            MainFrame.Children.Add(rl);
            ui = rl;
        }

        private void btBillList_Unchecked(object sender, RoutedEventArgs e)
        {
            MainFrame.Children.Remove(ui);
        }

        private void AboutMenu_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAboutMe me = new DormitoryManagement.Windows.WindowAboutMe();
            me.ShowDialog();
        }

        private void btEW_Checked(object sender, RoutedEventArgs e)
        {
            closeOtherUC("ElectricAndWater");
            UC.UCElectricityAndWater ew = new DormitoryManagement.UC.UCElectricityAndWater();
            ew.Margin = new Thickness(0, 0, 0, 0);
            MainFrame.Children.Add(ew);
            ui = ew;
        }

        private void btEW_Unchecked(object sender, RoutedEventArgs e)
        {
            MainFrame.Children.Remove(ui);
        }

        private void calendar1_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
