using ControlMainWizard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ControlMainWizard.ViewModel.Commands.IntermediateProductButtonCommands
{
    internal class IntermediateButtonAction
    {
        MainViewModel MainViewModel { get; }

        public IntermediateButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        {
            if (MainViewModel.MainUserControlContent is not SubControlIntermediateProductProject.View.IntermediateProductControl)
            {
                MainViewModel.MainUserControlContent = new SubControlIntermediateProductProject.View.IntermediateProductControl();
            }

            SetButtonsBorderToBlack setButtonsBorderToBlack = new SetButtonsBorderToBlack();
            setButtonsBorderToBlack.Set(MainViewModel);

            MainViewModel.IntermediateProductButtonBorderBrush = new System.Windows.Media.SolidColorBrush(Colors.Orange);
        }
    }
}
