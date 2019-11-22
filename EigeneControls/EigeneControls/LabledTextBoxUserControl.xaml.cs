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

namespace EigeneControls
{
    /// <summary>
    /// Interaction logic for LabledTextBoxUserControl.xaml
    /// </summary>
    public partial class LabledTextBoxUserControl : UserControl
    {
        public LabledTextBoxUserControl()
        {
            InitializeComponent();
            this.DataContext = this; // Ich bin meine eigene Standarddatenquelle für Bindings
        }


        public string LabelText { get; set; } // Binding mit der Kurzschreibweise
        public string TextBoxText { get; set; }
    }
}
