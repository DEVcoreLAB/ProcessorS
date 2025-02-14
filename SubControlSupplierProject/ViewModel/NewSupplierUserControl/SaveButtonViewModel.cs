using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SubControlSupplierProject.ViewModel.NewSupplierUserControl
{
    internal partial class NewSupplierMainViewModel : BaseViewModel
    {
		public RelayCommand SaveNewSupplierCommand { get; }

        private BitmapImage saveNewSupplierButtonForeground;
		public BitmapImage SaveNewSupplierButtonForeground
		{
			get { return saveNewSupplierButtonForeground; }
			set 
			{ 
				saveNewSupplierButtonForeground = value;
				OnPropertyChanged(nameof(SaveNewSupplierButtonForeground));
			}
		}

		private bool nameValidationbPredict;
		public bool NameValidationbPredict
		{
			get { return nameValidationbPredict; }
			set { nameValidationbPredict = value; }
		}

	}
}
