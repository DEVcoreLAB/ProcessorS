using Globals.MyControlsSchemas.Controls.MyButton;
using Globals.SettingFiles.Base;
using Globals.SettingFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Globals.MyControlsSchemas;
using System.Windows;
using Globals.Logger.Log4N;

namespace ProcessorS.Model
{
    internal class ConfigureSettingsFiles
    {
        SettingFileConfigurator configurator;

        public ConfigureSettingsFiles()
        {
            configurator = new SettingFileConfigurator(new SaveSettings());

            SetSystemPatch();
            SetCurrentLanguage();
            SetFontSize();
        }

        private void SetSystemPatch()
        {
            if (string.IsNullOrEmpty(Globals.SettingFiles.SettingFilePath.Default.SystemPath))
            {
                configurator.ConfigureFile.Configure(
                    SettingFilePath.Default,
                    nameof(SettingFilePath.Default.SystemPath),
                    $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\ProcessorS");
            }

            L4N.L4NDefault.Info("Program started");
        }

        private void SetCurrentLanguage()
        {
            string currentCulture = CultureInfo.CurrentCulture.Name == "pl-PL" ? "pl-PL" : "en-US";

            if (string.IsNullOrEmpty(Globals.SettingFiles.SettingCurrentLanguage.Default.CurrentLanguageCode))
            {
                configurator.ConfigureFile.Configure(
                    SettingCurrentLanguage.Default, 
                    nameof(SettingCurrentLanguage.Default.CurrentLanguageCode),
                    currentCulture);
            }
        }

        private void SetFontSize()
        {
            configurator.ConfigureFile.Configure(
                SettingFontProperties.Default,
                nameof(SettingFontProperties.Default.FontSize),
                SystemFonts.MessageFontSize
                );
        }
    }
}
