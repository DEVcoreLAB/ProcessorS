using SubControlSupplierProject.View.NewSchemaUserControl;
using SubControlSupplierProject.ViewModel.NewSchemaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SubControlSupplierProject.ViewModel.Command.MainControl.NewSchemaButtonCommands
{
    internal class NewSchemaButtonAction
    {
        MainViewModel mainViewModel;

        public NewSchemaButtonAction(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public void Execute(object? parameter)
        {
            mainViewModel.OperationUserControl = new NewSchemaControl();
        }
    }
}
