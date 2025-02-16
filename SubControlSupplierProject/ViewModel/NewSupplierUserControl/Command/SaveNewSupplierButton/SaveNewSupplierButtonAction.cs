using Globals.DbOperations.DbasesNames;
using Globals.DbOperations.Wizard.ItemViaSchema.NewItem;
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

        public async void Execute(object? parameter)
        {
            NewSupplierControl newSupplierControl = parameter as NewSupplierControl;
            await RunSaveMethod();

            newSupplierMainViewModel.NewSupplierName = null;

            newSupplierControl.Content = null;

            SaveCompleteEvent saveCompleteEvent = new SaveCompleteEvent();
            saveCompleteEvent.EvetRun();
        }

        private async Task RunSaveMethod()
        {
            SaveToTable saveToTable = new SaveToTable
              (newSupplierMainViewModel.ReflectedProperties,
              newSupplierMainViewModel.DynamicInstanceOfreflectedProperties);
            await saveToTable.Save
                (Globals.Security.PasswordBoxControlHelper.ReadFromFileSecuredStringToString.UnprotectString(Globals.SettingFiles.ConnString.Default.ConnectionString),
                DbNames.SuppliersList,
                newSupplierMainViewModel.NewSupplierName
                );
        }
    }
}
