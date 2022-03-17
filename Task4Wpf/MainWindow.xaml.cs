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

namespace Task4Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateD.Text);
            double sumDollar = Convert.ToDouble(sumD.Text);
            double resDouble = rateDollar*sumDollar;
            resSumFromD.Text = resDouble.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resDouble = rateEuro * sumEuro;
            resSumFromE.Text = resDouble.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivni = Convert.ToDouble(rateG.Text);
            double sumGrivni = Convert.ToDouble(sumG.Text);
            double resDouble = rateGrivni * sumGrivni;
            resSumFromG.Text = resDouble.ToString();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rateDr.Text);
            double sumDram = Convert.ToDouble(sumDr.Text);
            double resDouble = rateDram * sumDram;
            resSumFromDr.Text = resDouble.ToString();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double distanceInches = Convert.ToDouble(distanceInch.Text);
            double resDouble = distanceInches * 0.0254;
            resDistFromInch.Text= resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double distanceFeet = Convert.ToDouble(distanceF.Text);
            double resDouble = distanceFeet * 0.3048;
            resDistFromF.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double distanceMiles = Convert.ToDouble(distanceM.Text);
            double resDouble = distanceMiles * 1609.34;
            resDistFromM.Text = resDouble.ToString();

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double distanceVerst = Convert.ToDouble(distanceV.Text);
            double resDouble = distanceVerst * 1066.8;
            resDistFromV.Text = resDouble.ToString();
        }
    }
}
