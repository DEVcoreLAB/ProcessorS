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
        }

        private void SetCurrentLanguage()
        {
            if (string.IsNullOrEmpty(Globals.SettingFiles.SettingCurrentLanguage.Default.CurrentLanguageCode))
            {
                configurator.ConfigureFile.Configure(
                    SettingCurrentLanguage.Default, 
                    nameof(SettingCurrentLanguage.Default.CurrentLanguageCode), 
                    CultureInfo.CurrentCulture.Name);
            }
        }

        private void SetFontSize()
        {
            configurator.ConfigureFile.Configure(SettingFontProperties.Default,
                nameof(SettingFontProperties.Default.FontSize),
                SystemFonts.MessageFontSize
                );
        }

        
    }
}
