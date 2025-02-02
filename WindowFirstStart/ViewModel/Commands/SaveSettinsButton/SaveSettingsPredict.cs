using Globals.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFirstStart.ViewModel.Commands.SaveSettinsButton
{
    internal class SaveSettingsPredict
    {
        MainViewModel MainViewModel { get; }

        public SaveSettingsPredict(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public bool Check()
        {
            MainViewModel.SaveSettingsButtonBackground = Globals.Graphics.SetProperButtonBackground.Set(MainViewModel.IsEnabledSaveButton, Uris.SaveSettingsEnabled, Uris.SaveSettingsDisabled);


            return MainViewModel.IsEnabledSaveButton;
        }
    }
}
