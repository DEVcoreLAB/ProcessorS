using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMainWizard.ViewModel.Commands.CustomerButtonCommand
{
    internal class CustomerButtonAction
    {
        MainViewModel MainViewModel { get; }

        public CustomerButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        {
            if (MainViewModel.MainUserControlContent is not SubControlCustomerProject.View.CustomerControl)
            {
                MainViewModel.MainUserControlContent = new SubControlCustomerProject.View.CustomerControl();
            }
        }
    }
}
