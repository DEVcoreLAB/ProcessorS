using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ControlMainWizard.ViewModel
{
    internal partial class MainViewModel : Globals.ViewModel.BaseViewModel
    {
		public RelayCommand SupplierButtonCommand { get; }

		private string supplierButtonContent;
		public string SupplierButtonContent
		{
			get { return supplierButtonContent; }
			set 
			{ 
				supplierButtonContent = value;
				OnPropertyChanged(nameof(SupplierButtonContent));
			}
		}

		private SolidColorBrush supplierButtonBorderBrudh;
		public SolidColorBrush SupplierButtonBorderBrudh
		{
			get { return supplierButtonBorderBrudh; }
			set 
			{ 
				supplierButtonBorderBrudh = value;
				OnPropertyChanged(nameof(SupplierButtonBorderBrudh));
			}
		}
	}
}
