using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command.AddNewItem
{
    internal class AddNewItemButtonPredict
    {
        NewSchemaMainViewModel newSchemaMainViewModel;

        public AddNewItemButtonPredict(NewSchemaMainViewModel newSchemaMainViewModel)
        {
            this.newSchemaMainViewModel = newSchemaMainViewModel;
        }

        public bool Check()
        {
            if (newSchemaMainViewModel.SelectedTypeOfNewItem == null || newSchemaMainViewModel.NameOfNewItem == null || string.IsNullOrEmpty(newSchemaMainViewModel.NameOfNewItem))
            {
                newSchemaMainViewModel.AddNewItmButtonForeground = SetButtonForeground(false);
                return false;
            }
            else
            {
                newSchemaMainViewModel.AddNewItmButtonForeground = SetButtonForeground(true);
                return true;
            }
        }

        public BitmapImage SetButtonForeground(bool isEnabled)
        {
            return Globals.Graphics.SetProperButtonBackground.Set
                (
                    isEnabled,
                    Globals.Graphics.Uris.AddEnabled,
                    Globals.Graphics.Uris.AddDisabled
                );  
        }
    }
}
