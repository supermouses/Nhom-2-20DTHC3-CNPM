using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using System.Threading;
using System;

namespace DormitoryManagement.Windows
{
    /// <summary>
    /// Interaction logic for WindowEditReceipt.xaml
    /// </summary>
    public partial class WindowEditReceipt : Window
    {
        public WindowEditReceipt()
        {
            InitializeComponent();
        }

        int receiptID;
        decimal electricFee = 0;
        decimal waterFee = 0;
        decimal otherFee = 0;

        public delegate void added();
        public added done;

        public int ReceiptID
        {
            set
            {
                receiptID = value;
            }
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
                    var electric = (spuGetElectricFeeResult)db.spuGetElectricFee().Single();
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
            catch
            {
                MessageBox.Show("Chỉ được nhập số nguyên");
            }
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
                var s = (spuGetReceiptStatusResult)cbStatus.SelectedItem;                
                var Receipt = (spuGetReceiptByIDResult)db.spuGetReceiptByID(receiptID).Single();

                db.spuUpdateElectricNo
                (
                    Receipt.RoomID,
                    Receipt.Date,                    
                    int.Parse(tbNewElectricNo.Text)
                );

                db.spuUpdateWaterNo
                (
                    Receipt.RoomID,
                    Receipt.Date,
                    int.Parse(tbNewWaterNo.Text)
                );

                db.spuUpdateReceipt(
                                    receiptID,
                                    Receipt.RoomID,
                                    decimal.Parse(tbRoomFee.Text),
                                    waterFee,
                                    electricFee,
                                    otherFee,
                                    tbNote.Text,
                                    decimal.Parse(tbDebt.Text),
                                    Receipt.Date,
                                    s.StatusID
                                    );
                MessageBox.Show("Đã cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }

        private bool validateData()
        {
            if (tbNewElectricNo.Text.Trim() == ""
                || tbNewWaterNo.Text.Trim() == "" || tbOtherFee.Text.Trim() == ""
                || tbPay.Text.Trim() == "")
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

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadReceiptStatus();
            loadReceipt();

            CultureInfo ci = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            ci.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = ci;

            lbDate.Content = DateTime.Today.Date;
        }

        private void loadReceipt()
        {
            DMDataContext db = new DMDataContext();
            var Receipt = (spuGetReceiptByIDResult) db.spuGetReceiptByID(receiptID).Single();

            tbRoomName.Text = Receipt.Name;
            tbRoomFee.Text = Receipt.RoomFee.ToString();
            tbMonth.Text = Receipt.Date.Substring(0,Receipt.Date.IndexOf("/"));
            tbYear.Text = Receipt.Date.Substring(Receipt.Date.IndexOf("/")+1);

            var electric = (spuGetElectricNoResult)db.spuGetElectricNo(Receipt.RoomID, Receipt.Date).Single();
            tbOldElectricNo.Text = electric.OldNumber.ToString();
            tbNewElectricNo.Text = electric.NewNumber.ToString();

            var water = (spuGetWaterNoResult)db.spuGetWaterNo(Receipt.RoomID, Receipt.Date).Single();
            tbOldWaterNo.Text = water.OldNumber.ToString();
            tbNewWaterNo.Text = water.NewNumber.ToString();

            tbOtherFee.Text = Receipt.OtherFee.ToString();
            tbDebt.Text = Receipt.Debt.ToString();
            tbPay.Text = (decimal.Parse(tbTotal.Text) - decimal.Parse(tbDebt.Text)).ToString();
            tbNote.Text = Receipt.Note;

            int i = 0;
            foreach (spuGetReceiptStatusResult rs in cbStatus.Items)
            {                
                if (rs.StatusID == Receipt.StatusID)
                {
                    break;
                }
                i++;
            }
            cbStatus.SelectedIndex = i;
        }

        private void loadReceiptStatus()
        {
            DMDataContext db = new DMDataContext();
            cbStatus.ItemsSource = db.spuGetReceiptStatus();
        }
    }
}
