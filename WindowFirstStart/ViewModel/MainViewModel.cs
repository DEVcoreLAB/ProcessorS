using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.Model;
using WindowRegularStart.View.MainWindow;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        MainModel MainModel { get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);
        }
    }
}
