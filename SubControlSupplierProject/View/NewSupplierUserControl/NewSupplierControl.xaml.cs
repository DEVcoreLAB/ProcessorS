using Globals.MyDialogsAndWindows.MyMessagebox;
using SubControlSupplierProject.ViewModel.NewSupplierUserControl;
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
                StringBuilder sb = new StringBuilder();

                foreach ((string name, Control ctrl, object data, Type property) in newSupplierMainViewModel.SupplierControlsList)
                {
                    // Dodajemy podstawowe info o elemencie
                    sb.AppendLine($"Nazwa: {name}");
                    sb.AppendLine($"Typ property: {property.Name}");

                    // Rozróżniamy, co przechowuje dana kontrolka na podstawie property
                    if (property == typeof(string))
                    {
                        // Przykład: TextBox trzymający tekst typu string
                        if (ctrl is TextBox textBox)
                        {
                            sb.AppendLine($"Wartość (string): {textBox.Text}");
                        }
                    }
                    else if (property == typeof(ObservableCollection<string>))
                    {
                        // Przykład: ComboBox powiązany z kolekcją stringów
                        if (ctrl is ComboBox comboBox)
                        {
                            // Jeśli ComboBox ma ItemsSource w postaci ObservableCollection<string>,
                            // możemy ją odczytać i wylistować elementy
                            if (comboBox.ItemsSource is ObservableCollection<string> collection)
                            {
                                sb.AppendLine("Elementy w ObservableCollection<string>:");
                                foreach (var element in collection)
                                {
                                    sb.AppendLine("  - " + element);
                                }
                            }
                            else
                            {
                                sb.AppendLine("Brak powiązanej kolekcji lub nie jest to typ ObservableCollection<string>.");
                            }
                        }
                    }
                    else if (property == typeof(bool))
                    {
                        // Przykład: CheckBox trzymający wartość zaznaczenia
                        if (ctrl is CheckBox checkBox)
                        {
                            sb.AppendLine($"CheckBox (IsChecked): {checkBox.IsChecked}");
                        }
                    }
                    else
                    {
                        sb.AppendLine("Nieobsługiwany typ property.");
                    }

                    sb.AppendLine(new string('-', 40)); // Separator dla czytelności
                }

                // Wyświetlamy zebrane informacje
                MessageBoxX.Show(sb.ToString());









                //StringBuilder stringBuilder = new StringBuilder();

                //foreach (var item in newSupplierMainViewModel.SupplierControlsList)
                //{
                //    stringBuilder.AppendLine($@"{item.name}     {item.type.GetType()}   {item.property.Name}");
                //}

                //MessageBox.Show(stringBuilder.ToString());
            }



           
        }
    }
}
