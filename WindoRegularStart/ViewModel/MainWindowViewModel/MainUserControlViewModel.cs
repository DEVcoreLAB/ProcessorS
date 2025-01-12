using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WindowRegularStart.ViewModel.MainWindowViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private UserControl mainUserControl;
		public UserControl MainUserControl
		{
			get { return mainUserControl; }
			set 
			{ 
				mainUserControl = value;
				OnPropertyChanged(nameof(MainUserControl));
			}
		}
	}
}
