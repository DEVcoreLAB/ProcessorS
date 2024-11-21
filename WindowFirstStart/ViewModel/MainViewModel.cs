using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowFirstStart.Model;
using WindowRegularStart.View.MainWindow;

namespace WindowFirstStart.ViewModel
{
    internal partial class MainViewModel
    {
        MainModel MainModel { get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);
        }

        public MainWindow WindowRegularStartInstance { get; set; }
    }
}
