using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
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

namespace SubControlSupplierProject.View.NewSchemaUserControl
{
    /// <summary>
    /// Interaction logic for NewSchemaControl.xaml
    /// </summary>
    public partial class NewSchemaControl : UserControl
    {
        NewSchemaMainViewModel newSchemaMainViewModel;

        public NewSchemaControl()
        {
            InitializeComponent();
            newSchemaMainViewModel = new NewSchemaMainViewModel();
            this.DataContext = newSchemaMainViewModel;
        }
    }
}
