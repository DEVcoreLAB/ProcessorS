using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command.SaveSchema
{
    internal class SaveSchemaAction
    {
        NewSchemaMainViewModel NewSchemaMainViewModel { get; }

        public SaveSchemaAction(NewSchemaMainViewModel ewSchemaMainViewModel)
        {
            NewSchemaMainViewModel = ewSchemaMainViewModel;
        }

        public void Execute(object? parameter)
        {
           Globals.DbOperations.SupplierNewSchemaTable.CreateTable createTable = new Globals.DbOperations.SupplierNewSchemaTable.CreateTable(NewSchemaMainViewModel.ItemsToSaveDictionary, NewSchemaMainViewModel.NameOfNewSchema);
            createTable.Create();
        }
    }
}
