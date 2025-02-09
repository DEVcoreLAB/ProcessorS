using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.Model.Reactors.Behaviours.ListOfSchemasVM
{
    internal class SelectedSchemaValueBehaviur : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return () =>
            {
                mainViewModel.OperationUserControl = new SubControlSupplierProject.View.NewSupplierUserControl.NewSupplierControl
                (
                    mainViewModel.CompleteSchemasData.FirstOrDefault(x => x.Item1 == mainViewModel.SelectedSchemaValue).Item2.Select(x => (x.Key, x.Value)).ToList()
                );
            };
        }
    }
}
