using Globals.Security.PasswordBoxControlHelper;
using Globals.SettingFiles;
using Globals.SettingFiles.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowFirstStart.ViewModel.Commands.SaveSettinsButton
{
    internal class SaveSettingsAction
    {
        MainViewModel MainViewModel { get; }

        public SaveSettingsAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Save(object parameter)
        {
            SettingFileConfigurator settingFileConfigurator = new SettingFileConfigurator(new SaveSettings());
            settingFileConfigurator.ConfigureFile.Configure(SettingFontProperties.Default,nameof(SettingFontProperties.FontSize),MainViewModel.FontSizeSelectedValue);
            settingFileConfigurator.ConfigureFile.Configure(SettingCurrentLanguage.Default, nameof(SettingCurrentLanguage.CurrentLanguageCode), MainViewModel.SelectedLanguage.CultureCode);
            settingFileConfigurator.ConfigureFile.Configure(ConnString.Default, nameof(ConnString.ConnectionString), Globals.Security.PasswordBoxControlHelper.SaveToFileStringToSecuredString.ConvertString(MainViewModel.ConnectionStringTextboxText));
            settingFileConfigurator.ConfigureFile.Configure(PassKey.Default, nameof(PassKey.MyPassKey), SaveToFileStringToSecuredString.ConvertString(ConvertToUnsecureString.Convert(MainViewModel.PasswordConfirm)));

            Thread.CurrentThread.CurrentCulture = new CultureInfo($"{SettingCurrentLanguage.Default.CurrentLanguageCode}");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo($"{SettingCurrentLanguage.Default.CurrentLanguageCode}");

            Globals.DbOperations.CresteNewDb.CreateDb createDB = new Globals.DbOperations.CresteNewDb.CreateDb();
            createDB.Create(Globals.DbOperations.DbasesNames.DbNames.SupplierSchemas.ToString());
            createDB.Create(Globals.DbOperations.DbasesNames.DbNames.SuppliersList.ToString());
            

            Application.Current.MainWindow.Show();

            Window window = parameter as Window;
            window.Close();
        }
    }
}
