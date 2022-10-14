using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DormitoryManagement.UC
{
    /// <summary>
    /// Interaction logic for UCElectricityAndWater.xaml
    /// </summary>
    public partial class UCElectricityAndWater : UserControl
    {
        public UCElectricityAndWater()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {            
            loadData();
        }

        private void loadData()
        {
            DMDataContext db = new DMDataContext();
            var e = (spuGetElectricFeeResult)db.spuGetElectricFee().Single();
            var w = (spuGetWaterFeeResult)db.spuGetWaterFee().Single();
            tbElectricFee.Text = e.FeeCost.ToString();
            tbWaterFee.Text = w.FeeCost.ToString();
        }

        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            if (validateData())
            {
                DMDataContext db = new DMDataContext();
                db.spuUpdateElectricityFee(decimal.Parse(tbElectricFee.Text));
                db.spuUpdateWaterFee(decimal.Parse(tbWaterFee.Text));
                MessageBox.Show("Đã cập nhật!");
            }
            else
            {
                MessageBox.Show("Dữ Liệu Không Hợp Lệ!");
            }
        }

        private bool validateData()
        {
            if (tbElectricFee.Text.Trim() == "" || tbWaterFee.Text.Trim() == "")
            {
                return false;
            }

            try
            {
                decimal.Parse(tbWaterFee.Text);
                decimal.Parse(tbElectricFee.Text);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
