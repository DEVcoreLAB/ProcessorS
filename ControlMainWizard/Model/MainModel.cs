using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ControlMainWizard.ViewModel;
using Globals.Model.Observer;
using ControlMainWizard.Model.Reactors;

namespace ControlMainWizard.Model
{
    internal class MainModel
    {
        MainViewModel mainViewModel;

        public MainModel(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;

            BasicReactor reactor = new BasicReactor();
            new TObserver<MainViewModel, BasicReactor>(mainViewModel, reactor);
        }
    }
}
