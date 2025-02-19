using Globals.Logger.Log4N;
using Microsoft.Data.SqlClient;
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
            var mainRecords
                = new List<CollectionTableSchema>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // set proper base
                    using (var cmd = new SqlCommand($"USE [{dbName}]", connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // read from main tyable to list
                    string mainQuery = $@"
                        SELECT 
                            ID, 
                            PropertyName, 
                            DataType, 
                            BoolValue, 
                            Note, 
                            ListGroupID
                        FROM [{tablename}]";

                    using (var cmd = new SqlCommand(mainQuery, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var rec = new CollectionTableSchema
                                {
                                    iD = reader.GetInt32(0),
                                    propertyName = reader.GetString(1),
                                    controlTypename = reader.GetString(2)
                                };

                                // where bool can be null
                                if (!reader.IsDBNull(3))
                                    rec.boolValue = reader.GetBoolean(3);

                                // where string value can be null 
                                if (!reader.IsDBNull(4))
                                    rec.stringValue = reader.GetString(4);

                                // list group id can be null
                                if (!reader.IsDBNull(5))
                                    rec.keyToTable = reader.GetInt32(5);

                                mainRecords.Add(rec);
                            }
                        }
                    }

                    // fill data from additional tables
                    foreach (var item in mainRecords)
                    {
                        // only for ComboBoxControl elements
                        if (item.controlTypename ==
                            InvariantTypeOfControls.ControlTypes.ComboBoxControl.ToString()
                            && item.keyToTable != 0)
                        {
                            // 
                            string propName
                                = item.propertyName.Replace(' ', '_');
                            string childTableName
                                = $"{tablename}_{propName}";

                            string childQuery = $@"
                                SELECT ListItem
                                FROM [{childTableName}]
                                WHERE ListGroupID = @grpID";

                            using (var childCmd
                                   = new SqlCommand(childQuery, connection))
                            {
                                childCmd.Parameters.AddWithValue("@grpID",
                                                                 item.keyToTable);

                                // open new reader
                                using (var cReader = childCmd.ExecuteReader())
                                {
                                    var values = new ObservableCollection<string>();
                                    while (cReader.Read())
                                    {
                                        values.Add(cReader.GetString(0));
                                    }
                                    item.stringsCollection = values;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Read error: {ex.Message}",
                                "Error",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);

                L4N.L4NDefault.Error($@"{ex.Message}     {this.GetType().FullName}");
            }

            // 
            foreach (var rec in mainRecords)
            {
                temp.Add(rec);
            }

            //StringBuilder sb = new StringBuilder();

            //foreach (var rec in temp)
            //{
            //    sb.AppendLine($@"{rec.iD} || {rec.propertyName} || {rec.controlTypename} || {rec.boolValue} || {rec.stringValue} || {rec.keyToTable}");
            //    if (rec.keyToTable != 0)
            //    {
            //        foreach (var item in rec.stringsCollection)
            //        {
            //            sb.AppendLine($@"       {item}");
            //        }
            //        sb.AppendLine("\n");
            //    }
            //}

            //MessageBox.Show(sb.ToString());

            return temp;
        }
    }
}

