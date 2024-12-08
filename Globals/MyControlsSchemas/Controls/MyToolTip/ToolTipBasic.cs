using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Globals.MyControlsSchemas.Controls.MyToolTip
{
    public class ToolTipBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {
            Style style = new Style(typeof(ToolTip));
            style.Setters.Add(new Setter(Control.FontSizeProperty, fontSize));
            return style;
        }
    }
}
