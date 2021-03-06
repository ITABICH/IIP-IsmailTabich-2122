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

namespace WpfTodo
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
            if (cmbBx.Text == "laag")
            {
                lstBx.Items.Add(txtBxTaak.Text);
                lstBx.Foreground = Brushes.Green;
                
            }
            if (cmbBx.Text == "medium")
            {
                lstBx.Items.Add(txtBxTaak.Text);
                lstBx.Foreground = Brushes.Orange;
            }
            if (cmbBx.Text == "hoog")
            {
                lstBx.Items.Add(txtBxTaak.Text);
                lstBx.Foreground= Brushes.Red;
            }

        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            lstBx.Items.Remove(lstBx.SelectedItem);
        }
    }
}
