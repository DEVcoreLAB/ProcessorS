using WindowRegularStart.Model.MainWindowModel;
using Globals.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowRegularStart.ViewModel.Command.CollapsibleButtonCommand;

namespace WindowRegularStart.ViewModel.MainWindowViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        MainModel MainModel { get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);

            CollapsibleButtonClickCommand = new RelayCommand
            (
                new CollapsibleButtonAction(this).Execute,
                new CollapsibleButtonPredict(this).Check
                );
        }
    }
}
