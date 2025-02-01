using SubControlSupplierProject.View.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command
{
    internal class AddNewItemButtonAction
    {
        NewSchemaMainViewModel newSchemaMainViewModel;

        public AddNewItemButtonAction(NewSchemaMainViewModel newSchemaMainViewModel)
        {
            this.newSchemaMainViewModel = newSchemaMainViewModel;
        }

        public void Execute(object? parameter)
        {
            NewSchemaControl newSchemaControl = parameter as NewSchemaControl;
        }
    }
}
