
using Globals.Logger.Log4N;
using Globals.MyDialogsAndWindows.MyMessagebox;
using Globals.SettingFiles;
using Globals.SettingFiles.Base;
using ProcessorS.Model;
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
            new ConfigureSettingsFiles();
            L4N.L4NDefault.Info("Program started");
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}
