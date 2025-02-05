using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SubControlSupplierProject.Model.NewSchemaUserControl.Reactors.Behaviours.SaveNewSchemaVM
{
    internal class NameOfNewSchemaBehaviour : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            NewSchemaMainViewModel mainViewModel = viewModel as NewSchemaMainViewModel;

            return new Action(() =>
            {
                foreach (var item in mainViewModel.ListOfSchemasNames)
                {
                    if (item.Equals(mainViewModel.NameOfNewSchema))
                    {
                        mainViewModel.NewShemaNameBrush = new SolidColorBrush(Colors.Red);
                    }
                    else
                    {
                        mainViewModel.NewShemaNameBrush = new SolidColorBrush(Colors.Black);
                    }
                }
            });
        }
    }
}
