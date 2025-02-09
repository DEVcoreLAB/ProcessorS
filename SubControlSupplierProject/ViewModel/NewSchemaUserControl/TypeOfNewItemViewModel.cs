using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
		private ObservableCollection<string> typeOfNewItem;
		public ObservableCollection<string> TypeOfNewItem
		{
			get { return typeOfNewItem; }
			set 
			{ 
				typeOfNewItem = value;
				OnPropertyChanged(nameof(TypeOfNewItem));
            }
		}

		private string selectedTypeOfNewItem;
		public string SelectedTypeOfNewItem
		{
			get { return selectedTypeOfNewItem; }
			set 
			{ 
				selectedTypeOfNewItem = value;
				OnPropertyChanged(nameof(SelectedTypeOfNewItem));
            }
		}

		private bool isTypeOfNewItemEnabled;
		public bool IsTypeOfNewItemEnabled
		{
			get { return isTypeOfNewItemEnabled; }
			set 
			{
				isTypeOfNewItemEnabled = value; 
				OnPropertyChanged(nameof(IsTypeOfNewItemEnabled));
            }
		}

		private string typeOfNewItemLabel;
		public string TypeOfNewItemLabel
		{
			get { return typeOfNewItemLabel; }
			set 
			{ 
				typeOfNewItemLabel = value; 
				OnPropertyChanged(nameof(TypeOfNewItemLabel));
            }
		}

	}
}
