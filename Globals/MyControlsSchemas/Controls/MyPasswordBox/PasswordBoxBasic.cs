using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Globals.MyControlsSchemas.Controls.MyPasswordBox
{
    public class PasswordBoxBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {   
            Style PasswordBoxBasicStyle = new Style(typeof(PasswordBox));
            PasswordBoxBasicStyle.Setters.Add(new Setter(Control.FontSizeProperty, fontSize));
            return PasswordBoxBasicStyle;
        }
    }
}
