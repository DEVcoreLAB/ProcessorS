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
		private string schemasFilteringTextBox;
		public string SchemasFilteringTextBox
		{
			get { return schemasFilteringTextBox; }
			set 
			{ 
                if (ListOfSchemas.Count == 0) return;

				schemasFilteringTextBox = value;
                ViewListOfSchemas.Filter = FilterSchemasByName;

                OnPropertyChanged(nameof(SchemasFilteringTextBox));
			}
		}

        private bool FilterSchemasByName(object item)
        {
            var emp = item as string; 
            if (!string.IsNullOrEmpty(SchemasFilteringTextBox) && emp != null)
            {
                return emp.Contains(SchemasFilteringTextBox, StringComparison.OrdinalIgnoreCase); 
            }
            return true; // if SchemasFilteringTextBox is empty - return all elements
        }

    }
}
