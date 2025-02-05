using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
        public RelayCommand SaveNewSchemaCommand { get; }

		private string nameOfNewSchema;
		public string NameOfNewSchema
		{
			get { return nameOfNewSchema; }
			set 
			{
				nameOfNewSchema = value;
				OnPropertyChanged(nameof(NameOfNewSchema));
            }
		}

		private BitmapImage saveNewSchemaButtonForeground;
		public BitmapImage SaveNewSchemaButtonForeground
		{
			get { return saveNewSchemaButtonForeground; }
			set 
			{ 
				saveNewSchemaButtonForeground = value;
				OnPropertyChanged(nameof(SaveNewSchemaButtonForeground));
            }
		}

		private SolidColorBrush newShemaNameBrush;
		public SolidColorBrush NewShemaNameBrush
		{
			get { return newShemaNameBrush; }
			set 
			{ 
				newShemaNameBrush = value; 
				OnPropertyChanged(nameof(NewShemaNameBrush));
            }
		}

	}
}
