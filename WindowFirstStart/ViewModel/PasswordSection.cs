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
		private BitmapImage passwordOriginBackground;
		public BitmapImage PasswordOriginBackground
		{
			get { return passwordOriginBackground; }
			set 
			{ 
				passwordOriginBackground = value;
				OnPropertyChanged(nameof(PasswordOriginBackground));
			}
		}

		private BitmapImage passwordConfirmBackgound;
		public BitmapImage PasswordConfirmBackgound
		{
			get { return passwordConfirmBackgound; }
			set 
			{ 
				passwordConfirmBackgound = value;
				OnPropertyChanged(nameof(PasswordConfirmBackgound));
			}
		}


	}
}
