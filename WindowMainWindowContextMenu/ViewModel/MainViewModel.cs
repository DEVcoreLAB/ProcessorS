using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowMainWindowContextMenu.Command.LockScreenCommands;
using WindowMainWindowContextMenu.ViewModel.Command.MinimizeProgramCommands;
using WindowMainWindowContextMenu.ViewModel.Command.ShowStartBarCommand;

namespace WindowMainWindowContextMenu.ViewModel
{
    internal class MainViewModel
    {
        public RelayCommand LockSreenCommand {  get; }
        public RelayCommand ShowStartBarCommand { get; }
        public RelayCommand MinimizeProgram {  get; }

        public MainViewModel()
        {
            LockSreenCommand = new RelayCommand(new LockScreenAction().Execute,new LockScreenPredict().Check);

            IsStartBarVisible = false;

            ShowStartBarAction showStartBarAction = new ShowStartBarAction(this);
            ShowStartBarCommand = new RelayCommand(
                showStartBarAction.Execute,  
                () => new ShowStartBarPredict().Check());
            MinimizeProgram = new RelayCommand(new MinimizeProgramAction(this).Execute,new MinimizeProgramPredict().Check);
        }

        private bool isStartBarVisible;
        public bool IsStartBarVisible
        {
            get { return isStartBarVisible; }
            set { isStartBarVisible = value; }
        }

    }
}
