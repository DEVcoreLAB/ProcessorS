using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private ContentControl helpDocument;
		public ContentControl HelpDocument
		{
			get { return helpDocument; }
			set 
			{ 
				helpDocument = value; 
				OnPropertyChanged(nameof(HelpDocument));
			}
		}

		private string controlName;
		public string ControlName
		{
			get { return controlName; }
			set 
			{ 
				if (controlName == value) return;
				controlName = value; 
				OnPropertyChanged(nameof(ControlName));
			}
		}

	}
}
