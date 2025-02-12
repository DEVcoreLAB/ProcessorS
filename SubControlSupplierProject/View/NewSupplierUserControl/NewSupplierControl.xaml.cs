using Globals.MyDialogsAndWindows.MyMessagebox;
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
            //object instance = newSupplierMainViewModel.DynamicInstanceOfreflectedProperties;

            //// Ustawianie wartości w każdej właściwości dynamicznej:
            //foreach (var property in newSupplierMainViewModel.ReflectedProperties.GetProperties())
            //{
            //    if (property.PropertyType == typeof(ObservableCollection<string>))
            //    {
            //        property.SetValue(
            //            instance,
            //            new ObservableCollection<string>() { "jeden", "dwa" }
            //        );
            //    }
            //    else if (property.PropertyType == typeof(string))
            //    {
            //        property.SetValue(instance, "item");
            //    }
            //    else if (property.PropertyType == typeof(bool))
            //    {
            //        property.SetValue(instance, true);
            //    }
            //    // Możesz dodać inne typy według potrzeb
            //}

            //foreach (var property in newSupplierMainViewModel.ReflectedProperties.GetProperties())
            //{
            //    if (property.PropertyType == typeof(ObservableCollection<string>))
            //    {
            //        property.SetValue(newSupplierMainViewModel.DynamicInstanceOfreflectedProperties,
            //            new ObservableCollection<string>() { "jesde", "dwa" });
            //    }
            //    else if (property.PropertyType == typeof(string))
            //    {
            //        property.SetValue(newSupplierMainViewModel.DynamicInstanceOfreflectedProperties, "item");
            //    }
            //    else if (property.PropertyType == typeof(bool))
            //    { 
            //        property.SetValue(newSupplierMainViewModel.DynamicInstanceOfreflectedProperties, true);
            //    }
            //}


            //////////////////////////////////////////////////////////////////
            //StringBuilder builder = new StringBuilder();

            //foreach (var item in newSupplierMainViewModel.ReflectedProperties.GetProperties())
            //{
            //    builder.AppendLine(item.Name + " " + item.PropertyType);

            //}
            //MessageBox.Show(builder.ToString());
            //////////////////////////////////////////////////////////////////


            //check observable
            //foreach (var property in newSupplierMainViewModel.ReflectedProperties.GetProperties())
            //{
            //    if (property.PropertyType == typeof(ObservableCollection<string>))
            //    {
            //        property.SetValue(newSupplierMainViewModel.DynamicInstanceOfreflectedProperties, 
            //            new ObservableCollection<string>() { "jesde", "dwa" });
            //    }
            //    var currentValue = property.GetValue(newSupplierMainViewModel.DynamicInstanceOfreflectedProperties);

            //    if (currentValue is IEnumerable enumerable)
            //    { 
            //        StringBuilder sb = new StringBuilder();
            //        foreach (var item in enumerable)
            //        {
            //            sb.AppendLine(item.ToString());
            //        }
            //        MessageBox.Show(sb.ToString());
            //    }
            //}




            ////check string
            //foreach (var property in newSupplierMainViewModel.ReflectedProperties.GetProperties())
            //{
            //    // Interesują nas tylko właściwości typu string
            //    if (property.PropertyType == typeof(string))
            //    {
            //        // Ustawiamy wartość "napis"
            //        property.SetValue(newSupplierMainViewModel.DynamicInstanceOfreflectedProperties, "napis");

            //        // Odczytujemy tę wartość z instancji
            //        var currentValue = property.GetValue(newSupplierMainViewModel.DynamicInstanceOfreflectedProperties);

            //        // Sprawdzamy, czy faktycznie jest to string i czy ma oczekiwaną treść
            //        if (currentValue is string stringValue && stringValue == "napis")
            //        {
            //            // Tu możesz dodać kod potwierdzający powodzenie
            //            // np. zapis do logu lub inna akcja
            //            MessageBox.Show(currentValue.ToString());
            //        }
            //    }
            //}









            //MessageBox.Show("list changed");
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

                // Definiujemy trzy kolumny: etykieta, kontrolka, opcjonalny przycisk
                gridForRow.ColumnDefinitions.Add(
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                gridForRow.ColumnDefinitions.Add(
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                gridForRow.ColumnDefinitions.Add(
                    new ColumnDefinition { Width = new GridLength(50) });

                // Dodajemy etykietę
                Label lblSupplierName = new Label();
                lblSupplierName.Content
                    = newSupplierMainViewModel.SchemaControlsList[i].controlName;
                Grid.SetColumn(lblSupplierName, 0);
                gridForRow.Children.Add(lblSupplierName);

                // Tworzymy kontrolkę (TextBox, ComboBox, CheckBox itp.)
                Control control = CheckForControlType(
                    newSupplierMainViewModel.SchemaControlsList[i].controlType);

                //Kluczowe: nadajemy kontrolce Name = nazwa właściwości
                control.Name
                    = newSupplierMainViewModel.SchemaControlsList[i].controlName.Replace(" ", "_");


                ///////////////////////////////////////////////////////////////////////////////
                // Dodajemy kontrolkę do siatki w kolumnie 1
                Grid.SetColumn(control, 1);
                gridForRow.Children.Add(control);

                // Teraz łączymy kontrolkę z właściwością w obiekcie dynamicznym
                // - Sprawdzamy, czy w ReflectedProperties istnieje właściwość
                //   o nazwie równej control.Name
                foreach (var property in newSupplierMainViewModel.ReflectedProperties.GetProperties())
                {
                    if (property.Name == control.Name)
                    {
                        // Tworzymy Binding, gdzie Path = nazwa właściwości,
                        // a Source = instancja zawierająca te właściwości
                        var binding = new Binding(property.Name)
                        {
                            Source = newSupplierMainViewModel.DynamicInstanceOfreflectedProperties,
                            Mode = BindingMode.TwoWay, // lub TwoWay – zależnie od potrzeb
                            UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                        };

                        // Dopasowanie właściwości w kontrolce do typu danych
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
                            // Jeśli właściwość to np. ObservableCollection<string>,
                            // wiążemy do ItemsSource
                            BindingOperations.SetBinding(
                                comboBox,
                                ComboBox.ItemsSourceProperty,
                                binding
                            );

                            // Jeśli chcesz też wiązać wybrany element, użyj 
                            // osobnego Binding do SelectedItemProperty
                            // ...
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

                // Dodaj przycisk, jeżeli to np. ComboBox
                if (control is ComboBox)
                {
                    Button button = new Button();
                    button.Content = "ok";
                    Grid.SetColumn(button, 2);
                    button.Click += (s, e) =>
                    {
                        // Logika przycisku
                    };
                    gridForRow.Children.Add(button);
                }

                // Dopasuj wygląd CheckBox
                if (control is CheckBox)
                {
                    control.VerticalAlignment = VerticalAlignment.Center;
                }

                Grid.SetRow(gridForRow, i);
                GridForData.Children.Add(gridForRow);
                /////////////////////////////////////////////////////////////////////////

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

                        // Pobieramy wartość właściwości z obiektu 'instance'.
                        // Metoda GetValue() zwraca 'object', więc rzutujemy na właściwy typ.
                        var myCollection = property.GetValue(instance)
                                           as ObservableCollection<string>;

                        // Sprawdzamy, czy się udało
                        if (myCollection != null)
                        {
                            // Tutaj możesz wykorzystać 'myCollection' i 'stringBuilder'
                            // np. zbudować ciąg znaków z elementów kolekcji
                            foreach (var item in myCollection)
                            {
                                stringBuilder.AppendLine(item);
                            }

                            // Ewentualnie dalsza logika...
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
        }
    }
}
