using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for Shipping.xaml
    /// </summary>
    public partial class Shipping : Window
    {
        public Shipping()
        {
            InitializeComponent();
        }
        private decimal shippingFee(double Weight)
        {
            if (Weight < 2)
            {
                return 1.1m;
            }
            else if (Weight >= 2 && Weight < 6)
            {
                return 2.2m;
            }
            else if (Weight >= 6 && Weight < 10)
            {
                return 3.7m;
            }
            else
            {
                return 4.8m;
            }

        }

        private void FeeCalc_Btn_Click(object sender, RoutedEventArgs e)
        {
            TotalFee_TxtBox.Text = "$"+ shippingFee(double.Parse(ShippingFee_TxtBox.Text));
        }

        private void return_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void FeeCalc_Btn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
