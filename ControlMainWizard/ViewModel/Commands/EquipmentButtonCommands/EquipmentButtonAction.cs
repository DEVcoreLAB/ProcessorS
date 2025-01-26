using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMainWizard.ViewModel.Commands.EquipmentButtonCommands
{
    internal class EquipmentButtonAction
    {
        MainViewModel MainViewModel { get; }

        public EquipmentButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        {
            if (MainViewModel.MainUserControlContent is not SubContrrolEquipmentProject.View.EquipmentControl)
            {
                MainViewModel.MainUserControlContent = new SubContrrolEquipmentProject.View.EquipmentControl();
            }
        }
    }
}
