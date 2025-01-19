using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowMainWindowContextMenu.Command.LockScreenCommands;

namespace WindowMainWindowContextMenu.ViewModel
{
    internal class MainViewModel
    {
        public RelayCommand LockSreenCommand {  get; }

        public MainViewModel()
        {
            LockSreenCommand = new RelayCommand(new LockScreenAction().Execute,new LockScreenPredict().Check);
        }
    }
}
