using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Reflection.TypeWithProperties
{
    public class InputOutput
    {
        private List<(string name, string type)> inputValues;

        public InputOutput(List<(string name, string type)> inputValues)
        {
            this.inputValues = inputValues;
        }

        public Type GetCompleteType()
        { 
            Type type = null;


            return type;
        }
    }
}
