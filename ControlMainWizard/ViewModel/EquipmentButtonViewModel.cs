using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ControlMainWizard.ViewModel
{
    internal partial class MainViewModel : Globals.ViewModel.BaseViewModel
    {
		public RelayCommand EquipmentButtonCommand {  get; }

		private string equipmentButtonContent;
		public string EquipmentButtonContent
		{
			get { return equipmentButtonContent; }
			set 
			{ 
				equipmentButtonContent = value; 
				OnPropertyChanged(nameof(EquipmentButtonContent));
			}
		}

		private SolidColorBrush equipmentButtonBorderBrush;
		public SolidColorBrush EquipmentButtonBorderBrush
		{
			get { return equipmentButtonBorderBrush; }
			set 
			{
				equipmentButtonBorderBrush = value;
				OnPropertyChanged(nameof(EquipmentButtonBorderBrush));
			}
		}


	}
}
