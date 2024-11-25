using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Globals.MyControlsSchemas.Controls.MyLabel
{
    public class LabelBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {
            Style labelStyle = new Style(typeof(System.Windows.Controls.Label));

            labelStyle.Setters.Add(new Setter(Control.FontSizeProperty, fontSize));

            return labelStyle;
        }
    }
}
