using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WindowFirstStart.Model.SetInitialWindowValues.Languages;

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

		private List<ComboboxItemBaseClass> languagesCombobox;
		public List<ComboboxItemBaseClass> LanguagesCombobox
        {
			get { return languagesCombobox; }
			set 
			{ 
				languagesCombobox = value;
				OnPropertyChanged(nameof(LanguagesCombobox));
			}
		}


	}
}
