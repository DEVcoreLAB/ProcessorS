using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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






            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Zestawienie właściwości wygenerowanych typów:");

            //foreach (Type dynamicType in properties)
            //{
            //    sb.AppendLine($"Typ: {dynamicType.Name}");

            //    // Pobieramy publiczne właściwości instancji
            //    var props = dynamicType.GetProperties(
            //        BindingFlags.Public | BindingFlags.Instance
            //    );

            //    if (props.Length == 0)
            //    {
            //        sb.AppendLine("  (brak właściwości)");
            //    }
            //    else
            //    {
            //        foreach (var prop in props)
            //        {
            //            sb.AppendLine(
            //                $"  - Właściwość: {prop.Name}, " +
            //                $"Typ: {prop.PropertyType.Name}"
            //            );
            //        }
            //    }

            //    sb.AppendLine(new string('-', 40)); // Separator
            //}
            //MessageBox.Show(sb.ToString());

            return completeType;
        }
    }
}
