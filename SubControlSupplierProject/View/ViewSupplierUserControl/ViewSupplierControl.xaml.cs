using SubControlSupplierProject.ViewModel.ViewSupplierUserControl;
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

namespace SubControlSupplierProject.View.ViewSupplierUserControl
{
    /// <summary>
    /// Interaction logic for ViewSupplierControl.xaml
    /// </summary>
    public partial class ViewSupplierControl : UserControl
    {
        ViewSupplierMainViewModel viewSupplierMainViewModel; 

        public ViewSupplierControl()
        {
            InitializeComponent();
            viewSupplierMainViewModel = new ViewSupplierMainViewModel();
            this.DataContext = viewSupplierMainViewModel;
        }
    }
}
