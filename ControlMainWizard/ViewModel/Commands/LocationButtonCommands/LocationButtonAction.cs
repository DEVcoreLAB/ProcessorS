using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMainWizard.ViewModel.Commands.LocationButtonCommands
{
    internal class LocationButtonAction
    {
        MainViewModel MainViewModel { get; }

        public LocationButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        {
            if (MainViewModel.MainUserControlContent is not SubControlLocationProject.View.LocationControl)
            {
                MainViewModel.MainUserControlContent = new SubControlLocationProject.View.LocationControl();
            }
        }
    }
}
