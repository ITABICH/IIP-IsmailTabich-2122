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

namespace WpfWinkel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double PRIJS_BANAAN = 2.25;
        const double PRIJS_BOTER = 3.05;
        const double PRIJS_EIEREN = 2.95;




        public MainWindow()
        {
            InitializeComponent();
            Random voorraad = new Random();

            
            lblVoorraadBanaan.Content = voorraad.Next(5, 40);
            
            lblVoorraadBoter.Content = voorraad.Next(5, 40);
            
            lblVoorraadEieren.Content = voorraad.Next(5, 40);




        }

        private void btnBanaan_Click(object sender, RoutedEventArgs e)
        {
            int voorraadBanaan = Convert.ToInt32(lblVoorraadBanaan.Content);
            lblVoorraadBanaan.Content = voorraadBanaan - 1;
            lstBxVerkocht.Items.Add($"{PRIJS_BANAAN} - 1 tros banaan");

        }

        private void btnBoter_Click(object sender, RoutedEventArgs e)
        {
            int voorraadBoter = Convert.ToInt32(lblVoorraadBanaan.Content);
            lblVoorraadBoter.Content = voorraadBoter - 1;
            lstBxVerkocht.Items.Add($"{PRIJS_BOTER} - 1 pak boter");

        }

        private void btnEieren_Click(object sender, RoutedEventArgs e)
        {
            int voorraadEieren = Convert.ToInt32(lblVoorraadEieren.Content);
            lblVoorraadEieren.Content = voorraadEieren - 1;
            lstBxVerkocht.Items.Add($"{PRIJS_EIEREN} - 1 pak boter");
        }

        private void btnHerstel_Click(object sender, RoutedEventArgs e)
        {
            lstBxVerkocht.Items.Clear();
            lblVoorraadBanaan.Content = "";
            lblVoorraadBoter.Content = "";
            lblVoorraadEieren.Content = "";
            lblAfrekenen.Content = "";

            Random voorraad = new Random();

            lblVoorraadBanaan.Content = voorraad.Next(5, 40);
            lblVoorraadBoter.Content = voorraad.Next(5, 40);
            lblVoorraadEieren.Content = voorraad.Next(5, 40);
        }

        private void btnAfrekenen_Click(object sender, RoutedEventArgs e)
        {
            


        }
    }
}
