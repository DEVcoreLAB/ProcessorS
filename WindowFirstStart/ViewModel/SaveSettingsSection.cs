using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private BitmapImage saveSettingsButtonBackground;
		public BitmapImage SaveSettingsButtonBackground
		{
			get { return saveSettingsButtonBackground; }
			set 
			{ 
				saveSettingsButtonBackground = value;
				OnPropertyChanged(nameof(SaveSettingsButtonBackground));
			}
		}

		private bool isEnabledSaveButton;
		public bool IsEnabledSaveButton
		{
			get { return isEnabledSaveButton; }
			set 
			{ 
				isEnabledSaveButton = value;
				OnPropertyChanged(nameof(IsEnabledSaveButton));
			}
		}


	}
}
