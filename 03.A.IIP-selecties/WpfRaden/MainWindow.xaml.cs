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

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int raad;

        ///De 3 voor de aantal pogingen         
        int pogingenOver = 3;

        public MainWindow()
        {
            InitializeComponent();
            ///Random getal geven voor het geraden getal
            Random rnd = new Random();
            raad = rnd.Next(1, 10);

            lblResultaat.Foreground = Brushes.BlueViolet;

        }

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {

            int gok = Convert.ToInt32(txtbxGok.Text);

            ///Elke keer dat de butten geklickt wordt gaat een poging weg
            pogingenOver--;

            ///Als de gegokte getal groter is dan de geraden getal
            if (gok > raad)
            {
                lblResultaat.Content = ($"Te hoog ! Je beht nog {pogingenOver} pogingen over");
            }

            ///Als de gegokte getal kleiner is dan de geraden getal 
            else if (gok < raad)
            {
                lblResultaat.Content = ($"Te laag ! Je beht nog {pogingenOver} pogingen over");
            }

            ///Als de twee vorige if's niet klopen dan is het gegokte getal juist
            else
            {
                lblResultaat.Content = ("Je hebt gewonnen !!!");

                ///Als de gegokte getal juist is dan de gebruiker de button niet meer gebruiken
                btnControleer.IsEnabled = false;
            }

            ///Als de gok en radend getal gelijk zijn en de pogingen over zijn
            if (gok == raad && pogingenOver == 0)
            {
                lblResultaat.Content = ("Je hebt gewonnen !!!");
                btnControleer.IsEnabled = false;
            }

            ///Als er geen pogingen meer zijn dan kan je niet verder spelen
            else if (pogingenOver == 0)
            {
                lblResultaat.Content = ("Je hebt geen pogingen meer ! Herstart het programma om te spelen");

                ///Als de drie pogingen gebruikt zijn dan kan je de button niet meer gebruiken
                btnControleer.IsEnabled = false;
            }
        }
    }
}
