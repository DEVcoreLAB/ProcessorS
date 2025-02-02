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
		private string schemasLabel;
		public string SchemasLabel
		{
			get { return schemasLabel; }
			set 
			{ 
				schemasLabel = value;
				OnPropertyChanged(nameof(SchemasLabel));
            }
		}

	}
}
