using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowRegularStart.ViewModel.MainWindowViewModel;

namespace WindowRegularStart.ViewModel.Command.ExitButtonCommand
{
    internal class ExitButtonPredict
    {
        MainViewModel MainViewModel { get; }

        public ExitButtonPredict(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public bool Check() => true;
    }
}
