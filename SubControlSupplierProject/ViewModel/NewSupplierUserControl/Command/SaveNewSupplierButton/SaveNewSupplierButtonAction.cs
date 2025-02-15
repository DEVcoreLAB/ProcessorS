using Globals.DbOperations.DbasesNames;
using Globals.DbOperations.Wizard.TableViaSchema;
using SubControlSupplierProject.View.NewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SubControlSupplierProject.ViewModel.NewSupplierUserControl.Command.SaveNewSupplierButton
{
    internal class SaveNewSupplierButtonAction
    {
        NewSupplierMainViewModel newSupplierMainViewModel;

        public SaveNewSupplierButtonAction(NewSupplierMainViewModel newSupplierMainViewModel)
        {
            this.newSupplierMainViewModel = newSupplierMainViewModel;
        }

        public void Execute(object? parameter)
        {
            SaveToTable saveToTable = new SaveToTable
                (newSupplierMainViewModel.ReflectedProperties, 
                newSupplierMainViewModel.DynamicInstanceOfreflectedProperties);
            saveToTable.Save
                (newSupplierMainViewModel.NewSupplierName,
                DbNames.SuppliersList);
        }
    }
}
