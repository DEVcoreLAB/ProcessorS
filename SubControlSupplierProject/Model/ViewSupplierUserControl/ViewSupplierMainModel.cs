using Globals.Model.Observer;
using SubControlSupplierProject.Model.ViewSupplierUserControl.Reactors;
using SubControlSupplierProject.ViewModel.ViewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.Model.ViewSupplierUserControl
{
    class ViewSupplierMainModel
    {
        ViewSupplierMainViewModel viewSupplierMainViewModel;

        public ViewSupplierMainModel(ViewSupplierMainViewModel viewSupplierMainViewModel)
        {
            this.viewSupplierMainViewModel = viewSupplierMainViewModel;

            BasicReactor basicReactor = new BasicReactor();
            new TObserver<ViewSupplierMainViewModel, BasicReactor>(viewSupplierMainViewModel, basicReactor);
        }
    }
}
