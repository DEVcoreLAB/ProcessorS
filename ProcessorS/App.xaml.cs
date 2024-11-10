using Globals.Logger.Log4N;
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
        //string criticalErrorMessage = 

        private Action<string> action = new ((ex) => 
        {
            MessageBox.Show($"No access to the AppData/Local folder.\n Unable to create the configuration file.\n The program will now close. {ex}");
            Application.Current.Shutdown();
        });

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            SetLoggerFilesPath();
            L4N.L4NDefault.Info("Program started");
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

        private void SetLoggerFilesPath()
        {
            try
            {
                Globals.SettingFiles.SettingFilePath.Default.SystemPath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\ProcessorS";
                Globals.SettingFiles.SettingFilePath.Default.Save();
            }
            catch (Exception ex)
            {
                action(ex.Message);
            }
        }
    }

}
