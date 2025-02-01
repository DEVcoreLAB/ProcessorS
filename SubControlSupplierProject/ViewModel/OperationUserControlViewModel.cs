using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SubControlSupplierProject.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private UserControl operationUserControl;
		public UserControl OperationUserControl
		{
			get { return operationUserControl; }
			set 
			{ 
				operationUserControl = value; 
				OnPropertyChanged(nameof(OperationUserControl));
            }
		}

	}
}
