using Globals.Logger.Log4N;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Globals.DbOperations.Wizard.ItemViaSchema.ItemsNamesOnlyReader
{
    public class ReadAllItems
    {
        public async Task<ObservableCollection<string>> ReadItemNamesAsync()
        {
            ObservableCollection<string> tempListOfNames = new ObservableCollection<string>();

            string databaseName = DbasesNames.DbNames.SuppliersList.ToString();

            string connectionString = Security.PasswordBoxControlHelper
                .ReadFromFileSecuredStringToString
                .UnprotectString(SettingFiles.ConnString.Default.ConnectionString);

            string getTablesQuery = $@"
                SELECT t.TABLE_NAME
                FROM [{databaseName}].INFORMATION_SCHEMA.TABLES AS t
                INNER JOIN [{databaseName}].sys.tables st
                ON t.TABLE_NAME = st.name
                WHERE t.TABLE_TYPE = 'BASE TABLE'
                AND st.is_ms_shipped = 0
                AND st.type_desc = 'USER_TABLE'
                AND t.TABLE_NAME <> 'sysdiagrams'
                ";

            try
            {
                await using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (var tableCommand = new SqlCommand(getTablesQuery, connection))
                    {
                        using var tableReader = await tableCommand.ExecuteReaderAsync();
                        while (await tableReader.ReadAsync())
                        {
                            tempListOfNames.Add(tableReader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while reading tables from database '{databaseName}': {ex.Message}");
                L4N.L4NDefault.Error(
                    $"Error while reading tables from database '{databaseName}': {ex.Message}"
                );
            }

            return tempListOfNames;
        }
    }
}
