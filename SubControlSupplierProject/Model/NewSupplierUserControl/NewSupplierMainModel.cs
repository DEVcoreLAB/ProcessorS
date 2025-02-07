using SubControlSupplierProject.ViewModel.NewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.Model.NewSupplierUserControl
{
    internal class NewSupplierMainModel
    {
        NewSupplierMainViewModel newSupplierMainViewModel;

        public NewSupplierMainModel(NewSupplierMainViewModel newSupplierMainViewModel)
        {
            this.newSupplierMainViewModel = newSupplierMainViewModel;
        }
    }
}
