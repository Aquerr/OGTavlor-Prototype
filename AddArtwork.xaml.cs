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
using System.Windows.Shapes;

namespace TavelProjektPT
{
    /// <summary>
    /// Interaction logic for LäggTillTavla.xaml
    /// </summary>
    public partial class AddArtwork : Window
    {
        public AddArtwork()
        {
            InitializeComponent();
        }

        private void LäggTill_Click(object sender, RoutedEventArgs e)
        {
            //Öppnar ett nytt fönster
            MainWindow StartSida = new MainWindow();
            this.Close();
            StartSida.Show();
        }

        private void Avbryt_Click(object sender, RoutedEventArgs e)
        {
            //Öppnar ett nytt fönster
            MainWindow StartSida = new MainWindow();
            this.Close();
            StartSida.Show();
        }
    }
}
