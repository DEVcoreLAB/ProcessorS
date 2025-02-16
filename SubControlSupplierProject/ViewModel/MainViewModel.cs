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
using SubControlSupplierProject.Model.NewSchemaUserControl;
using System.Windows;
using System.Collections.ObjectModel;
using Globals.DbOperations.Wizard.Schemas.SchemasReader;
using Globals.DbOperations.Wizard.ItemViaSchema.ItemsReader;

namespace SubControlSupplierProject.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        MainModel MainModel { get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);
            ListOfSchemas = new ObservableCollection<string>();
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

            ReturnNewSchema.ReturnNewSchemaEvent += (s, e) =>
            {
                CompleteSchemasData.Clear();
                ListOfSchemas.Clear();
                RefreshSchemas();
            };

            ListOfSuppliers = new ObservableCollection<string>();

            ViewListOfSuppliers = CollectionViewSource.GetDefaultView(ListOfSuppliers);

            NewSupplierUserControl.Command.SaveNewSupplierButton.SaveCompleteEvent.SaveNewSupplierCompleteEvent += (s, e) =>
            {
                RefreshSuppliers();
            };
            RefreshSuppliers();
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

        public async void RefreshSuppliers()
        {
            ListOfSuppliers.Clear();
            ReadAllItems readAllItems = new ReadAllItems();
            var temp = await readAllItems.ReadItemNamesAsync();
            foreach (var item in temp)
            {
                if (!item.Contains('_'))
                {
                    ListOfSuppliers.Add(item);
                }
            }
        }
    }
}
