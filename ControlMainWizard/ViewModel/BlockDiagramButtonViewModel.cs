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
		private string blockDiagramButtonContent;
		public string BlockDiagramButtonContent
		{
			get { return blockDiagramButtonContent; }
			set 
			{ 
				blockDiagramButtonContent = value;
				OnPropertyChanged(nameof(BlockDiagramButtonContent));
			}
		}

		private SolidColorBrush blockDiagramButtonBorderBrush;
		public SolidColorBrush BlockDiagramButtonBorderBrush
		{
			get { return blockDiagramButtonBorderBrush; }
			set 
			{ 
				blockDiagramButtonBorderBrush = value;
				OnPropertyChanged(nameof(BlockDiagramButtonBorderBrush));
			}
		}
	}
}
