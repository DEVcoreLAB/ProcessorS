using SubControlSupplierProject.Model.ViewSupplierUserControl.Reactors.Behaviours;
using SubControlSupplierProject.ViewModel.NewSupplierUserControl;
using SubControlSupplierProject.ViewModel.ViewSupplierUserControl;
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

namespace SubControlSupplierProject.View.ViewSupplierUserControl
{
    /// <summary>
    /// Interaction logic for ViewSupplierControl.xaml
    /// </summary>
    public partial class ViewSupplierControl : UserControl
    {
        ViewSupplierMainViewModel viewSupplierMainViewModel; 

        public ViewSupplierControl(string selectedSupplier)
        {
            InitializeComponent();
            viewSupplierMainViewModel = new ViewSupplierMainViewModel();
            this.DataContext = viewSupplierMainViewModel;

            viewSupplierMainViewModel.SelectedSupplierBaseTableName = selectedSupplier;

            AllDataCollectionBehaviour.AllDataChanged += AllDataCollectionBehaviour_AllDataChanged;
        }

        private void AllDataCollectionBehaviour_AllDataChanged(object? sender, EventArgs e)
        {
            int rowCount = viewSupplierMainViewModel.AllDataCollection.Count();

            for (int i = 0; i < rowCount; i++)
            {
                RowDefinition rowDefinition = new RowDefinition
                {
                    Height = GridLength.Auto
                };
                rowDefinition.Tag = $"RowDefinition_{i}";
                GridForData.RowDefinitions.Add(rowDefinition);

                Grid gridForRow = new Grid();

                gridForRow.ColumnDefinitions.Add(
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                gridForRow.ColumnDefinitions.Add(
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                gridForRow.ColumnDefinitions.Add(
                    new ColumnDefinition { Width = new GridLength(50) });

                Label lblSupplierName = new Label();
                lblSupplierName.Content
                    = viewSupplierMainViewModel.AllDataCollection[i].propertyName;
                Grid.SetColumn(lblSupplierName, 0);
                gridForRow.Children.Add(lblSupplierName);

                Control control = CheckForControlType(
                viewSupplierMainViewModel.AllDataCollection[i].controlTypename);

                control.Name
                    = viewSupplierMainViewModel.AllDataCollection[i].propertyName.Replace(' ','_');

                Grid.SetColumn(control, 1);
                gridForRow.Children.Add(control);


                if (viewSupplierMainViewModel.AllDataCollection[i].controlTypename == 
                    Globals.DbOperations.InvariantTypeOfControls.ControlTypes.ComboBoxControl.ToString())
                {
                    var comboBox = new ComboBox();

                    // set path for property name "stringsCollection"
                    var comboBoxBinding = new Binding("stringsCollection")
                    {
                        Source = viewSupplierMainViewModel.AllDataCollection[i],
                        Mode = BindingMode.TwoWay,
                        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                    };

                    BindingOperations.SetBinding(
                        comboBox,
                        ComboBox.ItemsSourceProperty,
                        comboBoxBinding
                    );

                    Grid.SetColumn(comboBox, 1);
                    gridForRow.Children.Add(comboBox);
                }
                else if (viewSupplierMainViewModel.AllDataCollection[i].controlTypename ==
                    Globals.DbOperations.InvariantTypeOfControls.ControlTypes.TextBoxControl.ToString())
                {
                    var textBox = new TextBox();

                    var textBoxBinding = new Binding("stringValue")
                    {
                        Source = viewSupplierMainViewModel.AllDataCollection[i],
                        Mode = BindingMode.TwoWay,
                        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                    };

                    BindingOperations.SetBinding(
                        textBox,
                        TextBox.TextProperty,
                        textBoxBinding
                    );

                    Grid.SetColumn(textBox, 1);
                    gridForRow.Children.Add(textBox);
                }
                else if (viewSupplierMainViewModel.AllDataCollection[i].controlTypename ==
                    Globals.DbOperations.InvariantTypeOfControls.ControlTypes.CheckBoxControl.ToString())
                {
                    var checkBox = new CheckBox();

                    var checkBoxBinding = new Binding("boolValue")
                    {
                        Source = viewSupplierMainViewModel.AllDataCollection[i],
                        Mode = BindingMode.TwoWay,
                        UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                    };

                    BindingOperations.SetBinding(
                        checkBox,
                        CheckBox.IsCheckedProperty,
                        checkBoxBinding
                    );

                    Grid.SetColumn(checkBox, 1);
                    gridForRow.Children.Add(checkBox);
                }


                if (control is CheckBox)
                {
                    control.VerticalAlignment = VerticalAlignment.Center;
                }

                Grid.SetRow(gridForRow, i);
                GridForData.Children.Add(gridForRow);
            }
        }

        private Control CheckForControlType(string controlType)
        {
            Control control = null;

            if (controlType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.ComboBoxControl.ToString())
            {
                control = new ComboBox();
            }
            else if (controlType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.TextBoxControl.ToString())
            {
                control = new TextBox();
            }
            else if (controlType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.CheckBoxControl.ToString())
            {
                control = new CheckBox();
            }

            return control;
        }

    }
}
