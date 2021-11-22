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

namespace WpfApp4
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

        private void rbtnSpicy_Checked(object sender, RoutedEventArgs e)
        {
            txtblkIngredienten.Text = "Tomatensaus, mozzarella, ui, kip, paprika, pepperoni & spaanse pepers";
            imgPizza.Source = new BitmapImage(new Uri("Fotos/Hot&Spicy.jpg", UriKind.Relative)); 
        }

        private void rbtnTonno_Checked(object sender, RoutedEventArgs e)
        {
            txtblkIngredienten.Text = "Tomatensaus, mozzarella, tonijn, rode ui, zwarte olijven & verse spinazie";
            imgPizza.Source = new BitmapImage(new Uri("Fotos/Tonno.jpg", UriKind.Relative));
            
        }
        private void rbtnBbqGrill_Checked(object sender, RoutedEventArgs e)
        {
            txtblkIngredienten.Text = "BBQ saus, mozzarella, ui, gehakt, bacon & een swirl heerlijke BBQ saus";
            imgPizza.Source = new BitmapImage(new Uri("Fotos/BbqGrill.jpg", UriKind.Relative));

        }
    }
}
