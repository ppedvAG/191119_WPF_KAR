using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validierung
{
    class EmailValidationRule : ValidationRule
    {
        // 1) Neues UserControl mit einem neuen Steuerelement (z.B. Textbox) erstellen
        // 2) Dependency-Property für den zu validierenden Wert erstellen (z.B. "Email") und mit der Oberfläche verdrahten
        //     --- "this.DataContext = this" nicht vergessen !!!!
        // 3) Eigene ValidationRule-Klasse erstellen und von ValidationRule erben
        // 4) Regel in XAML einbauen
        // 5) Error-Template einbauen



        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
                return new ValidationResult(false, "Das Textfeld ist leer");

            // Regex
            //    regexr.com -> Tool
            // oder : http://emailregex.com/

            string email = (string)value;

            if (Regex.Match(email, @"[a-zA-Z0-9.äöüÄÖÜß]+@[a-zA-Z0-9.äöüÄÖÜß]+\.[a-zA-Z]{2,3}").Success)
            {
                return new ValidationResult(true, "");
            }
            else
                return new ValidationResult(false, "Ungültige Emailadresse");

        }
    }
}
