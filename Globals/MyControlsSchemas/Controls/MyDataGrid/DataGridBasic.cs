using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Globals.MyControlsSchemas.Controls.MyDataGrid
{
    public class DataGridBasic : ISetControl
    {
        public Style SetControlProperties(double fontSize)
        {
            Style dataGridStyle = new Style(typeof(System.Windows.Controls.DataGrid));

            dataGridStyle.Setters.Add(new Setter(Control.FontSizeProperty, fontSize));
            return dataGridStyle;
        }
    }
}
