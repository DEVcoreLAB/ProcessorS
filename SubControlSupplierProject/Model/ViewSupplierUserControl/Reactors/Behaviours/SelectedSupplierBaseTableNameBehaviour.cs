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
                MessageBox.Show("selected name changed");
            });
        }
    }
}
