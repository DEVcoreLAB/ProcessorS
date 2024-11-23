using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        private double[] listOfFontSize;
        public double[] ListOfFontSize
        {
            get { return listOfFontSize; }
            set
            {
                if (listOfFontSize == value) return;
                listOfFontSize = value;
                OnPropertyChanged(nameof(ListOfFontSize));
            }
        }

        private double fontSizeSelectedValue;
        public double FontSizeSelectedValue
        {
            get { return fontSizeSelectedValue; }
            set 
            {   
                if (fontSizeSelectedValue == value) return;
                fontSizeSelectedValue = value;
                OnPropertyChanged(nameof(FontSizeSelectedValue));
            }
        }

    }
}
