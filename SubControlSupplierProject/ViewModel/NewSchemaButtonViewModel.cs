using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SubControlSupplierProject.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        public RelayCommand NewSchemaCommand { get; }

		private BitmapImage newSchemaButtonForewground;
		public BitmapImage NewSchemaButtonForewground
		{
			get { return newSchemaButtonForewground; }
			set 
			{ 
				newSchemaButtonForewground = value;
				OnPropertyChanged(nameof(NewSchemaButtonForewground));
			}
		}


	}
}
