using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.View.ViewSupplierUserControl;
using SubControlSupplierProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.Model.Reactors.Behaviours.ListOfSuppliersVM
{
    internal class ListOfSuppliersSelectedValueBehaviour : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() => 
            {
                if (mainViewModel.ListOfSuppliersSelectedValue == null)
                { 
                    return;
                }

                mainViewModel.OperationUserControl = new ViewSupplierControl();
                mainViewModel.ListOfSuppliersSelectedValue = null;
            });
        }
    }
}
