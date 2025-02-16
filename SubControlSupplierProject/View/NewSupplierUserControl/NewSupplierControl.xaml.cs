using Globals.MyDialogsAndWindows.MyMessagebox;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
using SubControlSupplierProject.ViewModel.NewSupplierUserControl;
using System;
using System.Collections;
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

namespace SubControlSupplierProject.View.NewSupplierUserControl
{
    /// <summary>
    /// Interaction logic for NewSupplierControl.xaml
    /// </summary>
    public partial class NewSupplierControl : UserControl
    {
        NewSupplierMainViewModel newSupplierMainViewModel;

        public NewSupplierControl
            (
                List<(string nameOfControl, string typeOfControl)> selectedSchema,
                ObservableCollection<string> existingSpuupliers
            )
        {
            InitializeComponent();

            newSupplierMainViewModel = new NewSupplierMainViewModel();
            this.DataContext = newSupplierMainViewModel;

            newSupplierMainViewModel.SchemaControlsList = selectedSchema;
            newSupplierMainViewModel.existingSuppliers = existingSpuupliers;
            newSupplierMainViewModel.ListChanged += NewSupplierMainViewModel_ListChanged;
        }

        public void NewSupplierMainViewModel_ListChanged(object sender, EventArgs e)
        {
            foreach (var item in newSupplierMainViewModel.ReflectedProperties.GetProperties())
            {
                if (item.PropertyType == typeof(ObservableCollection<string>))
                {
                    var newCollection = new ObservableCollection<string>();


                    item.SetValue(
                        newSupplierMainViewModel.DynamicInstanceOfreflectedProperties,
                        newCollection
                    );
                }
            }


            int rowCount = newSupplierMainViewModel.SchemaControlsList.Count();

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
                    = newSupplierMainViewModel.SchemaControlsList[i].controlName;
                Grid.SetColumn(lblSupplierName, 0);
                gridForRow.Children.Add(lblSupplierName);

                Control control = CheckForControlType(
                    newSupplierMainViewModel.SchemaControlsList[i].controlType);

                control.Name
                    = newSupplierMainViewModel.SchemaControlsList[i].controlName.Replace(" ", "_");

                Grid.SetColumn(control, 1);
                gridForRow.Children.Add(control);

                // binding
                foreach (var property in newSupplierMainViewModel.ReflectedProperties.GetProperties())
                {
                    if (property.Name == control.Name)
                    {
                        var binding = new Binding(property.Name)
                        {
                            Source = newSupplierMainViewModel.DynamicInstanceOfreflectedProperties,
                            Mode = BindingMode.TwoWay, 
                            UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                        };

                        if (control is TextBox textBox)
                        {
                            BindingOperations.SetBinding(
                                textBox,
                                TextBox.TextProperty,
                                binding
                            );
                        }
                        else if (control is ComboBox comboBox)
                        {
                            BindingOperations.SetBinding(
                                comboBox,
                                ComboBox.ItemsSourceProperty,
                                binding
                            );

                        }
                        else if (control is CheckBox checkBox)
                        {
                            BindingOperations.SetBinding(
                                checkBox,
                                CheckBox.IsCheckedProperty,
                                binding
                            );
                        }
                    }
                }

                if (control is ComboBox box)
                {
                    Button button = new Button();
                    button.Height = 25;
                    var bitmap = Globals.Graphics.SetProperButtonBackground.Set
                        (
                            true,
                            Globals.Graphics.Uris.AddEnabled,
                            Globals.Graphics.Uris.AddDisabled
                        );

                    var image = new Image
                    {
                        Source = bitmap,
                        Width = 16,
                        Height = 16,
                        Margin = new Thickness(0, 0, 5, 0) // mały odstęp od tekstu
                    };

                    button.Content = image;

                    button.Background = new SolidColorBrush( Colors.Transparent );
                    button.BorderThickness = new Thickness(0);

                    Grid.SetColumn(button, 2);
                    button.Click += (s, e) =>
                    {
                        var prop = newSupplierMainViewModel
                            .ReflectedProperties
                            .GetProperties()
                            .FirstOrDefault(x => x.Name == box.Name);

                        if (prop == null)
                        {
                            MessageBox.Show("Nie znaleziono właściwości o nazwie: " + box.Name);
                            return;
                        }

                        var collection = prop.GetValue(
                            newSupplierMainViewModel.DynamicInstanceOfreflectedProperties
                        ) as ObservableCollection<string>;

                        Globals.Wizard.Windows.FillBoxes.FillComboBox fillComboBox = 
                            new Globals.Wizard.Windows.FillBoxes.FillComboBox(collection);
                        fillComboBox.ShowDialog();

                        
                    };
                    gridForRow.Children.Add(button);
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

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                object instance = newSupplierMainViewModel.DynamicInstanceOfreflectedProperties;

                StringBuilder sb = new StringBuilder();

                foreach (var property in newSupplierMainViewModel.ReflectedProperties.GetProperties())
                {
                    if (property.PropertyType == typeof(ObservableCollection<string>))
                    {
                        StringBuilder stringBuilder = new StringBuilder();

                        var myCollection = property.GetValue(instance)
                                           as ObservableCollection<string>;

                        if (myCollection != null)
                        {
                            foreach (var item in myCollection)
                            {
                                stringBuilder.AppendLine(item);
                            }
                        }
                        sb.AppendLine(stringBuilder.ToString());
                    }
                    else if (property.PropertyType == typeof(string))
                    {
                        var value = property.GetValue(instance);
                        if (value != null)
                        {
                            sb.AppendLine(value.ToString());
                        }
                        else
                        {
                            sb.AppendLine("wartość jest null");
                        }
                    }
                    else if (property.PropertyType == typeof(bool))
                    {
                        sb.AppendLine(property.GetValue(instance).ToString());
                    }
                }
                MessageBox.Show(sb.ToString());
            }
            else if (e.Key == Key.F2)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in newSupplierMainViewModel.existingSuppliers)
                {
                    sb.AppendLine(item);
                }
                MessageBox.Show(sb.ToString());
            }
        }

        private void NewSuuplierName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(newSupplierMainViewModel.NewSupplierName))
            {
                Globals.DbOperations.Validation.ForWindowDirectly.RestrictedChars.Check(sender);
            }
        }
    }
}
