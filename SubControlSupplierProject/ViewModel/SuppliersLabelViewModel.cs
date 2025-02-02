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
		private string suppliersLabel;
		public string SuppliersLabel
		{
			get { return suppliersLabel; }
			set 
			{ 
				suppliersLabel = value;
				OnPropertyChanged(nameof(SuppliersLabel));
            }
		}

	}
}
