using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowFirstStart.View;

namespace ProcessorS.Model
{
    internal class ShowProperWidow
    {
        public ShowProperWidow()
        {
            Show();
        }

        public void Show()
        {
            if (string.IsNullOrEmpty(Globals.SettingFiles.ConnString.Default.ConnectionString))
            {
                FirsStartWindow firsStartWindow = new FirsStartWindow();
                firsStartWindow.Show();
            }
            else
            {
                Application.Current.MainWindow.Show();
            }
        }
    }
}
