using Globals.DbOperations.DbasesNames;
using Globals.Logger.Log4N;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

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
            try
            {
                if (_dataSchema == null || _dataObject == null)
                {
                    await Application.Current.Dispatcher.InvokeAsync(() =>
                    {
                        MessageBox.Show($"Null input data exception in: {this.GetType().Name}", "Error",
                                        MessageBoxButton.OK, MessageBoxImage.Error);
                    });

                    L4N.L4NDefault.Error($"Null input data exception in: {this.GetType().Name}");
                    return;
                }

                var propertyInfo = _dataSchema.GetProperties();

                await using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // switch to correct database
                    await using (var cmd = new SqlCommand($"USE [{nameOfDataBase.ToString()}]", connection))
                    {
                        await cmd.ExecuteNonQueryAsync();
                    }

                    // create main datatable if not exist
                    string createMainTableQuery = $@"
                    IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = '{nameOfTable}')
                    BEGIN
                    CREATE TABLE [{nameOfTable}] (
                    ID INT IDENTITY(1,1) PRIMARY KEY,
                    PropertyName NVARCHAR(256) NOT NULL,
                    DataType NVARCHAR(256) NOT NULL,
                    BoolValue BIT NULL,
                    Note NVARCHAR(256) NULL,
                    ListGroupID INT NULL
                    )
                    END";

                    await using (var cmd = new SqlCommand(createMainTableQuery, connection))
                    {
                        await cmd.ExecuteNonQueryAsync();
                    }

                    foreach (var property in propertyInfo)
                    {
                        // processing all propeties of _dataschemaObject

                        #region observableCollection<string>Type
                        if (property.PropertyType == typeof(ObservableCollection<string>))
                        {
                            // name of additional table NameOfTable_NameOfProperty
                            string listTableName = $"{nameOfTable}_{property.Name}";

                            // create this additional table
                            string createListTableQuery = $@"
                                    IF NOT EXISTS 
                                    (SELECT * FROM sys.tables WHERE name = '{listTableName}')
                                    BEGIN
                                    CREATE TABLE [{listTableName}] (
                                    ID INT IDENTITY(1,1) PRIMARY KEY,
                                    ListGroupID INT NOT NULL,
                                    ListItem NVARCHAR(256) NOT NULL
                                    )
                                    END";

                            await using (var cmd = new SqlCommand(createListTableQuery, connection))
                            {
                                await cmd.ExecuteNonQueryAsync();
                            }

                            //  insert a row into the main table and retrieve the generated ID
                            string insertMainListQuery = $@"
                                    INSERT INTO [{nameOfTable}] 
                                    (PropertyName, DataType, BoolValue, Note, ListGroupID)
                                    VALUES
                                    (@propName, @dataType, NULL, NULL, NULL);
                                    SELECT SCOPE_IDENTITY();";

                            int mainId;
                            await using (var cmd = new SqlCommand(insertMainListQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@propName", property.Name);
                                cmd.Parameters.AddWithValue("@dataType", Globals.DbOperations.InvariantTypeOfControls.ControlTypes.ComboBoxControl.ToString());
                                mainId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // update a row in the main table by setting ListGroupID to the value of the primary key
                            string updateMainQuery = $@"
                                    UPDATE [{nameOfDataBase}].dbo.[{nameOfTable}]
                                    SET ListGroupID = @mainId
                                    WHERE ID = @mainId";

                            await using (var cmd = new SqlCommand(updateMainQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@mainId", mainId);
                                await cmd.ExecuteNonQueryAsync();
                            }

                            // retrieve the list items and, for each one, insert a row into the additional table
                            ObservableCollection<string> listValues = property.GetValue(_dataObject) as ObservableCollection<string>;
                            if (listValues != null)
                            {
                                foreach (var item in listValues)
                                {
                                    string insertListItemQuery = $@"
                                            INSERT INTO [{listTableName}] 
                                            (ListGroupID, ListItem)
                                            VALUES
                                            (@groupId, @listItem)";

                                    await using (var cmd = new SqlCommand(insertListItemQuery, connection))
                                    {
                                        cmd.Parameters.AddWithValue("@groupId", mainId);
                                        cmd.Parameters.AddWithValue("@listItem", item);
                                        await cmd.ExecuteNonQueryAsync();
                                    }
                                }
                            }
                        }
                        #endregion

                        #region booleanType
                        else if (property.PropertyType == typeof(bool))
                        {
                            bool boolValue = (bool)property.GetValue(_dataObject);
                            string insertBoolQuery = $@"
                            INSERT INTO [{nameOfTable}] 
                            (PropertyName, DataType, BoolValue, Note, ListGroupID)
                            VALUES
                            (@propName, @dataType, @boolValue, NULL, NULL)";

                            await using (var cmd = new SqlCommand(insertBoolQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@propName", property.Name);
                                cmd.Parameters.AddWithValue("@dataType", Globals.DbOperations.InvariantTypeOfControls.ControlTypes.CheckBoxControl.ToString());
                                cmd.Parameters.AddWithValue("@boolValue", boolValue);
                                await cmd.ExecuteNonQueryAsync();
                            }
                        }
                        #endregion

                        #region stringType
                        else if (property.PropertyType == typeof(string))
                        {
                            string stringValue = (string)property.GetValue(_dataObject);
                            string insertBoolQuery = $@"
                            INSERT INTO [{nameOfTable}] 
                            (PropertyName, DataType, BoolValue, Note, ListGroupID)
                            VALUES
                            (@propName, @dataType, NULL, @Note, NULL)";

                            await using (var cmd = new SqlCommand(insertBoolQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@propName", property.Name);
                                cmd.Parameters.AddWithValue("@dataType", Globals.DbOperations.InvariantTypeOfControls.ControlTypes.TextBoxControl.ToString());
                                cmd.Parameters.AddWithValue("@Note", stringValue);
                                await cmd.ExecuteNonQueryAsync();
                            }
                        }
                        #endregion
                    }
                }

            }
            catch (Exception ex)
            {
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    MessageBox.Show($"Error while saving: {ex.Message}", "Error",
                                    MessageBoxButton.OK, MessageBoxImage.Error);
                });

                L4N.L4NDefault.Error($"error in: {ex}       {this.GetType().Name}");
            }
        }
    }
}
