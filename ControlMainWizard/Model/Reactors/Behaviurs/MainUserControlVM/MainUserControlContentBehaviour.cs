using ControlMainWizard.ViewModel;
using Globals.Model.Observer.Components;
using Globals.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ControlMainWizard.Model.Reactors.Behaviurs.MainUserControlVM
{
    internal class MainUserControlContentBehaviour : IBehaviour
    {
        public Action GetAction<T>(T viewModel) where T : BaseViewModel
        {
            MainViewModel mainViewModel = viewModel as MainViewModel;

            return new Action(() => 
            {
                MessageBox.Show("changed");
            });
        }
    }
}
