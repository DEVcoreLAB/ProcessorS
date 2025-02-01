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
        public RelayCommand NewSchemaCommand { get; }

		private string newSchemaButtonContent;
		public string NewSchemaButtonContent
		{
			get { return newSchemaButtonContent; }
			set 
			{ 
				newSchemaButtonContent = value; 
				OnPropertyChanged(nameof(NewSchemaButtonContent));
            }
		}

	}
}
