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
using System.Windows.Threading;
using WMPLib;
using System.Media;


namespace WpfAppProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Random aanmaken
        private static Random rnd = new Random();

        //Race aanmaken
        DispatcherTimer race = new DispatcherTimer();

        //Muziek aanmaken
        WindowsMediaPlayer raceMuziek = new WindowsMediaPlayer();
        WindowsMediaPlayer applauseWinnaar = new WindowsMediaPlayer();

        //Einde
        const int EIND_STREEP = 708;

        //Stappen voor de lopers
        const int MINIMUM_STAP = 1;
        const int MAXIMUM_STAP = 5;


        public MainWindow()
        {
            InitializeComponent();

            //Stappen elke 20 milliseconden
            race.Interval = TimeSpan.FromMilliseconds(20);
            race.Tick += Race_;

            raceMuziek.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Geluiden/RaceMuziek.mp3");
            raceMuziek.controls.stop();

            applauseWinnaar.URL = System.IO.Path.Combine(Environment.CurrentDirectory, "Geluiden/ApplausWinnaar.mp3");
            applauseWinnaar.controls.stop();
        }

        private void Race_(object? sender, EventArgs e)
        {
            ///Huidige positie lopers
            double CurrentPositionHarley = Canvas.GetLeft(imgHarley);
            double CurrentPositionTmax = Canvas.GetLeft(imgTmax);
            double CurrentPositionBmw = Canvas.GetLeft(imgBmw);

            ///Huidige positie eindstreep
            double EindPosition = Canvas.GetLeft(imgEinde);

            ///Huidige positie lopers + random stappen 
            CurrentPositionHarley += rnd.Next(MINIMUM_STAP, MAXIMUM_STAP);
            CurrentPositionTmax += rnd.Next(MINIMUM_STAP, MAXIMUM_STAP);
            CurrentPositionBmw += rnd.Next(MINIMUM_STAP, MAXIMUM_STAP);

            ///Eindstreep positie 700 geven
            EindPosition = EIND_STREEP;

            ///stappen leggen voor de lopers
            Canvas.SetLeft(imgHarley, CurrentPositionHarley);
            Canvas.SetLeft(imgTmax, CurrentPositionTmax);
            Canvas.SetLeft(imgBmw, CurrentPositionBmw);


            ///Als bmw de eindlijn overschrijdt
            if (CurrentPositionBmw >= EindPosition)
            {
                ///De race stopt
                race.Stop();

                ///De race muziek stopt
                raceMuziek.controls.stop();

                ///De winnaar werd getoont
                lblWinnaar.Content = "Bmw heeft de race gewonnen!";

                ///Applaus geluid activeren
                applauseWinnaar.controls.play();

                ///Als jouw gok was bmw
                if (txtBxGok.Text == "BMW" || txtBxGok.Text == "bmw" || txtBxGok.Text == "Bmw")
                {
                    ///Krijg je 5 keer jouw inzet
                    double juisteGok = Convert.ToInt64(txtBxInzet.Text) * 5;
                    ///Melding: win
                    MessageBox.Show($"Je krijg {juisteGok} euro");
                }
                ///Als jouw gok niet bmw was
                else
                {
                    ///Melding: verlies
                    MessageBox.Show("Je verlies jouw geld");
                }

            }
            ///Als harley de eindlijk overschrijdt
            else if (CurrentPositionHarley >= EindPosition)
            {
                ///De spel stopt
                race.Stop();

                ///De race muziek stopt
                raceMuziek.controls.stop();

                ///De winnaar werd getoont
                lblWinnaar.Content = "Harley heeft de race gewonnen!";

                ///Applaus geluid activeren
                applauseWinnaar.controls.play();

                ///Als jouw gok was Tmax
                if (txtBxGok.Text == "Harley" || txtBxGok.Text == "harley" || txtBxGok.Text == "HARLEY")
                {
                    ///Krijg je 5 keer jouw inzet
                    double juisteGok = Convert.ToInt64(txtBxInzet.Text) * 5;
                    ///Melding: Win
                    MessageBox.Show($"Je krijg {juisteGok} euro");
                }
                ///Als de gok niet Harley was
                else
                {
                    ///Melding: verlies
                    MessageBox.Show("Je verlies jouw geld");
                }

            }
            ///Als tmax de eindlijn overschrijdt
            else if (CurrentPositionTmax >= EindPosition)
            {
                ///De spel stopt
                race.Stop();

                ///De race muziek stopt
                raceMuziek.controls.stop();

                ///De winnaar werd getoont
                lblWinnaar.Content= "Tmax heeft de race gewonnen!";

                ///Applaus  geluid activeren
                applauseWinnaar.controls.play();

                ///Als de gok was Tmax
                if(txtBxGok.Text == "tmax" || txtBxGok.Text == "TMAX" || txtBxGok.Text == "Tmax")
                {
                    ///Krijg je 5 keer jouw inzet
                    double juisteGok = Convert.ToInt64(txtBxInzet.Text) * 5;
                    ///Melding: win
                    MessageBox.Show($"Je krijg {juisteGok} euro");
                }
                ///Als de gok niet Tmax was
                else
                {
                    ///Melding: verlies
                    MessageBox.Show("Je verlies jouw geld");
                }

            }
            
        }


        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            ///Race starten
            race.Start();

            ///Affiches verwijderen
            lblBmw.Content = "";
            lblHarley.Content = "";
            lblTmax.Content = "";

            ///Race muziek starten
            raceMuziek.controls.play();
        }

        private void btnMute_Click(object sender, RoutedEventArgs e)
        {
            ///Geluid uitschekkelen
            raceMuziek.settings.mute = true;
            applauseWinnaar.settings.mute = true;
            ///Button in het rood = geluid uit           
            btnMute.Background = Brushes.IndianRed;

            ///Wat doen om geluid aan te zetten
            lblMute.Content = "MUTE AAN (rechter muis klik om uit te zetten)";
        }

        private void btnMute_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ///Geluid activeren
            raceMuziek.settings.mute = false;
            applauseWinnaar.settings.mute = false;

            ///Button in het groen = geluid aan
            btnMute.Background = Brushes.Green;

            ///Geluid aan
            lblMute.Content = "MUTE UIT";

        }
    }
}
