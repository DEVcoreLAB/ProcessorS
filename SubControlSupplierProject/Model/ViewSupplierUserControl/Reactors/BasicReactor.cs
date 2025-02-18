using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.Model.Reactors.Behaviours.ListOfSchemasVM;
using SubControlSupplierProject.Model.ViewSupplierUserControl.Reactors.Behaviours;
using SubControlSupplierProject.ViewModel;
using SubControlSupplierProject.ViewModel.ViewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SubControlSupplierProject.Model.ViewSupplierUserControl.Reactors
{
    internal class BasicReactor : IReactor
    {
        public void ReactForChange<T>(PropertyInfo newValue, object odlValue, T viewModel) where T : BaseViewModel
        {
            ViewSupplierMainViewModel viewSupplierMainViewModel = viewModel as ViewSupplierMainViewModel;
            Connector connector = null;

            if (newValue.Name == nameof(viewSupplierMainViewModel.SelectedSupplierBaseTableName))
            {
                connector = new Connector(new SelectedSupplierBaseTableNameBehaviour());
            }

            if (connector != null)
            {
                InvokeActionByDispatcher(connector.Behaviour.GetAction(viewSupplierMainViewModel));
            }
        }

        public void InvokeActionByDispatcher(Action action)
        {
            Dispatcher.CurrentDispatcher.BeginInvoke(action, DispatcherPriority.Background);
        }
    }
}
