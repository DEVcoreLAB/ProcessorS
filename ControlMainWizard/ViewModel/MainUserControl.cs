using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ControlMainWizard.ViewModel
{
    internal partial class MainViewModel : Globals.ViewModel.BaseViewModel
    {
		private UserControl mainUserControlContent;
		public UserControl MainUserControlContent
		{
			get { return mainUserControlContent; }
			set 
			{
				mainUserControlContent = value; 
				OnPropertyChanged(nameof(MainUserControlContent));
			}
		}

	}
}
