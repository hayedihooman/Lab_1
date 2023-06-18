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
    /// Interaction logic for Population.xaml
    /// </summary>
    public partial class Population : Window
    {
        public Population()
        {
            InitializeComponent();
        }
        public class PopulationDay
        {
            public int Day { get; set; }
            public double Population { get; set; }
        }


        private List<PopulationDay> CalculatePopulation(int startPopulation, double increaseRate, double days)
        {
            List<PopulationDay> populationList = new List<PopulationDay>();

            for (int day = 1; day <= days; day++)
            {
                double population = startPopulation * Math.Pow((1 + increaseRate / 100), day);
                populationList.Add(new PopulationDay { Day = day, Population = Math.Floor(population) });
            }

            return populationList;
        }


        private void Calc_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(ppt_TxtBox.Text) < 2)
            {
                MessageBox.Show("population must be greater than 1");
            }
            else if (double.Parse(AvgTxt_Box.Text) < 0)
            {
                MessageBox.Show("Average must be greater that 0  ");
            }
            else if (double.Parse(NumOfDays_TxtBox.Text) < 1)
            {
                MessageBox.Show("days must be greater than 1");
            }
            else
            {
                List<PopulationDay> populationData = CalculatePopulation(int.Parse(ppt_TxtBox.Text), double.Parse(AvgTxt_Box.Text), double.Parse(NumOfDays_TxtBox.Text));
                dataGrid.ItemsSource = populationData;
            }

        }

        private void return_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        
    }
}