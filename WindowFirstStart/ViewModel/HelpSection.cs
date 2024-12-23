using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private FlowDocument helpFlowDocument;
		public FlowDocument HelpFlowDocument
		{
			get { return helpFlowDocument; }
			set 
			{ 
				helpFlowDocument = value;
				OnPropertyChanged(nameof(HelpFlowDocument));
			}
		}

	}
}
