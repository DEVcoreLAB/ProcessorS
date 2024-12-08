using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFirstStart.ViewModel.Commands.SaveSettinsButton
{
    internal class CheckSettingsToSavePredict
    {
        MainViewModel MainViewModel { get; }

        public CheckSettingsToSavePredict(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public bool Check()
        {
            return MainViewModel.IsEnabledSaveButton;
        }
    }
}
