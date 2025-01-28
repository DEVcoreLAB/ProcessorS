using ControlMainWizard.Langs;
using ControlMainWizard.Model;
using ControlMainWizard.ViewModel.Commands.BlockDiagramButtonCommands;
using ControlMainWizard.ViewModel.Commands.CustomerButtonCommand;
using ControlMainWizard.ViewModel.Commands.EquipmentButtonCommands;
using ControlMainWizard.ViewModel.Commands.IntermediateProductButtonCommands;
using ControlMainWizard.ViewModel.Commands.LocationButtonCommands;
using ControlMainWizard.ViewModel.Commands.ProductButtonCommands;
using ControlMainWizard.ViewModel.Commands.SupplierButtonCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ControlMainWizard.ViewModel
{
    internal partial class MainViewModel : Globals.ViewModel.BaseViewModel
    {
        public MainViewModel()
        {
            BlockDiagramButtonContent = Lang.blockDiagramButtonContent;
            CustomerButtonContent = Lang.customerButtonContent;
            EquipmentButtonContent = Lang.equipmentButtonContent;
            IntermediateProductButtonContent = Lang.intermediateProductButtonContent;
            LocationButtonContent = Lang.locationButtonContent;
            ProductButtonContent = Lang.productButtonContent;
            SupplierButtonContent = Lang.supplierButtonContent;

            BlockDiagramButtonBorderBrush = new SolidColorBrush(Colors.Black);
            CustomerButtonBorderBrush = new SolidColorBrush(Colors.Black);
            EquipmentButtonBorderBrush = new SolidColorBrush(Colors.Black);
            IntermediateProductButtonBorderBrush = new SolidColorBrush(Colors.Black);
            LocationButtonBorderBrush = new SolidColorBrush(Colors.Black);
            ProductButtonBorderBrush = new SolidColorBrush(Colors.Black);
            SupplierButtonBorderBrudh = new SolidColorBrush(Colors.Black);

            BlockDiagramButtonCommand = new Globals.ViewModel.RelayCommand
                (
                    new BlockDiagramButtonAction(this).Execute,
                    new BlockDiagramButtonPredisct().Check
                );

            CustomerButtonCommand = new Globals.ViewModel.RelayCommand
                (
                    new CustomerButtonAction(this).Execute,
                    new CustomerButtonPredict().Check
                );

            EquipmentButtonCommand = new Globals.ViewModel.RelayCommand
                (
                    new EquipmentButtonAction(this).Execute,
                    new EquipmentButtonPredict().Check
                );

            IntermediateProductButtonCommand = new Globals.ViewModel.RelayCommand
                (
                    new IntermediateButtonAction(this).Execute,
                    new IntermediateProductButtonPredict().Check
                );

            LocationButtonCommand = new Globals.ViewModel.RelayCommand
                (
                    new LocationButtonAction(this).Execute,
                    new LocationButtonPredict().Check
                );

            ProductButtonCommand = new Globals.ViewModel.RelayCommand
                (
                    new ProductButtonAction(this).Execute,
                    new ProductButtonPredict().Check
                );

            SupplierButtonCommand = new Globals.ViewModel.RelayCommand
                (
                    new SupplierButtonAction(this).Execute,
                    new SupplierButtonPredict().Check
                );
        }
    }
}
