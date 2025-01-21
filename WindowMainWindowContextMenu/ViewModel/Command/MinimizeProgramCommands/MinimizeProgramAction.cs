using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowMainWindowContextMenu.View;

namespace WindowMainWindowContextMenu.ViewModel.Command.MinimizeProgramCommands
{
    internal class MinimizeProgramAction
    {
        MainViewModel mainViewModel;

        public MinimizeProgramAction(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        {
            var window = parameter as ContextMenuWindow;
            window.Hide();
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
    }
}
