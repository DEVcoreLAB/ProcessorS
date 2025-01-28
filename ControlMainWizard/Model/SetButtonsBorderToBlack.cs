using ControlMainWizard.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ControlMainWizard.Model
{
    internal class SetButtonsBorderToBlack
    {
        public void Set(MainViewModel mainViewModel)
        {
            var properties = mainViewModel.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(SolidColorBrush))
                {
                    property.SetValue(mainViewModel, new SolidColorBrush(Colors.Black));
                }
            }
        }
    }
}
