using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.Model;
using WindowFirstStart.ViewModel.Commands.ConnStringButton;
using WindowRegularStart.View.MainWindow;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        MainModel MainModel { get; }

        public RelayCommand ConnStringButtonCheckCommand { get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);

            CheckConnectionStringAction checkConnectionStringAction = new (this);
            CheckConnectionStringPredict checkConnectionStringPredict = new (this);

            ConnStringButtonCheckCommand = new(checkConnectionStringAction.Check, checkConnectionStringPredict.Check);
        }
    }
}
