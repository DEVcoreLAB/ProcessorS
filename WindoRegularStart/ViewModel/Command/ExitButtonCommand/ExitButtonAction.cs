using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowRegularStart.ViewModel.MainWindowViewModel;

namespace WindowRegularStart.ViewModel.Command.ExitButtonCommand
{
    internal class ExitButtonAction
    {
        MainViewModel MainViewModel { get; }

        public ExitButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("test");
        }
    }
}
