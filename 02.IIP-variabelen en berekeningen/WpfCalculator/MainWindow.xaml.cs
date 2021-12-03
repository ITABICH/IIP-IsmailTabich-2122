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

namespace WpfCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int GETAL_0 = 0;
        const int GETAL_1 = 1;
        const int GETAL_2 = 2;
        const int GETAL_3 = 3;
        const int GETAL_4 = 4;
        const int GETAL_5 = 5;
        const int GETAL_6 = 6;
        const int GETAL_7 = 7;
        const int GETAL_8 = 8;
        const int GETAL_9 = 9;
        const string KOMMA = ".";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEen_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_1;
        }

        private void btnTwee_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_2;
        }

        private void btnDrie_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_3;
        }

        private void btnVier_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_4;
        }

        private void btnVijf_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_5;
        }

        private void btnZes_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_6;
        }

        private void btnZeven_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_7;
        }

        private void btnAcht_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_8;
        }

        private void btnNegen_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_9;
        }

        private void btnNul_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + GETAL_0;
        }

        private void btnKomma_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Text = txtBxInvoeg.Text + KOMMA;
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtBxInvoeg.Clear();
            lblUitkomst.Content = "0.0";
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            txtBxInvoeg.Text = Convert.ToString(random.Next(0, 100));
        }

        private void btnOptellen_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
