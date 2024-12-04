using Globals.Logger.Log4N;
using Globals.MyDialogsAndWindows.MyMessagebox;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowRegularStart.View.MainWindow;

namespace WindowFirstStart.ViewModel.Commands.ConnStringButton
{
    internal class CheckConnectionStringAction
    {
        MainViewModel MainViewModel { get; set; }

        public CheckConnectionStringAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Check()
        {
           
            //return new Action(() =>
            //{
                bool connectionTestResult = false;

                try
                {
                    using (SqlConnection connection = new SqlConnection(MainViewModel.ConnectionStringTextboxText))
                    {
                        connection.Open();
                        MessageBoxX.Show("OK");
                        connectionTestResult = true;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBoxX.Show("SqlException " + ex.Message + "\n" + ex.Number);
                    L4N.L4NDefault.Error(ex);
                    connectionTestResult = false;
                }
                catch (Exception ex)
                {
                    MessageBoxX.Show("Exception " + ex.Message);
                    L4N.L4NDefault.Error(ex);
                    connectionTestResult = false;
                }

            //});
        }
    }
}
