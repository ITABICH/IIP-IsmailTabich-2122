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

namespace WpfGebruikersNaam
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

        private void txtBxGebruikersnaam_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                txtBxGebruikersnaam.Background = Brushes.Red;
                lblFoutmelding.Content = "Mag geen spaties bevatten";
                lblFoutmelding.Foreground = Brushes.Red;
            }

            else if (e.Key == Key.NumPad0 || e.Key == Key.NumPad1 || e.Key == Key.NumPad2 ||
                e.Key == Key.NumPad3 || e.Key == Key.NumPad4 || e.Key == Key.NumPad5 ||
                e.Key == Key.NumPad6 || e.Key == Key.NumPad7 || e.Key == Key.NumPad8 || e.Key == Key.NumPad9)
            {
                txtBxGebruikersnaam.Background = Brushes.Red;
                lblFoutmelding.Content = "Mag geen cijfers bevatten";
                lblFoutmelding.Foreground= Brushes.Red; 
            }

            else if (txtBxGebruikersnaam.Text == "")
            {
                lblFoutmelding.Content = "";
            }

            else
            {
                txtBxGebruikersnaam.Background= Brushes.Green;
                lblFoutmelding.Content = "";
            }
        }
    }
}
