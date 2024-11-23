using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Model.Observer.Components
{
    public interface IReactor
    {
        public void ReactForChange<T>(PropertyInfo newValue, object odlValue, T viewModel) where T : BaseViewModel;
        public void InvokeActionByDispatcher(Action action);
    }
}
