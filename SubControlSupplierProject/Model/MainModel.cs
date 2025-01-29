using SubControlSupplierProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SubControlSupplierProject.Model
{
    class MainModel
    {
        MainViewModel MainViewModel { get; }

        public MainModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            OnTest();
        }

        private void OnTest()
        {
            MainViewModel.ListOfSchemas = new System.Collections.ObjectModel.ObservableCollection<string>
            {
                "cocacola",
                "left side",
                "left corner",
                "middle corner",
                "new york city",
                "old york city",
                "yolanda be cool"
            };
        }
    }
}
