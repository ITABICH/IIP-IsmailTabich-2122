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

namespace WpfSliderKleur
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

        private void sldKleur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ///De value van de slider aantonen in txtblkWaarde
            txtblkWaarde.Text = Convert.ToString(sldKleur.Value);

            ///Als de value kleiner en gelijk is aan 25 dan is de tekstkleur groen
            if (Math.Round(sldKleur.Value) <= 25)
            {
                ///Aangeven van een kleur aan txtblkWaarde
                txtblkWaarde.Foreground = Brushes.Green;
            }
            ///Als de value groter is dan 25 of kleiner en gelijk is aan 50 dan is de tekstkleur geel
            else if ((Math.Round(sldKleur.Value) > 25) && (sldKleur.Value <= 50))
            {
                txtblkWaarde.Foreground = Brushes.Yellow;
            }
            ///Als de value groter is dan 50 of kleiner en gelijk is aan 75 dan is de tekstkleur oranje
            else if ((Math.Round(sldKleur.Value) > 50) && (sldKleur.Value <= 75))
            {
                txtblkWaarde.Foreground = Brushes.Orange;
            }
            ///Als het niet een van de vorige is dan wordt de tekstkleur rood
            else
            {
                txtblkWaarde.Foreground = Brushes.Red;
            }
        }
    }
}
