using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Effects;
using WindowMainWindowContextMenu.View;
using Windows.UI;

namespace WindowMainWindowContextMenu.ViewModel.Command.ShowStartBarCommand
{
    internal class ShowStartBarAction
    {
        MainViewModel mainViewModel;

        public ShowStartBarAction(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        {
            var window = parameter as ContextMenuWindow;

            if (mainViewModel.IsStartBarVisible == false)
            {
                window.Hide();

                Application.Current.MainWindow.Effect = new BlurEffect { Radius = 0 };

                Application.Current.MainWindow.WindowState = WindowState.Normal;
                Application.Current.MainWindow.Width = SystemParameters.WorkArea.Width + 7;
                Application.Current.MainWindow.Height = SystemParameters.WorkArea.Height + 7;
                Application.Current.MainWindow.Left = SystemParameters.WorkArea.Left;
                Application.Current.MainWindow.Top = SystemParameters.WorkArea.Top;
                mainViewModel.IsStartBarVisible = true;
            }
            else if (mainViewModel.IsStartBarVisible == true)
            {
                window.Hide();
                Application.Current.MainWindow.WindowState |= WindowState.Maximized;
                Application.Current.MainWindow.Effect = new BlurEffect { Radius = 0 };
                mainViewModel.IsStartBarVisible = false;
            }
        }
    }
}
