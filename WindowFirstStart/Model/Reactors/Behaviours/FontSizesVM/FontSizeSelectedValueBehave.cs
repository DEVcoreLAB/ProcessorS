using Globals.Model.Observer.Components;
using Globals.MyControlsSchemas;
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
                SetCustmControl setCustmButtonControl = new SetCustmControl(new ButtonBasic());
                Style buttonStyle = setCustmButtonControl.setControl.SetControlProperties(mainViewModel.FontSizeSelectedValue);
                Application.Current.Resources.Remove(typeof(System.Windows.Controls.Button));
                Application.Current.Resources.Add(typeof(System.Windows.Controls.Button), buttonStyle);

                SetCustmControl setCustmComboboxControl = new SetCustmControl(new ComboboxBasic());
                Style comboboxStyle = setCustmComboboxControl.setControl.SetControlProperties(mainViewModel.FontSizeSelectedValue);
                Application.Current.Resources.Remove(typeof(System.Windows.Controls.ComboBox));
                Application.Current.Resources.Add(typeof(System.Windows.Controls.ComboBox), comboboxStyle);

                SetCustmControl setCustmLabelControl = new SetCustmControl(new LabelBasic());
                Style labelStyle = setCustmLabelControl.setControl.SetControlProperties(mainViewModel.FontSizeSelectedValue);
                Application.Current.Resources.Remove(typeof(System.Windows.Controls.Label));
                Application.Current.Resources.Add(typeof(System.Windows.Controls.Label), labelStyle);

                SetCustmControl setCustmTextBoxControl = new SetCustmControl(new TextBoxBasic());
                Style textBoxStyle = setCustmTextBoxControl.setControl.SetControlProperties(mainViewModel.FontSizeSelectedValue);
                Application.Current.Resources.Remove(typeof(System.Windows.Controls.TextBox));
                Application.Current.Resources.Add(typeof(System.Windows.Controls.TextBox), textBoxStyle);

                SetCustmControl setCustomTooltipControl = new SetCustmControl(new ToolTipBasic());
                Style toolTipStyle = setCustomTooltipControl.setControl.SetControlProperties(mainViewModel.FontSizeSelectedValue);
                Application.Current.Resources.Remove(typeof(System.Windows.Controls.ToolTip));
                Application.Current.Resources.Add(typeof(System.Windows.Controls.ToolTip), toolTipStyle);

                SetCustmControl setCustomTextBlockControl = new SetCustmControl(new TextBlockBasic());
                Style textBlockStyle = setCustomTextBlockControl.setControl.SetControlProperties(mainViewModel.FontSizeSelectedValue);
                Application.Current.Resources.Remove(typeof(System.Windows.Controls.TextBlock));
                Application.Current.Resources.Add(typeof(System.Windows.Controls.TextBlock), textBlockStyle);

            });
        }
    }
}
