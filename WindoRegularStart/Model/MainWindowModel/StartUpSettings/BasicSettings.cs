using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowRegularStart.ViewModel.MainWindowViewModel;

namespace WindowRegularStart.Model.MainWindowModel.StartUpSettings
{
    internal class BasicSettings
    {
        MainViewModel MainViewModel { get; }

        public BasicSettings(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void SetMainUserControl()
        {
            MainViewModel.MainUserControl = new ControlProgramStart.ControlStart();
        }
    }
}
