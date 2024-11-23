using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globals.Model
{
    // used to configure startup ViewModel properties from Model constructor
    public interface IModelConfigurationSet<T> where T : BaseViewModel
    {
        public void Set(T mainViewModel);
    }
}
