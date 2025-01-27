using ControlMainWizard.ViewModel;
using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ControlMainWizard.Model.Reactors.Behaviurs.MainUserControlVM
{
    internal class MainUserControlContentBehaviour : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() => 
            {
                string FirstPartOfChangedPropertyName = GetFirstPartOfChangedPropertyName(mainViewModel.MainUserControlContent.GetType().Name); 

                var properties = typeof(T).GetProperties();



                foreach (var property in properties)
                {
                    if (property.Name.Contains(FirstPartOfChangedPropertyName)
                    && property.PropertyType == typeof(SolidColorBrush))
                    {
                        var brush = property.GetValue(viewModel) as SolidColorBrush;

                        if (brush != null)
                        {
                            brush.Color = Colors.Orange;

                            property.SetValue(viewModel, brush);
                        }
                    }
                    else if (!(property.Name.Contains(FirstPartOfChangedPropertyName))
                    && property.PropertyType == typeof(SolidColorBrush))
                    {
                        var brush = property.GetValue(viewModel) as SolidColorBrush;

                        if (brush != null)
                        {
                            brush.Color = Colors.Black;

                            property.SetValue(viewModel, brush);
                        }
                    }
                }
            });
        }

        private string GetFirstPartOfChangedPropertyName(string fullName)
        {
            for (int i = 1; i < fullName.Length; i++)
            {
                if (char.IsUpper(fullName[i]))
                {
                    string first = fullName.Substring(0, i);
                    return first;
                }
            }

            return string.Empty;
        }
    }
}
