using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMainWizard.ViewModel.Commands.ProductButtonCommands
{
    internal class ProductButtonAction
    {
        MainViewModel MainViewModel { get; }

        public ProductButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        {
            if (MainViewModel.MainUserControlContent is not SubControlProductProject.View.ProductControl)
            {
                MainViewModel.MainUserControlContent = new SubControlProductProject.View.ProductControl();
            }
        }
    }
}
