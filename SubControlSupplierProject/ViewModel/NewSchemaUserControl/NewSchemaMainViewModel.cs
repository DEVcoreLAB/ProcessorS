using Globals.ViewModel;
using SubControlSupplierProject.Model.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
        NewSchemaMainModel newSchemaMainModel;

        public NewSchemaMainViewModel()
        {
            newSchemaMainModel = new NewSchemaMainModel(this);
        }
    }
}
