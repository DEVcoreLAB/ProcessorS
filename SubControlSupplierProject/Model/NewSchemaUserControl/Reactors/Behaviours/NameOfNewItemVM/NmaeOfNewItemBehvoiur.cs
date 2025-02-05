using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SubControlSupplierProject.Model.NewSchemaUserControl.Reactors.Behaviours.NameOfNewItemVM
{
    internal class NmaeOfNewItemBehvoiur : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            NewSchemaMainViewModel mainViewModel = viewModel as NewSchemaMainViewModel;

            return new Action(() =>
            {
                foreach (var item in mainViewModel.ItemsToSaveDictionary.Keys)
                {
                    if (item == mainViewModel.NameOfNewItem)
                    {
                        mainViewModel.NewItemNameBrush = new SolidColorBrush(Colors.Red);
                        mainViewModel.IsTypeOfNewItemEnabled = false;
                    }
                    else
                    {
                        mainViewModel.NewItemNameBrush = new SolidColorBrush(Colors.Black);
                        mainViewModel.IsTypeOfNewItemEnabled = true;
                    }
                }
            });
        }
    }
}
