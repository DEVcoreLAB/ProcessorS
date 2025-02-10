using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Globals.Reflection.TypeWithProperties.PropertyAsType;

namespace Globals.Reflection.TypeWithProperties
{
    public class InputOutput
    {
        private List<(string name, string type)> inputValues;
        private List<Type> properties = new();

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

            MessageBox.Show(properties.Count.ToString());

            return completeType;
        }
    }
}
