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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BankCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ShippingCheckBox.IsChecked = false;
            PopulationCheckBox.IsChecked = false;
        }

        private void ShippingCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            BankCheckBox.IsChecked = false;
            PopulationCheckBox.IsChecked = false;
        }

        private void PopulationCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            BankCheckBox.IsChecked = false;
            ShippingCheckBox.IsChecked = false;
        }

        private void GoToBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)BankCheckBox.IsChecked)
            {
                Bank bank = new Bank();
                bank.Show();
                this.Close();
            }
            else if ((bool)ShippingCheckBox.IsChecked)
            {
                Shipping shipping = new Shipping();
                shipping.Show();
                this.Close();
            }
            else if ((bool)PopulationCheckBox.IsChecked)
            {
                Population population = new Population();
                population.Show();
                this.Close();
            }
        }

    }
}
