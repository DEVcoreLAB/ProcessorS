using Globals.ViewModel;
using SubControlSupplierProject.Model.NewSupplierUserControl;
using SubControlSupplierProject.ViewModel.NewSupplierUserControl.Command.SaveNewSupplierButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubControlSupplierProject.ViewModel.NewSupplierUserControl
{
    internal partial class NewSupplierMainViewModel : BaseViewModel
    {
        NewSupplierMainModel NewSupplierMainModel { get; }

        public NewSupplierMainViewModel()
        {
            NewSupplierMainModel = new NewSupplierMainModel(this);

            SaveNewSupplierButtonForeground = Globals.Graphics.SetProperButtonBackground.Set
               (
                   false,
                   Globals.Graphics.Uris.SaveSettingsEnabled,
                   Globals.Graphics.Uris.SaveSettingsDisabled
               );

            SaveNewSupplierCommand = new RelayCommand(new SaveNewSupplierButtonAction(this).Execute, new SaveNewSupplierButtonPredict().Check);
            GridForDataProperty = new System.Windows.Controls.Grid();
        }
    }
}
