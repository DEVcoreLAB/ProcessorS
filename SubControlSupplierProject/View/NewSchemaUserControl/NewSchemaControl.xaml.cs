using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public NewSchemaControl(ObservableCollection<string> listOfShemasNames)
        {
            InitializeComponent();
            newSchemaMainViewModel = new NewSchemaMainViewModel();
            this.DataContext = newSchemaMainViewModel;
            newSchemaMainViewModel.ListOfSchemasNames = listOfShemasNames;
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                MessageBox.Show(newSchemaMainViewModel.NameOfNewItem);
            }
        }

        private void NewItemTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(newSchemaMainViewModel.NameOfNewItem))
            {
                Globals.DbOperations.Validation.ForWindowDirectly.RestrictedChars.Check(sender);
            }
        }

        private void NewSchemaNameTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(newSchemaMainViewModel.NameOfNewSchema))
            {
                Globals.DbOperations.Validation.ForWindowDirectly.RestrictedChars.Check(sender);
            }
        }
    }
}
