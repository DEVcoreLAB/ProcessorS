using Globals.Model.Observer;
using SubControlSupplierProject.Model.NewSchemaUserControl.Reactors;
using SubControlSupplierProject.ViewModel;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.Model.NewSchemaUserControl
{
    internal class NewSchemaMainModel
    {
        NewSchemaMainViewModel NewSchemaMainViewModel { get; }

        public NewSchemaMainModel(NewSchemaMainViewModel newSchemaMainViewModel)
        {
            this.NewSchemaMainViewModel = newSchemaMainViewModel;


            BasicReactor reactor = new BasicReactor();
            new TObserver<NewSchemaMainViewModel, BasicReactor>(newSchemaMainViewModel, reactor);
        }
    }
}
