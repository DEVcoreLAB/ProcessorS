using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
        private string nameOfNewItem;
        public string NameOfNewItem
        {
            get { return nameOfNewItem; }
            set
            {
                nameOfNewItem = value;
                OnPropertyChanged(nameof(NameOfNewItem));
            }
        }

    }
}
