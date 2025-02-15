using Globals.DbOperations.DbasesNames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Globals.DbOperations.Wizard.TableViaSchema
{
    public class SaveToTable
    {
        StringBuilder sb = new StringBuilder(); // delete it after tests
        string connectionString;

        private Type _dataSchema;
        private object _dataObject;

        public SaveToTable(Type dataSchema, object dataObject)
        {
            _dataSchema = dataSchema;
            _dataObject = dataObject;
            connectionString = Globals.Security.PasswordBoxControlHelper.ReadFromFileSecuredStringToString.UnprotectString(Globals.SettingFiles.ConnString.Default.ConnectionString);
        }

        public void Save(string nameOfTable, DbNames saveDestination)
        {
            
        }
    }
}
