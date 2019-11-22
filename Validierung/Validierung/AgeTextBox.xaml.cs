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

namespace Validierung
{
    /// <summary>
    /// Interaction logic for AgeTextBox.xaml
    /// </summary>
    public partial class AgeTextBox : UserControl
    {
        public AgeTextBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            // Wenn das UserControl geladen ist, übertrage Minimum und Maximum in die ValidationRule
            ageValidationRule.Minimum = MinimumAge;
            ageValidationRule.Maximum = MaximumAge;
        }

        public string Age
        {
            get
            {
                return (string)GetValue(AgeProperty); 
            }
            set 
            {
                SetValue(AgeProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Age.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AgeProperty =
            DependencyProperty.Register("Age", typeof(string), typeof(AgeTextBox), new PropertyMetadata("0"));

        public int MinimumAge
        {
            get { return (int)GetValue(MinimumAgeProperty); }
            set 
            { 
                SetValue(MinimumAgeProperty, value);
                ageValidationRule.Minimum = MinimumAge;
            }
        }

        // Using a DependencyProperty as the backing store for MinimumAge.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinimumAgeProperty =
            DependencyProperty.Register("MinimumAge", typeof(int), typeof(AgeTextBox), new PropertyMetadata(0));


        public int MaximumAge
        {
            get { return (int)GetValue(MaximumAgeProperty); }
            set 
            { 
                SetValue(MaximumAgeProperty, value);
                ageValidationRule.Maximum = MaximumAge;
            }
        }

        // Using a DependencyProperty as the backing store for MaximumAge.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaximumAgeProperty =
            DependencyProperty.Register("MaximumAge", typeof(int), typeof(AgeTextBox), new PropertyMetadata(Int32.MaxValue));


    }
}
