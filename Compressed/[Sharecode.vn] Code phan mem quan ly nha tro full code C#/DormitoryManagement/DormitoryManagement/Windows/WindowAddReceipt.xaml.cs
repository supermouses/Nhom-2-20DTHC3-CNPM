using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using System.Threading;

namespace DormitoryManagement.Windows
{
    /// <summary>
    /// Interaction logic for WindowAddReceipt.xaml
    /// </summary>
    public partial class WindowAddReceipt : Window
    {
        public WindowAddReceipt()
        {
            InitializeComponent();
        }

        public delegate void added();
        public added done;

        DateTime month;
        int roomID;
        decimal electricFee = 0;
        decimal waterFee = 0;
        decimal otherFee = 0;

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
                var r = (spuGetUsingRoomResult)cbRoom.SelectedItem;
                var s = (spuGetReceiptStatusResult)cbStatus.SelectedItem;

                db.spuAddElectricNo
                (
                    roomID,
                    tbMonth.Text + "/" + tbYear.Text,
                    int.Parse(tbOldElectricNo.Text),
                    int.Parse(tbNewElectricNo.Text)                    
                );

                db.spuAddWaterNo
                (
                    roomID,
                    tbMonth.Text + "/" + tbYear.Text,
                    int.Parse(tbOldWaterNo.Text),
                    int.Parse(tbNewWaterNo.Text)                    
                );

                db.spuAddReceipt(
                                    r.RoomID,
                                    decimal.Parse(tbRoomFee.Text),
                                    waterFee,
                                    electricFee,
                                    otherFee,
                                    tbNote.Text,
                                    decimal.Parse(tbDebt.Text),
                                    tbMonth.Text + "/" + tbYear.Text,
                                    s.StatusID
                                    );

                MessageBox.Show("Đã thêm thành công");
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }

        private bool validateData()
        {
            if (cbRoom.SelectedItem == null || tbNewElectricNo.Text.Trim() == ""
                || tbNewWaterNo.Text.Trim() == "" || tbOtherFee.Text.Trim() == ""
                || tbPay.Text.Trim() == "" || cbStatus.SelectedItem == null)
            {
                return false;
            }

            try
            {
                decimal.Parse(tbNewWaterNo.Text);
                decimal.Parse(tbNewElectricNo.Text);
                decimal.Parse(tbOtherFee.Text);
                decimal.Parse(tbPay.Text);
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;

            month = DateTime.Now;
            lbDate.Content = month.Date;
            
            loadRooms();           
            caculateFee();
            loadReceiptStatus();

            lbElectricFee.Content = "";
            lbWaterFee.Content = "";
        }

        private void loadReceiptStatus()
        {
            DMDataContext db = new DMDataContext();
            cbStatus.ItemsSource = db.spuGetReceiptStatus();
        }        

        private void loadRooms()
        {
            DMDataContext db = new DMDataContext();
            cbRoom.ItemsSource = db.spuGetUsingRoom();
        }

        private void cbRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DMDataContext db = new DMDataContext();
            var r = (spuGetUsingRoomResult)cbRoom.SelectedItem;

            var type = (spuGetRoomByIDResult)db.spuGetRoomByID(r.RoomID).Single();
            tbRoomFee.Text = type.Price.ToString();
            
            roomID = r.RoomID;
            string latestReceipt = "";
            db.spuGetLatestMonthReceipt(roomID, ref latestReceipt);

            if (latestReceipt != "")
            {
                string[] temp = latestReceipt.Split('/');
                tbMonth.Text = (int.Parse(temp[0].Trim()) + 1).ToString();
                tbYear.Text = temp[1].Trim();
            }
            else
            {
                tbMonth.Text = month.Month.ToString();
                tbYear.Text = month.Year.ToString();
            }

            tbOldElectricNo.Text = r.ElectricNo.ToString();
            tbOldWaterNo.Text = r.WaterNo.ToString();
        }      

