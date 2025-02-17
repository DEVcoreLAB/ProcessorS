using Globals.ViewModel;
using SubControlSupplierProject.Model.ViewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel.ViewSupplierUserControl
{
    internal partial class ViewSupplierMainViewModel : BaseViewModel
    {
        ViewSupplierMainModel viewSupplierMainModel;

        public ViewSupplierMainViewModel()
        {
            viewSupplierMainModel = new ViewSupplierMainModel(this);
        }
    }
}
