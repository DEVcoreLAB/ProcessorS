using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.Model.NewSchemaUserControl.Reactors.Behaviours.NameOfNewItemVM;
using SubControlSupplierProject.ViewModel;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SubControlSupplierProject.Model.NewSchemaUserControl.Reactors
{
    internal class BasicReactor : IReactor
    {
        public void ReactForChange<T>(PropertyInfo newValue, object odlValue, T viewModel) where T : BaseViewModel
        {
            NewSchemaMainViewModel mainViewModel = viewModel as NewSchemaMainViewModel;
            Connector connector = null;

            if (newValue.Name == nameof(mainViewModel.NameOfNewItem))
            {
                connector = new Connector(new NmaeOfNewItemBehvoiur());
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
