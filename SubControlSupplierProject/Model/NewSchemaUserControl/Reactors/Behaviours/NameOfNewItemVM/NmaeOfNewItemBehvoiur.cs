using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.Model.NewSchemaUserControl.Reactors.Behaviours.NameOfNewItemVM
{
    internal class NmaeOfNewItemBehvoiur : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            NewSchemaMainViewModel mainViewModel = viewModel as NewSchemaMainViewModel;

            return new Action(() =>
            {
                 MessageBox.Show("Hello from NmaeOfNewItemBehvoiur");
            });
        }
    }
}
