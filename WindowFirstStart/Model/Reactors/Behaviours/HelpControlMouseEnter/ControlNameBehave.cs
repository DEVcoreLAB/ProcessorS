using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.Reactors.Behaviours.HelpControlMouseEnter
{
    internal class ControlNameBehave : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() => 
            {
                if (mainViewModel.ControlName == "connStringTEXTBOX")
                {
                    mainViewModel.HelpDocument = new HelpAndDocumentation.HelpForWindows.FirstStartWindow.ConnectionStringTextbox.ConnectionStringUserControl();
                }
                if (mainViewModel.ControlName == "connectionStringButton")
                {
                    mainViewModel.HelpDocument = new HelpAndDocumentation.HelpForWindows.FirstStartWindow.ConnectionStringButton.ConnectionStringButtonUserControl();
                }
                if (mainViewModel.ControlName == "languageCOMBOBOX")
                {
                    mainViewModel.HelpDocument = new HelpAndDocumentation.ProgramInfo.BasicInfo.BasicInformationAbouProgram();
                }
            });
        }
    }
}
