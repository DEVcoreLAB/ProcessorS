using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindowFirstStart.Langs;
using WindowFirstStart.Model.SetInitialWindowValues.FontSizes;
using WindowFirstStart.Model.SetInitialWindowValues.Languages;
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

            mainViewModel.FontSizeLabel = Lang.fontSizeLabel;

            // language section
            mainViewModel.LanguageSelectLabel = Lang.programLanguage;

            SetLangsCollection setLangsCollection = new SetLangsCollection();
            mainViewModel.LanguagesCombobox = setLangsCollection.Set().ToList();

            LanguageSelectedItem languageSelectedItem = new LanguageSelectedItem();
            languageSelectedItem.Select(mainViewModel);
        }
    }
}
