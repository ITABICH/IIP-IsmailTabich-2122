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

namespace WpfFormChecking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ///Combobox invullen
            comboBxProfiel.Items.Insert(0, "Gehuwd");
            comboBxProfiel.Items.Insert(1, "Ongehuwd");
        }

        private void btnWissen_Click(object sender, RoutedEventArgs e)
        {
            txtbxNaam.Text = "";
            txtBxEmail.Text = "";
            DatePicker.SelectedDate = null;
            comboBxProfiel.Items.Clear();
            pwBxPasswoord.Clear();
            rbtnMan.IsChecked = false;
            rbtnVrouw.IsChecked = false;
            chkBxProgrammeren.IsChecked = false;
            chkBxNetwerk.IsChecked = false;
            chkBxBusiness.IsChecked = false;
            lblResultaat.Content = "";
        }

        private void rbtnMan_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtnMan.IsChecked == true)
            {
                rbtnVrouw.IsChecked = false;
            }
            
        }

        private void rbtnVrouw_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtnVrouw.IsChecked == true)
            {
                rbtnMan.IsChecked = false;
            }
            
        }

        private void btnRegistreren_Click(object sender, RoutedEventArgs e)
        {
            int aantalFouten = 0;
            
            if (txtbxNaam.Text == "")
            {
                lblNaam.Content = "Naam moet ingevuld zijn!";
                lblNaam.Foreground = Brushes.Red;
                aantalFouten++;
            }

            if (txtBxEmail.Text == "")
            {
                lblEmail.Content = "Email moet ingevuld zijn!";
                lblEmail.Foreground = Brushes.Red;
                aantalFouten++;
            }

            if (DatePicker.SelectedDate == null) 
            {
                lblGeboortedatum.Content = "Datum moet geselecteerd zijn!";
                lblGeboortedatum.Foreground = Brushes.Red;
                aantalFouten++;
            }
            
            if (comboBxProfiel.SelectedItem == null)
            {
                lblProfiel.Content = "Profiel moet geselecteerd zijn!";
                lblProfiel.Foreground = Brushes.Red;
                aantalFouten++;

            }

            if (pwBxPasswoord.Password.ToString() == "")
            {
                lblPasswoord.Content = "Passwoord moet ingevuld zijn!";
                lblPasswoord.Foreground = Brushes.Red;
                aantalFouten++;
            }

            if (rbtnMan.IsChecked == false && rbtnVrouw.IsChecked == false)
            {
                lblGeslacht.Content = "Geslacht moet geselecteerd zijn!";
                lblGeslacht.Foreground = Brushes.Red;
                aantalFouten++;

            }

            if (chkBxProgrammeren.IsChecked == false && chkBxNetwerk.IsChecked == false && chkBxBusiness.IsChecked == false)
            {
                lblInteresse.Content = "Interesse moet geselecteerd zijn!";
                lblInteresse.Foreground = Brushes.Red;
                aantalFouten++;

            }

            lblResultaat.Content = $"Dit formulier bevat {aantalFouten} fouten";
            lblResultaat.Foreground = Brushes.Red;

            ///Als alles ingevuld is
            if (txtbxNaam.Text != "" && txtBxEmail.Text != "" && DatePicker.SelectedDate != null && 
                comboBxProfiel.SelectedItem != null && pwBxPasswoord.Password.ToString() != "" && 
                (rbtnMan.IsChecked != false || rbtnVrouw.IsChecked != false) && 
                (chkBxProgrammeren.IsChecked != false || chkBxNetwerk.IsChecked != false || chkBxBusiness.IsChecked != false))
            {
                lblResultaat.Content = "bedankt voor de registratie!";
                lblResultaat.Foreground= Brushes.Black;

                ///Alles wissen
                txtbxNaam.Text = "";
                txtBxEmail.Text = "";
                DatePicker.SelectedDate = null;
                comboBxProfiel.Items.Clear();
                pwBxPasswoord.Clear();
                rbtnMan.IsChecked = false;
                rbtnVrouw.IsChecked = false;
                chkBxProgrammeren.IsChecked = false;
                chkBxNetwerk.IsChecked = false;
                chkBxBusiness.IsChecked = false;

                lblNaam.Content = "";
                lblEmail.Content = "";
                lblGeboortedatum.Content = "";
                lblProfiel.Content = "";
                lblPasswoord.Content = "";
                lblGeslacht.Content = "";
                lblInteresse.Content = "";

            }
        }
    }
}
