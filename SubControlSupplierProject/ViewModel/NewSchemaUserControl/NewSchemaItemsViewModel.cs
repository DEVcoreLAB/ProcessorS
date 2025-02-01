using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
		private ContentControl newSchemaItemsContentControl;
		public ContentControl NewSchemaItemsContentControl
		{
			get { return newSchemaItemsContentControl; }
			set { newSchemaItemsContentControl = value; }
		}

	}
}
