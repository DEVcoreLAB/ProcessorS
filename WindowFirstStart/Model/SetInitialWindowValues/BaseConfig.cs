using ADocumentation.Projects.Globals.Graphics;
using Globals.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using WindowFirstStart.Langs;
using WindowFirstStart.Model.SetInitialWindowValues.FontSizes;
using WindowFirstStart.Model.SetInitialWindowValues.Languages;
using WindowFirstStart.Model.WindowIsDisplayed.Langchanged;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.SetInitialWindowValues
{
    internal class BaseConfig
    {
        public void Set(MainViewModel mainViewModel)
        {
            // font size section
            SetListOfFontsBySize setListOfFontsBySize = new SetListOfFontsBySize();
            mainViewModel.ListOfFontSize =
                setListOfFontsBySize.Set
                (
                    Globals.SettingFiles.SettingFontProperties.Default.FontSize
                );
            mainViewModel.FontSizeSelectedValue = mainViewModel.ListOfFontSize.FirstOrDefault(x => x.Equals(Globals.SettingFiles.SettingFontProperties.Default.FontSize));

            ChangeVisibleTexts changeVisibleTexts = new ChangeVisibleTexts();
            changeVisibleTexts.Change(mainViewModel);

            SetLangsCollection setLangsCollection = new SetLangsCollection();
            mainViewModel.LanguagesCombobox = setLangsCollection.Set().ToList();

            LanguageSelectedItem languageSelectedItem = new LanguageSelectedItem();
            languageSelectedItem.Select(mainViewModel);

            mainViewModel.CheckConnectioStringButtonBackground = SetProperButtonBackground.Set(false,Uris.CheckConnectionToDBEnabled,Uris.CheckConnectionToDBDisabled);
            mainViewModel.ConnStringButtonIsEnabled = false;

            mainViewModel.PasswordOriginBackground = SetProperButtonBackground.SetSimple(Uris.ShowDataIcon);
            mainViewModel.PasswordConfirmBackgound = SetProperButtonBackground.SetSimple(Uris.ShowDataIcon);

            mainViewModel.PasswordBase = new SecureString();
            mainViewModel.PasswordConfirm = new SecureString();

            mainViewModel.IsPasswordBoxConfirmEnabled = false;

            mainViewModel.PasswordBoxConfirmForeground = new System.Windows.Media.SolidColorBrush(Colors.Red);

            mainViewModel.SaveSettingsButtonBackground = SetProperButtonBackground.Set(false,Uris.SaveSettingsEnabled,Uris.SaveSettingsDisabled);
            mainViewModel.IsEnabledSaveButton = false;

            mainViewModel.ConnStrinngTextBoxForeground = new SolidColorBrush(Colors.Black);
        }
    }
}
