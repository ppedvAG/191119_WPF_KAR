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

namespace DarkmodeTaschenrechner
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

        bool isDarkMode = false;

        private void imageMode_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Toggle-Logik
            if(isDarkMode)
            {
                this.Resources["CurrentButtonStyle"] = this.Resources["DarkButtonStyle"]; 
                this.Resources["CurrentTextBoxStyle"] = this.Resources["DarkTextBoxStyle"]; 
                this.Resources["CurrentLabelStyle"] = this.Resources["DarkLabelStyle"];
                this.Resources["CurrentWindowStyle"] = this.Resources["DarkWindowStyle"];

                isDarkMode = false;
            }
            else
            {
                this.Resources["CurrentButtonStyle"] = this.Resources["LightButtonStyle"];
                this.Resources["CurrentTextBoxStyle"] = this.Resources["LightTextBoxStyle"];
                this.Resources["CurrentLabelStyle"] = this.Resources["LightLabelStyle"];
                this.Resources["CurrentWindowStyle"] = this.Resources["LightWindowStyle"];

                isDarkMode = true;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Applikation im LightMode - Starten
            this.Resources["CurrentButtonStyle"] = this.Resources["LightButtonStyle"];
            this.Resources["CurrentTextBoxStyle"] = this.Resources["LightTextBoxStyle"];
            this.Resources["CurrentLabelStyle"] = this.Resources["LightLabelStyle"];
            this.Resources["CurrentWindowStyle"] = this.Resources["LightWindowStyle"];

            isDarkMode = true;
        }
    }
}
