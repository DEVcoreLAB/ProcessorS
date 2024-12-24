using Globals.MyControlsSchemas.Controls.MyButton;
using Globals.MyControlsSchemas.Controls.MyCombobox;
using Globals.MyControlsSchemas.Controls.MyLabel;
using Globals.MyControlsSchemas.Controls.MyTextBlock;
using Globals.MyControlsSchemas.Controls.MyTextBox;
using Globals.MyControlsSchemas.Controls.MyToolTip;
using Globals.MyControlsSchemas.Controls.MyUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Globals.MyControlsSchemas.Controls
{
    public class SetResources
    {
        public static void Set(double fontSize)
        {
            SetCustmControl setCustmButtonControl = new SetCustmControl(new ButtonBasic());
            Style buttonStyle = setCustmButtonControl.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.Button));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.Button), buttonStyle);

            SetCustmControl setCustmComboboxControl = new SetCustmControl(new ComboboxBasic());
            Style comboboxStyle = setCustmComboboxControl.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.ComboBox));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.ComboBox), comboboxStyle);

            SetCustmControl setCustmLabelControl = new SetCustmControl(new LabelBasic());
            Style labelStyle = setCustmLabelControl.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.Label));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.Label), labelStyle);

            SetCustmControl setCustmTextBoxControl = new SetCustmControl(new TextBoxBasic());
            Style textBoxStyle = setCustmTextBoxControl.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.TextBox));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.TextBox), textBoxStyle);

            SetCustmControl setCustomTooltipControl = new SetCustmControl(new ToolTipBasic());
            Style toolTipStyle = setCustomTooltipControl.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.ToolTip));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.ToolTip), toolTipStyle);

            SetCustmControl setCustomTextBlockControl = new SetCustmControl(new TextBlockBasic());
            Style textBlockStyle = setCustomTextBlockControl.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.TextBlock));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.TextBlock), textBlockStyle);

            SetCustmControl setCustomUserControl = new SetCustmControl(new UserControlBasic());
            Style userControlStyle = setCustomUserControl.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.UserControl));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.UserControl), userControlStyle);
        }
    }
}
