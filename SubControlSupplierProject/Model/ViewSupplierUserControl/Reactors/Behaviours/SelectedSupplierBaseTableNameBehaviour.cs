using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.ViewModel.ViewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.Model.ViewSupplierUserControl.Reactors.Behaviours
{
    internal class SelectedSupplierBaseTableNameBehaviour : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            ViewSupplierMainViewModel viewSupplierMainViewModel = viewModel as ViewSupplierMainViewModel;

            return new Action(() => 
            {
                Globals.DbOperations.Wizard.ItemRader.BasicReader basicReader = new
                    (
                        Globals.Security.PasswordBoxControlHelper.ReadFromFileSecuredStringToString.UnprotectString(Globals.SettingFiles.ConnString.Default.ConnectionString),
                        Globals.DbOperations.DbasesNames.DbNames.SuppliersList.ToString(),
                        viewSupplierMainViewModel.SelectedSupplierBaseTableName
                    );
                viewSupplierMainViewModel.AllDataCollection = basicReader.Read();
            });
        }
    }
}