        private void tbNewElectricNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int newNumber = int.Parse(tbNewElectricNo.Text);

                int no = newNumber - int.Parse(tbOldElectricNo.Text);

                if (no < 0)
                {
                    lbElectricFee.Content = "0";
                    electricFee = 0;
                }
                else
                {
                    DMDataContext db = new DMDataContext();
                    var electric = (spuGetElectricFeeResult) db.spuGetElectricFee().Single();
                    lbElectricFee.Content = no.ToString() + " x " + electric.FeeCost.ToString()
                                            + " = " + (no * electric.FeeCost).ToString();
                    electricFee = electric.FeeCost * no;                    
                }
                caculateFee();
            }
            catch
            {
                MessageBox.Show("Chỉ được nhập số nguyên");
            }
        }

        private void caculateFee()
        {
            if (tbRoomFee.Text == "")
            {
                return;
            }

            tbTotal.Text = (electricFee + waterFee + otherFee + decimal.Parse(tbRoomFee.Text)).ToString();
            tbPay.Text = (electricFee + waterFee + otherFee + decimal.Parse(tbRoomFee.Text)).ToString();
            tbDebt.Text = (decimal.Parse(tbTotal.Text) - decimal.Parse(tbPay.Text)).ToString();
        }

        private void tbNewWaterNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int newNumber = int.Parse(tbNewWaterNo.Text);

                int no = newNumber - int.Parse(tbOldWaterNo.Text) ;

                if (no < 0)
                {
                    lbWaterFee.Content = "0";
                    waterFee = 0;
                }
                else
                {
                    DMDataContext db = new DMDataContext();
                    var water = (spuGetWaterFeeResult)db.spuGetWaterFee().Single();
                    lbWaterFee.Content = no.ToString() + " x " + water.FeeCost.ToString()
                                            + " = " + (no * water.FeeCost).ToString();
                    waterFee = water.FeeCost * no;
                }
                caculateFee();
            }
            catch
            {
                MessageBox.Show("Chỉ được nhập số nguyên");
            }
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbOtherFee_TextChanged(object sender, TextChangedEventArgs e)
        {
            otherFee = decimal.Parse(tbOtherFee.Text);
            caculateFee();
        }

        private void tbPay_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                tbDebt.Text = (decimal.Parse(tbTotal.Text) - decimal.Parse(tbPay.Text)).ToString(); 
            }
            catch
            {
                MessageBox.Show("Chỉ được nhập số nguyên!");
            }
        }

        private void tbOldElectricNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbNewElectricNo.Text.Trim() == "")
                return;

            int newNumber = int.Parse(tbNewElectricNo.Text);

            int no = newNumber - int.Parse(tbOldElectricNo.Text);

            if (no < 0)
            {
                lbElectricFee.Content = "0";
                electricFee = 0;
            }
            else
            {
                DMDataContext db = new DMDataContext();
                var electric = (spuGetElectricFeeResult)db.spuGetElectricFee().Single();
                lbElectricFee.Content = no.ToString() + " x " + electric.FeeCost.ToString()
                                        + " = " + (no * electric.FeeCost).ToString();
                electricFee = electric.FeeCost * no;
            }
            caculateFee();
        }

        private void tbOldWaterNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbNewWaterNo.Text.Trim() == "")
                return;

            int newNumber = int.Parse(tbNewWaterNo.Text);

            int no = newNumber - int.Parse(tbOldWaterNo.Text);

            if (no < 0)
            {
                lbWaterFee.Content = "0";
                waterFee = 0;
            }
            else
            {
                DMDataContext db = new DMDataContext();
                var water = (spuGetWaterFeeResult)db.spuGetWaterFee().Single();
                lbWaterFee.Content = no.ToString() + " x " + water.FeeCost.ToString()
                                        + " = " + (no * water.FeeCost).ToString();
                waterFee = water.FeeCost * no;
            }
            caculateFee();
        }
    }
}