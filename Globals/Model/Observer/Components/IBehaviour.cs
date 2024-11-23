using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Model.Observer.Components
{
    public interface IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel;
    }
}
