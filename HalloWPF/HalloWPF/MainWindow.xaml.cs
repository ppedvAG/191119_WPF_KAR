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

namespace HalloWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // var x = textBoxEingabe; // null
            InitializeComponent();
            // var y = textBoxEingabe; // intialisiert
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Fenster auf anderen Bildschrim verschieben:
            //  this.Top = 0;
            //  this.Left = -1920; // (2ter Monitor links vom Hauptmonitor)
            MessageBox.Show("Hallo Welt");
        }

        private void textBoxEingabe_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("Der Text wurde verändert ...");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(textBoxEingabe.Text);
        }

        private void textBoxMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Klick auf die Textbox");
        }

        private void GridBlauMouseDown(object sender, MouseButtonEventArgs e)
        {
            // F12 für das Erstellen eines Events aus XAML heraus
            MessageBox.Show("Klick auf blaues Grid");
        }

        private void GridSalmonMouseDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true; // Event nicht mehr weiterreichen
            MessageBox.Show("Klick auf Salmon Grid");

        }

        private void GridOrangeMouseDown(object sender, MouseButtonEventArgs e)
        {
            // MouseDown funktioniert im Root-Grid (hier gridOrange) nur, wenn das Grid eine Hintergrundfarbe hat
            // Wenn das Grid keine Hintergrundfarbe hat (z.B. Standardwert null bzw "Transparent"), reagiert das Grid nicht auf das "MouseDown" - Event !!!

            MessageBox.Show("Klick auf orangenes Grid");
        }
    }
}
