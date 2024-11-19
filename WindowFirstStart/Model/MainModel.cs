using WindowFirstStart.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowFirstStart.Model
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
