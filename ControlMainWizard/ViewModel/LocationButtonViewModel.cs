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
		private string locationButtonContent;
		public string LocationButtonContent
		{
			get { return locationButtonContent; }
			set 
			{
				locationButtonContent = value;
				OnPropertyChanged(nameof(LocationButtonContent));
			}
		}

		private SolidColorBrush locationButtonBorderBrush;
		public SolidColorBrush LocationButtonBorderBrush
		{
			get { return locationButtonBorderBrush; }
			set 
			{
				locationButtonBorderBrush = value;
				OnPropertyChanged(nameof(LocationButtonBorderBrush));
			}
		}

	}
}
