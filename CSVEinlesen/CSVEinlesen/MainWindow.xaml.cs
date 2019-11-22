using System;
using System.Collections.Generic;
using System.IO;
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

namespace CSVEinlesen
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
            // File: Alles auf einmal:

            string[] allLines = File.ReadAllLines("demo.csv");
            foreach (var line in allLines)
            {
                Person p = new Person();
                if (string.IsNullOrWhiteSpace(line))
                    continue; // Leerzeile ignorieren

                string[] values = line.Split(';');

                p.Vorname = values[0];
                p.Nachname = values[1];
                p.Alter =  Convert.ToByte(values[2]);
                p.Kontostand = Convert.ToDecimal(values[3]);

                listBoxPersonen.Items.Add(p);
            }
        }
    }
}
