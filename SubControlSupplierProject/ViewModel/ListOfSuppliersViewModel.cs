using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private ObservableCollection<string> listOfSuppliers;
		public ObservableCollection<string> ListOfSuppliers
		{
			get { return listOfSuppliers; }
			set 
			{ 
				listOfSuppliers = value; 
				OnPropertyChanged(nameof(ListOfSuppliers));
            }
		}

		private ICollectionView viewListOfSuppliers;
		public ICollectionView ViewListOfSuppliers
		{
			get { return viewListOfSuppliers; }
			set 
			{ 
				viewListOfSuppliers = value;
				OnPropertyChanged(nameof(ViewListOfSuppliers));
            }
		}


	}
}
