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

        private void Rbtn_Spicy_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlk_Ingredienten.Text = "Tomatensaus, mozzarella, ui, kip, paprika, pepperoni & spaanse pepers";
            imgPizza.Source = new BitmapImage(new Uri("Fotos/Hot&Spicy.jpg", UriKind.Relative)); 
        }

        private void Rbtn_Tonno_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlk_Ingredienten.Text = "Tomatensaus, mozzarella, tonijn, rode ui, zwarte olijven & verse spinazie";
            imgPizza.Source = new BitmapImage(new Uri("Fotos/Tonno.jpg", UriKind.Relative));
            
        }
        private void Rbtn_BbqGrill_Checked(object sender, RoutedEventArgs e)
        {
            TxtBlk_Ingredienten.Text = "BBQ saus, mozzarella, ui, gehakt, bacon & een swirl heerlijke BBQ saus";
            imgPizza.Source = new BitmapImage(new Uri("Fotos/BbqGrill.jpg", UriKind.Relative));

        }
    }
}
