using Globals.Model.Observer.Components;
using Globals.ViewModel;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SubControlSupplierProject.Model.NewSchemaUserControl.Reactors.Behaviours.SaveNewSchemaVM
{
    internal class NameOfNewSchemaBehaviour : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            NewSchemaMainViewModel mainViewModel = viewModel as NewSchemaMainViewModel;

            return new Action(() =>
            {
                bool colorChanged = false;

                var restrictedWords = Enum
                    .GetValues(typeof(Globals.DbOperations.Validation.ReserverWords.ReservedDbWords))
                    .Cast<Globals.DbOperations.Validation.ReserverWords.ReservedDbWords>()
                    .Select(x => x.ToString())
                    .ToList();

                foreach (var word in restrictedWords)
                {
                    if (word.ToLower().Equals(mainViewModel.NameOfNewSchema.ToLower()))
                    {
                        mainViewModel.NewShemaNameBrush = new SolidColorBrush(Colors.Red);
                        colorChanged = true;
                        
                        break;
                    }
                    else
                    {
                        mainViewModel.NewShemaNameBrush = new SolidColorBrush(Colors.Black);
                    }
                }

                if (colorChanged)
                {
                    return;
                }

                foreach (var item in mainViewModel.ListOfSchemasNames)
                {

                    if (item.Equals(mainViewModel.NameOfNewSchema))
                    {
                        mainViewModel.NewShemaNameBrush = new SolidColorBrush(Colors.Red);
                        break;
                    }
                    else
                    {
                        mainViewModel.NewShemaNameBrush = new SolidColorBrush(Colors.Black);
                    }
                }

                if (!string.IsNullOrEmpty(mainViewModel.NameOfNewSchema) && !char.IsLetter(mainViewModel.NameOfNewSchema[0]))
                {
                    mainViewModel.NameOfNewSchema = string.Empty;
                }
            });
        }
    }
}
