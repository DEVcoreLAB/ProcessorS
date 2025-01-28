using ControlMainWizard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ControlMainWizard.ViewModel.Commands.SupplierButtonCommands
{
    internal class SupplierButtonAction
    {
        MainViewModel MainViewModel { get; }

        public SupplierButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        {
            if (MainViewModel.MainUserControlContent is not SubControlSupplierProject.View.SupplierControl)
            {
                MainViewModel.MainUserControlContent = new SubControlSupplierProject.View.SupplierControl();
            }

            SetButtonsBorderToBlack setButtonsBorderToBlack = new SetButtonsBorderToBlack();
            setButtonsBorderToBlack.Set(MainViewModel);

            MainViewModel.SupplierButtonBorderBrudh = new System.Windows.Media.SolidColorBrush(Colors.Orange);
        }
    }
}
