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
        private Type _dataSchema;
        private object _dataObject;

        public SaveToTable(Type dataSchema, object dataObject)
        {
            _dataSchema = dataSchema;
            _dataObject = dataObject;
        }

        public async Task Save(string connectionString, DbNames nameOfDataBase, string nameOfTable)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(connectionString);
            stringBuilder.AppendLine(nameOfDataBase.ToString());
            stringBuilder.AppendLine(nameOfTable);

            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
