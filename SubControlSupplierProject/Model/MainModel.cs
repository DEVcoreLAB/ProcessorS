using Globals.Model.Observer;
using SubControlSupplierProject.Model.NewSchemaUserControl.Reactors;
using SubControlSupplierProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SubControlSupplierProject.Model
{
    class MainModel
    {
        MainViewModel MainViewModel { get; }

        public MainModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;

            SubControlSupplierProject.Model.Reactors.BasicReactor reactor = new SubControlSupplierProject.Model.Reactors.BasicReactor();
            new TObserver<MainViewModel, SubControlSupplierProject.Model.Reactors.BasicReactor>(mainViewModel, reactor);
        }
    }
}
