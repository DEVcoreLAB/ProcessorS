using ControlMainWizard.Langs;
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
        }
    }
}
