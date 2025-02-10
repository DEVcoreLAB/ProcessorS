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

        private (string name, Control control, Type property) Fill(string baseName, string baseType)
        {
            string name = baseName;
            Control control = null;
            Type property = null;

            if (baseType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.TextBoxControl.ToString())
            {
                property = typeof(string);

                TextBox textBox = new TextBox();
                textBox.Name = $@"{new string(
                    name.Where(c => !char.IsWhiteSpace(c)).ToArray())}TextBox";

                Binding binding = new Binding(property.Name)
                {
                    Source = property,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                };
                textBox.SetBinding(TextBox.TextProperty, binding);

                control = textBox;
            }
            else if (baseType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.ComboBoxControl.ToString())
            {
                property = typeof(ObservableCollection<string>);

                object createdInstance = Activator.CreateInstance(property);
                ObservableCollection<string> collection =
                    createdInstance as ObservableCollection<string>;

                ComboBox comboBox = new ComboBox();
                comboBox.Name = $@"{new string(
                    name.Where(c => !char.IsWhiteSpace(c)).ToArray())}ComboBox";

                Binding binding = new Binding(property.Name)
                {
                    Source = property,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                };
                comboBox.SetBinding(ComboBox.ItemsSourceProperty, binding);

                control = comboBox;
            }
            else if (baseType == Globals.DbOperations.InvariantTypeOfControls.ControlTypes.CheckBoxControl.ToString())
            {
                property = typeof(bool);
                CheckBox checkBox = new CheckBox();
                checkBox.Name = $@"{new string(
                    name.Where(c => !char.IsWhiteSpace(c)).ToArray())}CheckBox";

                Binding binding = new Binding(property.Name)
                {
                    Source = property,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                };
                checkBox.SetBinding(CheckBox.IsCheckedProperty, binding);

                control = checkBox;
            }

            return (name, control, property);
        }
    }
}
