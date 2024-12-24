using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private UserControl helpDocument;
		public UserControl HelpDocument
		{
			get { return helpDocument; }
			set 
			{ 
				helpDocument = value; 
				OnPropertyChanged(nameof(helpDocument));
			}
		}

	}
}
