using Globals.ViewModel;
using SubControlSupplierProject.Model;
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
        MainModel MainModel { get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);
            ViewListOfSchemas = CollectionViewSource.GetDefaultView(ListOfSchemas);

        }


    }
}
