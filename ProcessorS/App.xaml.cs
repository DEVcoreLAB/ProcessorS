﻿using WindowFirstStart.View;
using ProcessorS.Model;

using Globals.Logger.Log4N;
using Globals.MyDialogsAndWindows.MyMessagebox;
using Globals.SettingFiles;
using ProcessorS.Model;

using Globals.SettingFiles.Base;
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

            Application.Current.MainWindow = new WindowRegularStart.View.MainWindow.MainWindow();

            new ConfigureSettingsFiles();
            new ConfigureControls();
            new ShowProperWidow();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}
