using Globals.Model.Observer.Components;
using Globals.MyControlsSchemas;
using Globals.MyControlsSchemas.Controls;
using Globals.MyControlsSchemas.Controls.MyButton;
using Globals.MyControlsSchemas.Controls.MyCombobox;
using Globals.MyControlsSchemas.Controls.MyLabel;
using Globals.MyControlsSchemas.Controls.MyTextBlock;
using Globals.MyControlsSchemas.Controls.MyTextBox;
using Globals.MyControlsSchemas.Controls.MyToolTip;
using Globals.SettingFiles;
using Globals.SettingFiles.Base;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowFirstStart.ViewModel;

namespace WindowFirstStart.Model.Reactors.Behaviours.FontSizesVM
{
    internal class FontSizeSelectedValueBehave : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() =>
            {
                SetResources.Set(mainViewModel.FontSizeSelectedValue);
            });
        }
    }
}
