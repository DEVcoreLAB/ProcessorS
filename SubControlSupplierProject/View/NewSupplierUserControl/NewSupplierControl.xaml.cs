using SubControlSupplierProject.ViewModel.NewSupplierUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SubControlSupplierProject.View.NewSupplierUserControl
{
    /// <summary>
    /// Interaction logic for NewSupplierControl.xaml
    /// </summary>
    public partial class NewSupplierControl : UserControl
    {
        NewSupplierMainViewModel newSupplierMainViewModel;

        public NewSupplierControl()
        {
            InitializeComponent();

            newSupplierMainViewModel = new NewSupplierMainViewModel();
            this.DataContext = newSupplierMainViewModel;
        }
    }
}
