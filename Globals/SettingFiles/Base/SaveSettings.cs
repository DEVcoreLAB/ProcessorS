using Globals.Logger.Log4N;
using Globals.MyDialogsAndWindows.MyMessagebox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace Globals.SettingFiles.Base
{
    public class SaveSettings : IConfigureFile
    {
        string callerClassName; 
        string errorMessageboxMessage = $"Critical error. Cannot save values to the settings file. The program will be closed. Details in the event log.";

        public SaveSettings([CallerFilePath] string callerFilePath = "", [CallerLineNumber] int callerLineNumber = 0)
        {
            callerClassName = $"{callerFilePath}. Line {callerLineNumber}" ;
        }

        public void Configure<T>(T settingFile, string nameOfSetting, object value) where T : ApplicationSettingsBase
        {
            try
            {
                if (settingFile == null)
                {
                    throw new ArgumentNullException(nameof(settingFile));
                }
                if (string.IsNullOrEmpty(nameOfSetting))
                {
                    throw new ArgumentNullException(nameof(nameOfSetting));
                }
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                // Checking if settingFile contains the property nameOfSetting
                Type type = settingFile.GetType();
                PropertyInfo property = type.GetProperty(nameOfSetting);

                if (property == null)
                {
                    throw new MissingMemberException(type.Name, nameOfSetting);
                }

                // Checking if nameOfSetting and value are of the same type
                if (!property.PropertyType.IsAssignableFrom(value.GetType()))
                {
                    throw new InvalidOperationException(nameof(property) + " " + nameof(value));
                }

                property.SetValue(settingFile, value);
                settingFile.Save();
            }
            catch (Exception ex)
            {
                L4N.L4NDefault.Error(ex.Message + $"Caller class {callerClassName}");
                MessageBoxX.Show(errorMessageboxMessage + $"{ex.Message}" + $" Caller class {callerClassName}");
                Application.Current.Shutdown();
            }
        }
    }
}
