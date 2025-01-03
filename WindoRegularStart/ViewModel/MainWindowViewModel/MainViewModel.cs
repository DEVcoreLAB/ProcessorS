using WindowRegularStart.Model.MainWindowModel;
using Globals.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowRegularStart.ViewModel.MainWindowViewModel
{
    internal partial class MainViewModel : BaseViewModel
    {
        MainModel MainModel { get; }

        public MainViewModel()
        {
            MainModel = new MainModel(this);
            TestProperty = [10, 20, 30, 40];
        }

        private int[] testProperty;
        public int[] TestProperty
        {
            get { return testProperty; }
            set 
            {
                testProperty = value;
                OnPropertyChanged(nameof(TestProperty));
            }
        }

        private int testSelectedValue;
        public int TestSelectedValue
        {
            get { return testSelectedValue; }
            set 
            { 
                testSelectedValue = value;
                OnPropertyChanged(nameof(TestSelectedValue));
            }
        }


    }
}
