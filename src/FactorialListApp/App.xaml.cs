using FactorialListApp.ViewModels;
using FactorialListApp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FactorialListApp
{
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            MainView view = new MainView(); 
            MainViewModel mainViewModel = new MainViewModel();
            view.DataContext = mainViewModel;
            view.Show();
        }
    }
}
