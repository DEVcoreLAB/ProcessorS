using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Globals.MyControlsSchemas.Controls.MyUserControl
{
    public class UserControlBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {
            Style style = new Style(typeof(UserControl));
            style.Setters.Add(new Setter(Control.FontSizeProperty, fontSize));
            return style;
        }
    }
}
