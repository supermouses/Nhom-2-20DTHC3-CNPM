using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;

namespace DormitoryManagement.UC
{
    /// <summary>
    /// Interaction logic for UCGuestList.xaml
    /// </summary>
    public partial class UCGuestList : UserControl
    {
        public UCGuestList()
        {
            InitializeComponent();
        }

        private void btAddGuest_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddGuest ag = new DormitoryManagement.Windows.WindowAddGuest();
            ag.done = new DormitoryManagement.Windows.WindowAddGuest.added(loadGuests);
            ag.ShowDialog();
        }

        private void btEditGuest_Click(object sender, RoutedEventArgs e)
        {
            if (lvGuestList.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khách cẩn sửa thông tin!");
            }
            else
            {
                var t = (ListViewItem) lvGuestList.SelectedItem;
                var g = (spuGetGuestListResult)t.Content;
               
                Windows.WindowEditGuest eg = new DormitoryManagement.Windows.WindowEditGuest();
                eg.GuestID = g.ID;
                eg.done = new DormitoryManagement.Windows.WindowEditGuest.added(loadGuests);               
                eg.ShowDialog();                
            }
        }

        private void btDeleteGuest_Click(object sender, RoutedEventArgs e)
        {
            if (lvGuestList.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khách cần xóa!");
            }
            else
            {
                var t = (ListViewItem)lvGuestList.SelectedItem;
                var a = (spuGetGuestListResult)t.Content;                

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + a.CustomerName, "Cảnh báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {   
                    DMDataContext db = new DMDataContext();
                    db.spuDeleteGuest(a.ID);                        
                    MessageBox.Show("Đã xóa!");
                    loadGuests();
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            loadGuests();
        }

        private void loadGuests()
        {
            DMDataContext db = new DMDataContext();

            var guests = db.spuGetGuestList();
            lvGuestList.Items.Clear();

            foreach (var g in guests)
            {
                ListViewItem item = new ListViewItem();

                item.Content = g;                
                item.ToolTip = createTooltip(g);
                lvGuestList.Items.Add(item);
            }            
        }

        private Grid createTooltip(spuGetGuestListResult g)
        {   
            Grid gr = new Grid();

            //Guest Photo
            Image img = new Image();
            img.HorizontalAlignment = HorizontalAlignment.Left;
            img.Margin = new Thickness(12,22,0,152);
            img.Stretch = Stretch.Fill;
            img.Width = 130;
            img.Height = 160;

            string location = AppDomain.CurrentDomain.BaseDirectory;
            byte[] buffer = System.IO.File.ReadAllBytes(location + "\\Photos\\" + g.Photo);
            MemoryStream ms = new MemoryStream(buffer);

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = ms;
            image.EndInit();
            img.Source = image;            

            //Guest Name
            TextBlock tb = new TextBlock();
            tb.FontSize = 16;
            tb.FontWeight = FontWeights.Bold;
            tb.Foreground = new BrushConverter().ConvertFromString("#FF116A98") as SolidColorBrush;
            tb.Height = 20;
            tb.Text = g.CustomerName;
            tb.Margin = new Thickness(140, 22, 10, 0);
            tb.TextAlignment = TextAlignment.Center;
            tb.TextWrapping = TextWrapping.Wrap;
            tb.VerticalAlignment = VerticalAlignment.Top;

            //Birthday              
            TextBlock bd = new TextBlock();
            bd.Height = 20;
            bd.Width = 120;
            bd.HorizontalAlignment = HorizontalAlignment.Right;
            bd.FontSize = 12;
            bd.FontWeight = FontWeights.Bold;                        
            bd.Text = g.Birthday;
            bd.Margin = new Thickness(0,49,10,0);
            bd.TextAlignment = TextAlignment.Left;            
            bd.VerticalAlignment = VerticalAlignment.Top;

            //Sex            
            TextBlock se = new TextBlock();
            se.Height = 20;
            se.Width = 120;            
            se.FontSize = 12;
            se.FontWeight = FontWeights.Bold;            
            se.Margin = new Thickness(160, 49, 136, 0);
            se.TextAlignment = TextAlignment.Left;
            se.VerticalAlignment = VerticalAlignment.Top;

            if (g.Sex)
            {
                se.Text = "Nam";
            }
            else
            {
                se.Text = "Nữ";
            }

            //Guest ID
            TextBlock id = new TextBlock();
            id.Height = 20;
            id.Width = 56;
            id.FontSize = 12;
            id.FontWeight = FontWeights.Bold;
            id.FlowDirection = FlowDirection.RightToLeft;
            id.Margin = new Thickness(0, 0, 0, 0);
            id.TextAlignment = TextAlignment.Left;
            id.VerticalAlignment = VerticalAlignment.Top;
            id.HorizontalAlignment = HorizontalAlignment.Right;
            id.Text = g.ID.ToString();
             
            //Room
            TextBlock room = new TextBlock();
            room.Height = 20;            
            room.FontSize = 12;
            room.FontWeight = FontWeights.Bold;            
            room.Margin = new Thickness(160,76,12,0);            
            room.VerticalAlignment = VerticalAlignment.Top;            
            room.Text = g.Name;

            //Mobile Phone
            TextBlock mb = new TextBlock();
            mb.Height = 20;
            mb.FontSize = 12;
            mb.FontWeight = FontWeights.Bold;
            mb.Margin = new Thickness(160, 107, 12, 0);
            mb.VerticalAlignment = VerticalAlignment.Top;
            mb.Text = "Di động: " + g.MobilePhone;      
      
            //Telephone
            TextBlock tp = new TextBlock();
            tp.Height = 20;
            tp.FontSize = 12;
            tp.FontWeight = FontWeights.Bold;
            tp.Margin = new Thickness(160, 134, 12, 0);
            tp.VerticalAlignment = VerticalAlignment.Top;
            tp.Text = "Điện thoại bàn: " + g.Telephone;   

            //Address
            TextBlock addr = new TextBlock();
            addr.Height = 20;
            addr.FontSize = 12;
            addr.FontWeight = FontWeights.Normal;
            addr.Margin = new Thickness(12, 0, 10, 114);
            addr.VerticalAlignment = VerticalAlignment.Bottom;
            addr.Text = "Địa chỉ: " + g.Address;

            //Note
            TextBlock note = new TextBlock();
            note.Height = 105;
            note.FontSize = 12;
            note.FontWeight = FontWeights.Normal;
            note.Margin = new Thickness(12, 0, 10, 8);
            note.VerticalAlignment = VerticalAlignment.Bottom;
            note.Text = g.Note;

            gr.Children.Add(img);
            gr.Children.Add(tb);
            gr.Children.Add(bd);
            gr.Children.Add(se);
            gr.Children.Add(id);
            gr.Children.Add(room);
            gr.Children.Add(mb);
            gr.Children.Add(tp);
            gr.Children.Add(addr);
            gr.Children.Add(note);

            return gr;
        }

        private void lvGuestList_MouseEnter(object sender, MouseEventArgs e)
        {
           
        }

        private void lvGuestList_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
