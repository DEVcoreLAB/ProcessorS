using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.View;

namespace ProcessorS.Model
{
    internal class ShowProperWidow
    {
        WindowFirstStart.View.FirsStartWindow firsStartWindow;
        WindowRegularStart.View.MainWindow.MainWindow mainWindow;

        public ShowProperWidow()
        {
            firsStartWindow = new();
            mainWindow = new();
            Show();
        }

        public void Show()
        {
            if (string.IsNullOrEmpty(Globals.SettingFiles.ConnString.Default.ConnectionString))
            {
                firsStartWindow.Show();
            }
            else
            {
                mainWindow.Show();
            }
        }
    }
}
