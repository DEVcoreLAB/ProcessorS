using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowRegularStart.ViewModel.MainWindowViewModel;

namespace WindowRegularStart.ViewModel.Command.CollapsibleButtonCommand
{
    internal class CollapsibleButtonPredict
    {
        MainViewModel MainViewModel { get; }

        public CollapsibleButtonPredict(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public bool Check() => true;
    }
}
