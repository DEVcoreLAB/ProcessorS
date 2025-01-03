using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using WindowRegularStart.Model.MainWindowModel.Behaviours.MainViewModelVM;
using WindowRegularStart.ViewModel.MainWindowViewModel;

namespace WindowRegularStart.Model.MainWindowModel.Reactors
{
    internal class BasicRegularWindowReactor : IReactor
    {
        public void ReactForChange<T>(PropertyInfo newValue, object odlValue, T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;
            Connector connector = null;


            if (newValue.Name == nameof(mainViewModel.TestSelectedValue))
            {
                connector = new Connector(new TestSelectedValueBehavoiur());
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
