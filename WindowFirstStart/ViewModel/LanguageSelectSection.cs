using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
		private string languageSelectLabel;
		public string LanguageSelectLabel
		{
			get { return languageSelectLabel; }
			set 
			{ 
				languageSelectLabel = value;
				OnPropertyChanged(nameof(LanguageSelectLabel));
			}
		}

	}
}
