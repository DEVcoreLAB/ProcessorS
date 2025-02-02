using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command.AddNewItem
{
    internal class AddNewItemButtonPredict
    {
        NewSchemaMainViewModel newSchemaMainViewModel;

        public AddNewItemButtonPredict(NewSchemaMainViewModel newSchemaMainViewModel)
        {
            this.newSchemaMainViewModel = newSchemaMainViewModel;
        }

        public bool Check()
        {
            if (newSchemaMainViewModel.SelectedTypeOfNewItem == null || newSchemaMainViewModel.NameOfNewItem == null)
            {
                return false;
            }
            else
            {
                return true;

            }
        }
    }
}
