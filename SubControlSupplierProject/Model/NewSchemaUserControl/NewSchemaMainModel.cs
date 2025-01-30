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
        NewSchemaMainViewModel newSchemaMainViewModel;

        public NewSchemaMainModel(NewSchemaMainViewModel newSchemaMainViewModel)
        {
            this.newSchemaMainViewModel = newSchemaMainViewModel;
        }
    }
}
