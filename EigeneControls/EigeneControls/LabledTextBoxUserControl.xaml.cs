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

        // Normales .NET Property:
        //public string LabelText { get; set; } // Binding mit der Kurzschreibweise
        //public string TextBoxText { get; set; }


        // 1)
        // propdp + TAB + TAB 
        // 2) 
        // mit TAB durch alle 4 möglichkeiten Durchklicken:
        // * Datentyp (int/string/.... wählen)
        // * Name (name von eurem Property)
        // * OwnerClass -> Klassenname von eurem UserControl
        // * PropertyMetaData: Standardwert, wenn das ding leer ist




        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(LabledTextBoxUserControl), new PropertyMetadata(""));


        public string TextBoxText
        {
            get { return (string)GetValue(TextBoxTextProperty); }
            set { SetValue(TextBoxTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxTextProperty =
            DependencyProperty.Register("TextBoxText", typeof(string), typeof(LabledTextBoxUserControl), new PropertyMetadata(""));



    }
}
