using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel.NewSupplierUserControl.Command.SaveNewSupplierButton
{
    internal class SaveNewSupplierButtonPredict
    {
        NewSupplierMainViewModel newSupplierMainViewModel;

        public SaveNewSupplierButtonPredict(NewSupplierMainViewModel newSupplierMainViewModel)
        {
            this.newSupplierMainViewModel = newSupplierMainViewModel;
        }

        public bool Check()
        {
            if (string.IsNullOrEmpty(newSupplierMainViewModel.NewSupplierName) || !newSupplierMainViewModel.NameValidationbPredict)
            {
                newSupplierMainViewModel.SaveNewSupplierButtonForeground = Globals.Graphics.SetProperButtonBackground.Set
                (
                    false,
                    Globals.Graphics.Uris.SaveSettingsEnabled,
                    Globals.Graphics.Uris.SaveSettingsDisabled
                );

                return false;
            }
            else
            {
                newSupplierMainViewModel.SaveNewSupplierButtonForeground = Globals.Graphics.SetProperButtonBackground.Set
                (
                    true,
                    Globals.Graphics.Uris.SaveSettingsEnabled,
                    Globals.Graphics.Uris.SaveSettingsDisabled
                );
                return true;
            }
        }
    }
}
