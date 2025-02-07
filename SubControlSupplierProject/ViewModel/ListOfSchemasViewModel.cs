using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SubControlSupplierProject.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private ObservableCollection<string> listOfSchemas;
		public ObservableCollection<string> ListOfSchemas
		{
			get { return listOfSchemas; }
			set 
			{ 
				listOfSchemas = value;
				OnPropertyChanged(nameof(ListOfSchemas));
			}
		}

		private ICollectionView viewListOfSchemas;
		public ICollectionView ViewListOfSchemas
		{
			get { return viewListOfSchemas; }
			set 
			{ 
				viewListOfSchemas = value;
				OnPropertyChanged(nameof(ViewListOfSchemas));
			}
		}

        private List<(string, Dictionary<string, string>)> completeSchemasData;
		public List<(string, Dictionary<string, string>)> CompleteSchemasData
		{
			get { return completeSchemasData; }
			set { completeSchemasData = value; }
		}

		private string selectedSchemaValue;
		public string SelectedSchemaValue
		{
			get { return selectedSchemaValue; }
			set 
			{ 
				selectedSchemaValue = value;
				OnPropertyChanged(nameof(SelectedSchemaValue));
            }
		}

	}
}
