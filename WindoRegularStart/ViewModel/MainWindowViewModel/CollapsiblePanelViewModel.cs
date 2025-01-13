using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using WindowRegularStart.ViewModel.Command.CollapsibleButtonCommand;

namespace WindowRegularStart.ViewModel.MainWindowViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        public RelayCommand CollapsibleButtonClickCommand { get; }
           
      
    }
}
