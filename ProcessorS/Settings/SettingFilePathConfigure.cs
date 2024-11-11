using Globals.SettingFiles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace ProcessorS.Settings
{
    internal class SettingFilePathConfigure : IConfigureFile
    {
        public void Configure<T>(T settingFile, string nameOfSetting, object value) where T : ApplicationSettingsBase
        {
            if (settingFile == null)
            {
                MessageBox.Show("settings = null");
                return;
            }
            if (nameOfSetting == null)
            {
                MessageBox.Show("nameOfSetting = null");
                return;
            }
            if (value == null)
            {
                MessageBox.Show("value = null");
                return;
            }

            // Checking if settingFile contains the property nameOfSetting
            Type type = settingFile.GetType(); 
            PropertyInfo property = type.GetProperty(nameOfSetting);
            if (property == null)
            {
                MessageBox.Show(@$"{settingFile.GetType().Name} does not contain property {nameOfSetting}");
                return;
            }

            // Checking if nameOfSetting and value are of the same type
            if (!property.PropertyType.IsAssignableFrom(value.GetType()))
            {
                MessageBox.Show($"Type mismatch between property '{nameOfSetting}' and the value.");
                return;
            }

            try
            {
                property.SetValue(settingFile, value);
                settingFile.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while setting the value of property '{nameOfSetting}' in {typeof(T).Name}: {ex.Message}");
                Application.Current.Shutdown();
            }
        }
    }
}
