using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
        public RelayCommand SaveNewSchemaCommand { get; }

		private string nameOfNewSchema;
		public string NameOfNewSchema
		{
			get { return nameOfNewSchema; }
			set 
			{
				nameOfNewSchema = value;
				OnPropertyChanged(nameof(NameOfNewSchema));
            }
		}

	}
}
