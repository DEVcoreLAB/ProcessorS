using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl
{
    internal partial class NewSchemaMainViewModel : BaseViewModel
    {
        private string nameOfNewItem;
        public string NameOfNewItem
        {
            get { return nameOfNewItem; }
            set
            {
                nameOfNewItem = value;
                OnPropertyChanged(nameof(NameOfNewItem));
            }
        }

        private SolidColorBrush newItemNameBrush;
        public SolidColorBrush NewItemNameBrush
        {
            get { return newItemNameBrush; }
            set 
            { 
                newItemNameBrush = value;
                OnPropertyChanged(nameof(NewItemNameBrush));
            }
        }

        private string newItemNameLabel;
        public string NewItemNameLabel
        {
            get { return newItemNameLabel; }
            set 
            { 
                newItemNameLabel = value;
                OnPropertyChanged(nameof(NewItemNameLabel));
            }
        }

    }
}
