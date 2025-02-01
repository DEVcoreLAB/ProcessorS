using Globals.ViewModel;
using SubControlSupplierProject.Model.NewSchemaUserControl;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
        NewSchemaMainModel NewSchemaMainModel { get; }

        public NewSchemaMainViewModel()
        {
            NewSchemaMainModel = new NewSchemaMainModel(this);
            AddNewItemCommand = new RelayCommand(new AddNewItemButtonAction(this).Execute,new AddNewItemButtonPredict().Check);
            TypeOfNewItem = new System.Collections.ObjectModel.ObservableCollection<string> { "Type 1", "Type 2", "Type 3" };
        }
    }
}
