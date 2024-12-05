using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Globals.MyControlsSchemas.Controls.MyTextBox
{
    public class TextBoxBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {
            Style textBoxBasicStyle = new Style(typeof(TextBox));
            textBoxBasicStyle.Setters.Add(new Setter(Control.FontSizeProperty,fontSize));
            return textBoxBasicStyle;
        }
    }
}
