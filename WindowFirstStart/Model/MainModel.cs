using WindowFirstStart.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Globals.Model.Observer;
using WindowFirstStart.Model.Reactors;
using Globals.Model;
using WindowFirstStart.Model.SetInitialWindowValues;

namespace WindowFirstStart.Model
{
    internal class MainModel
    {
        MainViewModel MainViewModel { get; }

        public MainModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;

            BaseConfig modelConfigurationSet = new BaseConfig();
            modelConfigurationSet.Set(mainViewModel);

            BasicReactor reactor = new BasicReactor();
            new TObserver<MainViewModel, BasicReactor>(mainViewModel, reactor);

        }
    }
}
