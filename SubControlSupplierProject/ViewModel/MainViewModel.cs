using Globals.ViewModel;
using SubControlSupplierProject.Langs;
using SubControlSupplierProject.Model;
using SubControlSupplierProject.ViewModel.Command.MainControl.NewSchemaButtonCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Globals;
using System.Net.WebSockets;
using Globals.DbOperations.Supplier.SupplierSchemasReader;
using SubControlSupplierProject.Model.NewSchemaUserControl;
using System.Windows;

namespace SubControlSupplierProject.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        MainModel MainModel { get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);
            ListOfSchemas = new System.Collections.ObjectModel.ObservableCollection<string>();
            ViewListOfSchemas = CollectionViewSource.GetDefaultView(ListOfSchemas);

            NewSchemaCommand = new RelayCommand
                (
                    new NewSchemaButtonAction(this).Execute,
                    new NewSchemaButtonPredict().Check
                );

            SchemasLabel = Lang.schemasLabel;
            SuppliersLabel = Lang.suppliersLabel;

            NewSchemaButtonForewground = Globals.Graphics.SetProperButtonBackground.Set
                (
                    true,
                    Globals.Graphics.Uris.AddEnabled,
                    Globals.Graphics.Uris.AddDisabled
                );

            RefreshSchemas();

            ReturnNewSchema.ReturnNewSchemaEvent += (s,e) =>
            {
                listOfSchemas.Add(e[0].Item1);
                CompleteSchemasData.Add(e[0]);
            };


            ListOfSuppliers = new System.Collections.ObjectModel.ObservableCollection<string>() 
            { 
                "Kamix",
                "Font end developers",
                "Kojijama",
                "End points",
                "Forsaken",
            };

            ViewListOfSuppliers = CollectionViewSource.GetDefaultView(ListOfSuppliers);
        }

        public async void RefreshSchemas()
        {
            ReadAllSchemas readAllSchemas = new ReadAllSchemas();
            CompleteSchemasData = await readAllSchemas.ReadSchemasAsync();

            foreach (var schema in CompleteSchemasData)
            {
                ListOfSchemas.Add(schema.Item1);
            }
        }
    }
}
