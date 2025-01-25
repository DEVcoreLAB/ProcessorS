using ControlMainWizard.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowRegularStart.ViewModel.MainWindowViewModel;

namespace WindowRegularStart.ViewModel.Command.WizardButtonCommands
{
    internal class WizardButtonAction
    {
        MainViewModel MainViewModel { get; }

        public WizardButtonAction(MainViewModel mainViewModel)
        {
           MainViewModel =  mainViewModel;
        }

        public void Execute(object? parameter)
        {
            if (MainViewModel.MainUserControl is not WizardMainControl)
            {
                MainViewModel.MainUserControl = new ControlMainWizard.View.WizardMainControl();
                MainViewModel.CollapsibleButtonClickCommand.Execute(parameter);
            }
        }
    }
}
