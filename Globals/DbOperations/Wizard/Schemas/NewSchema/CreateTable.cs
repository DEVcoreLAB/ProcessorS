using Globals.Logger.Log4N;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Globals.DbOperations.Wizard.Schemas.NewSchema
{
    public class CreateTable
    {
        private readonly Dictionary<string, string> _schemaItems;
        private readonly string _tableName;

        public CreateTable(Dictionary<string, string> listOfItems, string tableName)
        {
            _schemaItems = listOfItems ?? throw new ArgumentNullException(nameof(listOfItems));
            _tableName = string.IsNullOrWhiteSpace(tableName)
                ? throw new ArgumentException("Table name cannot be empty.", nameof(tableName))
                : tableName;
        }

        public async Task Create()
        {
            string databaseName = DbasesNames.DbNames.SupplierSchemas.ToString();

            string connectionString = Security.PasswordBoxControlHelper
                .ReadFromFileSecuredStringToString
                .UnprotectString(SettingFiles.ConnString.Default.ConnectionString);

            string firstColumn = "Id";
            string secondColumn = "Content";
            string thirdColumn = "ControlType";

            string createTableQuery = $@"
                IF NOT EXISTS (SELECT * FROM {databaseName}.INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{_tableName}')
                BEGIN
                CREATE TABLE [{databaseName}].[dbo].[{_tableName}] (
                {firstColumn} INT IDENTITY(1,1) PRIMARY KEY,
                {secondColumn} NVARCHAR(255) NOT NULL,
                {thirdColumn} NVARCHAR(255) NOT NULL
                ); END";

            try
            {
                await using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    await using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                    {
                        await command.ExecuteNonQueryAsync();
                    }

                    foreach (var kvp in _schemaItems)
                    {
                        string insertQuery = $@"
                            INSERT INTO [{databaseName}].[dbo].[{_tableName}]
                            ({secondColumn}, {thirdColumn})
                            VALUES (@content, @controlType)";

                        await using (SqlCommand insertCommand =
                            new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@content", kvp.Key);
                            insertCommand.Parameters.AddWithValue("@controlType", kvp.Value);

                            await insertCommand.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while create table new supplier schema '{_tableName}': {ex.Message}");
                L4N.L4NDefault.Error($"Error while create table new supplier schema '{_tableName}': {ex.Message}");
            }
        }
    }
}
