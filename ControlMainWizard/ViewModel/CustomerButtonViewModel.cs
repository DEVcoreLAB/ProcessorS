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
		public RelayCommand CustomerButtonCommand { get; }

		private string customerButtonContent;
		public string CustomerButtonContent
		{
			get { return customerButtonContent; }
			set 
			{
				customerButtonContent = value;
				OnPropertyChanged(nameof(CustomerButtonContent));
			}
		}

		private SolidColorBrush customerButtonBorderBrush;
		public SolidColorBrush CustomerButtonBorderBrush
		{
			get { return customerButtonBorderBrush; }
			set 
			{ 
				customerButtonBorderBrush = value; 
				OnPropertyChanged(nameof(CustomerButtonBorderBrush));
			}
		}


	}
}
