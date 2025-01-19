using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Effects;

namespace WindowMainWindowContextMenu.Command.LockScreenCommands
{
    class LockScreenAction
    {
        public void Execute(object parameter)
        {
            if (parameter is Window window)
            {
                 window.Visibility = Visibility.Collapsed;
            }

            Application.Current.MainWindow.Effect = new BlurEffect() { Radius = 50};
            
            Globals.MyDialogsAndWindows.MyLockScreen.LockScreenWindow lockScreenWindow = new Globals.MyDialogsAndWindows.MyLockScreen.LockScreenWindow();
            lockScreenWindow.ShowDialog();
        }
    }
}
