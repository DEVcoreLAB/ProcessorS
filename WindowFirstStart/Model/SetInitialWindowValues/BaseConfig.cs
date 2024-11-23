using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.Model.SetInitialWindowValues.FontSizes;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.SetInitialWindowValues
{
    internal class BaseConfig
    {
        public void Set(MainViewModel mainViewModel)
        {
            SetListOfFontsBySize setListOfFontsBySize = new SetListOfFontsBySize();
            mainViewModel.ListOfFontSize =
                setListOfFontsBySize.Set
                (
                    Globals.SettingFiles.SettingFontProperties.Default.FontSize
                );
        }
    }
}
