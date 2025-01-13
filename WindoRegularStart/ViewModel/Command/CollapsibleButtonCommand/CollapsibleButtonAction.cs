using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using WindowRegularStart.View.MainWindow;
using WindowRegularStart.ViewModel.MainWindowViewModel;

namespace WindowRegularStart.ViewModel.Command.CollapsibleButtonCommand
{
    internal class CollapsibleButtonAction
    {
        MainViewModel MainViewModel { get; }

        public CollapsibleButtonAction(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }

        public void Execute(object parameter)
        {
            if (parameter is MainWindow window)
            {
                
            }
           
        }
    }
}
