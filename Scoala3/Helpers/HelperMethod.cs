using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Scoala3.Helpers
{
    public static class HelperMethod
    {
        public static void SwitchWindow<T>(T window) where T : Window
        {
            System.Windows.Application.Current.MainWindow.Close();
            App.Current.MainWindow = window;
            window.Show();
        }
    }
}
