using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.Model.NewSchemaUserControl.Reactors.Behaviours.NameOfNewItemVM;
using SubControlSupplierProject.Model.NewSupplierUserControl.Reactor.Behaviours.NewSupplierMainViewModelVM;
using SubControlSupplierProject.ViewModel;
using SubControlSupplierProject.ViewModel.NewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace SubControlSupplierProject.Model.NewSupplierUserControl.Reactor
{
    internal class BasicNewSupplierReactor : IReactor
    {
        public void ReactForChange<T>(PropertyInfo newValue, object odlValue, T viewModel) where T : BaseViewModel
        {
            NewSupplierMainViewModel mainViewModel = viewModel as NewSupplierMainViewModel;
            Connector connector = null;

            if (newValue.Name == nameof(mainViewModel.SchemaControlsList))
            {
                connector = new Connector(new SchemaControlsListBehaviours());
            }

            if (connector != null)
            {
                InvokeActionByDispatcher(connector.Behaviour.GetAction(mainViewModel));
            }
        }

        public void InvokeActionByDispatcher(Action action)
        {
            Dispatcher.CurrentDispatcher.BeginInvoke(action, DispatcherPriority.Background);
        }
    }
}
