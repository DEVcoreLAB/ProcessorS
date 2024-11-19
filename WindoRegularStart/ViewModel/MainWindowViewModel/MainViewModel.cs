using WindowRegularStart.Model.MainWindowModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowRegularStart.ViewModel.MainWindowViewModel
{
    internal partial class MainViewModel
    {
        MainModel MainModel { get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);
        }
    }
}
