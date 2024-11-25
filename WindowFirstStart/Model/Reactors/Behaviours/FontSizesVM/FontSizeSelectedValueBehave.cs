using Globals.Model.Observer.Components;
using Globals.MyControlsSchemas;
using Globals.MyControlsSchemas.Controls.MyButton;
using Globals.MyControlsSchemas.Controls.MyCombobox;
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
                SetCustmControl setCustmButtonControl = new SetCustmControl(new ButtonBasic());
                Style buttonStyle = setCustmButtonControl.setControl.SetControlProperties(mainViewModel.FontSizeSelectedValue);
                Application.Current.Resources.Remove(typeof(System.Windows.Controls.Button));
                Application.Current.Resources.Add(typeof(System.Windows.Controls.Button), buttonStyle);

                SetCustmControl setCustmComboboxControl = new SetCustmControl(new ComboboxBasic());
                Style comboboxStyle = setCustmComboboxControl.setControl.SetControlProperties(mainViewModel.FontSizeSelectedValue);
                Application.Current.Resources.Remove(typeof(System.Windows.Controls.ComboBox));
                Application.Current.Resources.Add(typeof(System.Windows.Controls.ComboBox), comboboxStyle);
            });
        }
    }
}
