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
            txtBier.Text = sldBier.Value + " glazen";
            rctAlcoholGehalte.Width = sldBier.Value;
        }

        private void sldWijn_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtWijn.Text = sldWijn.Value + " glazen";
            rctAlcoholGehalte.Width = rctAlcoholGehalte.Width + sldWijn.Value;
        }

        private void sldSterkeDrank_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            txtSterkeDrank.Text = sldSterkeDrank.Value + " glazen";
            rctAlcoholGehalte.Width = rctAlcoholGehalte.Width + sldSterkeDrank.Value;
        }
    }
}
