using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowFirstStart.Model.WindowIsDisplayed.Langchanged;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.Reactors.Behaviours.LanguageSelectVM
{
    internal class LanguageChangedBehave : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() => 
            {
                CultureInfo cultureInfo = CultureInfo.GetCultureInfo(mainViewModel.SelectedLanguage.CultureCode);

                Thread.CurrentThread.CurrentCulture = cultureInfo;
                Thread.CurrentThread.CurrentUICulture = cultureInfo;

                ChangeVisibleTexts changeVisibleTexts = new ChangeVisibleTexts();
                changeVisibleTexts.Change(mainViewModel);

                mainViewModel.HelpDocument = null;
                mainViewModel.HelpDocument = new HelpAndDocumentation.ProgramInfo.BasicInfo.BasicInformationAbouProgram();
            });
        }
    }
}
