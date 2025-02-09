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

        public NewSupplierControl(List<(string nameOfControl, string typeOfControl)> selectedSchema)
        {
            InitializeComponent();

            newSupplierMainViewModel = new NewSupplierMainViewModel();
            this.DataContext = newSupplierMainViewModel;

            newSupplierMainViewModel.SchemaControlsList = selectedSchema;
            newSupplierMainViewModel.ListChanged += NewSupplierMainViewModel_ListChanged;
        }

        public void NewSupplierMainViewModel_ListChanged(object sender, EventArgs e)
        {
            int rowCount = newSupplierMainViewModel.SupplierControlsList.Count();

            for (int i = 0; i < rowCount; i++)
            {
                RowDefinition rowDefinition = new RowDefinition
                {
                    Height = GridLength.Auto
                };

                rowDefinition.Tag = $"RowDefinition_{i}";

                GridForData.RowDefinitions.Add(rowDefinition);

                Grid gridForRow = new Grid();
                ColumnDefinition columnNameDefinition = new ColumnDefinition()
                {
                    Width = new GridLength(1, GridUnitType.Star)
                };
                ColumnDefinition columnTypeDefinition = new ColumnDefinition()
                {
                    Width = new GridLength(1, GridUnitType.Star)
                };
                ColumnDefinition columnButtonDefinition = new ColumnDefinition()
                {
                    Width = new GridLength(50)
                };
                gridForRow.ColumnDefinitions.Add(columnNameDefinition);
                gridForRow.ColumnDefinitions.Add(columnTypeDefinition);
                gridForRow.ColumnDefinitions.Add(columnButtonDefinition);

                Label lblSupplierName = new Label();
                lblSupplierName.Content = newSupplierMainViewModel.SupplierControlsList[i].name;
                Grid.SetColumn(lblSupplierName, 0);
                gridForRow.Children.Add(lblSupplierName);


                Control control = newSupplierMainViewModel.SupplierControlsList[i].type;
                Grid.SetColumn(control, 1);
                gridForRow.Children.Add(control);

                if (newSupplierMainViewModel.SupplierControlsList[i].type is ComboBox)
                {
                    Button button = new Button();
                    button.Content = "ok";
                    Grid.SetColumn(button, 2);
                    gridForRow.Children.Add(button);
                }



                Grid.SetRow(gridForRow,i);
                GridForData.Children.Add(gridForRow);

            }
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var item in newSupplierMainViewModel.SupplierControlsList)
                {
                    stringBuilder.AppendLine($@"{item.name}     {item.type.GetType()}   {item.property.Name}");
                }

                MessageBox.Show(stringBuilder.ToString());
            }
        }
    }
}
