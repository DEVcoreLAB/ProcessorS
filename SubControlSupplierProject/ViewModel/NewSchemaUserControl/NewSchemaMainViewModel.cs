using Globals.ViewModel;
using SubControlSupplierProject.Model.NewSchemaUserControl;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command.AddNewItem;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command.SaveSchema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
        NewSchemaMainModel NewSchemaMainModel { get; }

        public NewSchemaMainViewModel()
        {
            NewSchemaMainModel = new NewSchemaMainModel(this);
            AddNewItemCommand = new RelayCommand(new AddNewItemButtonAction(this).Execute,new AddNewItemButtonPredict(this).Check);
            TypeOfNewItem = new System.Collections.ObjectModel.ObservableCollection<string> 
            { 
                Langs.Lang.textBox, 
                Langs.Lang.comboBox, 
                Langs.Lang.checkBox 
            };
            SaveNewSchemaCommand = new RelayCommand(new SaveSchemaAction(this).Execute, new SaveSchemaPredict().Check);
        }
    }
}
