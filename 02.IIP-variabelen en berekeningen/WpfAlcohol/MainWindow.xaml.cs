using System;
using System.Windows;
using System.Windows.Media;

namespace WpfAlcohol
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

        private void sldBier_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ///Text aanmaken naast de slider om de hoeveelheid glazen te tonen
            txtBier.Text = sldBier.Value + " glazen";

            ///De rectangle breder maken aan de hand van de slider value 
            ///Alle sliders samen optellen om het continu groter of kleiner word aan de hand va de volgende of vorige slider aanpassingen
            rctAlcoholGehalte.Width = (Math.Round(sldBier.Value * 17) + Math.Round(sldWijn.Value * 17) + Math.Round(sldSterkeDrank.Value * 17));

            ///Na hoeveel glazen gaat het van groen naar rood
            int rood = Convert.ToInt32(rctAlcoholGehalte.Width);
            int groen =  255 - rood;
            int blauw = 0;

            ///Aanmaken van de kleuren
            rctAlcoholGehalte.Fill = new SolidColorBrush(Color.FromRgb((byte)rood, (byte)groen, (byte)blauw));

        }

        private void sldWijn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ///Text aanmaken naast de slider om de hoeveelheid glazen te tonen
            txtWijn.Text = sldWijn.Value + " glazen";

            ///De rectangle breder maken aan de hand van de slider value 
            ///Alle sliders samen optellen om het continu groter of kleiner word aan de hand va de volgende of vorige slider aanpassingen
            rctAlcoholGehalte.Width = (Math.Round(sldBier.Value * 17) + Math.Round(sldWijn.Value * 17) + Math.Round(sldSterkeDrank.Value * 17));

            ///Na hoeveel glazen gaat het van groen naar rood
            int rood = Convert.ToInt32(rctAlcoholGehalte.Width);
            int groen = 255 - rood;
            int blauw = 0;

            ///Aanmaken van de kleuren
            rctAlcoholGehalte.Fill = new SolidColorBrush(Color.FromRgb((byte)rood, (byte)groen, (byte)blauw));

        }

        private void sldSterkeDrank_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ///Text aanmaken naast de slider om de hoeveelheid glazen te tonen
            txtSterkeDrank.Text = sldSterkeDrank.Value + " glazen";

            ///De rectangle breder maken aan de hand van de slider value 
            ///Alle sliders samen optellen om het continu groter of kleiner word aan de hand va de volgende of vorige slider aanpassingen
            rctAlcoholGehalte.Width = (Math.Round(sldBier.Value * 17) + Math.Round(sldWijn.Value * 17) + Math.Round(sldSterkeDrank.Value * 17));

            ///Na hoeveel glazen gaat het van groen naar rood
            int rood = Convert.ToInt32(rctAlcoholGehalte.Width);
            int groen = 255 - rood;
            int blauw = 0;

            ///Aanmaken van de kleuren
            rctAlcoholGehalte.Fill = new SolidColorBrush(Color.FromRgb((byte)rood, (byte)groen, (byte)blauw));

        }
    }
}
