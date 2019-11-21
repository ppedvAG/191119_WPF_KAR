using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Binding_Demo
{
    class Farbkonverter : IValueConverter
    {
        // One Way
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string text = (string)value;

            if (text == "Rot")
                return Brushes.Red;
            else if (text == "Blau")
                return Brushes.Blue;
            else if (text == "Grün")
                return Brushes.Green;
            else
                return Brushes.Black;
        }

        // TwoWay
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}