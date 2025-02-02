using Globals.Logger.Log4N;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.System;
using Microsoft.Data.SqlClient;

namespace Globals.DbOperations.CresteNewDb
{
    public class CreateDb
    {
        public void Create(string nameOfNewDb)
        {
            // Connection string to connect to the master database
            string connectionString =
                @$"{Globals.Security.PasswordBoxControlHelper.ReadFromFileSecuredStringToString.UnprotectString
                (Globals.SettingFiles.ConnString.Default.ConnectionString)}";

            // SQL command to create a new database
            string createDbQuery = $"CREATE DATABASE [{nameOfNewDb}]";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(createDbQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try to create supplier schemas DB - " + ex.Message);
                L4N.L4NDefault.Error("Try to create supplier schemas DB - " + ex.Message);
            }
        }
    }
}
