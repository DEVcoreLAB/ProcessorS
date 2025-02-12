using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.ViewModel.NewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace SubControlSupplierProject.Model.NewSupplierUserControl.Reactor.Behaviours.NewSupplierMainViewModelVM
{
    internal class SchemaControlsListBehaviours : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            NewSupplierMainViewModel mainViewModel = viewModel as NewSupplierMainViewModel;

            return () =>
            {
                Globals.Reflection.TypeWithProperties.InputOutput inputOutput =
                 new(mainViewModel.SchemaControlsList);
                mainViewModel.ReflectedProperties = inputOutput.GetCompleteType();

                mainViewModel.DynamicInstanceOfreflectedProperties = Activator.CreateInstance(mainViewModel.ReflectedProperties);

                mainViewModel.ListChangedInvoke();
            };

        }
    }
}
