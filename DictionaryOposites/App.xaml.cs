using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DictionaryOposites
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            var ces = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            AppDomain.CurrentDomain.SetData("DataDirectory", ces);
            var a = 4;
        }
    }
}
