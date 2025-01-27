using ControlMainWizard.Model.Reactors.Behaviurs.MainUserControlVM;
using ControlMainWizard.ViewModel;
using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ControlMainWizard.Model.Reactors
{
    internal class BasicReactor : IReactor
    {
        public void ReactForChange<T>(PropertyInfo newValue, object odlValue, T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;
            Connector connector = null;

            if (newValue.Name == nameof(mainViewModel.MainUserControlContent))
            {
                connector = new Connector(new MainUserControlContentBehaviour());
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
