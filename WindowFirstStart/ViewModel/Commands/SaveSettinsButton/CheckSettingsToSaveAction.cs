using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowFirstStart.ViewModel.Commands.SaveSettinsButton
{
    internal class CheckSettingsToSaveAction
    {
        MainViewModel MainViewModel { get; }

        public CheckSettingsToSaveAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Check()
        {
            MessageBox.Show("test");
        }
    }
}
