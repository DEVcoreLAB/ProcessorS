using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.Model;
using WindowFirstStart.ViewModel.Commands.ConnStringButton;
using WindowFirstStart.ViewModel.Commands.SaveSettinsButton;
using WindowRegularStart.View.MainWindow;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        MainModel MainModel { get; }

        public RelayCommand ConnStringButtonCheckCommand { get; }
        public RelayCommand CheckPropsToSave {  get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);
            ConnStringButtonCheckCommand = new RelayCommand
                (new CheckConnectionStringAction(this).Check,
                new CheckConnectionStringPredict(this).Check);
            CheckPropsToSave = new RelayCommand
                (new SaveSettingsAction(this).Check,
                new SaveSettingsPredict(this).Check);
        }
    }
}
