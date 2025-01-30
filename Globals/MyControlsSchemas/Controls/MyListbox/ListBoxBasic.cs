using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Globals.MyControlsSchemas.Controls.MyListbox
{
    internal class ListBoxBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {
            Style ListBoxStyle = new Style(typeof(System.Windows.Controls.ListBox));

            ListBoxStyle.Setters.Add(new Setter(Control.FontSizeProperty, fontSize));

            return ListBoxStyle;
        }
    }
}
