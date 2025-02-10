using Globals.Model.Observer.Components;
using Globals.ViewModel;
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

namespace SubControlSupplierProject.Model.NewSupplierUserControl.Reactor.Behaviours.NewSupplierMainViewModelVM
{
    internal class SchemaControlsListBehaviours : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            NewSupplierMainViewModel mainViewModel = viewModel as NewSupplierMainViewModel;

            return () =>
            {
                foreach (var item in mainViewModel.SchemaControlsList)
                {
                    mainViewModel.SupplierControlsList.Add
                    (
                        Fill
                        (
                            item.Item1,
                            item.Item2
                        )
                    );
                }
                mainViewModel.ListChangedInvoke();
            };

        }

        private (string name, Control control, object data, Type property) Fill(string baseName, string baseType)
        {
            string name = baseName;
            Control control = null;
            object dataInstance = null; // Tu przechowamy faktyczne dane
            Type property = null;

            if (baseType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.TextBoxControl.ToString())
            {
                property = typeof(string);

                // 1) Tworzymy instancję danych (tu: pusty string)
                dataInstance = string.Empty;

                // 2) Tworzymy kontrolkę
                TextBox textBox = new TextBox();
                textBox.Name = $"{new string(name.Where(c => !char.IsWhiteSpace(c)).ToArray())}TextBox";

                // 3) Ustawiamy Binding 
                //    Bez Path, bo wiążemy całe "dataInstance" jako Source,
                //    i chcemy żeby TextBox.Text odwzorowywał "dataInstance" (string).
                Binding binding = new Binding(".")
                {
                    Source = dataInstance,              // obiekt, np. string
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                };
                textBox.SetBinding(TextBox.TextProperty, binding);

                control = textBox;
            }
            else if (baseType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.ComboBoxControl.ToString())
            {
                property = typeof(ObservableCollection<string>);

                // 1) Tworzymy faktyczną kolekcję
                dataInstance = new ObservableCollection<string>();

                // Opcjonalnie wypełniamy przykładowymi danymi:
                // ((ObservableCollection<string>)dataInstance).Add("Pozycja 1");
                // ((ObservableCollection<string>)dataInstance).Add("Pozycja 2");

                // 2) Kontrolka
                ComboBox comboBox = new ComboBox();
                comboBox.Name = $"{new string(name.Where(c => !char.IsWhiteSpace(c)).ToArray())}ComboBox";

                // 3) Binding do ItemsSource, ale tym razem Source = dataInstance
                Binding binding = new Binding
                {
                    Source = dataInstance,
                    Mode = BindingMode.OneWay // jeśli chcemy tylko czytać kolekcję
                };
                comboBox.SetBinding(ComboBox.ItemsSourceProperty, binding);

                control = comboBox;
            }
            else if (baseType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.CheckBoxControl.ToString())
            {
                property = typeof(bool);

                // 1) Tworzymy instancję danych – domyślnie false
                dataInstance = false;

                // 2) Kontrolka
                CheckBox checkBox = new CheckBox();
                checkBox.Name = $"{new string(name.Where(c => !char.IsWhiteSpace(c)).ToArray())}CheckBox";

                // 3) Binding do IsChecked

                Binding binding = new Binding(".")
                {
                    Source = dataInstance,   // np. bool
                    Mode = BindingMode.TwoWay
                };
                checkBox.SetBinding(CheckBox.IsCheckedProperty, binding);

                control = checkBox;
            }

            return (name, control, dataInstance, property);
        }
    }
}
