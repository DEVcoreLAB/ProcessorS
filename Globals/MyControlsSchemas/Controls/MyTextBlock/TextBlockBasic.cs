using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Globals.MyControlsSchemas.Controls.MyTextBlock
{
    public class TextBlockBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {
            Style textBlockBasicStyle = new Style(typeof(TextBlock));
            textBlockBasicStyle.Setters.Add(new Setter(Control.FontSizeProperty, fontSize));
            return textBlockBasicStyle;
        }
    }
}
