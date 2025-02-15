using Globals.Logger.Log4N;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.System;
using Microsoft.Data.SqlClient;
using Globals.DbOperations.DbasesNames;

namespace Globals.DbOperations.CresteNewDb
{
    public class CreateDb
    {
        public async Task Create(DbNames nameOfNewDb)
        {
            // Connection string to connect to the master database
            string connectionString =
                @$"{Globals.Security.PasswordBoxControlHelper.ReadFromFileSecuredStringToString.UnprotectString
                (Globals.SettingFiles.ConnString.Default.ConnectionString)}";

            // SQL command to create a new database
            string createDbQuery = $"CREATE DATABASE [{nameOfNewDb}]";

            try
            {
                await using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    await using (SqlCommand command = new SqlCommand(createDbQuery, connection))
                    {
                        await command.ExecuteNonQueryAsync(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try to new DB - " + ex.Message);
                L4N.L4NDefault.Error("Try to create new DB - " + ex.Message);
            }
        }
    }
}
