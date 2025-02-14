using Globals.ViewModel;
using SubControlSupplierProject.Model.NewSupplierUserControl;
using SubControlSupplierProject.ViewModel.NewSupplierUserControl.Command.SaveNewSupplierButton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SubControlSupplierProject.ViewModel.NewSupplierUserControl
{
    internal partial class NewSupplierMainViewModel : BaseViewModel
    {
        NewSupplierMainModel NewSupplierMainModel { get; }
        public event EventHandler ListChanged;
        public void ListChangedInvoke() => ListChanged?.Invoke(this, EventArgs.Empty);


        public NewSupplierMainViewModel()
        {
            NewSupplierMainModel = new NewSupplierMainModel(this);

            SaveNewSupplierButtonForeground = Globals.Graphics.SetProperButtonBackground.Set
               (
                   false,
                   Globals.Graphics.Uris.SaveSettingsEnabled,
                   Globals.Graphics.Uris.SaveSettingsDisabled
               );

            SaveNewSupplierCommand = new RelayCommand(new SaveNewSupplierButtonAction(this).Execute, new SaveNewSupplierButtonPredict(this).Check);
            NewSupplierNameLabel = Langs.Lang.newSupplierName;
            NewSupplierNameForeground = new System.Windows.Media.SolidColorBrush(Colors.Black);
        }

        public IEnumerable<string> existingSuppliers { get; set; }

        private List<(string controlName,string controlType)> schemaControlsList;
        public List<(string controlName,string controlType)> SchemaControlsList
        {
            get { return schemaControlsList; }
            set 
            { 
                schemaControlsList = value;
                OnPropertyChanged(nameof(SchemaControlsList));
            }
        }

        private Type reflectedProperties;
        public Type ReflectedProperties
        {
            get { return reflectedProperties; }
            set { reflectedProperties = value; }
        }

        private object dynamicInstanceOfreflectedProperties;
        public object DynamicInstanceOfreflectedProperties
        {
            get { return dynamicInstanceOfreflectedProperties; }
            set { dynamicInstanceOfreflectedProperties = value; }
        }

    }
}