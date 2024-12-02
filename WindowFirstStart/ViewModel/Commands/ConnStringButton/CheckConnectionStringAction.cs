using Globals.MyDialogsAndWindows.MyMessagebox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowRegularStart.View.MainWindow;

namespace WindowFirstStart.ViewModel.Commands.ConnStringButton
{
    internal class CheckConnectionStringAction
    {
        MainViewModel MainViewModel { get; set; }

        public CheckConnectionStringAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Check()
        {
            MessageBoxX.Show("test");
        }
    }
}
