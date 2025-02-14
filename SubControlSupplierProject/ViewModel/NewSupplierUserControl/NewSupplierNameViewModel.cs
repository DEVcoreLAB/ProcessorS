using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

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

		private string newSupplierNameLabel;
		public string NewSupplierNameLabel
		{
			get { return newSupplierNameLabel; }
			set 
			{ 
				newSupplierNameLabel = value;
				OnPropertyChanged(nameof(NewSupplierNameLabel));
            }
		}

		private SolidColorBrush newSupplierNameForeground;
		public SolidColorBrush NewSupplierNameForeground
		{
			get { return newSupplierNameForeground; }
			set 
			{ 
				newSupplierNameForeground = value;
				OnPropertyChanged(nameof(NewSupplierNameForeground));
			}
		}

	}
}
