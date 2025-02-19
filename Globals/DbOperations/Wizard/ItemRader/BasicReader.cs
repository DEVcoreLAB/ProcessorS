using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Globals.DbOperations.Wizard.ItemRader
{
    public class BasicReader
    {
        ObservableCollection<CollectionTableSchema> temp = new ObservableCollection<CollectionTableSchema>();
        string connectionString;
        string dbName;
        string tablename;

        public BasicReader(string connectionString, string dbName, string tablename)
        {
            this.connectionString = connectionString;
            this.dbName = dbName;
            this.tablename = tablename;
        }

        public ObservableCollection<CollectionTableSchema> Read()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(connectionString);
            stringBuilder.AppendLine(dbName);
            stringBuilder.AppendLine(tablename);

            MessageBox.Show(stringBuilder.ToString());

            return temp;
        }
    }
}
