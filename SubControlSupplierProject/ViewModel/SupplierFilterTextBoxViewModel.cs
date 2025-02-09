using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private string supplierFilteringTextBox;
		public string SupplierFilteringTextBox
		{
			get { return supplierFilteringTextBox; }
			set 
			{
                if (ListOfSuppliers.Count == 0) return;

                supplierFilteringTextBox = value;
                ViewListOfSuppliers.Filter = FilterSuppliersByName;

                OnPropertyChanged(nameof(SupplierFilteringTextBox));
            }
		}

        private bool FilterSuppliersByName(object item)
        {
            var emp = item as string;
            if (!string.IsNullOrEmpty(SupplierFilteringTextBox) && emp != null)
            {
                return emp.Contains(SupplierFilteringTextBox, StringComparison.OrdinalIgnoreCase);
            }
            return true; // if SchemasFilteringTextBox is empty - return all elements
        }
    }
}
