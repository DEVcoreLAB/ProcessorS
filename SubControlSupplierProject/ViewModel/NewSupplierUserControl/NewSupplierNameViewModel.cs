using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.ViewModel.NewSupplierUserControl
{
    internal partial class NewSupplierMainViewModel : BaseViewModel
    {
		private string newSupplierName;
		public string NewSupplierName
		{
			get { return newSupplierName; }
			set 
			{ 
				newSupplierName = value;
				OnPropertyChanged(nameof(NewSupplierName));
			}
		}

	}
}
