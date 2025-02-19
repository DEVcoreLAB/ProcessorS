using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.DbOperations.Wizard.ItemRader
{
    public class CollectionTableSchema
    {
        public int iD { get; set; }
        public string propertyName { get; set; }
        public string controlTypename { get; set; }
        public bool boolValue { get; set; }
        public string stringValue { get; set; }
        public int keyToTable { get; set; }
        public ObservableCollection<string> stringsCollection { get; set; }
    }
}
