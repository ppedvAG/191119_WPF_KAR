﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Lokalisierung
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // Beim Applikationsstart bevor der XAML-Parser angetriggert wird:
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
        }
    }
}
