using Globals.Model.Observer;
using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.Model.Reactors.Behaviours.ListOfSchemasVM;
using SubControlSupplierProject.Model.Reactors.Behaviours.ListOfSuppliersVM;
using SubControlSupplierProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SubControlSupplierProject.Model.Reactors
{
    internal class BasicReactor : IReactor
    {
        public void ReactForChange<T>(PropertyInfo newValue, object odlValue, T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;
            Connector connector = null;

            if (newValue.Name == nameof(mainViewModel.SelectedSchemaValue))
            {
                connector = new Connector(new SelectedSchemaValueBehaviur());
            }
            if (newValue.Name == nameof(mainViewModel.ListOfSuppliersSelectedValue))
            {
                connector = new Connector(new ListOfSuppliersSelectedValueBehaviour());
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
