using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (newSchemaMainViewModel.ItemsToSaveDictionary.Count > 0 && !string.IsNullOrWhiteSpace(newSchemaMainViewModel.NameOfNewSchema))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
