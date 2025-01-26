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
                    mainViewModel.HelpDocument = new HelpAndDocumentation.HelpForWindows.FirstStartWindow.ConnectionStringTextbox.ConnectionStringUserControl(mainViewModel.FontSizeSelectedValue);
                }
                if (mainViewModel.ControlName == "connectionStringButton")
                {
                    mainViewModel.HelpDocument = new HelpAndDocumentation.HelpForWindows.FirstStartWindow.ConnectionStringButton.ConnectionStringButtonUserControl(mainViewModel.FontSizeSelectedValue);
                }
                if (mainViewModel.ControlName == "languageCOMBOBOX")
                {
                    mainViewModel.HelpDocument = new HelpAndDocumentation.ProgramInfo.BasicInfo.BasicInformationAbouProgram(mainViewModel.FontSizeSelectedValue);
                }
                if (mainViewModel.ControlName == "passwordBoxBase")
                {
                    mainViewModel.HelpDocument = new HelpAndDocumentation.HelpForWindows.FirstStartWindow.FirstPasswordBox.FirstPasswordBoxControl(mainViewModel.FontSizeSelectedValue);
                }
            });
        }
    }
}
