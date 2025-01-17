using Globals.MyDialogsAndWindows.MyDialogBox;
using Globals.MyDialogsAndWindows.MyDialogBox.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowRegularStart.ViewModel.MainWindowViewModel;

namespace WindowRegularStart.ViewModel.Command.ExitButtonCommand
{
    internal class ExitButtonAction
    {
        MainViewModel MainViewModel { get; }
        Action action = new Action(() => { Application.Current.Shutdown(); });

        public ExitButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object parameter)
        {
            DialogBoxX.Show(Langs.Lang.closeAp_p, action);
        }
    }
}
