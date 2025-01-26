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
		private string intermediateProductButtonContent;
		public string IntermediateProductButtonContent
		{
			get { return intermediateProductButtonContent; }
			set 
			{
				intermediateProductButtonContent = value;
				OnPropertyChanged(nameof(IntermediateProductButtonContent));
			}
		}

		private SolidColorBrush intermediateProductButtonBorderBrush;
		public SolidColorBrush IntermediateProductButtonBorderBrush
		{
			get { return intermediateProductButtonBorderBrush; }
			set 
			{
				intermediateProductButtonBorderBrush = value;
				OnPropertyChanged(nameof(IntermediateProductButtonBorderBrush));
			}
		}


	}
}
