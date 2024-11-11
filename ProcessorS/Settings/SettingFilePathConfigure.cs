using Globals.SettingFiles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProcessorS.Settings
{
    internal class SettingFilePathConfigure : IConfigureFile
    {
        public void Configure<T>(T settingFile, object value) where T : ApplicationSettingsBase
        {
            var resultValue = value as string;
            var resultSettinFile = settingFile as SettingFilePath;

            try
            {
                if (resultSettinFile != null)
                {
                    resultSettinFile.SystemPath = resultValue;
                    resultSettinFile.Save();
                }
            }
			catch (Exception ex)
			{
                MessageBox.Show($"No access to the AppData/Local folder.\n Unable to create the configuration file.\n The program will now close. {ex}");
                Application.Current.Shutdown();
            }
        }


    }
}
