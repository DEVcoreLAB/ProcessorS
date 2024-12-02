using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFirstStart.ViewModel.Commands.ConnStringButton
{
    internal class CheckConnectionStringPredict
    {
        MainViewModel MainViewModel { get; }

        public CheckConnectionStringPredict(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public bool Check()
        {
            return MainViewModel.ConnStringButtonIsEnabled;
        }
    }
}
