using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;


namespace SubControlSupplierProject.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            OnTest();
        }

        private void OnTest()
        {
            ListOfSchemas = new System.Collections.ObjectModel.ObservableCollection<string>
            {
                "cocacola",
                "left side",
                "left corner",
                "middle corner",
                "new york city",
                "old york city",
                "yolanda be cool"
            };

            ViewListOfSchemas = CollectionViewSource.GetDefaultView(ListOfSchemas);
        }
    }
}
