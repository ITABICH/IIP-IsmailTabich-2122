﻿using System;
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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int hoogsteBod;
        string hoogsteBieder;
         

        public MainWindow()
        {
            InitializeComponent();
            lblHoogsteBod.Content = "Er is nog geen bod uitgrebracht";
        }

        private void btnBod_Click(object sender, RoutedEventArgs e)
        {
            int bod;
            string bieder;

            bieder = txtbxNaam.Text;

            bod = Convert.ToInt32(txtbxBod.Text);

            lblHoogsteBod.Content = $"{bieder} heeft met {bod} euro nu het hoogste bod!";   

            if (hoogsteBod > bod)
            {
                lblHoogsteBod.Content = $"Sorry, {hoogsteBieder} heeft met {hoogsteBod} euro nu het hoogste bod!";
            }
            else if (hoogsteBod < bod)
            {
                lblHoogsteBod.Content = $"{bieder} heeft met {bod} euro nu het hoogste bod! ";
                bieder = hoogsteBieder;
                bod = hoogsteBod;
            }






        }
    }
}