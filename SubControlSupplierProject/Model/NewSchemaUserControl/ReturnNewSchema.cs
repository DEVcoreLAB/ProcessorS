using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.Model.NewSchemaUserControl
{
    public class ReturnNewSchema
    {
        public static event EventHandler<List<(string,Dictionary<string,string>)>> ReturnNewSchemaEvent;

        public void ReturnNewSchemaMethod(List<(string, Dictionary<string, string>)> newSchema)
        {
            ReturnNewSchemaEvent?.Invoke(this, newSchema);
        }
    }
}
