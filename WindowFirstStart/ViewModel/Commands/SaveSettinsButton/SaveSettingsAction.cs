using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowFirstStart.ViewModel.Commands.SaveSettinsButton
{
    internal class SaveSettingsAction
    {
        MainViewModel MainViewModel { get; }

        public SaveSettingsAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Check(object parameter)
        {
            WindowRegularStart.View.MainWindow.MainWindow mainWindow = new WindowRegularStart.View.MainWindow.MainWindow();
            mainWindow.Show();

            Window window = parameter as Window;
            window.Close();
        }
    }
}
