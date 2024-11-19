using WindowRegularStart.ViewModel.MainWindowViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowRegularStart.Model.MainWindowModel
{
    internal class MainModel
    {
        MainViewModel MainViewModel { get; }

        public MainModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }
    }
}
