using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SubControlSupplierProject.ViewModel.NewSchemaUserControl.Command.SaveSchema
{
    internal class SaveSchemaPredict
    {
        NewSchemaMainViewModel newSchemaMainViewModel;

        public SaveSchemaPredict(NewSchemaMainViewModel newSchemaMainViewModel)
        {
            this.newSchemaMainViewModel = newSchemaMainViewModel;
        }

        public bool Check()
        {
            bool isNameOfNewSchemaUnique = true;

            foreach (var item in newSchemaMainViewModel.ListOfSchemasNames)
            {
                if (item == newSchemaMainViewModel.NameOfNewSchema)
                {
                    isNameOfNewSchemaUnique = false;
                    break;
                }
            }

            if (newSchemaMainViewModel.ItemsToSaveDictionary.Count > 0 
                && !string.IsNullOrEmpty(newSchemaMainViewModel.NameOfNewSchema) 
                && isNameOfNewSchemaUnique)
            {
                newSchemaMainViewModel.SaveNewSchemaButtonForeground = SetButtonForeground(true);
                return true;
            }
                newSchemaMainViewModel.SaveNewSchemaButtonForeground = SetButtonForeground(false);
                return false;
        }

        private BitmapImage SetButtonForeground(bool isEnabled)
        {
            return Globals.Graphics.SetProperButtonBackground.Set
                (
                    isEnabled,
                    Globals.Graphics.Uris.SaveSettingsEnabled,
                    Globals.Graphics.Uris.SaveSettingsDisabled
                );
        }
    }
}
