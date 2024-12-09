using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private SolidColorBrush connStrinngTextBoxForeground;
		public SolidColorBrush ConnStrinngTextBoxForeground
		{
			get { return connStrinngTextBoxForeground; }
			set 
			{ 
				connStrinngTextBoxForeground = value;
				OnPropertyChanged(nameof(ConnStrinngTextBoxForeground));
			}
		}


		private BitmapImage checkConnectioStringButtonBackground;
		public BitmapImage CheckConnectioStringButtonBackground
		{
			get { return checkConnectioStringButtonBackground; }
			set 
			{ 
				checkConnectioStringButtonBackground = value;
				OnPropertyChanged(nameof(CheckConnectioStringButtonBackground));
			}
		}

		private bool connStringButtonIsEnabled;
		public bool ConnStringButtonIsEnabled
		{
			get { return connStringButtonIsEnabled; }
			set 
			{ 
				if (connStringButtonIsEnabled == value) return;
				connStringButtonIsEnabled = value;
				OnPropertyChanged(nameof(ConnStringButtonIsEnabled));
			}
		}

		private string connectionStringTextboxText;
		public string ConnectionStringTextboxText
		{
			get { return connectionStringTextboxText; }
			set 
			{ 
				connectionStringTextboxText = value;
				OnPropertyChanged(nameof(ConnectionStringTextboxText));
			}
		}

	}
}
