using Globals.SettingFiles;
using Globals.SettingFiles.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowFirstStart.ViewModel.Commands.SaveSettinsButton
{
    internal class SaveSettingsAction
    {
        MainViewModel MainViewModel { get; }

        public SaveSettingsAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Check(object parameter)
        {
            SettingFileConfigurator settingFileConfigurator = new SettingFileConfigurator(new SaveSettings());
            settingFileConfigurator.ConfigureFile.Configure(SettingFontProperties.Default,nameof(SettingFontProperties.FontSize),MainViewModel.FontSizeSelectedValue);

            WindowRegularStart.View.MainWindow.MainWindow mainWindow = new WindowRegularStart.View.MainWindow.MainWindow();
            mainWindow.Show();

            Window window = parameter as Window;
            window.Close();
        }
    }
}
