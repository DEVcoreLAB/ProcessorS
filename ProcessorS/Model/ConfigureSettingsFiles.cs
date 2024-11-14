using Globals.SettingFiles.Base;
using Globals.SettingFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProcessorS.Model
{
    internal class ConfigureSettingsFiles
    {
        SettingFileConfigurator Configurator;

        public ConfigureSettingsFiles()
        {
            Configurator = new SettingFileConfigurator(new SaveSettings());

            SetSystemPatch();
            SetCurrentLanguage();
        }

        private void SetSystemPatch()
        {
            if (string.IsNullOrEmpty(Globals.SettingFiles.SettingFilePath.Default.SystemPath))
            {
                Configurator.ConfigureFile.Configure(
                    SettingFilePath.Default,
                    nameof(SettingFilePath.Default.SystemPath),
                    $@"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\ProcessorS");

            }
        }

        private void SetCurrentLanguage()
        {
            if (string.IsNullOrEmpty(Globals.SettingFiles.SettingCurrentLanguage.Default.CurrentLanguageCode))
            {
                Configurator.ConfigureFile.Configure(
                    SettingCurrentLanguage.Default, 
                    nameof(SettingCurrentLanguage.Default.CurrentLanguageCode), 
                    CultureInfo.CurrentCulture.Name);
            }
        }
    }
}
