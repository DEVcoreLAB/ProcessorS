using Globals.MyControlsSchemas.Controls.MyButton;
using Globals.MyControlsSchemas.Controls.MyCombobox;
using Globals.MyControlsSchemas.Controls.MyDataGrid;
using Globals.MyControlsSchemas.Controls.MyLabel;
using Globals.MyControlsSchemas.Controls.MyListbox;
using Globals.MyControlsSchemas.Controls.MyPasswordBox;
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
using System.Windows.Controls;

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

            SetCustmControl setCustomPasswordBox = new SetCustmControl(new PasswordBoxBasic());
            Style passwordBoxStyle = setCustomPasswordBox.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.PasswordBox));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.PasswordBox), passwordBoxStyle);

            SetCustmControl setCustomListBox = new SetCustmControl(new ListBoxBasic());
            Style listBoxStyle = setCustomListBox.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.ListBox));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.ListBox), listBoxStyle);

            SetCustmControl setCustomDataGrid = new SetCustmControl(new DataGridBasic());
            Style dataGridStyle = setCustomDataGrid.setControl.SetControlProperties(fontSize);
            Application.Current.Resources.Remove(typeof(System.Windows.Controls.DataGrid));
            Application.Current.Resources.Add(typeof(System.Windows.Controls.DataGrid), dataGridStyle);
        }
    }
}
