using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.ViewModel;
using SubControlSupplierProject.ViewModel.NewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SubControlSupplierProject.Model.NewSupplierUserControl.Reactor.Behaviours.NewSupplierNameVM
{
    internal class NewSupplierNameBehaviour : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            NewSupplierMainViewModel mainViewModel = viewModel as NewSupplierMainViewModel;

            return new Action(() =>
            {
                Globals.DbOperations.Validation.TextValidation.NamesValidation namesValidation = new Globals.DbOperations.Validation.TextValidation.NamesValidation();
                var reservedResult = namesValidation.Validate(mainViewModel.existingSuppliers, mainViewModel.NewSupplierName);


                if (!reservedResult._isNameInique)
                {
                    mainViewModel.NewSupplierNameForeground =
                        new System.Windows.Media.SolidColorBrush(Colors.Red);
                    mainViewModel.NameValidationbPredict = reservedResult._isNameInique;
                }
                else
                {
                    mainViewModel.NewSupplierNameForeground =
                        new System.Windows.Media.SolidColorBrush(Colors.Black);
                    mainViewModel.NameValidationbPredict = reservedResult._isNameInique;
                }
            });
        }
    }
}
