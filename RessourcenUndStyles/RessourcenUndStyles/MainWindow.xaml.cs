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

namespace RessourcenUndStyles
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            if(r.Next(0,2) % 2 == 1)
                buttonFarbwechsel.Background = (SolidColorBrush)this.Resources["Farbe1"];
            else
                buttonFarbwechsel.Background = (SolidColorBrush)this.Resources["Farbe2"];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            buttonStyleToggle.Style = (Style)this.Resources["YellowButtonStyle"];
        }
    }
}
