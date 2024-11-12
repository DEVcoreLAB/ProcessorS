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

namespace Globals.SettingFiles.Base
{
    public class SaveSettings : IConfigureFile
    {
        public void Configure<T>(T settingFile, string nameOfSetting, object value) where T : ApplicationSettingsBase
        {
            string callerClassName = GetCallerClassName();
            bool gotSomeProblem = false;

            if (settingFile == null)
            {
                gotSomeProblem = true;
            }
            if (nameOfSetting == null)
            {
                gotSomeProblem = true;
            }
            if (value == null)
            {
                gotSomeProblem = true;
            }

            // Checking if settingFile contains the property nameOfSetting
            Type type = settingFile.GetType();
            PropertyInfo property = type.GetProperty(nameOfSetting);
            if (property == null)
            {
                MessageBox.Show(@$"{settingFile.GetType().Name} does not contain property {nameOfSetting}");
                gotSomeProblem = true;
            }

            // Checking if nameOfSetting and value are of the same type
            if (!property.PropertyType.IsAssignableFrom(value.GetType()))
            {
                MessageBox.Show($"Type mismatch between property '{nameOfSetting}' and the value.");
                gotSomeProblem = true;
            }

            if (gotSomeProblem)
            {
                MessageBox.Show($@"The class named {callerClassName} contains a call to this object {GetType().Name}. ""\n"" {callerClassName} has initialization errors in the constructor. ""\n"" One or more parameters are null.");
                Application.Current.Shutdown();
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

        private string GetCallerClassName()
        {
            StackTrace stackTrace = new StackTrace();
            // Indeks 2: 0 - current method, 1 - helper method, 2 - caller method
            StackFrame frame = stackTrace.GetFrame(2);
            if (frame != null)
            {
                var method = frame.GetMethod();
                if (method != null)
                {
                    var DeclaringType = method.DeclaringType;
                    if (DeclaringType != null)
                    {
                        return DeclaringType.FullName;
                    }
                }
            }
            return null;
        }
    }
}
