using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Globals.MyControlsSchemas.Controls.MyCombobox
{
    public class ComboboxBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {
            Style comboboxStyle = new Style(typeof(System.Windows.Controls.ComboBox));

            comboboxStyle.Setters.Add(new Setter(Control.FontSizeProperty, fontSize));

           return comboboxStyle;
        }
    }
}
