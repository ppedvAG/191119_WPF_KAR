using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Validierung
{
    class AgeValidationRule : ValidationRule
    {

        // Ein Objekt vom Typ ValidationRule ist kein Dependency-Object und kann daher
        // keine DependencyProperties haben !!!!!!!!!!!!!!!!!
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        // Deswegen die Aktualisierung über das Event in MainWindow.xaml.cs


        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (Int32.TryParse(value.ToString(), out int age))
            {
                if (age < Minimum)
                    return new ValidationResult(false, $"Sie sind zu jung (jünger als {Minimum})");
                else if (age > Maximum)
                    return new ValidationResult(false, $"Sie sind zu alt (älter als {Maximum})");
                else
                    return new ValidationResult(true, null);
            }
            else
                return new ValidationResult(false, "Bitte geben Sie eine gültige Zahl ein");

        }
    }
}
