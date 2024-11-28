using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.Langs;
using WindowFirstStart.ViewModel;
using WindowRegularStart.View.MainWindow;

namespace WindowFirstStart.Model.WindowIsDisplayed.Langchanged
{
    internal class ChangeVisibleTexts
    {
        public void Change(MainViewModel mainViewModel)
        {
            mainViewModel.LanguageSelectLabel = Lang.programLanguage;
            mainViewModel.FontSizeLabel = Lang.fontSizeLabel;
        }
    }
}
