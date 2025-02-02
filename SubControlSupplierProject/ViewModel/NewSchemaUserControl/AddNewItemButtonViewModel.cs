using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
        public RelayCommand AddNewItemCommand { get; }

		private BitmapImage addNewItmButtonForeground;
		public BitmapImage AddNewItmButtonForeground
		{
			get { return addNewItmButtonForeground; }
			set 
			{ 
				addNewItmButtonForeground = value;
				OnPropertyChanged(nameof(AddNewItmButtonForeground));
            }
		}

	}
}
