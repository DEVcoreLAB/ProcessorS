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
		public RelayCommand ProductButtonCommand { get; }

		private string productButtonContent;
		public string ProductButtonContent
		{
			get { return productButtonContent; }
			set 
			{
				productButtonContent = value;
				OnPropertyChanged(nameof(ProductButtonContent));
			}
		}

		private SolidColorBrush productButtonBorderBrush;
		public SolidColorBrush ProductButtonBorderBrush
		{
			get { return productButtonBorderBrush; }
			set 
			{
				productButtonBorderBrush = value;
				OnPropertyChanged(nameof(ProductButtonBorderBrush));
			}
		}

	}
}
