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

namespace WpfKwistet
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

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            lstBx.Items.Add(txtBxNaam.Text);
            txtBxNaam.Text = "";
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            lstBx.Items.Remove(lstBx.SelectedItem);
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            lstBx.Items.RemoveAt(lstBx.SelectedIndex);
            lstBx.Items.Add(txtBxNaam.Text);
            txtBxNaam.Text = "";
        }

        private void btnAllesVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            lstBx.Items.Clear();
        }
    }
}
