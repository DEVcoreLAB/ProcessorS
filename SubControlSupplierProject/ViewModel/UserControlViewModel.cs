using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SubControlSupplierProject.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private UserControl supplierSchemasUserControl;
		public UserControl SupplierSchemasUserControl
		{
			get { return supplierSchemasUserControl; }
			set 
			{ 
				supplierSchemasUserControl = value;
				OnPropertyChanged(nameof(SupplierSchemasUserControl));
			}
		}

	}
}
