using Globals.DbOperations.Wizard.ItemRader;
using Globals.ViewModel;
using SubControlSupplierProject.Model.ViewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.ViewModel.ViewSupplierUserControl
{
    internal partial class ViewSupplierMainViewModel : BaseViewModel
    {
        ViewSupplierMainModel viewSupplierMainModel;

        public ViewSupplierMainViewModel()
        {
            viewSupplierMainModel = new ViewSupplierMainModel(this);
        }

        private string selectedSupplierBaseTableName;
        public string SelectedSupplierBaseTableName
        {
            get { return selectedSupplierBaseTableName; }
            set 
            { 
                selectedSupplierBaseTableName = value; 
                OnPropertyChanged(nameof(SelectedSupplierBaseTableName));
            }
        }

        private ObservableCollection<CollectionTableSchema> allDataCollection;
        public ObservableCollection<CollectionTableSchema> AllDataCollection
        {
            get { return allDataCollection; }
            set 
            {
                allDataCollection = value;
                OnPropertyChanged(nameof(AllDataCollection));  
            }
        }


    }
}
