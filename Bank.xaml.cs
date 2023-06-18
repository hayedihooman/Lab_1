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
    /// Interaction logic for Bank.xaml
    /// </summary>
    public partial class Bank : Window
    {
        public Bank()
        {
            InitializeComponent();
        }

        private decimal serviceFee(int numbOfChecks, bool Balance)
        {
            decimal chargeFee = 10m;

            if (numbOfChecks < 20)
            {
                chargeFee += numbOfChecks * 0.1m;
            }
            else if (numbOfChecks >= 20 && numbOfChecks < 40)
            {
                chargeFee += (1.9m + (numbOfChecks - 19) * 0.08m);
            }
            else if (numbOfChecks >= 40 && numbOfChecks < 60)
            {
                chargeFee += (3.5m + (numbOfChecks - 39) * 0.06m);
            }
            else
            {
                chargeFee += (4.7m + (numbOfChecks - 59) * 0.1m);
            }

            if (Balance)
            {
                chargeFee += 15m;
            }


            return chargeFee;
        }

        private void Calc_Btn_Click(object sender, RoutedEventArgs e)
        {
            bool balance = false;
            if ((bool)Yes_Btn.IsChecked)
            {
                balance = true;
            }


            Total_Lbl.Content = "$"+ serviceFee(int.Parse(NumOfCk_TxtBox.Text), balance) ;


        }

    

    private void return_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        
    }
}
