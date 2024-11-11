using Globals.Logger.Log4N;
using Globals.SettingFiles;
using ProcessorS.Settings;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace ProcessorS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            SettingFileConfigurator settingFileConfigurator = new SettingFileConfigurator(new SettingFilePathConfigure());
            settingFileConfigurator.ConfigureFile.Configure(SettingFilePath.Default, $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\ProcessorS");

            set(SettingFilePath.Default);

            L4N.L4NDefault.Info("Program started");
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

        private void set(ApplicationSettingsBase asd)
        {
            
        }
    }

}
