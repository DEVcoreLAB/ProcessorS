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
		private ContentControl licenseDocument;
		public ContentControl LicenseDocument
		{
			get { return licenseDocument; }
			set { licenseDocument = value; }
		}

	}
}
