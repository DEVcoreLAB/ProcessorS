using Globals.ViewModel;
using SubControlSupplierProject.Model.NewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel.NewSupplierUserControl
{
    internal partial class NewSupplierMainViewModel : BaseViewModel
    {
        NewSupplierMainModel NewSupplierMainModel { get; }

        public NewSupplierMainViewModel()
        {
            NewSupplierMainModel = new NewSupplierMainModel(this);
        }
    }
}
