using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.Model.ViewSupplierUserControl.Reactors.Behaviours
{
    internal class AllDataCollectionBehaviour : IBehaviour
    {
        public static event EventHandler<EventArgs> AllDataChanged;
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            return new Action(() => 
            { 
                AllDataChanged?.Invoke(this, new EventArgs());
            });
        }
    }
}
