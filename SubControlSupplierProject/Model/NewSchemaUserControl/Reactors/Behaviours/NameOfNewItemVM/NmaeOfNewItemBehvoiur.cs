using Globals.DbOperations.Validation.TextValidation;
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
                NamesValidation namesValidation = new NamesValidation();
                var result = namesValidation.Validate(mainViewModel.ItemsToSaveDictionary.Keys, mainViewModel.NameOfNewItem);

                mainViewModel.NewItemNameBrush = result._textColor;
                mainViewModel.IsTypeOfNewItemEnabled = result._isNameInique;
            });
        }
    }
}
