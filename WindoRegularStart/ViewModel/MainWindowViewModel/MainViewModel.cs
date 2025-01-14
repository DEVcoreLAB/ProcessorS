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
using WindowRegularStart.ViewModel.Command.ExitButtonCommand;

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

            ExitButtonClickCommand = new RelayCommand
            (
                new ExitButtonAction(this).Execute, 
                new ExitButtonPredict(this).Check
                );
        }
    }
}
