using Globals.Reflection.TypeWithProperties.PropertyAsType.Builder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Reflection.TypeWithProperties.PropertyAsType
{
    internal class PropertyWithInotifyPropertyChanged
    {
        public static Type Genrate(string name, string typeOfData)
        {
            Type propertyType = null;
            Type selectedType = GetSimpleType(typeOfData);

            SimpleTypeBuilder builder = new SimpleTypeBuilder();
            var typebuilder = builder._typeBuilder;

            SimplePropertyGenerator
                .CreateAutoImplementedProperty(typebuilder, name, selectedType);

            propertyType = typebuilder.CreateType();

            return propertyType;
        }

        private static Type GetSimpleType(string selectedType)
        {
            Type type = null;

            if (selectedType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.ComboBoxControl.ToString())
            {
                type = typeof(ObservableCollection<string>);
            }
            else if (selectedType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.CheckBoxControl.ToString())
            {
                type = typeof(bool);
            }
            else if (selectedType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.TextBoxControl.ToString())
            {
                type = typeof(string);
            }

            return type;
        }
    }
}
