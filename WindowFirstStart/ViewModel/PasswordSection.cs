using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
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

		private SecureString passwordBase;
		public SecureString PasswordBase
		{
			get { return passwordBase; }
			set 
			{ 
				passwordBase = value;
				OnPropertyChanged(nameof(PasswordBase));
			}
		}

		private SecureString passwordConfirm;
		public SecureString PasswordConfirm
		{
			get { return passwordConfirm; }
			set 
			{ 
				passwordConfirm = value; 
				OnPropertyChanged(nameof(PasswordConfirm));
			}
		}

		private bool isPasswordBoxConfirmEnabled;
		public bool IsPasswordBoxConfirmEnabled
		{
			get { return isPasswordBoxConfirmEnabled; }
			set 
			{ 
				isPasswordBoxConfirmEnabled = value; 
				OnPropertyChanged(nameof(IsPasswordBoxConfirmEnabled));
			}
		}

		private SolidColorBrush passwordBoxConfirmForeground;
		public SolidColorBrush PasswordBoxConfirmForeground
		{
			get { return passwordBoxConfirmForeground; }
			set 
			{ 
				passwordBoxConfirmForeground = value;
				OnPropertyChanged(nameof(PasswordBoxConfirmForeground));
			}
		}


	}
}
