using Globals.Logger.Log4N;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Globals.DbOperations.Supplier.SupplierSchemasReader
{
    public class ReadAllSchemas
    {
        public async Task<List<(string, Dictionary<string, string>)>> ReadSchemasAsync()
        {
            var result = new List<(string, Dictionary<string, string>)>();

            string databaseName = DbasesNames.DbNames.SupplierSchemas.ToString();

            string connectionString = Security.PasswordBoxControlHelper
                .ReadFromFileSecuredStringToString
                .UnprotectString(SettingFiles.ConnString.Default.ConnectionString);

            string getTablesQuery = $@"
            SELECT TABLE_NAME
            FROM [{databaseName}].INFORMATION_SCHEMA.TABLES
            WHERE TABLE_TYPE = 'BASE TABLE'";

            try
            {
                await using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    var tableNames = new List<string>();
                    await using (var tableCommand = new SqlCommand(getTablesQuery, connection))
                    {
                        using var tableReader = await tableCommand.ExecuteReaderAsync();
                        while (await tableReader.ReadAsync())
                        {
                            tableNames.Add(tableReader.GetString(0));
                        }
                    }

                    foreach (var tableName in tableNames)
                    {
                        var dataDict = new Dictionary<string, string>();

                        string selectQuery = $@"
                        SELECT [Content], [ControlType]
                        FROM [{databaseName}].[dbo].[{tableName}]";

                        await using (var selectCommand = new SqlCommand(selectQuery, connection))
                        {
                            using var reader = await selectCommand.ExecuteReaderAsync();

                            while (await reader.ReadAsync())
                            {
                                string contentValue = reader.GetString(0);
                                string controlTypeValue = reader.GetString(1);

                                dataDict[contentValue] = controlTypeValue;
                            }
                        }

                        result.Add((tableName, dataDict));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error while reading tables from database '{databaseName}': {ex.Message}"
                );
                L4N.L4NDefault.Error(
                    $"Error while reading tables from database '{databaseName}': {ex.Message}"
                );
            }

            return result;
        }
    }
}
