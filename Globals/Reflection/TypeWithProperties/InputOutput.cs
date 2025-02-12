using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Globals.Reflection.TypeWithProperties.PropertyAsType;
using Globals.Reflection.TypeWithProperties.PropertyAsType.Builder;

namespace Globals.Reflection.TypeWithProperties
{
    public class InputOutput
    {
        private List<(string name, string type)> inputValues;
        private List<Type> properties = new();
        public Type completeType {  get; }

        public InputOutput(List<(string name, string type)> inputValues)
        {
            this.inputValues = inputValues;
        }

        public Type GetCompleteType()
        { 
            Type completeType = null;

            // property with inotifypropertychanged
            foreach (var type in inputValues)
            {
                properties.Add(PropertyWithInotifyPropertyChanged.Genrate(type.name,type.type));
            }

            var typeBuilder = new SimpleTypeBuilder()._typeBuilder;

            foreach (var type in properties)
            {
                foreach (var property in type.GetProperties())
                {
                    SimplePropertyGenerator
                        .CreateAutoImplementedProperty(typeBuilder, property.Name, property.PropertyType);
                }
            }

            Type resultingType = typeBuilder.CreateType();
            completeType = resultingType;

            return completeType;
        }
    }
}
