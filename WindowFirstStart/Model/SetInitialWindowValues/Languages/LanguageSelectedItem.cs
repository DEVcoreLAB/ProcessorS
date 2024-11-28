using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.SetInitialWindowValues.Languages
{
    internal class LanguageSelectedItem
    {
        public void Select(MainViewModel mainViewModel)
        {
            mainViewModel.SelectedLanguage = mainViewModel.LanguagesCombobox.FirstOrDefault(x => x.CultureCode.Equals(Globals.SettingFiles.SettingCurrentLanguage.Default.CurrentLanguageCode));
        }
    }
}
