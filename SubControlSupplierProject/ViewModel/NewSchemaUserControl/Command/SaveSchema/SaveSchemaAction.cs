using Globals.DbOperations.Supplier.SupplierNewSchemaTable;
using SubControlSupplierProject.Model.NewSchemaUserControl;
using SubControlSupplierProject.View.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command.SaveSchema
{
    internal class SaveSchemaAction
    {
        NewSchemaMainViewModel NewSchemaMainViewModel { get; }

        public SaveSchemaAction(NewSchemaMainViewModel ewSchemaMainViewModel)
        {
            NewSchemaMainViewModel = ewSchemaMainViewModel;
        }

        public async void Execute(object? parameter)
        {
            NewSchemaControl newSchemaControl = parameter as NewSchemaControl;

            CreateTable createTable = new Globals.DbOperations.Supplier.SupplierNewSchemaTable.CreateTable(NewSchemaMainViewModel.ItemsToSaveDictionary, NewSchemaMainViewModel.NameOfNewSchema);
            await createTable.Create();




            List<(string, Dictionary<string, string>)> newSchema = new List<(string, Dictionary<string, string>)>();
            newSchema.Add((NewSchemaMainViewModel.NameOfNewSchema, NewSchemaMainViewModel.ItemsToSaveDictionary));

            ReturnNewSchema returnNewSchema = new ReturnNewSchema();
            returnNewSchema.ReturnNewSchemaMethod(newSchema);




            NewSchemaMainViewModel.ItemsToSaveDictionary.Clear();
            NewSchemaMainViewModel.NameOfNewSchema = null;

            newSchemaControl.GridForItems.Children.Clear();
            new SaveSchemaPredict(NewSchemaMainViewModel).Check();

           
            NewSchemaMainViewModel.NameOfNewItem = null;
            NewSchemaMainViewModel.SelectedTypeOfNewItem = null;

        }
    }
}
